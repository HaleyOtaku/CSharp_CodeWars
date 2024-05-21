using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_C__Mini
{
    //Ctrl+K+C Comment Out Multiple Lines
    //Ctrl+K+U Uncomment Multiple Lines

    #region C# Kata 1
    //public class Kata
    //{
    //    public static string AreYouPlayingBanjo(string name)
    //    {
    //        string result = "";

    //        if (name[0] == 'R' || name[0] == 'r')
    //        {
    //            result = name + " plays banjo";
    //        }
    //        else
    //        {
    //            result = name + " does not play banjo";
    //        }

    //        return result;
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }
    //}
    #endregion

    #region C# Kata 2
    //In this simple assignment you are given a number and have to make it negative.But maybe the number is already negative?
    //Kata.MakeNegative(1);  // return -1
    //Kata.MakeNegative(-5); // return -5
    //Kata.MakeNegative(0);  // return 0
    //public static class Kata
    //{
    //    public static int MakeNegative(int number)
    //    {
    //        if (number > 0)
    //        {
    //            return number * -1; ;
    //        }
    //        else
    //        {
    //            return number;
    //        }
    // ** Simplest Answer: return -Math.Abs(number); **
    //    }
    //}
    #endregion

    #region C# Kata 3
    //Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".

    //[Make sure you type the exact thing I wrote or the program may not execute properly]
    //public static class Kata
    //{
    //    public static string Greet(string name)
    //    { 
    //        return "Hello, " + name + " how are you doing today?";

    //    }
    //}
    #endregion

    #region C# Kata 4 
    //Your task is to make two functions(max and min, or maximum and minimum, etc., depending on the language) that receive a list of integers as input,
    //and return the largest and lowest number in that list, respectively.
    //public class Kata
    //{   //Had to make fields below static to console.log in Program.cs
    //    public static int Min(int[] list) => list.Min();
    //    public static int Max(int[] list) => list.Max();
    //}
    #endregion

    #region C# Kata 5
    //Introduction    
    //The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

    //Task
    //Given a year, return the century it is in.

    //public static class Kata
    //{
    //    public static int СenturyFromYear(int year)
    //    {
    //        var century = (int)(year / 100)+((year % 100 == 0) ? 0:1);
    //        //year % 100 == 0 ? 0 : 1 means that if year = 1705, the remainder is 5 which !== 0, therefore, it adds 1 to the century, for 18.
    //        //It will only not add 1 to the century if, as in the example above, it's the first year of the century, such as 1700, which would be
    //        //still considered the 17th century.
    //        return century;
    //    }
    //}
    #endregion

    #region C# Kata 6
    //Given an array of integers your solution should find the smallest integer.

    //For example:

    //Given[34, 15, 88, 2] your solution will return 2
    //Given[34, -345, -1, 100] your solution will return -345
    //You can assume, for the purpose of this kata, that the supplied array will not be empty.
    //public class Kata
    //{
    //    public static int FindSmallestInt(int[] args)
    //    {
    //        Array.Sort(args);
    //        return args[0]; //^1 would get the largest item, as Sort goes from least to greatest
    //        //** Simplest Answer: return args.Min(); **
    //    }
    //}
    #endregion

    #region C# Kata 7 
    //Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
    //public class Kata
    //{
    //    public static string RemoveExclamationMarks(string s)
    //    {
    //        // Your code goes here
    //        var exclamation = new String[] {"!"};
    //        foreach (var c in exclamation)
    //        {
    //           s = s.Replace(c, string.Empty);
    //        }
    //        return s;
    //        //** Simplest Answer: return s.Replace("!", ""); **
    //    }
    //}
    #endregion

    #region C# Kata 8 
    //Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

    //Note: input will never be an empty string
    //public class Kata
    //{
    //    public static string FakeBin(string x)
    //    {
    //        string result = "";

    //        foreach (char c in x)
    //        {
    //            result += c < '5' ? "0" : "1";
    //        }
    //            return result;
    //    }
    //}

    #endregion

    #region C# Kata 9 
    //Given a set of numbers, return the additive inverse of each.Each positive becomes negatives, and the negatives become positives.
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
           

        }
    }
    #endregion
}
