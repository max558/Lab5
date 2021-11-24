using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumMaxMin
{
    class Program
    {
        /*
         * Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
         * Определить сумму максимального и минимального элементов массива.
         */
        static void Main(string[] args)
        {

            const int k = 15;
            int[] array = new int[k];
            Random random = new Random();
            //Заполнение массива
            Console.WriteLine("Входной массив:");
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            //Определяем максимальное и минимальное значение массива
            int sum = 0,
                elMax = array[0],
                elMin = array[0];
            foreach (int a in array)
            {
                if (a>elMax)
                {
                    elMax = a;
                }
                if (a<elMin)
                {
                    elMin = a;
                }
            }
            sum = elMax + elMin;

            Console.WriteLine("минимальное значение массива {0}, максимальное значение массива {1}, сумма максимального и минимального значений {2}",elMin,elMax,sum);
            Console.ReadKey();
        }
    }
}
