﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SampleButton_Click(object sender, EventArgs e)
        {
            HostPanel.Controls.Clear(); // Removes any existing user controls

            var c = new SampleCalculatorUserControl();  // Creates a new Sample Calculator
            c.Dock = DockStyle.Fill; // Sets it to fill the host panel
            HostPanel.Controls.Add(c); // Adds it to the host panel
        }

        private void JetFuel_Click(object sender, EventArgs e)
        {
            HostPanel.Controls.Clear(); // Removes any existing user controls

            var c = new SampleCalculatorUserControl();  // Creates a new Sample Calculator
            c.Dock = DockStyle.Fill; // Sets it to fill the host panel
            HostPanel.Controls.Add(c); // Adds it to the host panel

        }

<<<<<<< HEAD
        private void CalculatorTest_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            HostPanel.Controls.Clear(); // Removes any existing user controls

            var c = new CalculatorTestUserControl();  // Creates a new Sample Calculator
            c.Dock = DockStyle.Fill; // Sets it to fill the host panel
            HostPanel.Controls.Add(c); // Adds it to the host panel
>>>>>>> origin/master
        }
=======

        private void btnLoveCalculator_Click(object sender, EventArgs e)
        {
            HostPanel.Controls.Clear(); // Removes any existing user controls

            var c = new LoveCalculatorUserControl();  // Creates a new Sample Calculator
            c.Dock = DockStyle.Fill; // Sets it to fill the host panel
            HostPanel.Controls.Add(c); // Adds it to the host panel
        }

<<<<<<< HEAD
        private void MainForm_Load(object sender, EventArgs e)
=======
        private void johncenabutton_Click(object sender, EventArgs e)
>>>>>>> origin/master
        {

        }

<<<<<<< HEAD
     
=======
        private void BushButton_Click(object sender, EventArgs e)
        {

        }     


>>>>>>> origin/master
>>>>>>> origin/master
    }
}
