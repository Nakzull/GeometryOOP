using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryOOP
{
    class Square
    {
        protected double sideA;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public virtual double Perimiter()
        {
            return sideA * 4;
        }
        public virtual double Area()
        {
            return sideA * sideA;
        }

        public Square(double side)
        {
            SideA = side;
        }
        public Square()
        {

        }
    }
}
