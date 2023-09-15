﻿using System.Runtime.ExceptionServices;

namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int min, max, number1, number2, decimalPnts;
            double rndDouble1, rndDouble2, rndDouble3;
            Random generator = new Random();

            // Part 1
            Console.WriteLine("Hello, I am a random number generator. Please input the minimum value you want:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay, now input you maximum desired value:");
            max = Convert.ToInt32(Console.ReadLine());
            while (min > max)
            {
                Console.WriteLine("Silly you! The max value must be higher then the min. Try again");
                max = Convert.ToInt32(Console.ReadLine());
            }
            number1 = generator.Next(min, max + 1);
            Console.WriteLine($"Your randomly generated number between {min} and {max} is {number1}. Have a good day.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Part 2
            Console.WriteLine("Let's role some dice! Press enter to roll!");
            Console.ReadLine();
            number1 = generator.Next(1, 7);
            number2 = generator.Next(1, 7);
            if (number1 == number2)
            {
                Console.WriteLine($"The first die rolled {number1}, and the second rolled {number2}, for a total of {number1 + number2}. Those are doubles! Good for you!");
            }
            else
            {
                Console.WriteLine($"The first die rolled {number1}, and the second rolled {number2}, for a total of {number1 + number2}.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Part 3
            Console.WriteLine($"Hey. remeber those minimum and maximum values you input earlier, {min} and {max}? Well their coming back, this time to generate a numbers with decimals included.");
            Console.WriteLine("Just tell me how many decimal points the numbers should be rounded to, and we'll get started:");
            decimalPnts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Alright, all the numbers will be rounded to {decimalPnts} demical points. Press enter to generate the numbers.");
            Console.ReadLine();
            rndDouble1 = Math.Round(generator.Next(min, max) + generator.NextDouble(),decimalPnts);
            rndDouble2 = Math.Round(generator.Next(min, max) + generator.NextDouble(),decimalPnts);
            rndDouble3 = Math.Round(generator.Next(min, max) + generator.NextDouble(),decimalPnts);
            Console.WriteLine($" Your randonly generated numbers are {rndDouble1}, {rndDouble2}, and {rndDouble3}");

        }
    }
}