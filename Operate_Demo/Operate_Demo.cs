using System;
using System.Linq;
using Operate;
using Operate.StringHelper;
using static Operate.Count;
using static Operate.StringHelper.Strings;
using static Operate.Statistic;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Testing the Statistic class functions
            double[] data = {7.5, 8, 7, 6.5, 7, 7, 6.5, 8, 7.5, 8, 7, 7};
            Console.WriteLine(Average(data));
            Console.WriteLine(Median(data));
            Console.WriteLine(Mode(data));
            
            // Testing the Count class functions
            int a = 10;
            int b = 5;
            int[] point1 = {3, 3};
            int[] point2 = {0, 0};
            Console.WriteLine("Count class\n");
            Console.WriteLine(a.IsGreater(b));
            Console.WriteLine(b.IsLess(a));
            Console.WriteLine(b.Factorial());
            Console.WriteLine(b.IsPrime());
            Console.WriteLine(Combination(a, b));
            Console.WriteLine(Distance(point1, point2));
            Console.WriteLine(Distance(new int[] {2, 4}, new int[] {3, 9}));
            Console.WriteLine(Cbrt(a));
            Console.WriteLine();

            // Testing the StringHelper
            Console.WriteLine("StringHelper\n");
            string str = "Hello,";
            string addString = str.AddString(" World!");
            string str1 = "1 9 2 3";
            string str2 = "1 2 5 9";
            string longStr = "i have a car and my car is black because i love black and i love my car.";
            Console.WriteLine(addString);
            Console.WriteLine(addString.Reverse());
            Console.WriteLine(ReverseWord(addString));
            Console.WriteLine();
            Console.WriteLine(Intersection(new string[] {"1, 2, 3, 4", "1, 9, 3, 7"}));
            Console.WriteLine(Intersection(str1, str2));
            Console.WriteLine(longStr.Occurences("car"));
            Console.WriteLine(longStr.WordCount());
        }
    }
}
