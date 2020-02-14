using System;
using System.Collections.Generic;

namespace Programming_Assignment_2
{
   class Program
   {
      static void Main(string[] args)
      {
         int i = 0;

         int number1 = 0;
         int number2 = 0;
         int number3 = 0;
         int number4 = 0;
         int number5 = 0;
         int hold1 = 0;

         //Asking for the user to input their name and storing it in hold1 string.
         Console.WriteLine("What is your name? ");
         string name = Console.ReadLine();

         //Welcoming the user to my program.
         Console.WriteLine($"Welcome to my program {name} \n");

         //Asking for user to input their first number.
         //Storing their number in an integer value (number1).
         Console.Write("Please enter your first number: ");
         number1 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their second number.
         //Storing their number in an integer value (number2).
         Console.Write("\nPlease enter your second number: ");
         number2 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number3).
         Console.Write("\nPlease enter your third number: ");
         number3 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number4).
         Console.Write("\nPlease enter your fourth number: ");
         number4 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number5).
         Console.Write("\nPlease enter your fifth number: ");
         number5 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine($"Your numbers out of order were..." +
            $"{number1}, {number2}, {number3}, {number4}, {number5}");



         for (i = 0; i < 4; i++)
         {
            if (number1 > number2)
            {
               hold1 = number1;
               number1 = number2;
               number2 = hold1;
            }

            if (number2 > number3)
            {
               hold1 = number2;
               number2 = number3;
               number3 = hold1;
            }

            if (number3 > number4)
            {
               hold1 = number3;
               number3 = number4;
               number4 = hold1;
            }

            if (number4 > number5)
            {
               hold1 = number4;
               number4 = number5;
               number5 = hold1;
            }

            if (number5 > number1)
            {
               hold1 = number5;
               number5 = number1;
               number1 = hold1;
            }
         }

         if (number4 > number5)
         {
            Console.WriteLine($"Your lowest two numbers were {number4} and {number5}");
         }
         if (number4 == number5)
         {
            Console.WriteLine($"The last two numbers are the same they are {number5}");
         }

      }
   }
}
