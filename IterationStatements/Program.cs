using System.ComponentModel;
using System;
using System.Reflection.Metadata;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;

namespace IterationStatements
{
    public class Program
    {

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ThreeThroughOneThousand(int i)
        {
            for (i = 3; i < 1000; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not



        public static void CheckIfEqual(int num1, int num2)
        {
            CheckIfEqual(12, 13);

            CheckIfEqual(14, 14);

            if (num1 != num2)
            {

                Console.WriteLine($"{num1} is not equal to {num2}.");

            }
            else
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int int1)

        {
            if (int1 % 2 == 0)
            {
                Console.WriteLine($"{int1} is even");
            }
            else
            {
                Console.WriteLine($"{int1} is false");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void NegativeOrPostive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is neither negative or postive");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void AgeCheck()
        {
            bool userAge;
            int result; 

            do
            {
                Console.WriteLine("Please enter your age?");

                userAge = int.TryParse(Console.ReadLine(), out result);
            }while (!userAge); 
            
            if (result < 18)
            {
                Console.WriteLine("You are not old enough to vote");
            }
            else
            {
                Console.WriteLine("You are old enough to vote");
            }
           
        }
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer");
                    userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse); 

            if (result >= -10)
            {

            }
        }
       
    }
   
}
