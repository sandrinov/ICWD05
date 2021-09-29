using System;

namespace Operators_Overload
{
    public readonly struct Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }
        /*
        public static Fraction PositiveFraction(Fraction a)
        {
            return a;
        }
        public static Fraction NegativeFraction(Fraction a)
        {
            return new Fraction(-a.num, a.den);
        }
        */

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }

        public override string ToString()=> $"{num}/{den}";
        //{
        //    return $"{num}/{den}";
        //}
    }

    public readonly struct Digit
    {
        private readonly byte digit;
        public override string ToString() => $"{digit}";
        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit must be less than 10");
            }
            this.digit = digit;
        }

        public static implicit operator byte(Digit d) => d.digit;
        public static explicit operator Digit(byte b) => new Digit(b);
        
    }




    class Program
    {
        static void Main(string[] args)
        {
            TestFractions();
            TestDigit();

            TestBoxing();

            int x1 = 10;
            double d = x1;
            int x2 = (int)d;
        }

        private static void TestBoxing()
        {
            int i = 0;
            Type t = i.GetType();
            Console.WriteLine(t.Name);
        }

        private static void TestDigit()
        {
            var d = new Digit(7);

            byte number = d;
            Console.WriteLine(d);

            Digit d1 = (Digit)number;
            Console.WriteLine(d1);

        }

        private static void TestFractions()
        {
            var a = new Fraction(5, 4);
            var b = new Fraction(1, 2);

            Console.WriteLine(+a);
            Console.WriteLine(-a);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a+b);

        }
    }
}
