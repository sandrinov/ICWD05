using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Console
{
    public class Cerchio : FiguraGeometrica
    {
        public double raggio { get; set; }

        public Cerchio(double r)
        {
            this.raggio = r;
        }
        public override double GetArea()
        {
            return raggio * raggio * Math.PI;
        }
        public override double GetPerimetro()
        {
            return raggio * 2 * Math.PI;
        }
    }
}
