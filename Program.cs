﻿using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using KittyMath;

namespace KittyMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             
            Kitty Tiger Strikes Again.  You probably shouldn't have let Kitty 
            help you balance your bank books.  It seems that Kitty wrote all
            your numbers down half the time, and the other half of the time 
            Kitty wrote the numbers as words.

            Write a string extension method that will convert Kitty's scribblings 
            into decimal numbers.

            */

            string scribblings = "One2THreE4.fiVeSix";

            decimal balance = scribblings.GetNumbers();

            Console.WriteLine($"Your Bank Balance is: ${balance}");
        }
    }
}
