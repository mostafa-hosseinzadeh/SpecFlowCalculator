﻿using System;

namespace CalculatorCore
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            //throw new NotImplementedException();
            return FirstNumber + SecondNumber;
        }
    }
}