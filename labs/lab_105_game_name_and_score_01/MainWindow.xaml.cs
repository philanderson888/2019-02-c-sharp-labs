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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        // Create a GAMING HOME PAGE
        // Name of gamer (saved to text file)
        // Level reached  (saved to text file)
        // Top score
        // Prize for BEST PRESENTED INTERFACE

        void Initialize()
        {
            TxtBoxName.Text = "hi";
            TxtBoxLevel.Text = "5";
            TxtBoxScore.Text = "10";
        }


        string[] data = new string[3];


        private void TxtBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            data[0] = TxtBoxName.Text;
            File.WriteAllLines("data.txt", data);
        }

        private void TxtBoxLevel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtBoxScore_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
