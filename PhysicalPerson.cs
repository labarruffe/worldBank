using System;

namespace worldBank
{
    public class PhysicalPerson : Person
    {
        public string Name { get; set; }       
        public string LastName { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime Birthdate { get; set; }
        private readonly int Age;
        public int AgeRange { get; set; }
        private readonly double Income;


        public PhysicalPerson(string name, string latname, string rg, string cpf, DateTime birthdate)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Birthdate = birthdate;
            // Random numbers between 5 and 85
            this.Age = new Random().Next(5, 85);
            this.AgeRange = Auxiliary.TranslateAgeRange(this.Age);
            this.Income = new Random().NextDouble(1000, 10000);
        }
    }
}
