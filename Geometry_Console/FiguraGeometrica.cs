using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Console
{
    public abstract class FiguraGeometrica : IComparable
    {
        public int CompareTo(object obj)
        {
            FiguraGeometrica f2 = obj as FiguraGeometrica;
            if (f2 != null)
            {
                return (int)(this.GetArea() - f2.GetArea());
            }
            else
                throw new Exception("Invalid Figura Geometrica");
        }

        public abstract double GetArea();
        public abstract double GetPerimetro();

        public void PrintFiguraGeometrica()
        {
            double area = GetArea();
            double perimetro = GetPerimetro();
            string s = $"Area: {area}, Perimetro: {perimetro}";
            Console.WriteLine(s);
        }
    }
}
