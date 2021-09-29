using System;

namespace Geometry_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerchio c1 = new Cerchio(11);
            Quadrato q1 = new Quadrato(33);

            //PrintQuadrato(q1);
            //PrintCerchio(c1);

            //PrintFigura(q1);
            //PrintFigura(c1);

            //CompareFigure(q1, c1);

            var persona = new { Nome = "Mario", Cognome = "Rossi", Eta = 99, DataAssunzione = DateTime.Now };

            var persona2 = new { Nome = "Mario", Cognome = "Rossi", Eta = 99.5, DataAssunzione = DateTime.Now };

            var persona3 = new { Nome = "AAAA", Cognome = "Rossi", DataAssunzione = DateTime.Now };

            var c = new Cerchio(111);

            string type = persona.GetType().FullName;
            Console.WriteLine(type);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string type2 = persona2.GetType().FullName;
            Console.WriteLine(type2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string type3 = persona3.GetType().FullName;
            Console.WriteLine(type3);
            Console.WriteLine($"hash code persona 1: {persona.GetHashCode() }  persona 2: {persona2.GetHashCode() }");
        }

        private static void CompareFigure(FiguraGeometrica f1, FiguraGeometrica f2)
        {
            int result = f1.CompareTo(f2);
            if(result > 0)
                Console.WriteLine("figura 1 > figura 2");
            else if (result < 0)
                Console.WriteLine("figura 1 < figura 2");
            else
                Console.WriteLine("figura 1 == figura 2");
        }

        private static void PrintFigura(FiguraGeometrica f)
        {
            Console.WriteLine(f.GetArea() + " " + f.GetPerimetro());
        }

        private static void PrintCerchio(Cerchio c1)
        {
            Console.WriteLine(c1.GetArea() + " " + c1.GetPerimetro());
        }
        private static void PrintQuadrato(Quadrato q1)
        {
            Console.WriteLine(q1.GetArea() + " " + q1.GetPerimetro());
        }
    }
}
