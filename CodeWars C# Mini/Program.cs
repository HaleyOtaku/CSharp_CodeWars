using CodeWars_C_Mini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars_C_Mini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CodeWars C# Kata #1 Results
            //Console.WriteLine(Kata.AreYouPlayingBanjo("John"));
            //Console.WriteLine(Kata.AreYouPlayingBanjo("Raul"));
            #endregion

            #region CodeWars C# Kata #2 Results
            //Console.WriteLine(Kata.MakeNegative(1));  // return -1
            //Console.WriteLine(Kata.MakeNegative(-5)); // return -5
            //Console.WriteLine(Kata.MakeNegative(0));  // return 0
            #endregion

            #region CodeWars C# Kata #3 Results
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine(Kata.Greet(name));
            #endregion

            #region CodeWars C# Kata #4 Results
            //* [4, 6, 2, 1, 9, 63, -134, 566]-> max = 566, min = -134
            //* [-52, 56, 30, 29, -54, 0, -110]-> min = -110, max = 56
            //* [42, 54, 65, 87, 0]-> min = 0, max = 87
            //* [5]->min = 5, max = 5
            //Int32[] list = new Int32[] { 4, 6, 2, 1, 9, 63, -134, 566 };

            //List<int> list2 = new List<int> { -52, 56, 30, 29, -54, 0, -110};
            //List<int> list3 = new List<int> { 42, 54, 65, 87, 0};
            //List<int> list4 = new List<int> {5};
            //Console.WriteLine($"List 1 Min: {Kata.Min(list)}");
            //Console.WriteLine($"List 1 Max: {Kata.Max(list)}");
            //Console.WriteLine($"List 1 Range: {Kata.Min(list)}-{Kata.Max(list)}");
            #endregion

            #region CodeWars C# Kata #5 Results
            //1705-- > 18
            //1900-- > 19
            //1601-- > 17
            //2000-- > 20
            //2742-- > 28
            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The year {year} is in the {Kata.СenturyFromYear(year)} century.");
            #endregion

            #region CodeWars C# Kata #6 Results 
            //Given[34, 15, 88, 2] your solution will return 2
            //Given[34, -345, -1, 100] your solution will return -345
            //int[] integers = new int[] { 34, 15, 88, 2 };
            //int[] moreInts = new int[] { 34, -345, -1, 100 };

            //Console.WriteLine($"Integers Smallest Int: {Kata.FindSmallestInt(integers)}");
            //Console.WriteLine($"MoreInts Smallest Int: {Kata.FindSmallestInt(moreInts)}");
            #endregion

            #region CodeWars C# Kata #7 Results 
            //Console.WriteLine("Write a string: ");
            //string s = Console.ReadLine();

            //Console.WriteLine(Kata.RemoveExclamationMarks(s));
            #endregion

            #region CodeWars C# Kata #8 Results
            //Console.WriteLine("Enter a number: ");
            //string num = Console.ReadLine();

            //Console.WriteLine(Kata.FakeBin(num));

            #endregion

            #region CodeWars C# Kata #9 Results
            //invert([1, 2, 3, 4, 5]) == [-1, -2, -3, -4, -5]
            //invert([1, -2, 3, -4, 5]) == [-1, 2, -3, 4, -5]
            //invert([]) == []
            //int[] integers = new int[] { 1, 2, 3, 4, 5 };
            //int[] integer2 = new int[] { 1, -2, 3, -4, 5 };

            //Console.WriteLine("First Array: [ 1, 2, 3, 4, 5] inverted below.");
            //Array.ForEach(Kata.InvertValues(integers), Console.WriteLine);
            //Console.WriteLine("Second Array: [ 1, -2, 3, -4, 5] inverted below.");
            //Array.ForEach(Kata.InvertValues(integer2), Console.WriteLine);            
            #endregion

            #region CodeWars C# Kata #10 Results 
            //Console.Write("Enter a Positive Number: ");
            //var enteredNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Kata.CountSheep(enteredNum));
            #endregion

            #region CodeWars C# Kata #11 Results 
            //Console.Write("Enter a number: ");
            //string enteredNum = Console.ReadLine();
            //Console.WriteLine(enteredNum.GetType());
            //Console.WriteLine(Kata.StringToNumber(enteredNum).GetType());
            #endregion

            #region CodeWars C# Kata #12 Results 
            //Console.Write("Enter your first number: ");
            //int firstNum = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your second number: ");
            //int secNum = Convert.ToInt32(Console.ReadLine());

            //Array.ForEach(Kata.CountBy(firstNum, secNum), Console.WriteLine);
            #endregion

            #region CodeWars C# Kata 13 Results 
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Avg of Grades: {Kata.GetGrade(num1,num2,num3)}");
            #endregion

            #region CodeWars C# Kata 14 Results
            //Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
            //Console.WriteLine("Player 1's Turn\n");

            //Console.Write("Player 1, enter rock paper or scissors: ");
            //string p1 = Console.ReadLine().ToLower();

            //Console.Clear();

            //Console.WriteLine("Player 2's Turn\n");

            //Console.Write("Player 2, enter rock paper or scissors: ");
            //string p2 = Console.ReadLine().ToLower();

            //Console.Clear();

            //Console.WriteLine(Kata.Rps(p1,p2));

            #endregion

            #region CodeWars C# Kata 15 Results
            //Console.WriteLine("Welcome to the Array Guessing Game!");

            //object[] numbers = { 1, 2, 3, 4, 5 };
            //Console.Write("Enter a numerical guess to see if it is in the array: ");

            //int target = int.Parse(Console.ReadLine());

            //Console.WriteLine(Kata.Check(numbers,target));
            #endregion

            #region C# Kata 16 Results
            ////Make a simple function called greet that returns the most-famous "hello world!".
            //Console.WriteLine(Kata.Greet());
            #endregion

            #region C# Kata 17 Results 
            //Write function bmi that calculates body mass index(bmi = weight / height2).

            //if bmi <= 18.5 return "Underweight"

            //if bmi <= 25.0 return "Normal"

            //if bmi <= 30.0 return "Overweight"

            //if bmi > 30 return "Obese"
            //Console.WriteLine("Welcome to the BMI Calculator!\n");
            //Console.Write("Enter your weight (kg): ");
            //double weight = double.Parse(Console.ReadLine());
            //Console.Write("Enter your height (m): ");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine(Kata.Bmi(weight,height));
            #endregion

            #region C# Kata 18 Results 
            //Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.

            //The output should be two capital letters with a dot separating them.

            //It should look like this:

            //Sam Harris => S.H

            //patrick feeney => P.F

            //Console.Write("Enter your first and last name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine(Kata.AbbrevName(name));

            #endregion

            #region C# Kata 19 Results 



            #endregion
        }
    }
}
