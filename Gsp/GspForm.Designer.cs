//////////////////////////////////////////////////////////////////////////////////////////////////
// File Name: Tsp.Form.Designer.cs
//      Date: 06/01/2006
// Copyright (c) 2006 Michael LaLena. All rights reserved.
// Permission to use, copy, modify, and distribute this Program and its documentation,
//  if any, for any purpose and without fee is hereby granted, provided that:
//   (i) you not charge any fee for the Program, and the Program not be incorporated
//       by you in any software or code for which compensation is expected or received;
//   (ii) the copyright notice listed above appears in all copies;
//   (iii) both the copyright notice and this Agreement appear in all supporting documentation; and
//   (iv) the name of Michael LaLena or lalena.com not be used in advertising or publicity
//          pertaining to distribution of the Program without specific, written prior permission. 
///////////////////////////////////////////////////////////////////////////////////////////////////
namespace Tsp
{
    partial class GspForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tourDiagram = new System.Windows.Forms.PictureBox();
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.lastIterationLabel = new System.Windows.Forms.Label();
            this.lastIterationValue = new System.Windows.Forms.Label();
            this.lastTourLabel = new System.Windows.Forms.Label();
            this.lastFitnessValue = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.maxGenerationLabel = new System.Windows.Forms.Label();
            this.maxGenerationTextBox = new System.Windows.Forms.TextBox();
            this.groupSizeTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.openCityListButton = new System.Windows.Forms.Button();
            this.clearCityListButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.mutationTextBox = new System.Windows.Forms.TextBox();
            this.mutationLabel = new System.Windows.Forms.Label();
            this.NumberCitiesLabel = new System.Windows.Forms.Label();
            this.NumberCitiesValue = new System.Windows.Forms.Label();
            this.NumberCloseCitiesTextBox = new System.Windows.Forms.TextBox();
            this.CloseCityOddsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // tourDiagram
            // 
            this.tourDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourDiagram.BackColor = System.Drawing.Color.White;
            this.tourDiagram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tourDiagram.Location = new System.Drawing.Point(12, 68);
            this.tourDiagram.Name = "tourDiagram";
            this.tourDiagram.Size = new System.Drawing.Size(698, 410);
            this.tourDiagram.TabIndex = 0;
            this.tourDiagram.TabStop = false;
            this.tourDiagram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tourDiagram_MouseDown);
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeTextBox.Location = new System.Drawing.Point(14, 28);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(116, 21);
            this.populationSizeTextBox.TabIndex = 1;
            this.populationSizeTextBox.Text = "10000";
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Location = new System.Drawing.Point(9, 9);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(136, 13);
            this.PopulationSizeLabel.TabIndex = 0;
            this.PopulationSizeLabel.Text = "Popülasyon Büyüklüðü";
            // 
            // lastIterationLabel
            // 
            this.lastIterationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationLabel.AutoSize = true;
            this.lastIterationLabel.Location = new System.Drawing.Point(12, 493);
            this.lastIterationLabel.Name = "lastIterationLabel";
            this.lastIterationLabel.Size = new System.Drawing.Size(79, 13);
            this.lastIterationLabel.TabIndex = 0;
            this.lastIterationLabel.Text = "Son Tekrar: ";
            // 
            // lastIterationValue
            // 
            this.lastIterationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationValue.Location = new System.Drawing.Point(88, 493);
            this.lastIterationValue.Name = "lastIterationValue";
            this.lastIterationValue.Size = new System.Drawing.Size(88, 13);
            this.lastIterationValue.TabIndex = 0;
            // 
            // lastTourLabel
            // 
            this.lastTourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastTourLabel.AutoSize = true;
            this.lastTourLabel.Location = new System.Drawing.Point(266, 493);
            this.lastTourLabel.Name = "lastTourLabel";
            this.lastTourLabel.Size = new System.Drawing.Size(112, 13);
            this.lastTourLabel.TabIndex = 0;
            this.lastTourLabel.Text = "Son Tur Uzunluðu:";
            // 
            // lastFitnessValue
            // 
            this.lastFitnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastFitnessValue.Location = new System.Drawing.Point(384, 493);
            this.lastFitnessValue.Name = "lastFitnessValue";
            this.lastFitnessValue.Size = new System.Drawing.Size(53, 13);
            this.lastFitnessValue.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(716, 248);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(113, 37);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Baþla";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(576, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(113, 13);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "XML Þehir Dosyasý";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(579, 28);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(116, 21);
            this.fileNameTextBox.TabIndex = 6;
            this.fileNameTextBox.Text = "C:\\Users\\gs190\\Desktop\\Berlin52.xml";
            // 
            // maxGenerationLabel
            // 
            this.maxGenerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationLabel.AutoSize = true;
            this.maxGenerationLabel.Location = new System.Drawing.Point(300, 9);
            this.maxGenerationLabel.Name = "maxGenerationLabel";
            this.maxGenerationLabel.Size = new System.Drawing.Size(93, 13);
            this.maxGenerationLabel.TabIndex = 0;
            this.maxGenerationLabel.Text = "Maximum Nesil";
            // 
            // maxGenerationTextBox
            // 
            this.maxGenerationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationTextBox.Location = new System.Drawing.Point(301, 29);
            this.maxGenerationTextBox.Name = "maxGenerationTextBox";
            this.maxGenerationTextBox.Size = new System.Drawing.Size(116, 21);
            this.maxGenerationTextBox.TabIndex = 4;
            this.maxGenerationTextBox.Text = "10000000";
            // 
            // groupSizeTextBox
            // 
            this.groupSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeTextBox.Location = new System.Drawing.Point(402, 534);
            this.groupSizeTextBox.Name = "groupSizeTextBox";
            this.groupSizeTextBox.Size = new System.Drawing.Size(10, 21);
            this.groupSizeTextBox.TabIndex = 3;
            this.groupSizeTextBox.Text = "5";
            this.groupSizeTextBox.Visible = false;
            // 
            // randomSeedTextBox
            // 
            this.randomSeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedTextBox.Location = new System.Drawing.Point(450, 28);
            this.randomSeedTextBox.Name = "randomSeedTextBox";
            this.randomSeedTextBox.Size = new System.Drawing.Size(116, 21);
            this.randomSeedTextBox.TabIndex = 5;
            this.randomSeedTextBox.Text = "0";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(449, 9);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(87, 13);
            this.randomSeedLabel.TabIndex = 0;
            this.randomSeedLabel.Text = "Rastgele Nesil";
            // 
            // openCityListButton
            // 
            this.openCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCityListButton.Location = new System.Drawing.Point(716, 135);
            this.openCityListButton.Name = "openCityListButton";
            this.openCityListButton.Size = new System.Drawing.Size(113, 35);
            this.openCityListButton.TabIndex = 8;
            this.openCityListButton.Text = "Þehir Dosyasý Aç";
            this.openCityListButton.UseVisualStyleBackColor = true;
            this.openCityListButton.Click += new System.EventHandler(this.openCityListButton_Click);
            // 
            // clearCityListButton
            // 
            this.clearCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCityListButton.Location = new System.Drawing.Point(716, 193);
            this.clearCityListButton.Name = "clearCityListButton";
            this.clearCityListButton.Size = new System.Drawing.Size(113, 36);
            this.clearCityListButton.TabIndex = 9;
            this.clearCityListButton.Text = "Þehir Dosyasý Sil";
            this.clearCityListButton.UseVisualStyleBackColor = true;
            this.clearCityListButton.Click += new System.EventHandler(this.clearCityListButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(716, 80);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(113, 35);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "Þehir Dosyasý Yükle";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // mutationTextBox
            // 
            this.mutationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationTextBox.Location = new System.Drawing.Point(160, 28);
            this.mutationTextBox.Name = "mutationTextBox";
            this.mutationTextBox.Size = new System.Drawing.Size(116, 21);
            this.mutationTextBox.TabIndex = 2;
            this.mutationTextBox.Text = "3";
            // 
            // mutationLabel
            // 
            this.mutationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationLabel.AutoSize = true;
            this.mutationLabel.Location = new System.Drawing.Point(163, 9);
            this.mutationLabel.Name = "mutationLabel";
            this.mutationLabel.Size = new System.Drawing.Size(77, 13);
            this.mutationLabel.TabIndex = 10;
            this.mutationLabel.Text = "Mutasyon %";
            // 
            // NumberCitiesLabel
            // 
            this.NumberCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesLabel.Location = new System.Drawing.Point(576, 495);
            this.NumberCitiesLabel.Name = "NumberCitiesLabel";
            this.NumberCitiesLabel.Size = new System.Drawing.Size(85, 13);
            this.NumberCitiesLabel.TabIndex = 12;
            this.NumberCitiesLabel.Text = "Þehir Sayýsý: ";
            // 
            // NumberCitiesValue
            // 
            this.NumberCitiesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesValue.Location = new System.Drawing.Point(662, 495);
            this.NumberCitiesValue.Name = "NumberCitiesValue";
            this.NumberCitiesValue.Size = new System.Drawing.Size(48, 13);
            this.NumberCitiesValue.TabIndex = 13;
            // 
            // NumberCloseCitiesTextBox
            // 
            this.NumberCloseCitiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesTextBox.Location = new System.Drawing.Point(386, 534);
            this.NumberCloseCitiesTextBox.Name = "NumberCloseCitiesTextBox";
            this.NumberCloseCitiesTextBox.Size = new System.Drawing.Size(10, 21);
            this.NumberCloseCitiesTextBox.TabIndex = 15;
            this.NumberCloseCitiesTextBox.Text = "5";
            this.NumberCloseCitiesTextBox.Visible = false;
            // 
            // CloseCityOddsTextBox
            // 
            this.CloseCityOddsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsTextBox.Location = new System.Drawing.Point(370, 534);
            this.CloseCityOddsTextBox.Name = "CloseCityOddsTextBox";
            this.CloseCityOddsTextBox.Size = new System.Drawing.Size(10, 21);
            this.CloseCityOddsTextBox.TabIndex = 18;
            this.CloseCityOddsTextBox.Text = "70";
            this.CloseCityOddsTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(671, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 19;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(642, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 20;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(718, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 30);
            this.label3.TabIndex = 21;
            this.label3.Visible = false;
            // 
            // TspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseCityOddsTextBox);
            this.Controls.Add(this.NumberCloseCitiesTextBox);
            this.Controls.Add(this.NumberCitiesValue);
            this.Controls.Add(this.NumberCitiesLabel);
            this.Controls.Add(this.mutationTextBox);
            this.Controls.Add(this.mutationLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.clearCityListButton);
            this.Controls.Add(this.openCityListButton);
            this.Controls.Add(this.randomSeedTextBox);
            this.Controls.Add(this.randomSeedLabel);
            this.Controls.Add(this.groupSizeTextBox);
            this.Controls.Add(this.maxGenerationTextBox);
            this.Controls.Add(this.maxGenerationLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.lastFitnessValue);
            this.Controls.Add(this.lastTourLabel);
            this.Controls.Add(this.lastIterationValue);
            this.Controls.Add(this.lastIterationLabel);
            this.Controls.Add(this.PopulationSizeLabel);
            this.Controls.Add(this.populationSizeTextBox);
            this.Controls.Add(this.tourDiagram);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TspForm";
            this.Text = "Gezgin Satýcý Problemi";
            this.Load += new System.EventHandler(this.TspForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tourDiagram;
        private System.Windows.Forms.TextBox populationSizeTextBox;
        private System.Windows.Forms.Label PopulationSizeLabel;
        private System.Windows.Forms.Label lastIterationLabel;
        private System.Windows.Forms.Label lastIterationValue;
        private System.Windows.Forms.Label lastTourLabel;
        private System.Windows.Forms.Label lastFitnessValue;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label maxGenerationLabel;
        private System.Windows.Forms.TextBox maxGenerationTextBox;
        private System.Windows.Forms.TextBox groupSizeTextBox;
        private System.Windows.Forms.TextBox randomSeedTextBox;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button openCityListButton;
        private System.Windows.Forms.Button clearCityListButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox mutationTextBox;
        private System.Windows.Forms.Label mutationLabel;
        private System.Windows.Forms.Label NumberCitiesLabel;
        private System.Windows.Forms.Label NumberCitiesValue;
        private System.Windows.Forms.TextBox NumberCloseCitiesTextBox;
        private System.Windows.Forms.TextBox CloseCityOddsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

