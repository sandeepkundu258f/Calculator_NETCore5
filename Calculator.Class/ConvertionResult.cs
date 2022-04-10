using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    public static class ConvertionResult
    {
        public static string Temperature(string InputVal, string OutputVal, int InputID, int OutputID)
        {
            double? InputValDouble = null;
            try
            {
                InputValDouble = double.Parse(InputVal);
            }
            catch(FormatException e)
            {
                return OutputVal;
            }
            double? inKelvin = null, OutputValDouble = null;
            
            //Convert to Kelvin (SI)
            if(InputID != (int)Constants.Temperature.Kelvin)
            {
                if(InputID == (int)Constants.Temperature.Celsius)
                {
                    inKelvin = InputValDouble + 273.15;
                }
                else if(InputID == (int)Constants.Temperature.Fahrenheit)
                {
                    inKelvin = (InputValDouble + 459.67) * ((double)5 / (double)9);
                }
            }
            else
            {
                inKelvin = InputValDouble;
            }

            //Convert to Output
            if(OutputID == (int)Constants.Temperature.Kelvin)
            {
                OutputValDouble = inKelvin;
            }
            else if(OutputID == (int)Constants.Temperature.Celsius)
            {
                OutputValDouble = inKelvin - 273.15;
            }
            else if(OutputID == (int)Constants.Temperature.Fahrenheit)
            {
                OutputValDouble = (((double)9 / (double)5) * (inKelvin - 273.15)) + (double)32;
            }

            try
            {
                return Math.Round(double.Parse(OutputValDouble.ToString()), 6, MidpointRounding.AwayFromZero).ToString();
            }
            catch(FormatException e)
            {
                return Constants.Invalid;
            }
        }
    }
}
