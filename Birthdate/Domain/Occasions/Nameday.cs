using System;
using Xamarin.Forms;

namespace Birthdate.Domain.Occasions
{
    public class NameDay : Occasion
    {
        public NameDay(Person person, DateTime occasionDate) : base(person, occasionDate)
        {
            Name = "name day";
            CalendarColor = Color.Green;
        }
    }
}
