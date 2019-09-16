namespace worldBank
{
    public abstract class Account
    {
        public Person Owner { get; set; }
        public long Number { get; set; }
        public int Agency { get; set; }
        public double Balance { get; set; }
        public double WithdrawalFee { get; set; }

        public Account(Person owner, long number, int agency, double withdrawalFee)
        {
            this.Owner = owner;
            this.Number = number;
            this.Agency = agency;
            this.WithdrawalFee = WithdrawalFee;
            this.Balance = 0;
        }

        public abstract void Withdraw(double value);

        public abstract double CheckBalance();

        public abstract void Transfer(Account account, double value);

    }
}