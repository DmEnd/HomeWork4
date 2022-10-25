using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задачи на использование операторов цикла for. Осуществить ввод необходимых данных, выполнить 
             * реализацию алгоритма с использованием операторов цикла for, обеспечить вывод полученных результатов. 
             * Не разрешается использовать другие операторы цикла.

             Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления 
            следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее 
            значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).*/

            Console.WriteLine("Ввести целое число N > 0");
            int N = Convert.ToInt16(Console.ReadLine());

            if (N > 0)
            {
                int S = 0;

                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(S = S + 2 * i - 1);
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Введино отрицательное число.");
            }
            Console.ReadKey();
        }
    }
}