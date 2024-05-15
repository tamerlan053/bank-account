namespace Bank_account
{
    public class BankAccount
    {
        public double Saldo { get; private set; }\

        public void Withdraw(double amount)
        {
            if (amount > Saldo)
            {
                throw new BankException("not enough money on your account");
            }
            Saldo -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount > 2500)
            {
                throw new BankException("deposit too large");
            }
            Saldo += amount;
        }
    }
}
