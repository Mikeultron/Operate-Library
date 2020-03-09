using System;
using System.Linq;
using System.Collections.Generic;

namespace Operate
{
    public static class Count
    {        
        /**
            * Count the factorial of this int.
            * Returns the factorial of this integer.
            */
        public static int Factorial(this int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            int num;
            num = n;
            for(int i = n - 1; i > 0; i--)
            {
                num = num * i;
            }
            return num;
        }
        /**
            * Check if this int is greater than the comparer.
            * Returns boolean value.
            */
        public static bool IsGreater(this int n, int Comparer)
        {
            if(n > Comparer)
            {
                return true;
            }            
            return false;
        }
        /**
            * Check if this int is less than the comparer.
            * Returns boolean value.
            */
        public static bool IsLess(this int n, int m)
        {
            if(n < m)
            {
                return true;
            }
            return false;
        }
        /**
            * Check if this integer is a prime number or not.
            * Returns true if it is a prime number, and false if it is not a prime number.
            */
        public static bool IsPrime(this int n)
        {            
            if(n < 2)
            {                
                return false;
            }
            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {                    
                    return false;
                }
            }
            return true;
        }
        /**
            * Returns combination of nCr.
            * The function will return 0 if n is less than r.
            */
        public static int Combination(int n, int r)
        {
            if(n < r)
            {
                return 0;
            }
            int sum;
            sum = Factorial(n)/(Factorial(n - r) * Factorial(r));
            return sum;
        }
        /**
            * Calculate the distance between point1 and point2.
            * ex : new int[] {3, 3}, new int[] {0, 0}
            *
            * Output : 4.24
            */
        public static double Distance(int[] point1, int[] point2)
        {
            double sum;
            sum = Math.Sqrt((Math.Pow(point1[0] - point2[0], 2)) + (Math.Pow(point1[1] - point2[1], 2)));
            return Math.Round(sum, 2);
        }
        /**
            * Returns the cube root of a specified number.
            */
        public static double Cbrt(double n)
        {
            double num, res, p = (double)1/3;
            num = Convert.ToDouble(n);
            res = Math.Round((Math.Pow(num, p)), 5);
            return res;
        }
    }
    namespace StringHelper
    {
        public static class Strings
        {
            /**
                * Returns a new string which all the characters are reversed.
                * This function takes parameter string s.
                * This function will reverse the given string.
                */
            public static string Reverse(this string s)
            {
                string reverse = "";
                for(int i = s.Length - 1; i >= 0; i--)
                {
                    reverse += s[i];
                }
                return reverse;
            }
            /**
                * Returns a new string which each words of the string are reversed.
                * This function takes parameter string s.
                * This function will reverse the given string.
                */
            public static string ReverseWord(string s)
            {
                string[] str;
                str = s.Split();
                string reverse = ""; 
                for(int i = 0; i < str.Count(); i++)
                {
                    string z = str[i];
                    int length = z.Length - 1;
                    string temp = "";
                    for(int j = 0; j < z.Length; j++)
                    {
                        temp += z[length];
                        length--;
                    }
                    reverse += temp + " ";
                }
                return reverse;
            }
            /**
                * Add new string to an existing string.
                */
            public static string AddString(this string s, string add)
            {
                return s + add;
            }
            /**
                * Returns the intersection between two indexes of an array.
                * This function parses the string into integer.
                * This function only accept numeric strings.
                * Separated by comma.
                *
                * ex : new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
                *
                * Output : 1,4,13
                */
            public static string Intersection(string[] str)
            {
                var firstArray = str[0].Split(',');
                var secondArray = str[1].Split(',');
                var firstIndex = 0;
                var secondIndex = 0;
                var results = new List<String>();
                do
                {
                    var firstNumber = Int32.Parse(firstArray[firstIndex].Trim());
                    var secondNumber = Int32.Parse(secondArray[secondIndex].Trim());
                    if(firstNumber == secondNumber)
                    {
                        results.Add(firstArray[firstIndex].Trim());
                        firstIndex++;
                        secondIndex++;
                    }
                    else if(firstNumber < secondNumber)
                        firstIndex++;
                    else
                        secondIndex++;
                }
                while(firstIndex < firstArray.Length && secondIndex < secondArray.Length);
                return string.Join(",", results.ToArray());
            }
            /**
                * Returns the intersection between two strings (str1, str2).
                * This function takes two string parameter.
                * Separated by space.
                *
                * ex : "Operate library open source", "Operate library closed source";
                *
                * Output : Operate library source.
                */
            public static string Intersection(string str1, string str2)
            {
                string[] string1 = str1.Split(' ');
                string[] string2 = str2.Split(' ');
                var m = string1.Distinct();
                var n = string2.Distinct();
                var results = m.Intersect(n, StringComparer.OrdinalIgnoreCase);
                var test = "";
                foreach(var k in results) 
                    test += k + " ";
                return test;
            }
            /**
                * Count the occurences of a specified string in a string.
                *
                * Returns the total of the occurences.
                */
            public static int Occurences(this string str, string key)
            {
                string[] arr = str.Split(new[] {' ', '?', '.', ',', '!', ';'}, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<int, string> d = new Dictionary<int, string>();

                for(int i = 0; i < arr.Length; i++)                
                    d.Add(i, arr[i]);                
                return d.Where(x => x.Value == key).ToList().Count();
            }
            /**
                * Count the number of words in a string.
                *
                * Returns the total number of words in the string.
                *
                * ex : "hello my name is Operate";
                * Output : 5
                */
            public static int WordCount(this string str)
            {                
                int wrd,l;
                l = 0;
                wrd = 1;
                while (l <= str.Length - 1)
                {
                    if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
                        wrd++;
                    l++;
                }
                return wrd;
            }
        }
    }
}
