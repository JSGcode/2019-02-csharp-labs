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

namespace lab_105_game_name_and_score_01
{
    //create a gaming home page
    //name of gamer (saved text file)
    //level reached (saved text file)
    //top score (saved text file)
    //prize for best presented interface

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
            File.WriteAllLines ("info.txt", information);
        }

        private void start()
        {
            nameBox.Text = File.ReadAllLines("info.txt")[0];
            levelBox.Text = File.ReadAllLines("info.txt")[1];
            scoreBox.Text = File.ReadAllLines("info.txt")[2];
        }
    }
}
