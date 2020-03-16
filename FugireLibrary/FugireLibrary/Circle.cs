using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FugireLibrary
{
    public class Circle : Figure
    {
        private double r;

        public Circle(double r)
        {
            if(r <= 0)
            {
                throw new ArgumentException();
            }
            this.r = r;
        }

        public double R{get => r;}
        public override double GetSquare()
        {
            return Math.PI * r * r;
        }

        public override string ToString()
        {
            return "r = " + r.ToString();
        }
    }
}
