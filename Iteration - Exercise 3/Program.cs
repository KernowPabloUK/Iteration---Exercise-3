using System;

namespace Iteration___Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3- Write a program and ask the user to enter a number. //
            //Compute the factorial of the number and print it on the console. 
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120

            //Console.WriteLine($"Please enter a number");

            //int output = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //int factorialResult = 0;

            //while (output > 0)
            //{
            //    for (factorial = 1; factorial <= output; factorial++)
            //        factorialResult = factorial * output;


            //    Console.WriteLine($"The factorial of your number is {output}! = {factorialResult}");
            //    break;
            //}


            //CWL
            //Readline & Convert to int.32
            //iterate over entered number with reduction multiplication

            Console.WriteLine("Please enter a number and I will calculate the factorial for you!");
            Convert.ToInt32(Console.ReadLine());

            int output = int.Parse(Console.ReadLine());
            int factorial;
            int factorialResult = 0;

            
                for (factorial = 1; factorial <=1 ; factorial++)
               
                    factorialResult = factorial * output;

                    output -= factorial;

            Console.WriteLine($"The Factorial is {output}! = {factorialResult}");
           

        }
    }
}
