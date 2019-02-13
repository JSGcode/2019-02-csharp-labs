using System;
using System.Diagnostics;

namespace WordType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would You like an ordered or a random list of Characters?\n1) Ordered\n2) Unordered\n");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Modes0();
                    break;
                case "2":
                    Modes1();
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }

        static string Randomise_Str()
        {
            Random rnd = new Random();
            string s = "abcdefghijklmnopqrstuvwxyz";
            string d = s;
            int lengthOfMovingPart = 1;

            for (int i = 0; i < 1; i++)
            {
                lengthOfMovingPart = rnd.Next(0, 10);
                s = string.Format("{0}{1}", s.Substring(s.Length - lengthOfMovingPart), s.Substring(i, s.Length - lengthOfMovingPart));                
            }
            for (int i = 0; i < 1; i++)
            {
                lengthOfMovingPart = rnd.Next(0, 10);
                d = string.Format("{0}{1}", d.Substring(d.Length - lengthOfMovingPart), d.Substring(0, d.Length - lengthOfMovingPart));
            }
            s = s + d;
            return s;
        }

        static void GameStart(string alphabet)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine(alphabet);
            stopwatch.Start();
            string input = Console.ReadLine();
            if (alphabet == input)
                Console.WriteLine("Congrats you typed all the characters correctly");
            else
                Console.WriteLine("Too bad that is incorrect");
            stopwatch.Stop();
            Console.WriteLine("\nTime elapsed: {0:ss} Seconds", stopwatch.Elapsed);
            Console.ReadLine();
        }

        static void Modes0()
        {
            Stopwatch stopwatch = new Stopwatch();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            alphabet += alphabet;
            GameStart(alphabet);
        }

        static void Modes1()
        {
            Stopwatch stopwatch = new Stopwatch();
            string alphabet = Randomise_Str();

            GameStart(alphabet);
        }
    }
}
