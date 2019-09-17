using System;

namespace worldBank
{
    public enum TypeEnum {
        SIMPLE,
        SPECIAL
    }

    public class CurrentAccount : Account, IDepositable
    {
        private readonly TypeEnum Type;

        private readonly double Limit;
        private readonly double LimitRate;
        public CurrentAccount(TypeEnum type, Person owner):base(owner)
        {
            if (owner.GetType() == typeof(PhysicalPerson))
            {
                owner = new PhysicalPerson(); 
            }
            else if (owner.GetType() == typeof(LegalPerson))
            {
                owner = new LegalPerson();
            }

            if (type.Equals(TypeEnum.SPECIAL))
            {
                if (owner.Income > 5000 || owner.Revenues > 5000)
                {
                    this.Type = type;
                    this.Limit = (owner.Income * 2.5) || ((owner.Revenues * 2.5));
                    this.LimitRate = 0.02;
                }
                else
                {
                    Console.WriteLine("You should have Income or Revenues great than R$5.000,00!");
                }
            }
            else if (type.Equals(TypeEnum.SIMPLE))
            {
                this.Type = type;
                this.Limit = (owner.Income * 1.5) || ((owner.Revenues * 1.5));
                this.LimitRate = 0.05;
            }
            else
            {
                Console.WriteLine("The account type should be SIMPLE or SPECIAL!");
            }
        }

        public override void Withdraw(double value)
        {
            if (value + this.Limit <= this.Balance)
            {
                this.Balance -= value;
            } 
            else 
            {
                Console.WriteLine("This value exceeds your limit!");
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

        public void Pay(string barCode)
        {
             
            Console.WriteLine("Pay the " + barCode + "!");
            
        }

        public void Loan(double value)
        {
            this.Balance += value;
        }

        public void Deposit(double value)
        {
            this.Balance += value;
        }
    }
}
