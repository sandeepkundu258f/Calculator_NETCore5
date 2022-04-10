using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    public static class Constants
    {
        #region Common
        public static string Invalid { get => "Invalid"; }
        #endregion

        #region Calculation
        public static List<string> inputOperators
        {
            get
            {
                return new() { "+", "-", "/", "x", "." };
            }
        }

        public static List<string> arithmeticOperators
        {
            get
            {
                return new() { "+", "-", "/", "x" };
            }
        }

        //public static IList<string> inputOperators = _inputOperators.AsReadOnly();
        //public static IList<string> arithmeticOperators = _arithmeticOperators.AsReadOnly();
        #endregion

        #region Controls
        //public static readonly string basicCalculator = "basicCalculator";
        
        public static string basicCalculator { get => "basicCalculator"; }
        public static string convertTemperature { get => "convertTemperature"; }
        public static string convertLength { get => "convertLength"; }

        private static List<string> _allControls = new()
        {
            basicCalculator,
            convertTemperature,
            convertLength
        };
        
        public static IList<string> allControls = _allControls.AsReadOnly();
        #endregion

        #region ComboBox Enum

        public enum Temperature
        {
            Celsius = 1,
            Fahrenheit,
            Kelvin
        }

        public enum Length
        {
            Nanometer = 1,
            Micron,
            Millimeter,
            Centimeter,
            Meters,
            Kilometer,
            Inches,
            Feet,
            Yards,
            Mile,
            NauticalMile
        }

        #endregion
    }

    public class ComboBoxItem
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
