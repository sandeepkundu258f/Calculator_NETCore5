﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Class
{
    public static class Constants
    {
        private static List<string> _inputOperators = new() { "+", "-", "/", "x", "." };
        private static List<string> _arithmeticOperators = new() { "+", "-", "/", "x" };

        public static IList<string> inputOperators = _inputOperators.AsReadOnly();
        public static IList<string> arithmeticOperators = _arithmeticOperators.AsReadOnly();
    }
}
