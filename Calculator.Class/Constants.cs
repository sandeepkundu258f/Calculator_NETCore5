using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    public static class Constants
    {
        #region Calculation
        private static List<string> _inputOperators = new() { "+", "-", "/", "x", "." };
        private static List<string> _arithmeticOperators = new() { "+", "-", "/", "x" };

        public static IList<string> inputOperators = _inputOperators.AsReadOnly();
        public static IList<string> arithmeticOperators = _arithmeticOperators.AsReadOnly();
        #endregion

        #region Controls
        public static readonly string basicCalculator = "basicCalculator";
        public static readonly string convertTemperature = "convertTemperature";

        private static List<string> _allControls = new()
        {
            basicCalculator,
            convertTemperature
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
