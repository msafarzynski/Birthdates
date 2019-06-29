using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace Birthdate
{
    public partial class CalendarView : ContentPage
    {
        public CalendarView()
        {
            InitializeComponent();
            SfCalendar calendar = new SfCalendar();
            this.Content = calendar;
        }
    }
}
