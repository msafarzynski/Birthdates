using System;
using Xamarin.Forms;

namespace Birthdate.Domain.Occasions
{
    public abstract class Occasion
    {
        public Person Person { get; set; }
        public DateTime OccasionDate { get; set; }
        public string Name { get; set; }
        public Color CalendarColor { get; set; }

        public Occasion(Person person, DateTime occasionDate)
        {
            Person = person;
            OccasionDate = occasionDate;
            CalendarColor = Color.Blue;
        }
    }
}
