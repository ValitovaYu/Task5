using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        /* Сформировать одномерный массив из 7 элементов. 
        Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов. */
        static void Main(string[] args)
        {
            double[] array = new double[7];
            double Sum = 0;
            Console.WriteLine("Введите массив из 7 элементов");
            for (int i = 0; i < 7; i++)
            {
                array[i]=Convert.ToDouble(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое элементов массива = {0:f2}", Sum/7);
            Console.ReadKey();

        }
    }
}
