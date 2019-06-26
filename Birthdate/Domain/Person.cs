using System;
namespace Birthdate.Domain
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime NamesdayDate { get; set; }

        public Person()
        {
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
