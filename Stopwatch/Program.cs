using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type 'Start' to begin the stopwatch, 'Stop' to end or " + "'exit' to quit: ");
            var userInput = Console.ReadLine();

            //initialize an object to run stopwatch
            Stopwatch stopwatch = new Stopwatch();
            bool isStarted = false;
            
            //If user types exit the progarm will terminate
            while (userInput.ToLower() != "exit")
            {
                if (userInput.ToLower() == "start")
                {
                    stopwatch.Start();
                    isStarted = true;
                    Console.WriteLine("Now type 'stop' to end timer or 'start' to reset: ");
                    userInput = Console.ReadLine();

                }
                else if (userInput.ToLower() == "stop")
                {
                    if (isStarted)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("Now type 'stop' again for new time or 'start' to reset: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You need to start the timer first. Please type 'start'.");
                        Console.Write("Now type start: ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You did not type one of the required words. Please try again.");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}