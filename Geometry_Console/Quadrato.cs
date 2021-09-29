using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Console
{
    public class Quadrato : FiguraGeometrica
    {
        public double lato { get; set; }

        public Quadrato(double l)
        {
            this.lato = l;
        }
        public override double GetArea()
        {
            return lato * lato;
        }
        public override double GetPerimetro()
        {
            return lato * 4;
        }
    }
}
