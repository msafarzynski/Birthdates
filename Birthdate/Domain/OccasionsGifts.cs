using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Birthdate.Domain.Occasions;

namespace Birthdate.Domain
{
    public class OccasionsGifts : ObservableCollection<OccasionGiftGroup>, INotifyPropertyChanged
    {
        public static ObservableCollection<OccasionGiftGroup> ListOfAllOccasionsAndGifts { get; set; }

        static OccasionsGifts()
        {
            var maciek = new Person("Maciek", "Kowalski");
            var macieksBirthday = new Birthday(maciek, DateTime.Parse("06-06-2019"));

            var macieksNamesday = new NameDay(maciek, DateTime.Parse("08-08-2019"));

            var zosia = new Person("Zosia", "Walen");
            var zosiasBirthday = new Birthday(zosia, DateTime.Parse("07-07-2019"));

            ObservableCollection<OccasionGiftGroup> AllOccasionsAndGifts = new ObservableCollection<OccasionGiftGroup>
            {
                new OccasionGiftGroup(macieksBirthday)
                {
                    new Gift("BMW 1"),
                    new Gift("House"),
                    new Gift("Sandals")
                },
                new OccasionGiftGroup(macieksNamesday)
                {
                    new Gift("Chocolate")
                },
                new OccasionGiftGroup(zosiasBirthday)
                {
                    new Gift("Flowers"),
                    new Gift("Painting")
                }
            };

            ListOfAllOccasionsAndGifts = AllOccasionsAndGifts;
        }

    }
}
