using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Task5
{
    class Program
    {
        //Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN//
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
