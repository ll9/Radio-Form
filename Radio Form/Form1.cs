using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isChecked = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton1.Checked;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !isChecked)
                radioButton1.Checked = false;
            else
            {
                radioButton1.Checked = true;
                isChecked = false;
            }
        }
    }
}
