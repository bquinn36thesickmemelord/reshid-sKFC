using System;
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
            var c = new SampleCalculatorUserControl();
            c.Dock = DockStyle.Fill;
            HostPanel.Controls.Add(c);
        }
    }
}
