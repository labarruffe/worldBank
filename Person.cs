using System;

namespace worldBank
{
    public abstract class Person
    {
        public int NumberOfPeople { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string address, string phone, string email)
        {
            this.Id = Person.GetHashCode();
            Console.WriteLine("ID generated: " + this.Id);
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }
    }
}