﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.UleevRI.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double a = Math.Truncate(x);
            double b = (x - a) * 10;
            double m = Math.Truncate(b);
            int result = Convert.ToInt32(m);
            return result;
        }
    }
}
