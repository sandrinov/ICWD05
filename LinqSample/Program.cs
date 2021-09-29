using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static List<string> presidents = new List<string>(){
"Adams", "Arthur", "Buchanan", "Bush", "Carter", "Cleveland",
"Clinton", "Coolidge", "Eisenhower", "Fillmore", "Ford", "Garfield",
"Grant", "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
"Jefferson", "Johnson", "Kennedy", "Lincoln", "Madison", "McKinley",
"Monroe", "Nixon", "Obama", "Pierce", "Polk", "Reagan", "Roosevelt",
"Taft", "Taylor", "Truman", "Tyler", "Van Buren", "Washington", "Wilson"};


        public delegate bool Filterdelegate(int i);
        static void Main(string[] args)
        {
            TestLamba_one();

            var result1 = presidents
                         .Where(s => s.ToUpper().Length <= 6)
                         .OrderByDescending(s=>s);


            var result2 = (from p in presidents
                          .Where(s => s.EndsWith("a"))
                           orderby p.Length
                          select p);


        }

        private static void TestLamba_one()
        {
            List<int> startList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Filterdelegate filter = new Filterdelegate(FilterOdd);
            //List<int> OddInts = FilterList(startList, filter);
            //List<int> OddInts = FilterList(startList, FilterOdd);
            List<int> OddInts = FilterList(startList, i => (i & 1) == 1);
            foreach (int i in OddInts)
            {
                Console.WriteLine(i);
            }
        }

        public static bool FilterOdd(int i)
        {
            if ((i % 2) == 1)
                return true;
            else
                return false;
        }
        public static List<int> FilterList(List<int> lst, Filterdelegate filter )
        {
            List<int> resultList = new List<int>();
            foreach (var i in lst)
            {
                if (filter(i))
                    resultList.Add(i);
            }
            return resultList;
        }
    }
}
