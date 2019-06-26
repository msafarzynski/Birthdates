using System;

namespace Birthdate.Domain
{
    public class Occasion
    {
        public Person Person { get; set; }
        public DateTime OcassionDate { get; set; }

        public Occasion()
        {
        }

        public Occasion(Person person, DateTime ocassionDate)
        {
            Person = person;
            OcassionDate = ocassionDate;
        }
    }
}
