using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Birthdate.Dao;
using Birthdate.Domain.Occasions;

namespace Birthdate.Domain
{
    public class OccasionsGifts : ObservableCollection<OccasionGiftGroup>, INotifyPropertyChanged
    {
        public static ObservableCollection<OccasionGiftGroup> ListOfAllOccasionsAndGifts { get; set; }

        static OccasionsGifts()
        {
            var listOfOccasions = OccasionDao.getAllOccasions();

            ObservableCollection<OccasionGiftGroup> AllOccasionsAndGifts = new ObservableCollection<OccasionGiftGroup> { 
                new OccasionGiftGroup(listOfOccasions[0])
                {
                    new Gift("BMW 1"),
                    new Gift("House"),
                    new Gift("Sandals")
                },
                new OccasionGiftGroup(listOfOccasions[1])
                {
                    new Gift("Chocolate")
                },
                new OccasionGiftGroup(listOfOccasions[2])
                {
                    new Gift("Flowers"),
                    new Gift("Painting")
                }
            };

            ListOfAllOccasionsAndGifts = AllOccasionsAndGifts;
        }

    }
}
