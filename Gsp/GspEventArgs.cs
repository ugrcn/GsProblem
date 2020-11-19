using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Tsp
{
    public class GspEventArgs : EventArgs
    {
        public GspEventArgs()
        {

        }
        public GspEventArgs(Sehirler cityList, Tur bestTour, int generation, bool complete)
        {
            this.cityList = cityList;
            this.bestTour = bestTour;
            this.generation = generation;
            this.complete = complete;
        }


        private Sehirler cityList;
 
        public Sehirler CityList
        {
            get
            {
                return cityList;
            }
        }

        private Tur bestTour;

        public Tur BestTour
        {
            get
            {
                return bestTour;
            }
        }

        private int generation;

        public int Generation
        {
            get
            {
                return generation;
            }
            set
            {
                generation = value;
            }
        }


        private bool complete = false;

        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
    }
}