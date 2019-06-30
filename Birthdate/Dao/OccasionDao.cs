using System;
using System.Collections.Generic;
using Birthdate.Domain;
using Birthdate.Domain.Occasions;

namespace Birthdate.Dao
{
    public static class OccasionDao
    {

        public static List<Occasion> getAllOccasions()
        {
            var listOfOccasions = new List<Occasion>();

            var maciek = new Person("Maciek", "Kowalski");
            var macieksBirthday = new Birthday(maciek, DateTime.Parse("06-06-2019"));

            var macieksNamesday = new NameDay(maciek, DateTime.Parse("08-08-2019"));

            var zosia = new Person("Zosia", "Walen");
            var zosiasBirthday = new Birthday(zosia, DateTime.Parse("07-07-2019"));

            listOfOccasions.Add(macieksBirthday);
            listOfOccasions.Add(macieksNamesday);
            listOfOccasions.Add(zosiasBirthday);

            return listOfOccasions;
        }
    }
}
