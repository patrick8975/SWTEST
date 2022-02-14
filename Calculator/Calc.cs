using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public Calc() { }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Power(double a, double exp)
        {
            //test for throw exception -- negative exp not allowed!
            if (exp < 0)
                throw new ArgumentOutOfRangeException(String.Format($"exp is negative: {exp}"));
            return Math.Pow(a, exp);
        }

        public double Division(double a, double b)
        {
            return (a / b);
        }
    }
}