using System;

namespace Condition_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number from 1 to 12.");
           
            int month = int.Parse (Console.ReadLine());

            switch (month)

            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("That's not cool!");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Who wants some trivia?");
            Console.WriteLine();
            Console.WriteLine("Please select a category number: ");
            Console.WriteLine("1 - Sports");
            Console.WriteLine("2 - Music");
            Console.WriteLine("3 - Movies");
            string category = Console.ReadLine();

            switch (category)
            {
                case "1":
                    Console.WriteLine("Sports");
                    Console.WriteLine("How many innings are in a baseball game?");
                    string innings = Console.ReadLine();
                    if (innings == "9" || innings.ToLower() == "nine")
                    {
                        Console.WriteLine("You are correct!");
                    } 
                    else
                    {
                        Console.WriteLine("You are so wrong!");
                    }
                    break;
                case "2":
                    Console.WriteLine("Music");
                    Console.WriteLine("Who originally sang the song New York, New York?");
                    string song = Console.ReadLine();
                    if (song.ToLower()=="frank sinatra")
                    {
                        Console.WriteLine("That's correct!");

                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
                    break;
                case "3":
                    Console.WriteLine("Movies");
                    Console.WriteLine("Who directed Pulp Fiction?");
                    string director = Console.ReadLine();
                    if (director.ToLower()=="quinton tarantino" || director.ToLower() == "tarantino")
                    {
                        Console.WriteLine("Good Job!");
                    }
                    else
                    {
                        Console.WriteLine("Not even close!");
                    }
                    break;
                default:
                    Console.WriteLine("Nope");
                    break;
            }
                









            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }
    }
}
