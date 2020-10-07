using System;
using System.Collections.Generic;

namespace Lab2
{
    abstract class Figure
    {
        public virtual double ploshad()
        {
            return 0;
        }
    }
    class Rectangle : Figure, IPrint
    {
        protected double w, h;
        public Rectangle()
        {
            w = h = 0;
        }
        public Rectangle(double a, double b)
        {
            w = a;
            h = b;
        }
        public override double ploshad()
        {
            return (w * h);
        }
        public override string ToString()
        {
            return $"Rectangle\nWidth = {w}, Heigth = {h}\nPloshad = {ploshad()}\n";
        }
        void IPrint.Print()
        {
            Console.WriteLine(ToString());
        }
    }
    class Square : Rectangle, IPrint
    {
        public Square(double a)
        {
            w = a;
            h = a;
        }
        public override string ToString()
        {
            return $"Square\nSide = {w}\nPloshad = {ploshad()}\n";
        }
        void IPrint.Print()
        {
            Console.WriteLine(ToString());
        }
    }
    class Circle : Figure, IPrint 
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double ploshad()
        {
            return (radius * radius * Math.PI);
        }
        public override string ToString()
        {
            return $"Circle\nRadius = {radius}\nPloshad = {ploshad()}\n";
        }
        void IPrint.Print()
        {
            Console.WriteLine(ToString());
        }
    }
    interface IPrint
    {
        void Print();
    }


    class Program
    {
        static void Print(IPrint pr)
        {
            pr.Print();
        }
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(0, 7);
            Circle b = new Circle(9);
            Square c = new Square(98);
            Print(a);
            Print(b);
            Print(c);
        }
    }
}
