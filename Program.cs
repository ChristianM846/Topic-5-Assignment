namespace Topic_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int min, max, number1, number2;
            Random generator = new Random();


            // Part 1
            Console.WriteLine("Hello, I am a random number generator. Please input the minimum value you want:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Okay, now input you maximum desired value:");
            max = Convert.ToInt32(Console.ReadLine());
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
            

        }
    }
}