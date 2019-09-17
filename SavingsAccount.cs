using System;

namespace worldBank
{
    public class SavingsAccount : Account, IDepositable
    {
        public SavingsAccount()
        {
            // All savings accounts should have the same Withdrawal Fee
            this.WithdrawalFee = 4.99;
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
            this.Withdraw(value);
            account.Balance += value;   
        }

        public void Deposit(double value)
        {
            this.Balance += value;
        }
    }
}
