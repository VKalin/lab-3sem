using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1, 9);
            Square square = new Square(9);
            Circle circle = new Circle(7);

            Console.WriteLine("ArrayList");
            ArrayList AL = new ArrayList();
            AL.Add(circle);
            AL.Add(rect);
            AL.Add(square);

            foreach (var x in AL) Console.WriteLine(x);
            Console.WriteLine("\nArrayList - сортировка");
            AL.Sort();
            foreach (var x in AL) Console.WriteLine(x);

            Console.WriteLine("\nList<GeometricFigure>");
            List<GeometricFigure> L = new List<GeometricFigure>();
            L.Add(circle);
            L.Add(rect);
            L.Add(square);

            foreach (var x in L) Console.WriteLine(x);
            Console.WriteLine("\nList<GeometricFigure> - сортировка");
            L.Sort();
            foreach (var x in AL) Console.WriteLine(x);

            Console.WriteLine("\nМатрица");
            Matrix 3D < GeometricFigure > MATRIX = newMatrix 3D < GeometricFigure > (3, 3, 3, null);
            MATRIX[0, 0, 0] = rect;
            MATRIX[1, 1, 1] = square;
            MATRIX[2, 2, 2] = circle;
            Console.WriteLine(MATRIX.ToString());

            Console.WriteLine("\nСписок");
            SimpleList<GeometricFigure> list = new SimpleList<GeometricFigure>();
            list.Add(square);
            list.Add(rect);
            list.Add(circle);
            foreach (var x in list) Console.WriteLine(x);
            list.Sort();
            Console.WriteLine("\nСортировкасписка");
            foreach (var x in list) Console.WriteLine(x);

            Console.WriteLine("\nСтек");
            SimpleStack<GeometricFigure> stack = new SimpleStack<GeometricFigure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                GeometricFigure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}

