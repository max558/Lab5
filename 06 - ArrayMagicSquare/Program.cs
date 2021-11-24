using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___ArrayMagicSquare
{
    class Program
    {
        /*
         * Запросить у пользователя целочисленное значение N. 
         * Сформировать двумерный массив размера NxN. 
         * Заполнить массив числами, вводимыми с клавиатуры. 
         * Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
         * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
         */
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите целочисленное число N: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, n];
            int[] arrayStr = new int[n];
            int[] arrayCol = new int[n];

            //Заполнение массива с клавиатуры
            int elenNum = 0,
                sumDiag = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите целочисленное значение массива a({0}:{1}): ", i, j);
                    elenNum = Convert.ToInt32(Console.ReadLine());
                    array[i, j] = elenNum;
                }
            }
            Console.WriteLine();

            //Общий вывод массива с суммами
            for (int i = 0; i < (n + 1); i++)
            {
                for (int j = 0; j < (n + 1); j++)
                {
                    //Расчет сумм
                    if ((i < n) && (j < n))
                    {
                        arrayStr[i] += array[i, j];
                        arrayCol[i] += array[j, i];
                        if (i == j)
                        {
                            sumDiag += array[i, j];
                        }
                    }
                    //Вывод общей матрицы
                    if (i < n)
                    {
                        if (j < n)
                        {
                            Console.Write("{0,4} ", array[i, j]);
                        }
                        else
                        {
                            Console.Write("{0,6} ", arrayStr[i]);
                        }
                    }
                    else
                    {
                        if (j < n)
                        {
                            Console.Write("{0,4} ", arrayCol[j]);
                        }
                        else
                        {
                            Console.Write("{0,6} ", sumDiag);
                        }
                    }
                }
                Console.WriteLine();
                if (i == (n - 1))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            //Сравнение сумм и общий вывод по задаче
            bool strCol = false,
                res = false;
            for (int i = 0; i < n; i++)
            {
                if (arrayStr[i] == arrayStr[i])
                {
                    strCol = true;
                }
                if ((strCol) && (arrayCol[i] == sumDiag))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }

            if (res)
            {
                Console.WriteLine("Введенный массив является магическим квадратом.");
            }
            else
            {
                Console.WriteLine("Введенный массив НЕ является магическим квадратом.");
            }

            Console.ReadKey();
        }
    }
}
