using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    public static class ResultCalculation
    {
        public static string Calculate(string strOut)
        {
            if(strOut[0]=='-' && (strOut.Length < 2))
            {
                return Constants.Invalid;
            }

            string[] rawNumbers = strOut.Split('+','-','/','x');
            if (rawNumbers[0] == string.Empty)
            {
                rawNumbers[1] = "-" + rawNumbers[1];
            }

            List<float> floatNumbers = new List<float>();
            foreach(string x in rawNumbers)
            {
                if (x != string.Empty)
                {
                    floatNumbers.Add(float.Parse(x));
                }
            }

            List<char> proceededOperators = strOut.ToCharArray().ToList();
            proceededOperators.RemoveAll(x => (Char.IsNumber(x)||x=='.'));

            if(rawNumbers[0] == string.Empty)
            {
                proceededOperators.RemoveAt(0);
            }
            if (rawNumbers[^1] == string.Empty)
            {
                proceededOperators.RemoveAt(proceededOperators.Count - 1);
            }

            float Result = floatNumbers[0];
            for(int i=1; i< floatNumbers.Count; i++)
            {
                if (proceededOperators[i - 1] == '+')
                {
                    Result += floatNumbers[i];
                } 
                else if (proceededOperators[i - 1] == '-')
                {
                    Result -= floatNumbers[i];
                }
                else if (proceededOperators[i - 1] == 'x')
                {
                    Result *= floatNumbers[i];
                }
                else if (proceededOperators[i - 1] == '/')
                {
                    Result /= floatNumbers[i];
                }
            }

            return Result.ToString();
        }
    }
}
