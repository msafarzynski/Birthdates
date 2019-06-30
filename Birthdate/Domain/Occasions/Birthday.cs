using System;
using Xamarin.Forms;

namespace Birthdate.Domain.Occasions
{
    public class Birthday : Occasion
    {

        public Birthday(Person person, DateTime occasionDate) : base(person, occasionDate)
        {
            Name = "Birthday";
            CalendarColor = Color.Red;
        }

        public int GetAgeAtBirthday()
        {
            var d = this.Person.BirthdayDate;
            return 0;
        }
    }
}
