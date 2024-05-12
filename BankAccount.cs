namespace Bank_account
{
    public class BankAccount
    {
        public double Saldo { get; private set; }\

        public void Withdraw(double amount)
        {
            if (amount > Saldo)
            {
                throw new BankException("Not enough money on your account");
            }
            Saldo -= amount;
        }
    }
}
