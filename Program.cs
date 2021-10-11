using System;

namespace DevYou_Week1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            string firstName = "Hakeem";
            int age = 23;
            char middleInitial = 'J';
            double weight = 190.5;

            //Exercise Two
            Console.WriteLine(firstName);
            Console.WriteLine(age);
            Console.WriteLine(middleInitial);
            Console.WriteLine(weight);

            //Exercise Three
            string fName = "Sarah";
            string lName = "Kay";


            //string concatenation
            Console.WriteLine("Hello " + fName + " " + lName  +" it is nice to meet you!");

            //string tokenization
            Console.WriteLine("Hello {0} {1} it is nice to meet you!", fName, lName);

            //string interpolation
            Console.WriteLine($"Hello {fName} {lName} it is nice to meet you!");

            Console.ReadLine();
        }
    }
}
