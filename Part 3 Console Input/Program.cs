using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_3_Console_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Which program would you like to use?");
                Console.WriteLine("Greetings[1]");
                Console.WriteLine("Adder[2]");
                Console.WriteLine("Distance[3]");
                Console.WriteLine("Hypoteneuse[4]");
                Console.WriteLine("Exit[5]");

                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Greetings();
                        break;
                    case "2":
                        Adder();
                        break;
                    case "3":
                        Distance();
                        break;
                    case "4":
                        Hypoteneuse();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using my program!");
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(2000);
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
        static void Greetings()
        {
            string userName;
            int userAge;
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userAge))
                {
                    Console.WriteLine($"Hello,{userName}. You were born in {currentYear - userAge}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid age!");
                }
            }
            
            Console.WriteLine("\nPress ENTER to return home");
            Console.ReadLine();
        }

        static void Adder()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter three numbers to add");
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number!");
                        i--;
                    }
                }
                break;
            }
            Console.WriteLine($"Adding: {numbers[0]}, {numbers[1]}, {numbers[2]}");
            int sum = numbers.Sum();
            Thread.Sleep(1000);
            Console.WriteLine($"The result is: {sum}");

            Console.WriteLine("\nPress ENTER to return home");
            Console.ReadLine();
        }

        static void Distance()
        {
            List<double> distances = new List<double>();
            Console.WriteLine("Enter three distances in km to average");
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (double.TryParse(Console.ReadLine(), out double distance))
                    {
                        distances.Add(distance);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid distance!");
                        i--;
                    }
                }
                break;
            }
            Console.WriteLine($"Averaging: {distances[0]}km, {distances[1]}km, {distances[2]}km");
            double avg = Math.Round(distances.Average(), 2);
            Thread.Sleep(1000);
            Console.WriteLine($"The result is: {avg}km");

            Console.WriteLine("\nPress ENTER to return home");
            Console.ReadLine();
        }

        static void Hypoteneuse()
        {
            List<int> sides = new List<int>();
            string[] sideNames = { "Opposite", "Adjacent" };
            
            Console.WriteLine("Enter the two legs of a right angle triangle");
           
            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(sideNames[i] + ": ");
                    if (int.TryParse(Console.ReadLine(), out int side))
                    {
                        sides.Add(side);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid side!");
                        i--;
                    }
                }
                break;
            }

            Console.WriteLine($"Calculating the hypoteneuse with sides: {sides[0]}, {sides[1]}");
            double hyp = Math.Round(Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)), 2);
            Thread.Sleep(1000);
            Console.WriteLine($"The hypoteneuse is {hyp}");

            Console.WriteLine("\nPress ENTER to return home");
            Console.ReadLine();
        }
    }
}
