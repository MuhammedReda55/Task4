namespace task4
{
    class SavingsAccount : Account
    {
        public double InRate { get; set; }
        public SavingsAccount(string name = "no Name", double balance = 0, double inRate = 0) : base(name, balance)
        {
            InRate = inRate;
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + InRate);
        }




    }
}
