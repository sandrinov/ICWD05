using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyUtilities;

namespace ConsoleApp_Framework
{
    /// <summary>
    /// 
    /// </summary>
    class MyClass { public String MyProperty { get; set; }}
    
    class Program
    {
        static void Main(string[] args)
        {
            #region examples
            //TestExtensions();

            //TestBoxing();
            //List<MyClass> mc_list = new List<MyClass>();
            //Object o;


            //using (SqlConnection conn = new SqlConnection("kkk"))
            //{
            //    conn.Open();
            //    //.........
            //    conn.Close();
            //}

            //int x = 10;
            //int y = 20;
            //string result = "Risultato Somma: ";

            //for (int i = 0; i < 10000; i++)
            //{
            //    Thread.Sleep(100);
            //    mc_list.Add(new MyClass() { MyProperty = i.ToString() });
            //}

            //int res = Somma(x, y);
            //result += res;
            //Console.WriteLine(result);


            //List<String> lst = new List<string>();

            //String s = "a";
            //s += "b";



            ////lst.Add(10);

            //var persona = new { Nome = "Mario", Cognome = "Rossi", Eta = 99, DataAssunzione = DateTime.Now };
            //string type = persona.GetType().FullName;
            //Console.WriteLine(type);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //var pesce = new { Nomeeee = "Mario", Cognomeeeeee = "Rossi", lunghezza = 99, DataAssunzione = DateTime.Now };
            //string s = pesce.GetType().FullName;
            //Console.WriteLine(s);
            #endregion

            ShowThreadInfo("Application");
            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();
            Console.ReadLine();
        }
        static void ShowThreadInfo(String s)
        {
            Console.WriteLine("{0} thread ID: {1} Unmanaged Thread ID: {2}",
                              s, Thread.CurrentThread.ManagedThreadId, GetCurrentThreadId());
        }

        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();
        private static void TestExtensions()
        {
            string s_pi = "3.1493749873747";
            double pi = s_pi.ToDouble();

            List<String> lst = new List<string>();
        }
        private static int Somma(int x, int y)
        {
            return x + y;
        }
        private static void TestBoxing()
        {
            int i = 0;
            Type t = i.GetType();
            Console.WriteLine(t.Name);
        }
    }
}
