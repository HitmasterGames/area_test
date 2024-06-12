using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    internal class circle : Figure
    {
        public double Radius { get; set; }
        public double Pi { get; set; }

        public circle()
        {
            Pi = 3.14;
            Radius = 0;
        }

        public circle(double radius)
        {
            Radius = Radius;
        }

        public override double Square()
        {
            return Pi * (Radius*Radius);
        }

        public override string ToString()
        {
            return string.Format("Окружность (Пи * r^2 = {0}x({1}*{2}))", Pi, Radius, Radius);
        }
    }
}
