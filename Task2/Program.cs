using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, 
            выполнить реализацию алгоритма с использованием операторов цикла do - while, обеспечить вывод полученных результатов. 
            Использование других операторов цикла недопустимо.

            Задачи
            Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
            Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
             */
            Console.WriteLine("Вводите последовательно целые числа, окончанием последовательности служит число 0.");

            int n, pos, neg;

            pos=neg=0;

            //Ввод чисел и подсчёт
            do
            {
                n = Convert.ToInt16(Console.ReadLine());

                if (n < 0)
                {
                    neg++;
                }
                else if (n>0)
                {
                    pos++;
                }

            } while (n!=0);

            //Вывод результата
            if (neg==pos)
            {
                Console.Write("Количество положительных и отрицательных чисел одинаково и равно {0}.",neg);
            }
            else if (neg>pos)
            {
                Console.Write("Количество отрицательных чисел больше, чем положительных и равно {0}.", neg);
            }
            else
            {
                Console.Write("Количество положительных чисел больше, чем отрицательных и равно {0}.", pos);
            }
            Console.ReadKey();
        }
    }
}
