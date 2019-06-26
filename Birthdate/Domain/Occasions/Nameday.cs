using System;
namespace Birthdate.Domain.Occasions
{
    public class NameDay : Occasion
    {
        public NameDay(Person person, DateTime occasionDate) : base(person, occasionDate)
        {
            Name = "Namesday";
        }
    }
}
