using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using System.IO;

namespace WordGame_Project_03
{
    public partial class MainWindow : Window
    {
        static string errStr;
        static int lives;
        static string word;
        static string hangWord;
        static string hintPhrase;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            Hint.IsEnabled = false;
            Txtbox.Foreground = Brushes.Black;
            errStr = null;
            Error.Text = null;
            lives = 8;
            LoadWord();
            int numberOfLetters = hangWord.Length;
            Txtbox.Text = new String('-', numberOfLetters);
            HintLabel.Content = " ";
            Trace.WriteLine(hangWord);
        }

        private void Txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Txtbox.Text == hangWord && lives > 0)
            {
                DisableButtons();
                Txtbox.Foreground = Brushes.Green;
                MessageBox.Show("You Saved Bill", "Congratulations");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (sender as Button).IsEnabled = false;

            string content = (sender as Button).Content.ToString();
            word = Txtbox.Text;
            char[] wordAsChar = word.ToCharArray();
            // Finds the first char that is equal to the content of button
            int toReplace = hangWord.IndexOf(content);
            if (toReplace != -1)
            {
                // Finds the second char that is equal to the content of button
                wordAsChar[toReplace] = content[0];
                int toReplace2 = hangWord.IndexOf(content, toReplace + 1);
                if (toReplace2 != -1)
                {
                    // Finds the third char that is equal to the content of button
                    wordAsChar[toReplace2] = content[0];
                    int toReplace3 = hangWord.IndexOf(content, toReplace2 + 1);
                    if (toReplace3 != -1)
                    {
                        wordAsChar[toReplace3] = content[0];
                    }
                }
            }
            else
            {
                lives--;
                HangmanFigure();
                errStr += $"{content}, ";
                Error.Text = errStr;
            }
            Txtbox.Text = new String(wordAsChar);
        }

        static void HangmanFigure()
        {
            var brush = new ImageBrush();
            var game = ((MainWindow)Application.Current.MainWindow);
            switch (lives)
            {
                case 7:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/7.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 6:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/6.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 5:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/5.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 4:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/4.png"));
                    game.HangmanFig.Fill = brush;
                    game.Hint.IsEnabled = true;
                    break;
                case 3:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/3.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 2:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/2.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 1:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/1.png"));
                    game.HangmanFig.Fill = brush;
                    break;
                case 0:
                    brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/0.png"));
                    game.HangmanFig.Fill = brush;
                    DisableButtons();
                    game.Txtbox.Foreground = Brushes.Red;
                    game.Txtbox.Text = hangWord;
                    MessageBox.Show("Unfortunatly Bill will not be able to carry on.\n                          RIP Bill", "Game Over");
                    break;
                default:
                    break;
            }
        }

        static void LoadWord()
        {
            Random rnd = new Random();
            int randomNo = rnd.Next(0, 53);
            hangWord = File.ReadAllLines("Words.txt")[randomNo];
            hintPhrase = File.ReadAllLines("Hints.txt")[randomNo];
        }

        private void Button_Click_Hint(object sender, RoutedEventArgs e)
        {
            var game = ((MainWindow)Application.Current.MainWindow);
            game.HintLabel.Content = $"Hint: {hintPhrase}";
        }

        static void DisableButtons()
        {
            var game = ((MainWindow)Application.Current.MainWindow);
            // Disable Buttons
            List<Button> allButtons = new List<Button>() { game.Btn_A, game.Btn_B, game.Btn_C, game.Btn_D,
                                                           game.Btn_E, game.Btn_F, game.Btn_G, game.Btn_H,
                                                           game.Btn_I, game.Btn_J, game.Btn_K, game.Btn_L,
                                                           game.Btn_M, game.Btn_N, game.Btn_O, game.Btn_P,
                                                           game.Btn_Q, game.Btn_R, game.Btn_R, game.Btn_S,
                                                           game.Btn_T, game.Btn_U, game.Btn_V, game.Btn_W,
                                                           game.Btn_X, game.Btn_Y, game.Btn_Z};
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].IsEnabled = false;
            }
        }

        private void Button_Click_Rst(object sender, RoutedEventArgs e)
        {
            var brush = new ImageBrush();
            Initialize();
            brush.ImageSource = new BitmapImage(new Uri("C:/Users/tech-w105a/Desktop/C#/2019-02-csharp-labs/Lab/WordGame_Project_03/initial.png"));
            HangmanFig.Fill = brush;
            // Enables Buttons
            List<Button> allButtons = new List<Button>() { Btn_A, Btn_B, Btn_C, Btn_D, Btn_E, Btn_F, Btn_G,
                                                           Btn_H, Btn_I, Btn_J, Btn_K, Btn_L, Btn_M, Btn_N,
                                                           Btn_O, Btn_P, Btn_Q, Btn_R, Btn_R, Btn_S, Btn_T,
                                                           Btn_U, Btn_V, Btn_W, Btn_X, Btn_Y, Btn_Z};
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].IsEnabled = true;
            }
        }
    }
}
