using System;
using System.Collections.Generic;

namespace worldBank
{
    public class LegalPerson : Person
    {
        public List<PhysicalPerson> Partner { get; set; }
        public int Cnpj { get; set; }
        public string CorporateName { get; set; }
        public string FantasyName { get; set; }
        public int StateRegistration { get; set; }
        public DateTime OpeningDate { get; set; }
        private readonly int Age;
        public double Revenues { get; set; }

        public LegalPerson(string cnpj, string corporateName, string fantasyName, string stateRegistration, DateTime openingDate)
        {
            this.Partner = new List<PhysicalPerson>();
            this.Cnpj = Int.Parse(cnpj);
            this.CorporateName = corporateName;
            this.FantasyName = fantasyName;
            this.StateRegistration = Int.Parse(stateRegistration);
            this.OpeningDate = openingDate;
            this.Age = new Random().Next(1, 70);
            this.Revenues = new Random().NextBytes(10000, 1000000);
        }
    }
}
