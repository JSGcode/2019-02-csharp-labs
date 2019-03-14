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
using System.IO;

namespace WordGame_Project_02
{
    public partial class MainWindow : Window
    {
        static string errStr;
        static int lives;
        static string word;
        static string hangWord;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            Txtbox.Foreground = Brushes.Black;
            errStr = null;
            Error.Text = null;
            lives = 8;
            hangWord = LoadWord();
            int numberOfLetters = hangWord.Length;
            Txtbox.Text = new String('-', numberOfLetters);
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
            // Finds the first char that is equal to content
            int toReplace = hangWord.IndexOf(content);
            if (toReplace != -1)
            {
                // Finds the second char that is equal to content
                wordAsChar[toReplace] = content[0];
                int toReplace2 = hangWord.IndexOf(content, toReplace + 1);
                if (toReplace2 != -1)
                {
                    // Finds the third char that is equal to content
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
                hangman();
                errStr += content;
                Error.Text = errStr;
            }
            Txtbox.Text = new String(wordAsChar);
        }

        static void hangman()
        {
            var game = ((MainWindow)Application.Current.MainWindow);
            switch (lives)
            {
                case 7:
                    game.Wrong.Content = "|\n|\n|\n|\n|";
                    break;
                case 6:
                    game.Wrong.Content = "__________________\n|           |\n|\n|\n|\n|";
                    break;
                case 5:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|\n|\n|";
                    break;
                case 4:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|          / \n|\n|";
                    break;
                case 3:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|          / \\\n|\n|";
                    break;
                case 2:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|          /|\\ \n|\n|";
                    break;
                case 1:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|          /|\\\n|          /\n|";
                    break;
                case 0:
                    game.Wrong.Content = "__________________\n|           |\n|           O\n|          /|\\\n|          / \\\n|";
                    DisableButtons();
                    game.Txtbox.Foreground = Brushes.Red;
                    game.Txtbox.Text = hangWord;
                    MessageBox.Show("Unfortunatly Bill will not be able to carry on.", "Game Over");
                    break;
                default:
                    break;
            }
        }

        static string LoadWord()
        {
            Random rnd = new Random();
            int randomNo = rnd.Next(0, 49);
            string word = File.ReadAllLines("Words.txt")[randomNo];
            return word;
        }

        static void DisableButtons()
        {
            var game = ((MainWindow)Application.Current.MainWindow);
            game.Btn_A.IsEnabled = false;
            game.Btn_B.IsEnabled = false;
            game.Btn_C.IsEnabled = false;
            game.Btn_D.IsEnabled = false;
            game.Btn_E.IsEnabled = false;
            game.Btn_F.IsEnabled = false;
            game.Btn_G.IsEnabled = false;
            game.Btn_H.IsEnabled = false;
            game.Btn_I.IsEnabled = false;
            game.Btn_J.IsEnabled = false;
            game.Btn_K.IsEnabled = false;
            game.Btn_L.IsEnabled = false;
            game.Btn_M.IsEnabled = false;
            game.Btn_N.IsEnabled = false;
            game.Btn_O.IsEnabled = false;
            game.Btn_P.IsEnabled = false;
            game.Btn_Q.IsEnabled = false;
            game.Btn_R.IsEnabled = false;
            game.Btn_S.IsEnabled = false;
            game.Btn_T.IsEnabled = false;
            game.Btn_U.IsEnabled = false;
            game.Btn_V.IsEnabled = false;
            game.Btn_W.IsEnabled = false;
            game.Btn_X.IsEnabled = false;
            game.Btn_Y.IsEnabled = false;
            game.Btn_Z.IsEnabled = false;
        }

        private void Button_Click_Rst(object sender, RoutedEventArgs e)
        {
            Initialize();
            Wrong.Content = " ";
            // Enables buttons
            Btn_A.IsEnabled = true;
            Btn_B.IsEnabled = true;
            Btn_C.IsEnabled = true;
            Btn_D.IsEnabled = true;
            Btn_E.IsEnabled = true;
            Btn_F.IsEnabled = true;
            Btn_G.IsEnabled = true;
            Btn_H.IsEnabled = true;
            Btn_I.IsEnabled = true;
            Btn_J.IsEnabled = true;
            Btn_K.IsEnabled = true;
            Btn_L.IsEnabled = true;
            Btn_M.IsEnabled = true;
            Btn_N.IsEnabled = true;
            Btn_O.IsEnabled = true;
            Btn_P.IsEnabled = true;
            Btn_Q.IsEnabled = true;
            Btn_R.IsEnabled = true;
            Btn_S.IsEnabled = true;
            Btn_T.IsEnabled = true;
            Btn_U.IsEnabled = true;
            Btn_V.IsEnabled = true;
            Btn_W.IsEnabled = true;
            Btn_X.IsEnabled = true;
            Btn_Y.IsEnabled = true;
            Btn_Z.IsEnabled = true;
        }
    }
}