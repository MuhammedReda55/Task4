namespace task4
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public Account(string name ="no Name" , double balance =0)
        {
            Name = name;
            Balance = balance;
        }
       
       

        public static double operator +(Account a, Account b)
        {
            return a.Balance + b.Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && Balance - amount > 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

    }
}
