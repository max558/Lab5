using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRandom15
{
    /*
     * Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
     * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 10;
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

            //Обработка входного массива

            //Сортировка всего массива, но по 5 элементов возрастания и 5 элементов убывания - не по условию задачи
            /*
            for (int i = 0; i < k - 1; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < k ; j++)
                {
                    if (i >= k / 2)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                    else
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            */
            //Согласно условию задачи сортировка по 5 элементов
            for (int i = 0; i < k / 2 - 1; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < k / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = k / 2; i < k - 1; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < k; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


            //вывод результата
            Console.WriteLine("Обработанный массив по заданию 2:");
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
