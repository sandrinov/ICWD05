
namespace ConsoleApp_Core
{
    class MyClass { }
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 x = new System.Int32();
            x = 10;
            int y = 20;
            string result = "Risultato Somma: ";

            System.Object o;

            MyClass mc;


            mc = new MyClass();

            int res = Somma(x, y);
            result += res;
            System.Console.WriteLine(result);
        }

        private static int Somma(int x, int y)
        {
            return x + y;
        }
    }
}
