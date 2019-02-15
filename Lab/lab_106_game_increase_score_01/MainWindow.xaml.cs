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
using System.IO;

namespace lab_106_game_increase_score_01
{
    //create a gaming home page
    //name of gamer (saved text file)
    //level reached (saved text file)
    //top score
    //prize for best presented interface
    // +++ A button that will add 1 to the score
    // --- A button that will subtract 1 from the score
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            start();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string level = levelBox.Text;
            string score = scoreBox.Text;
            string[] information = new string[3] { name, level, score };
            File.WriteAllLines("info.txt", information);
        }

        private void start()
        {
            try
            {
                nameBox.Text = File.ReadAllLines("info.txt")[0];
                levelBox.Text = File.ReadAllLines("info.txt")[1];
                scoreBox.Text = File.ReadAllLines("info.txt")[2];
            }
            catch (Exception e)
            {
                
            }
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            int score = Int32.Parse(scoreBox.Text);
            score--;
            scoreBox.Text = score.ToString();
        }

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {
            int score = Int32.Parse(scoreBox.Text);
            score++;
            scoreBox.Text = score.ToString();
        }
    }
}
