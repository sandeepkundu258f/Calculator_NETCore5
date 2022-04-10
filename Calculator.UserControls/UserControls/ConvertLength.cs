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
    public partial class ConvertLength : UserControl
    {
        public ConvertLength()
        {
            InitializeComponent();
        }

        private void SetComboBoxDataSource()
        {
            ComboBoxItem[] LengthDropdown = new ComboBoxItem[]
            {
                new ComboBoxItem{ID=(int)Constants.Length.Nanometer, Text=Constants.Length.Nanometer.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Micron, Text=Constants.Length.Micron.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Millimeter, Text=Constants.Length.Millimeter.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Centimeter, Text=Constants.Length.Centimeter.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Meters, Text=Constants.Length.Meters.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Kilometer, Text=Constants.Length.Kilometer.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Inches, Text=Constants.Length.Inches.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Feet, Text=Constants.Length.Feet.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Yards, Text=Constants.Length.Yards.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.Mile, Text=Constants.Length.Mile.ToString()},
                new ComboBoxItem{ID=(int)Constants.Length.NauticalMile, Text="Nautical Mile"}
            };
            comboBoxOutput.DataSource = LengthDropdown.Clone();
            comboBoxOutput.SelectedIndex = 3;

            comboBoxInput.DataSource = LengthDropdown.Clone();
            comboBoxInput.SelectedIndex = 6;
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

        private void ConvertLength_Load(object sender, EventArgs e)
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
