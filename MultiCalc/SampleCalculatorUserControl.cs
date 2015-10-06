using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiCalc
{
    public partial class SampleCalculatorUserControl : UserControl
    {
        public SampleCalculatorUserControl()
        {
            InitializeComponent();
        }

        private void SampleCalculatorUserControl_Load(object sender, EventArgs e)
        {
            //label1.Top = DateTime.Now.Millisecond;
            //label1.Left = DateTime.Now.Millisecond;
        }
    }
}
