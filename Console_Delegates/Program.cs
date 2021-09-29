using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Delegates
{
    public class MyClass
    {
        public int GetLength(String s)
        {
            return s.Length;
        }
    }
    class Program
    {
        public delegate int MyDelegate(String s);
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyDelegate md = new MyDelegate(mc.GetLength);

            Console.WriteLine(mc.GetLength("lkjkljkjlkjlknljkl"));

            Console.WriteLine(md("lkjòhhiib"));
        }
    }
}
