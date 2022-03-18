using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Class;

namespace Calculator
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();
        }

        private void btnStrConCat_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = StringMaker.Join(txtBoxResult.Text, ((System.Windows.Forms.Button)sender).Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = string.Empty;
        }
    }
}
