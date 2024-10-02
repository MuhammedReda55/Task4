namespace task4
{
    class TrustAccount : Account
    {
        public double InRaete { set; get; }
        private const double bonus = 50;
        private const int MaxCount = 3;
        private int PerYear { set; get; } = 0;
        private const double Percentage = 0.20;

       
        public TrustAccount(string name = "no Name", double balance = 0, double inrate = 0) : base(name, balance)
        {
            InRaete = inrate;

        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                return base.Deposit(amount + bonus);
            }
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            if (amount < (Balance * Percentage) && PerYear < MaxCount)
            {
                PerYear++;
                return base.Withdraw(amount);
            }
            return false;
        }

    }
}
