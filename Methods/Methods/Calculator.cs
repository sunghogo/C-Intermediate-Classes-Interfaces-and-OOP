﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator
    {
        // Using params keyword to initialize arrays for variable numbers of arguments
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
