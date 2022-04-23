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


            //Convert Kelvin to Output
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

        public static string Length(string InputVal, string OutputVal, int InputID, int OutputID)
        {
            double? InputValDouble = null;
            try
            {
                InputValDouble = double.Parse(InputVal);
            }
            catch (FormatException e)
            {
                return OutputVal;
            }
            double? inMeter = null, OutputValDouble = null;

            //Convert to Meter (SI)
            if (InputID != (int)Constants.Length.Meters)
            {
                if (InputID == (int)Constants.Length.Nanometer)
                {
                    inMeter = InputValDouble / (double)1000000000;
                }
                else if (InputID == (int)Constants.Length.Micron)
                {
                    inMeter = InputValDouble / (double)1000000;
                }
                else if(InputID == (int)Constants.Length.Millimeter)
                {
                    inMeter = InputValDouble / (double)1000;
                }
                else if (InputID == (int)Constants.Length.Centimeter)
                {
                    inMeter = InputValDouble / (double)100;
                }
                else if (InputID == (int)Constants.Length.Kilometer)
                {
                    inMeter = InputValDouble * (double)1000;
                }
                else if (InputID == (int)Constants.Length.Inches)
                {
                    inMeter = InputValDouble / 39.37;
                }
                else if (InputID == (int)Constants.Length.Feet)
                {
                    inMeter = InputValDouble / 3.281;
                }
                else if (InputID == (int)Constants.Length.Yards)
                {
                    inMeter = InputValDouble / 1.094;
                }
                else if (InputID == (int)Constants.Length.Mile)
                {
                    inMeter = InputValDouble * (double)1609;
                }
                else if (InputID == (int)Constants.Length.NauticalMile)
                {
                    inMeter = InputValDouble * (double)1852;
                }
            }
            else
            {
                inMeter = InputValDouble;
            }


            //Convert Meter to Output
            if (OutputID == (int)Constants.Length.Meters)
            {
                OutputValDouble = inMeter;
            }
            else if (OutputID == (int)Constants.Length.Nanometer)
            {
                OutputValDouble = inMeter * (double)1000000000;
            }
            else if (OutputID == (int)Constants.Length.Micron)
            {
                OutputValDouble = inMeter * (double)1000000;
            }
            else if (OutputID == (int)Constants.Length.Millimeter)
            {
                OutputValDouble = inMeter * (double)1000;
            }
            else if (OutputID == (int)Constants.Length.Centimeter)
            {
                OutputValDouble = inMeter * (double)100;
            }
            else if (OutputID == (int)Constants.Length.Kilometer)
            {
                OutputValDouble = inMeter / (double)1000;
            }
            else if (OutputID == (int)Constants.Length.Inches)
            {
                OutputValDouble = inMeter * (double)39.37;
            }
            else if (OutputID == (int)Constants.Length.Feet)
            {
                OutputValDouble = inMeter * (double)3.281;
            }
            else if (OutputID == (int)Constants.Length.Yards)
            {
                OutputValDouble = inMeter * (double)1.094;
            }
            else if (OutputID == (int)Constants.Length.Mile)
            {
                OutputValDouble = inMeter / (double)1609;
            }
            else if (OutputID == (int)Constants.Length.NauticalMile)
            {
                OutputValDouble = inMeter / (double)1852;
            }

            try
            {
                return Math.Round(double.Parse(OutputValDouble.ToString()), 6, MidpointRounding.AwayFromZero).ToString();
            }
            catch (FormatException e)
            {
                return Constants.Invalid;
            }
        }
    }
}
