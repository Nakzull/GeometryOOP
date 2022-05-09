using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOOP
{
    class Trapez : Square
    {
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        private double sideD;

        public double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }

        public override double Perimiter()
        {
            return sideA + sideB + sideC + SideD;
        }
        public override double Area()
        {
            double s = (sideA + sideB - sideC + sideD) / 2;
            double temp = s * (s - sideA + sideC) * (s - sideB) * (s - sideD);
            double h = (2 / (sideA - sideC)) * Math.Sqrt(temp);
            return (sideA + sideC) * h / 2;
        }

        public Trapez(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
    }
}
