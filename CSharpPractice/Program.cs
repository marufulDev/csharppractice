using System;

namespace CSharpPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ternary Operator Implementation
            int number = 103;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Is the number is 10? Ans: {0}", isNumber10);

            //Null coalescing Operator Implementation
            int? TotalTokken = 100;
            int? SoldTokken = 100;
            int AvailableToken = (TotalTokken - SoldTokken) ?? 0;
            Console.WriteLine("Total Number of Available Token is : {0}", AvailableToken);
        }
    }
}