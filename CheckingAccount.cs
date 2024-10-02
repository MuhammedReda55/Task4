namespace task4
{
    class CheckingAccount : Account
    {
        private const double InRate = 1.50;

        public CheckingAccount(string name = "no Name", double balance = 0) : base(name, balance)
        {

        }
       
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + InRate);
        }
    }
}
