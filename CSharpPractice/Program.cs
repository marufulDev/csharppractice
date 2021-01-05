using System;

namespace CSharpPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please write your Name: ");
            string UserName = Console.ReadLine();

            // Concatenation writing Way
            Console.WriteLine("Welcome " + UserName);

            // Place holder syntax---- preferred
            Console.WriteLine("Welcome {0} .", UserName);
        }
    }
}