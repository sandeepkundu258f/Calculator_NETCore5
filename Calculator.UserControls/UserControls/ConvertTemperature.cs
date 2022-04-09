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
    public partial class ConvertTemperature : UserControl
    {
        public ConvertTemperature()
        {
            InitializeComponent();
        }

        private void SetComboBoxDataSource()
        {
            ComboBoxItem[] TemperatureDropdown = new ComboBoxItem[]
            {
                new ComboBoxItem{ID=(int)Constants.Temperature.Celsius, Text=Constants.Temperature.Celsius.ToString()},
                new ComboBoxItem{ID=(int)Constants.Temperature.Fahrenheit, Text=Constants.Temperature.Fahrenheit.ToString()},
                new ComboBoxItem{ID=(int)Constants.Temperature.Kelvin, Text=Constants.Temperature.Kelvin.ToString()}
            };
            comboBoxOutput.DataSource = TemperatureDropdown.Clone();
            comboBoxOutput.SelectedIndex = 1;

            comboBoxInput.DataSource = TemperatureDropdown.Clone();
            comboBoxInput.SelectedIndex = 0;
        }

        private int InputID
        {
            get
            {
                return ((ComboBoxItem)comboBoxInput.SelectedItem).ID;
            }
        }

        private int OutputID
        {
            get
            {
                return ((ComboBoxItem)comboBoxOutput.SelectedItem).ID;
            }
        }

        private void btnStrConCat_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = StringMaker.Join(textBoxInput.Text, ((Button)sender).Text);
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void btnRemoveFocus_Enter(object sender, EventArgs e)
        {
            lblHidden.Focus();
        }

        private void lblHidden_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            textBoxInput.Text = KeyboardInput.ProcessKeyOnlyNumbers(textBoxInput.Text, e);

            if (textBoxInput.Text == string.Empty)
                textBoxInput.Text = "0";

            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void ConvertTemperature_Load(object sender, EventArgs e)
        {
            SetComboBoxDataSource();
            textBoxInput.Text = "0";
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void comboBox_DropDownClosed(object sender, EventArgs e)
        {
            lblHidden.Focus();
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "0";
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = StringMaker.Remove(textBoxInput.Text);
            
            if (textBoxInput.Text == string.Empty)
                textBoxInput.Text = "0";
            
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "0";
            SetComboBoxDataSource();
            textBoxOutput.Text = ConvertionResult.Temperature(textBoxInput.Text, textBoxOutput.Text, InputID, OutputID);
            //calculate
        }
    }
}
