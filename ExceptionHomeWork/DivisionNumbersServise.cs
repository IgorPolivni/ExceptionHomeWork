using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomeWork
{
    public class DivisionNumbersServise
    {
        public double Division(double divisible, double divider)//делимое и делитель
        {
            if (divisible == null || divider == null)
            {
                throw new ArgumentNullException();
            }
            else if (divider == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return divisible / divider;
            }
        }
    }
}
