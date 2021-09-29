using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    public static class StringConversions 
    {
        public static double ToDouble(this string s)
        {
            return Double.Parse(s);
        }
        public static bool ToBool(this string s)
        {
            return Boolean.Parse(s);
        }
    }
}
