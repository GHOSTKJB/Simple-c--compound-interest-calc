﻿using System;
using System.Diagnostics;

namespace CompoundInterestCalc
{
  class Program
  {
    static void Main(string[] args)
    {
      // Program goes in here
      Console.Title = "Simple Compund Interest Calculator CS";
      Console.WriteLine($"Keenan's simple compund interest calculator!");
      
      //Initial investment input
      Console.WriteLine($"How much is the initial interest?");
      var investInit = Console.ReadLine();

      //Years to compund interest input
      Console.WriteLine($"How many years are we compounding?");
      var investYear = Console.ReadLine();

      //Average expected compund interest input
      Console.WriteLine($"How much interest do you expect to compound per year");
      var investAvgInterest = Console.ReadLine();



      //Maths
      // This equation is correct but the data is still strings instead of int: var finalInvest = investInit * Math.Pow((1 + investAvgInterest) , investYear);

      


      //Outputs
      int investIntegers = convertStringInt(investInit,investYear,investAvgInterest);
      
      



      //tests
      Console.WriteLine($"Your Initial Investment: {investInit}, Years to hold: {investYear}, Estimated Average Interest Rates: {investAvgInterest}");
      Console.WriteLine();

    }
    public static int convertStringInt (string input, string input2, string input3) {

      var investInitInt = 0;
      var investYearInt = 0;
      var investAvgInterestInt = 0;

      bool success = int.TryParse(input, out investInitInt);
      bool success2 = int.TryParse(input2, out investYearInt);
      bool success3 = int.TryParse(input3, out investAvgInterestInt);

      return investInitInt;
      return investYearInt;
      return investAvgInterestInt;


   
    }


  }
}