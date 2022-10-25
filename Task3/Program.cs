using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задачи на использование операторов цикла с предусловием.Осуществить ввод необходимых данных, выполнить реализацию 
             * алгоритма с использованием операторов цикла while, обеспечить вывод полученных результатов. Использование других 
             * операторов цикла недопустимо.
            Задачи
            Ввести положительные числа A, B, C.На прямоугольнике размера A x B размещено максимально возможное количество 
            квадратов со стороной C(без наложений). Найти количество квадратов, размещенных на прямоугольнике.Операции умножения и 
            деления не использовать.
             * 
             */
            Console.Write("Введите длину стороны A прямоугольника. A=");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите длину стороны B прямоугольника. B=");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите длину стороны C вписанного в прямоугольника квадрата. C=");
            float c = Convert.ToSingle(Console.ReadLine());

            float la , lb;
            la = lb = c;

            int n=0;
            
            while (la <= a) 
            {
                while (lb <= b)
                {
                    n++;
                    lb += c;
                }
                lb = c;
                la += c;
            }

            Console.Write("На прямоугольнике c размерами A={0} x B={1} можно разместить {2} квадратов со стороной C ={3} (без наложений).",a,b,n,c);

            Console.ReadKey();
        }
    }
}
