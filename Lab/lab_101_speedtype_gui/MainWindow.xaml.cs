using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace lab_101_speedtype_gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int errors = 0;
        static List<char> alphabet = new List<char>();
        static Stopwatch stopwatch = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char letter = 'a';
            errors = 0;

            Timer.Foreground = Brushes.Black;
            Timer.Text = "0:00";
            Output.Clear();
            Input.Clear();
            Timer.Clear();
            alphabet.Clear();
            stopwatch.Restart();

            // Fills the list

            for (int i = 0; i < 26; i++)
            {
                alphabet.Add(letter);
                letter++;
            }
            if (IsRandom.IsChecked == true)
            {
                Output.Text = Display(Shuffle(alphabet));
            }
            else
            {
                Output.Text = Display(alphabet);
            }
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            char lastLetter = ' ';
            Timer.Text = string.Format("{0}:{1}", Math.Floor(stopwatch.Elapsed.TotalMinutes), stopwatch.Elapsed.ToString("ss"));
            try
            {
                lastLetter = Input.Text[Input.Text.Length - 1];

                if (lastLetter == alphabet[Input.Text.Length - 1])
                {
                    Input.Foreground = Brushes.Green;
                }
                else if (lastLetter != alphabet[Input.Text.Length - 1])
                {
                    Input.Foreground = Brushes.Red;
                    errors++;
                } 
                if (Input.Text == Output.Text)
                {
                    Timer.Foreground = Brushes.Blue;
                    stopwatch.Stop();
                    Input.Text = $"You made {errors} mistake(s)";
                }
            }
            catch (Exception ex){}
        }

        static List<char> Shuffle(List<char> rnd_Alphabet)
        {
            //instantiate random
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
            return rnd_Alphabet;
        }

        static string Display(List<char> alphabet)
        {
            //intialize variables
            string str = null;

            // Builds the string to be typed
            foreach (var item in alphabet)
                str += item;
            //GameLogic(alphabet);
            return str;
        }
    }
}
