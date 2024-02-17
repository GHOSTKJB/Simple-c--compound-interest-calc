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
      Console.WriteLine($"How much is the initial investment?");
      var investInit = Console.ReadLine();

      //Years to compund interest input
      Console.WriteLine($"How many years are we compounding?");
      var investYear = Console.ReadLine();

      //Average expected compund interest input
      Console.WriteLine($"How much interest do you expect to compound per year");
      var investAvgInterest = Console.ReadLine();



      // Importing the data from my methoc convertStringInt
      convertStringInt(investInit,investYear,investAvgInterest, out int investInitInt, out int investYearInt, out int investAvgInterestInt);

      //Maths
      // This equation is correct but the data is still strings instead of int: var finalInvest = investInit * Math.Pow((1 + investAvgInterest) , investYear);
      double interestTotal = investInitInt * (1 + investAvgInterestInt * investYearInt);
      double compoundInterestTotal = investInitInt * Math.Pow(1 + (investAvgInterestInt / 1), 1 * investYearInt);
    
      if(investInitInt >= 1 && investYearInt >= 1 && investAvgInterestInt >= 1 ){
      Console.WriteLine($"");
      Console.WriteLine($"");
      Console.WriteLine($"The estimated interest after {investYearInt} is ${interestTotal}");
      Console.WriteLine($"This is the estimated compound interest value after {investYear} years. ${compoundInterestTotal}");
      }
      else{
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"Please only enter numbers.");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");

      }
     

      

      //Outputs
      
      
  



      //tests
      /*
      Console.WriteLine($"");
      Console.WriteLine($"Tests:");
      Console.WriteLine($"Your Initial Investment: {investInit}, Years to hold: {investYear}, Estimated Average Interest Rates: {investAvgInterest}");
      Console.WriteLine($"After parsing your initial investment is {investInitInt}. Years to hold: {investYearInt}. Estimated Average Interest Rates: {investAvgInterestInt}");
      */
    }
    public static void convertStringInt (string investInit, string investYear, string investAvgInterest, out int investInitInt, out int investYearInt, out int investAvgInterestInt) {

      

      bool success = int.TryParse(investInit, out investInitInt);
      bool success2 = int.TryParse(investYear, out investYearInt);
      bool success3 = int.TryParse(investAvgInterest, out investAvgInterestInt);

  


   
    }


  }
}