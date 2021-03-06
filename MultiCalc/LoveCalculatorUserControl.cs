﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiCalc
{
    public partial class LoveCalculatorUserControl : UserControl
    {
        public LoveCalculatorUserControl()
        {
            InitializeComponent();
        }

        private void btnLoveCalculate_Click(object sender, EventArgs e)
        {
            lblLovePercentage.Show();
            Random rnd = new Random();
            int LovePercentage = rnd.Next(0, 101); // creates a number between 0 and 100
            lblLovePercentage.Text = String.Format("{0}%", LovePercentage.ToString());
            if (txtFirstPerson.Text == "Tony")
            {
                lblLovePercentage.Text = "∞";
            }
            else if (txtSecondPerson.Text == "Tony")
            {
                lblLovePercentage.Text = "∞";
            }
        }
    }
}
