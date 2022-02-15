using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Given the following code, change the code to implement inferred typing, string interpolation, and the ternary operator
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + “greater than or equal to nine”;
            //}

            
            //// Inferred, String Interpolation, and Ternary
            Console.WriteLine("Please select a number 1-10");
            var answer = int.Parse(Console.ReadLine());

            var response = ((answer) < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

        }
    }
}
