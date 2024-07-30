using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CodeWars_C_Mini
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
    //public class Kata
    //{
    //    public static int[] InvertValues(int[] input)
    //    {
    //        return input.Select(n => -n).ToArray();
    //    }
    //}
    #endregion

    #region C# Kata 10 
    //If you can't sleep, just count sheep!!

    //Task:
    //Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will
    //always be valid, i.e.no negative integers.
    //public static class Kata
    //{
    //    public static string CountSheep(int n)
    //    {
    //        string result = "";
    //        for (int i = 1; i <= n; i++)
    //        {
    //            result += $"{i} sheep...";
    //        }
    //        return result;

    //    }
    //}
    #endregion

    #region C# Kata 11
    //We need a function that can transform a string into a number.What ways of achieving this do you know?

    //Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral
    //number.

    //public class Kata
    //{
    //    public static int StringToNumber(String str)
    //    {
    //        //TODO: Convert str into a number
    //        int result = Convert.ToInt32(str);
    //        return result;
    //    }
    //}
    #endregion

    #region C# Kata 12 
    //Create a function with two arguments that will return an array of the first n multiples of x.

    //Assume both the given number and the number of times to count will be positive numbers greater than 0.

    //Return the results as an array or list(depending on language).
    //public static class Kata
    //{
    //    public static int[] CountBy(int x, int n)
    //    {
    //        int[] z = new int[n-1];

    //        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
    //    }
    //}
    #endregion

    #region C# Kata 13
    //Complete the function so that it finds the average of the three scores passed to it and returns the letter value 
    //associated with that grade.
    //Numerical Score Letter Grade
    //90 <= score <= 100	'A'
    //80 <= score< 90	'B'
    //70 <= score< 80	'C'
    //60 <= score< 70	'D'
    //0 <= score< 60	'F'

    //public class Kata
    //{
    //    public static char GetGrade(int s1, int s2, int s3)
    //    {
    //        //Your code goes here...
    //        var avg = (s1 + s2 + s3)/3;

    //        switch (avg)
    //        {
    //            case <= 0:
    //                return '0';

    //            case > 0 and <= 60:
    //                Console.WriteLine("0-60");
    //                break;

    //            case > 60 and <= 70:
    //                Console.WriteLine("61-70");
    //                break;

    //            case > 70 and <= 80:
    //                Console.WriteLine("71-80");
    //                break;

    //            case > 80 and <= 90:
    //                Console.WriteLine("81-90");
    //                break;

    //            case > 90 and <= 100:
    //                avg = "91-99");
    //                break;

    //            default:
    //                break;
    //        }
    //        return Convert.ToChar(avg);
    //    }
    //}
    #endregion

    #region C# Kata 14
    /*
        Rock Paper Scissors
        Let's play! You have to return which player won! In case of a draw return Draw!.

        Examples(Input1, Input2 --> Output) :

        "scissors", "paper" --> "Player 1 won!"
        "scissors", "rock" --> "Player 2 won!"
        "paper", "paper" --> "Draw!"
    
     */
    //public class Kata
    //{
    //    public static string Rps(string p1, string p2)
    //    {
    //        if (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock")
    //        {
    //            return "Player 1 won!";
    //        }
    //        else if (p1 == p2)
    //        {
    //            return "Draw!";
    //        }
    //        else
    //        {
    //            return "Player 2 won!";
    //        }

    //    }
    //}
    #endregion

    #region C# Kata 15
    //You will be given an array a and a value x.All you need to do is check whether the provided array contains the value.

    //Array can contain numbers or strings.X can be either.

    //Return true if the array contains the value, false if not.

    //public class Kata
    //{
    //    public static bool Check(object[] a, object x)
    //    {
    //        bool containsTarget = a.Contains(x);
    //        return containsTarget;

    //    }
    // Optimal Option: (  public static bool Check(object[] a, object v) => a.Contains(v);   )
    //}
    #endregion

    #region C# Kata 16
    //Make a simple function called greet that returns the most-famous "hello world!".

    //public static class Kata
    //{
    //    // Write a public static method "greet" that returns "hello world!"
    //    public static string Greet()
    //    {
    //        return "hello world!";
    //    }
    //}
    #endregion

    #region C# Kata 17 
    //Write function bmi that calculates body mass index(bmi = weight / height2).

    //if bmi <= 18.5 return "Underweight"

    //if bmi <= 25.0 return "Normal"

    //if bmi <= 30.0 return "Overweight"

    //if bmi > 30 return "Obese"

    //public class Kata
    //{
    //    public static string Bmi(double weight, double height)
    //    {
    //        double bmi = weight / (height*height);

    //        if (bmi <= 18.5)
    //        {
    //            return "Underweight";
    //        }
    //        else if(bmi <= 25.0)
    //        {
    //            return "Normal";
    //        }
    //        else if (bmi <= 30.0)
    //        {
    //            return "Overweight";
    //        }
    //        else
    //        {
    //            return "Obese";
    //        }

    //    }
    //}
    #endregion

    #region C# Kata 18 
    //Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.

    //The output should be two capital letters with a dot separating them.

    //It should look like this:

    //Sam Harris => S.H

    //patrick feeney => P.F

    //public class Kata
    //{
    //    public static string AbbrevName(string name)
    //    {
    //        string shortName = "";
    //        name.Split(' ').ToList().ForEach(i => shortName += i[0].ToString());
    //        return shortName.Insert(1, ".").ToUpper();

    //        //Best solution:
    //        //public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
    //    }
    }
#endregion

    #region C# Kata 19 



    #endregion


