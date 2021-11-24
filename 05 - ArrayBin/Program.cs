using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ArrayBin
{
    /*
     * Запросить у пользователя целочисленное число N.
     * Сформировать двумерный массив размера NxN вида: 
     * 1 0 1 0 1
     * 0 1 0 1 0
     * 1 0 1 0 1
     * 0 1 0 1 0
     * 1 0 1 0 1
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите целочисленное число N: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, n];

            int kk = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kk++;
                    if ((kk) % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
