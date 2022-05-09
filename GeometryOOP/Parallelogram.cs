using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOOP
{
    class Parallelogram : Square
    {
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public override double Perimiter()
        {
            return (sideA + sideB) * 2;
        }

        public override double Area()
        {
            return sideA * sideB * Math.Sin(angle);
        }

        public Parallelogram(double sideA, double sideB, double angle)
        {
            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }
    }
}
