using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра а = ");   //Ввод с консоли переменной а
            float a = float.Parse(Console.ReadLine());

            Console.Write("Введите значение параметра b = ");   //Ввод с консоли переменной b
            float b = float.Parse(Console.ReadLine());

            Console.Write("Введите значение параметра c = ");   //Ввод с консоли переменной c
            float c = float.Parse(Console.ReadLine());

            float d = b * b - 4 * a * c;    //Объявление переменной d (дискриминант) и подсчёт её значения

            if (d < 0)
            {
                Console.Write("Ошибочкавышла, D < 0");
                Console.ReadLine();
            }
            else
            {
                float x1, x2;   //Объявление корней уравнения
                if (d == 0)
                {
                    x2 = x1 = (-b) / 2 * a;     //Решение уравнения в случае нулевого дискриминанта 
                }
                else
                {
                    float koren_D = (float)System.Math.Sqrt(d);   //Извлечение квадратного корня из дискриминанта
                                                                 //Решение квадратного уравнения в общем случае
                    x1 = (-b + koren_D) / (2 * a);
                    x2 = (-b - koren_D) / (2 * a);
                }
                //Вывод получившихся значений на консоль
                Console.Write("D = " + d);
                Console.ReadLine();
                Console.Write("X1 = " + x1);
                Console.ReadLine();
                Console.Write("X2 = " + x2);
                Console.ReadLine();
            }
            Console.Write("Нажмителюбуюклавишу, чтобывыйтиизпрограммы");
            Console.ReadLine();
        }
    }
}

