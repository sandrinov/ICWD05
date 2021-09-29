using System;

namespace Casting_Console
{
    public class A { public int p_a { get; set; } };
    public class B : A, I1, I2 { public int p_b { get; set; }
        public void m1() { }
        public void m2() { }
    };
    public class C : A { public int p_c { get; set; } };
    public class D : B { public int p_d { get; set; } };

    public interface I1 { void m1(); };
    public interface I2 { void m2(); };
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new D();

            try
            {
                D d4 = (D)a2;
            }
            catch (Exception e)
            {

                throw;
            }

            D d3 = a2 as D;

            if (d3!= null)
            {
                
            }


            B b1 = (B)a2;

            I1 mc1 = new D();
           // mc1.
            I1 mc2 = new B();

          //  I1 mc3 = new A();

            I2 mc11 = new D();
            I2 mc22 = new B();
         //   I2 mc33 = new A();

            //C c1 = new A();
            //B b1 = new C();
        }
    }
}
