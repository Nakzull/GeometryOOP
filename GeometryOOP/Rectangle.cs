using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOOP
{
    class Rectangle : Square
    {
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override double Perimiter()
        {
            return (sideA + sideB) * 2;
        }
        public override double Area()
        {
            return sideA * sideB;
        }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
    }
}
