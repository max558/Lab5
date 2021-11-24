using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNechet
{
    class Program
    {
        /*
         * Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
         * Определить количество   нечетных положительных элементов, стоящих на четных местах.
         */
        static void Main(string[] args)
        {
            const int k = 20;
            int[] array = new int[k];
            Random random = new Random();
            //Заполнение массива
            Console.WriteLine("Входной массив:");
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            int number = 0;

            for (int i = 0; i < k; i++)
            {
                if ((array[i]>0) &&(array[i] % 2 > 0) && (i % 2 == 0))
                {
                    number++;
                }
            }

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}", number);

            Console.ReadKey();
        }
    }
}
