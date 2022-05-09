using System;
using System.Collections.Generic;

namespace GeometryOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square4 = new Square(4);
            Rectangle rect4b6 = new Rectangle(4, 6);
            Parallelogram parallelogram5b8A40 = new Parallelogram(5, 8, 40);
            Trapez trapez5b4c7d9 = new Trapez(10, 9, 8, 9);
            Triangle triangle3b4 = new Triangle(3, 4);
            List<Square> results = new List<Square>() { square4, rect4b6, parallelogram5b8A40, trapez5b4c7d9, triangle3b4 };
            foreach (Square item in results)
            {
                Console.WriteLine("Perimiter: " + item.Perimiter());
                Console.WriteLine("Area: " + item.Area());
            }
        }
    }
}
