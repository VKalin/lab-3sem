using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCollections
{
interface IPrint
{
void Print();
}
///<summary>
///Классфигура
///</summary>
abstract class Figure
{  ///<summary>
///Типфигуры
///</summary>
public string Type
{
    get
    {
        return this._Type;
    }
    protected set
    {
        this._Type = value;
    }
}
string _Type;
///<summary>
///площадь
///</summary>
///<returns></returns>
public abstract double Area();

///<summary>
/// Преобразование в строку, переопределение метода Object
///</summary>
///<returns></returns>
public override string ToString()
{
    return this.Type + " площадью " + this.Area().ToString();
}
}
class Rectangle :Figure, IPrint
{
///<summary>
///Высота
///</summary>
double height;
///<summary>
///Ширина
///</summary>
double width;
///<summary>
///Основнойконструктор
///</summary>
///<param name="ph">Высота</param>
///<param name="pw">Ширина</param>
publicRectangle(double ph, double pw)
{
    this.height = ph;
    this.width = pw;
    this.Type = "Прямоугольник";
}
///<summary>
/// Вычисление площади
///</summary>
public override double Area()
{
    double Result = this.width * this.height;
    return Result;
}
public void Print()
{
    Console.WriteLine(this.ToString());
}
}
class Square :Rectangle, IPrint
{
public Square(double size)
: base(size, size)
{
    this.Type = "Квадрат";
}
}
class Circle :Figure, IPrint
{  ///<summary>
///Ширина
///</summary>
double radius;
///<summary>
///Основнойконструктор
///</summary>
///<param name="ph">Высота</param>
///<param name="pw">Ширина</param>
public Circle(double pr)
{
    this.radius = pr;
    this.Type = "Круг";
}
public override double Area()
{
    double Result = Math.PI * this.radius * this.radius;
    return Result;
}
public void Print()
{
    Console.WriteLine(this.ToString());
}
}
class program
{
static void Main(string[] args)
{
    Console.Write("Введите значение параметра n = ");   //Ввод с консоли переменной n
    float n = float.Parse(Console.ReadLine());
    Console.Write("Введите значение параметра m = ");   //Ввод с консоли переменной m
    float m = float.Parse(Console.ReadLine());

    if (n == m)
    {
        Square square = new Square(n);
        square.Print();
    }
    if (n != m)
    {
        if (m == 0)
        {
            Circle circle1 = new Circle(n);
            circle1.Print();
        }
        else
        {
            Rectangle rectangle = new Rectangle(n, m);
            rectangle.Print();
        }
    }
    Console.ReadLine();
}
}
}
