using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Globalization;

namespace Tsp
{
    public partial class GspForm : Form
    {
        Sehirler cityList = new Sehirler();

        Gsp tsp;

        Image cityImage;

        Graphics cityGraphics;

        public delegate void DrawEventHandler(Object sender, GspEventArgs e);

        public GspForm()
        {
            InitializeComponent();
        }

        private void tsp_foundNewBestTour(object sender, GspEventArgs e)
        {
            if ( this.InvokeRequired )
            {
                try
                {
                    this.Invoke(new DrawEventHandler(DrawTour), new object[] { sender, e });
                    return;
                }
                catch (Exception)
                {
                }
            }

            DrawTour(sender, e);
        }

        public void DrawTour(object sender, GspEventArgs e)
        {
            this.lastFitnessValue.Text = Math.Round(e.BestTour.Fitness, 2).ToString(CultureInfo.CurrentCulture);
            this.lastIterationValue.Text = e.Generation.ToString(CultureInfo.CurrentCulture);

            if (cityImage == null)
            {
                cityImage = new Bitmap(tourDiagram.Width, tourDiagram.Height);
                cityGraphics = Graphics.FromImage(cityImage);
            }

            int lastCity = 0;
            int nextCity = e.BestTour[0].Connection1;

            cityGraphics.FillRectangle(Brushes.White, 0, 0, cityImage.Width, cityImage.Height);
            foreach( Sehir city in e.CityList )
            {
 
                cityGraphics.DrawEllipse(Pens.Black, city.Location.X/3 - 2, city.Location.Y/3 - 2, 5, 5);
                Point p = cityList[lastCity].Location;
                Point p2 = cityList[nextCity].Location;
                p2.X /= 3;
                p2.Y /= 3;

                p.X /= 3;
                p.Y /= 3;


                cityGraphics.DrawLine(Pens.Black, p, p2);


                if (lastCity != e.BestTour[nextCity].Connection1)
                {
                    lastCity = nextCity;
                    nextCity = e.BestTour[nextCity].Connection1;
                }
                else
                {
                    lastCity = nextCity;
                    nextCity = e.BestTour[nextCity].Connection2;
                }
            }

            this.tourDiagram.Image = cityImage;

            if (e.Complete)
            {
                StartButton.Text = "Baþla";
                //StatusLabel.Text = "Open a City List or click the map to place cities.";
                //StatusLabel.ForeColor = Color.Black;
            }
        }

        private void DrawCityList(Sehirler cityList)
        {
            Image cityImage = new Bitmap(tourDiagram.Width, tourDiagram.Height);
            Graphics graphics = Graphics.FromImage(cityImage);

            foreach (Sehir city in cityList)
            {
                graphics.DrawEllipse(Pens.Black, city.Location.X/3 - 2, city.Location.Y/3 - 2, 5, 5);
            }

            this.tourDiagram.Image = cityImage;

            updateCityCount();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (tsp != null)
            {
                tsp.Halt = true;
                return;
            }

            int populationSize = 0;
            int maxGenerations = 0;
            int mutation = 0;
            int groupSize = 0;
            int numberOfCloseCities = 0;
            int chanceUseCloseCity = 0;
            int seed = 0;

            try
            {
                populationSize = Convert.ToInt32(populationSizeTextBox.Text, CultureInfo.CurrentCulture);
                maxGenerations = Convert.ToInt32(maxGenerationTextBox.Text, CultureInfo.CurrentCulture);
                mutation = Convert.ToInt32(mutationTextBox.Text, CultureInfo.CurrentCulture);
                groupSize = Convert.ToInt32(groupSizeTextBox.Text, CultureInfo.CurrentCulture);
                numberOfCloseCities = Convert.ToInt32(NumberCloseCitiesTextBox.Text, CultureInfo.CurrentCulture);
                chanceUseCloseCity = Convert.ToInt32(CloseCityOddsTextBox.Text, CultureInfo.CurrentCulture);
                seed = Convert.ToInt32(randomSeedTextBox.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
            }

            if (populationSize <= 0)
            {
                MessageBox.Show("Bir Popülasyon Büyüklüðü Belirtmelisiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 ,MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (maxGenerations <= 0)
            {
                MessageBox.Show("Maksimum Nesil Sayýsý Belirtmelisiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((mutation < 0) || (mutation > 100))
            {
                MessageBox.Show("Mutasyon Oraný 0 ile 100 Arasýnda Olmalýdýr.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((groupSize < 2) || ( groupSize > populationSize ))
            {
                MessageBox.Show("You must specify a Group (Neighborhood) Size between 2 and the population size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((numberOfCloseCities < 3) || (numberOfCloseCities >= cityList.Count))
            {
                MessageBox.Show("The number of nearby cities to evaluate for the greedy initial populations must be more than 3 and less than the total number of cities.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((chanceUseCloseCity < 0) || (chanceUseCloseCity > 95))
            {
                MessageBox.Show("The odds of using a nearby city when creating the initial population must be between 0% - 95%.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (seed < 0)
            {
                MessageBox.Show("Rastgele Nesil Sayýsýný Belirtmelisiniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (cityList.Count < 5)
            {
                MessageBox.Show("Bir Þehir Dosyasý Listesini Yüklemelisiniz. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            this.StartButton.Text = "Dur";
            ThreadPool.QueueUserWorkItem( new WaitCallback(BeginTsp));
        }

        private void BeginTsp(Object stateInfo)
        {
            int populationSize = Convert.ToInt32(populationSizeTextBox.Text, CultureInfo.CurrentCulture);
            int maxGenerations = Convert.ToInt32(maxGenerationTextBox.Text, CultureInfo.CurrentCulture); ;
            int mutation = Convert.ToInt32(mutationTextBox.Text, CultureInfo.CurrentCulture);
            int groupSize = Convert.ToInt32(groupSizeTextBox.Text, CultureInfo.CurrentCulture);
            int seed = Convert.ToInt32(randomSeedTextBox.Text, CultureInfo.CurrentCulture);
            int numberOfCloseCities = Convert.ToInt32(NumberCloseCitiesTextBox.Text, CultureInfo.CurrentCulture);
            int chanceUseCloseCity = Convert.ToInt32(CloseCityOddsTextBox.Text, CultureInfo.CurrentCulture);

            cityList.CalculateCityDistances(numberOfCloseCities);

            tsp = new Gsp();
            tsp.foundNewBestTour += new Gsp.NewBestTourEventHandler(tsp_foundNewBestTour);
            tsp.Begin(populationSize, maxGenerations, groupSize, mutation, seed, chanceUseCloseCity, cityList);
            tsp.foundNewBestTour -= new Gsp.NewBestTourEventHandler(tsp_foundNewBestTour);
            tsp = null;
        }
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpenDialog = new OpenFileDialog();
            fileOpenDialog.Filter = "XML(*.xml)|*.xml";
            fileOpenDialog.InitialDirectory = ".";
            fileOpenDialog.ShowDialog();
            fileNameTextBox.Text = fileOpenDialog.FileName;
        }
        private void openCityListButton_Click(object sender, EventArgs e)
        {
            string fileName = "";

            try
            {
                if (tsp != null)
                {
                    //StatusLabel.Text = "Cannot alter city list while running";
                    //StatusLabel.ForeColor = Color.Red;
                    //return;
                }

                fileName = this.fileNameTextBox.Text;
                
                cityList.OpenCityList(fileName);
                DrawCityList(cityList);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found: " + fileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Cities XML file is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void clearCityListButton_Click(object sender, EventArgs e)
        {
            if (tsp != null)
            {
                //StatusLabel.Text = "Cannot alter city list while running";
                //StatusLabel.ForeColor = Color.Red;
                //return;
            }

            cityList.Clear();
            this.DrawCityList(cityList);
        }

        private void tourDiagram_MouseDown(object sender, MouseEventArgs e)
        {
            if (tsp != null)
            {
                //StatusLabel.Text = "Cannot alter city list while running";
                //StatusLabel.ForeColor = Color.Red;
                return;
            }

            cityList.Add(new Sehir(e.X, e.Y));
            DrawCityList(cityList);
        }

        private void updateCityCount()
        {
            this.NumberCitiesValue.Text = cityList.Count.ToString();
        }

        private void TspForm_Load(object sender, EventArgs e)
        {

        }
    }
}