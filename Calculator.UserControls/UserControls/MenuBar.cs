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
            bool BasicActive = this.Parent.Controls.ContainsKey(Constants.basicCalculator);

            if (!BasicActive)
            {
                foreach(string control in Constants.allControls)
                {
                    this.Parent.Controls.RemoveByKey(control);
                }

                Basic basicCalculator = new();
                basicCalculator.Location = new System.Drawing.Point(1, 32);
                basicCalculator.Name = Constants.basicCalculator;
                basicCalculator.Size = new System.Drawing.Size(410, 377);
                basicCalculator.TabIndex = 1;

                this.Parent.Text = "Basic Calculator";
                this.Parent.Controls.Add(basicCalculator);
            }
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ConvertTemperatureActive = this.Parent.Controls.ContainsKey(Constants.convertTemperature);

            if (!ConvertTemperatureActive)
            {
                foreach (string control in Constants.allControls)
                {
                    this.Parent.Controls.RemoveByKey(control);
                }

                ConvertTemperature convertTemperature = new();
                convertTemperature.Location = new System.Drawing.Point(1, 32);
                convertTemperature.Name = Constants.convertTemperature;
                convertTemperature.Size = new System.Drawing.Size(410, 377);
                convertTemperature.TabIndex = 1;

                this.Parent.Text = "Temperature Converter";
                this.Parent.Controls.Add(convertTemperature);
            }
        }
    }
}

