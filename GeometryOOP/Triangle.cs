using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOOP
{
    class Triangle : Square
    {
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override double Perimiter()
        {
            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            return sideA + sideB + sideC;
        }

        public override double Area()
        {
            return sideA * sideB / 2;
        }

        public Triangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
    }
}
