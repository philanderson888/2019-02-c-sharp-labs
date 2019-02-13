using System.Windows;


namespace lab_06_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            textInputCharacter.AppendText($"You chose time {textBoxTotalTime.Text}");
        }
    }
}
