namespace worldBank
{
    public enum TypeEnum {
        simple = "SIMPLE",
        special = "SPECIAL"
    }
    public class CurrentAccount : Account, IDepositable
    {
        private readonly TypeEnum Type;

        private readonly double Limit;
        private readonly double LimitRate;
        public CurrentAccount(TypeEnum type)
        {
            if (type.Equals(TypeEnum.special))
            {
                // if ()
                // {
                    
                // }
            }
        }

        public void Pay(string barCode)
        {

        }

        public void Loan(double value)
        {

        }
    }
}
