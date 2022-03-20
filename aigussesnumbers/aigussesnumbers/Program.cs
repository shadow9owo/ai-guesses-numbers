using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace aigussesnumbers
{
    class Program
    {
        static int aiguess;
        static int correctguess;
        static int attemps = 1;
        static bool iscorrect = false;
        static int stuffonscreen = 0;
        static bool wasrunned = false;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "ai gusses numbers v1.1";
            Console.WriteLine("ai guesses numbers v1.1");
            Console.WriteLine("created by shadowdev from www.shadowstudios.rf.gd");
            Console.WriteLine("source code on github\n");
            Console.ReadLine();
            Console.Clear();
            while (true)
            {
                Random rnd = new Random();
                correctguess = rnd.Next(1, 1000);
                if (wasrunned == true)
                {
                    Console.WriteLine("press any key to start the procces again");
                    Console.ReadLine();
                }
                while (iscorrect == false)
                {
                    aiguess = rnd.Next(1, 1000);
                    if (stuffonscreen == 30)
                    {
                        Console.Clear();
                        Thread.Sleep(500);
                        stuffonscreen = 0;
                    }
                    if (aiguess == correctguess)
                    {
                        Console.WriteLine("correct answer");
                        Console.WriteLine("attemps: " + attemps);
                        Console.WriteLine($"do you want to exit y|n");
                        string a = Console.ReadLine();
                        if (a == "y")
                        {
                            Environment.Exit(0);
                        }else
                        {
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("wrong answer the correct answer is: " + correctguess + " and the ai guessed: " + aiguess);
                        stuffonscreen++;
                        attemps++;
                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
