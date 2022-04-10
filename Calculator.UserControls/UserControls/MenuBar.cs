using System;
using System.Windows.Forms;
using Calculator.UserControls.Forms;
using Calculator.Class;

namespace Calculator.UserControls.UserControls
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new();
            aboutBox.ShowDialog();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlSwap.SwapControl<Basic>(Constants.basicCalculator, "Basic Calculator", this);
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlSwap.SwapControl<ConvertTemperature>(Constants.convertTemperature, "Temperature Converter", this);
        }

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlSwap.SwapControl<ConvertLength>(Constants.convertLength, "Length Converter", this);
        }
    }
}

