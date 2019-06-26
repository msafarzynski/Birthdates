using System;

namespace Birthdate.Domain.Occasions
{
    public class Occasion
    {
        public Person Person { get; set; }
        public DateTime OccasionDate { get; set; }
        public string Name { get; set; }

        public Occasion(Person person, DateTime occasionDate)
        {
            Person = person;
            OccasionDate = occasionDate;
        }
    }
}
