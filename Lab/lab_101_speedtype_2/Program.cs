using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WordType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>();
            char letter = 'a';
            // Builds the list
            for (int i = 0; i < 26; i++)
            {
                alphabet.Add(letter);
                letter++;
            }
            Console.WriteLine("Welcome to speed-type\nWould You like an ordered or a random list of Characters?\n1) Ordered\n2) Unordered\n");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Modes0(alphabet);
                    break;
                case "2":
                    Shuffle(alphabet);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }

        static void Shuffle(List<char> rnd_Alphabet)
        {
            Random rnd = new Random();
            int n = rnd_Alphabet.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                char value = rnd_Alphabet[k];
                rnd_Alphabet[k] = rnd_Alphabet[n];
                rnd_Alphabet[n] = value;
            }
            Modes1(rnd_Alphabet);
        }


        static void GameLogic(List<char> alphabet)
        {
            char input;
            int listItem = 0;
            int errors = 0;
            bool finished = false;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            while (finished == false)
            {
                input = Console.ReadKey().KeyChar;
                if (input == alphabet[listItem] && listItem < 26)
                {
                    //Console.WriteLine();
                    listItem++;
                }
                else if (input != alphabet[listItem])
                {
                    Console.WriteLine("\n == Wrong try again == \n");
                    errors++;
                }
                if (listItem == 26)
                    finished = true;
            }
            stopwatch.Stop();
            Console.WriteLine("\n\nTime elapsed: {0:mm}:{0:ss}", stopwatch.Elapsed);
            Console.WriteLine("You made {0} mistake(s)", errors);
            Console.Read();
        }

        static void Modes0(List<char> alphabet)
        {
            //intialize variables
            string str = null;

            // Builds the string to be typed
            foreach (var item in alphabet)
                str += item;
            Console.WriteLine(str);
            GameLogic(alphabet);
        }

        static void Modes1(List<char> alphabet)
        {
            //intialize variables
            string str = null;

            // Builds the string to be typed
            foreach (var item in alphabet)
                str += item;
            Console.WriteLine(str);
            GameLogic(alphabet);
        }
    }
}
