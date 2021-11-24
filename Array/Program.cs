using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /*
     * Сформировать одномерный массив из 7 элементов. 
     * Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 7;
            float sum = 0;
            int[] arrayInt = new int[k];
            for (int i = 0; i < k; i++)
            {
                arrayInt[i] = Convert.ToInt32(Console.ReadLine());
                sum += arrayInt[i];
            }
            sum = sum / k;
            Console.WriteLine();
            Console.WriteLine("среднее арифметическое введенных элементов = {0:f2}", sum);
            Console.ReadKey();
        }
    }
}
