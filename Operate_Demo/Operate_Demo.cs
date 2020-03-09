using System;
using Operate;
using Operate.StringHelper;
using static Operate.Count;
using static Operate.StringHelper.Strings;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Some Variables to test
            int a = 10;
            int b = 5;
            int[] point1 = {3, 3};
            int[] point2 = {0, 0};
            
            // Testing the Count classes functions
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
            Console.WriteLine(addString);
            Console.WriteLine(addString.Reverse());
            Console.WriteLine(ReverseWord(addString));
            Console.WriteLine();
            Console.WriteLine(Intersection(new string[] {"1, 2, 3, 4", "1, 9, 3, 7"}));
            Console.WriteLine(Intersection(str1, str2));
        }
    }
}