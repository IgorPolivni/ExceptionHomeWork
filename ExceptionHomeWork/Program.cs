using System;

namespace ExceptionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1
            //var servise = new DivisionNumbersServise();
            //Console.Write("Введите делимое: ");
            //double.TryParse(Console.ReadLine(), out double divisible);     
            //Console.Write("Введите делитель: ");
            //double.TryParse(Console.ReadLine(), out double divider);
            //try
            //{
            //    Console.WriteLine($"Результат = {servise.Division(divisible, divider)}");
            //}
            //catch (ArgumentNullException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}



            ////Задание 2
            //Console.WriteLine("Введите размер массива: ");
            //int.TryParse(Console.ReadLine(), out int sizeArray);
            //int[] array = new int[sizeArray];
            //for(int i = 0; i < sizeArray; i++)
            //{
            //    Random random = new Random();
            //    array[i] = random.Next(0, 100);
            //}
            //try
            //{
            //    for (int i = 0; i <= sizeArray; i++) // Исключение: выход за пределы массива
            //    {
            //        Console.Write($"{array[i]} ");
            //    }
            //}
            //catch (ArgumentOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Программа завершена!!!");
            //}


            ////Практика
            //FirstClass obj = new FirstClass();
            //obj.FirsteMethod();
        }
    }
}
