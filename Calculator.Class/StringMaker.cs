using System;
using System.Collections.Generic;

namespace Calculator.Class
{
    public static class StringMaker
    {
        public static string Join(string strOut, string strAdd)
        {
            if (strOut.Length == 0)
            {
                if (Constants.inputOperators.IndexOf(strAdd) >= 0)
                {
                    if (strAdd == "-")
                    {
                        return strOut + strAdd;
                    }
                    return strOut;
                }
                else
                {
                    return strOut + strAdd;
                }
            }
            else
            {
                char lastChar = strOut[^1];

                if (Constants.inputOperators.IndexOf(lastChar.ToString()) >= 0 && Constants.inputOperators.IndexOf(strAdd) >= 0)
                {
                    if (Constants.arithmeticOperators.IndexOf(lastChar.ToString()) >= 0 && Constants.arithmeticOperators.IndexOf(strAdd) >= 0)
                    {
                        if (strOut.Length == 1 && lastChar == '-')
                        {
                            return strOut;
                        }
                        char[] charOut = strOut.ToCharArray();
                        charOut[^1] = strAdd.ToCharArray()[0];
                        return new string(charOut);
                    }
                    else
                    {
                        return strOut;
                    }
                }
                else
                {
                    return strOut + strAdd;
                }
            }
        }

        public static string Remove(string strOut)
        {
            if (strOut.Length > 0)
            {
                return strOut.Substring(0, strOut.Length - 1);
            }
            return string.Empty;
        }
    }
}
