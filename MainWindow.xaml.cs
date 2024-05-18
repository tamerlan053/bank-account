using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_account
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankAccount _bankaccount;
        public MainWindow()
        {
            InitializeComponent();
            _bankaccount = new BankAccount();
        }

        private void saldoButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                double amount = Convert.ToDouble(depositTextBox.Text);
                if (amount < 0)
                {
                    _bankaccount.Withdraw(-amount);
                } else
                {
                    _bankaccount.Deposit(amount);
                }
                saldoTextBlock.Text = $"Saldo {_bankaccount.Saldo:c}";
                if (_bankaccount.Saldo < 0)
                {
                    MessageBox.Show("you are in red!!");
                }
            } catch (Exception ex)
            {
            }
        }
    }
}
