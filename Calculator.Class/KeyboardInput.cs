using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Class
{
    public static class KeyboardInput
    {
        public static string ProcessKeyCalculation(string strOut, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.NumPad0 || e.KeyData == Keys.D0)
            {
                return StringMaker.Join(strOut, "0");
            }
            else if (e.KeyData == Keys.NumPad1 || e.KeyData == Keys.D1)
            {
                return StringMaker.Join(strOut, "1");
            }
            else if (e.KeyData == Keys.NumPad2 || e.KeyData == Keys.D2)
            {
                return StringMaker.Join(strOut, "2");
            }
            else if (e.KeyData == Keys.NumPad3 || e.KeyData == Keys.D3)
            {
                return StringMaker.Join(strOut, "3");
            }
            else if (e.KeyData == Keys.NumPad4 || e.KeyData == Keys.D4)
            {
                return StringMaker.Join(strOut, "4");
            }
            else if (e.KeyData == Keys.NumPad5 || e.KeyData == Keys.D5)
            {
                return StringMaker.Join(strOut, "5");
            }
            else if (e.KeyData == Keys.NumPad6 || e.KeyData == Keys.D6)
            {
                return StringMaker.Join(strOut, "6");
            }
            else if (e.KeyData == Keys.NumPad7 || e.KeyData == Keys.D7)
            {
                return StringMaker.Join(strOut, "7");
            }
            else if (e.KeyData == Keys.NumPad8 || e.KeyData == Keys.D8)
            {
                return StringMaker.Join(strOut, "8");
            }
            else if (e.KeyData == Keys.NumPad9 || e.KeyData == Keys.D9)
            {
                return StringMaker.Join(strOut, "9");
            }
            else if (e.KeyData == Keys.Decimal || e.KeyData == Keys.OemPeriod)
            {
                return StringMaker.Join(strOut, ".");
            }
            else if (e.KeyData == Keys.Add)
            {
                return StringMaker.Join(strOut, "+");
            }
            else if (e.KeyData == Keys.Subtract)
            {
                return StringMaker.Join(strOut, "-");
            }
            else if (e.KeyData == Keys.Multiply)
            {
                return StringMaker.Join(strOut, "x");
            }
            else if (e.KeyData == Keys.Divide)
            {
                return StringMaker.Join(strOut, "/");
            }
            else if (e.KeyData == Keys.Back)
            {
                return StringMaker.Remove(strOut);
            }
            else if (e.KeyData == Keys.Enter)
            {
                return ResultCalculation.Calculate(strOut);
            }
            return strOut;
        }

        public static string ProcessKeyOnlyNumbers(string strOut, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.NumPad0 || e.KeyData == Keys.D0)
            {
                return StringMaker.Join(strOut, "0");
            }
            else if (e.KeyData == Keys.NumPad1 || e.KeyData == Keys.D1)
            {
                return StringMaker.Join(strOut, "1");
            }
            else if (e.KeyData == Keys.NumPad2 || e.KeyData == Keys.D2)
            {
                return StringMaker.Join(strOut, "2");
            }
            else if (e.KeyData == Keys.NumPad3 || e.KeyData == Keys.D3)
            {
                return StringMaker.Join(strOut, "3");
            }
            else if (e.KeyData == Keys.NumPad4 || e.KeyData == Keys.D4)
            {
                return StringMaker.Join(strOut, "4");
            }
            else if (e.KeyData == Keys.NumPad5 || e.KeyData == Keys.D5)
            {
                return StringMaker.Join(strOut, "5");
            }
            else if (e.KeyData == Keys.NumPad6 || e.KeyData == Keys.D6)
            {
                return StringMaker.Join(strOut, "6");
            }
            else if (e.KeyData == Keys.NumPad7 || e.KeyData == Keys.D7)
            {
                return StringMaker.Join(strOut, "7");
            }
            else if (e.KeyData == Keys.NumPad8 || e.KeyData == Keys.D8)
            {
                return StringMaker.Join(strOut, "8");
            }
            else if (e.KeyData == Keys.NumPad9 || e.KeyData == Keys.D9)
            {
                return StringMaker.Join(strOut, "9");
            }
            else if (e.KeyData == Keys.Decimal || e.KeyData == Keys.OemPeriod)
            {
                return StringMaker.Join(strOut, ".");
            }
            else if (e.KeyData == Keys.Back)
            {
                return StringMaker.Remove(strOut);
            }
            return strOut;
        }
    }
}
