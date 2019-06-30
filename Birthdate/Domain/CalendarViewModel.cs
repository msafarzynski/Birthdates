using System;
using Birthdate.Dao;
using Birthdate.Domain.Occasions;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace Birthdate.Domain
{
    public class CalendarViewModel
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();

        public CalendarViewModel()
        {
            var listOfAllOccasions = OccasionDao.getAllOccasions();

            foreach (Occasion occasion in listOfAllOccasions)
            {
                CalendarInlineEvents.Add(new CalendarInlineEvent()
                {
                    StartTime = occasion.OccasionDate,
                    EndTime = occasion.OccasionDate,
                    IsAllDay = true,
                    Subject = occasion.Person.Name + "'s " + occasion.Name,
                    Color = occasion.CalendarColor
                });
            }
        }
    }
}
