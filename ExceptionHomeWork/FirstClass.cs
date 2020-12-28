using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHomeWork
{
    public class FirstClass
    {
        public void FirsteMethod()
        {

            SecondClass myObject = new SecondClass();
            try
            {
                myObject.SecondMethod();
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Все завершено!!!");
            }
        }
    }
}
