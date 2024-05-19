using System.Windows;

namespace Bank_account
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            if (name != "")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Title = name;
                mainWindow.ShowDialog();
                nameTextBox.Clear();
                startButton.IsEnabled = false;
            }
        }
    }
}
