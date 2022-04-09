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

namespace Calculator.UserControls.UserControls
{
    public partial class Basic : UserControl
    {
        public Basic()
        {
            InitializeComponent();
        }

        private void btnStrConCat_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = StringMaker.Join(txtBoxResult.Text, ((Button)sender).Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = StringMaker.Remove(txtBoxResult.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = ResultCalculation.Calculate(txtBoxResult.Text);
        }

        private void lblHidden_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            txtBoxResult.Text = KeyboardInput.ProcessKeyCalculation(txtBoxResult.Text, e);
        }

        private void btnRemoveFocus_Enter(object sender, EventArgs e)
        {
            lblHidden.Focus();
        }
    }
}
