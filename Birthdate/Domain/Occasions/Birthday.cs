using System;
namespace Birthdate.Domain.Occasions
{
    public class Birthday : Occasion
    {

        public Birthday(Person person, DateTime occasionDate) : base(person, occasionDate)
        {
            Name = "Birthday";
        }
    }
}
