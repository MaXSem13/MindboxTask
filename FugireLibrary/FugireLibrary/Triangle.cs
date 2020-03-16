using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FugireLibrary
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if((a + b <=c || a + c <= b || c + b <= a) && (a <= 0 || b <= 0 || c <= 0))
            {
                throw new ArgumentException();
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a;}
        public double B { get => b; }
        public double C { get => c; }

        public override double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        }

        public bool IsRectangular()
        {
            return (a*a + b* b) == c * c;
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public override string ToString()
        {
            return "a = "+ a.ToString() + " b = " + b.ToString() + " c = " + c.ToString();
        }
    }
}
