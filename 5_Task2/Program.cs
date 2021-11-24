using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Task2
{
    class Program
    {
        /* Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
         Определить сумму максимального и минимального элементов массива.*/
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);

            }
            Console.WriteLine();

            int max = array[0];
            int min = array[0];
            for (int i = 0; i < 15; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }

            int Sum = max + min;
                 
            Console.WriteLine("Сумма max и min элементов массива = {0}", Sum);
            Console.ReadKey();
        }
    }
}
