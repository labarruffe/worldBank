using System;

namespace worldBank
{
    public class SalaryAccount : Account
    {
        public SalaryAccount()
        {
            this.WithdrawalFee = 0;
        }

        public override void Withdraw(double value)
        {
            if (value > this.Balance)
            {
                Console.WriteLine("This value exceeds your balance!");
            } 
            else 
            {
                this.Balance -= value;
            }
        }

        public override double CheckBalance()
        {
            return this.Balance;
        }

        public override void Transfer(Account account, double value)
        {
            if (account.Owner.Equals(this.Owner))
            {
                this.Withdraw(value);
                account.Balance += value;   
            } 
            else
            {
                Console.WriteLine("The owner of the account should be the same of the salary account!");
            }
        }
    }
}
