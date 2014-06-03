using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using Xamarin.Forms.Toolkit.Controls;
using Xamarin.Forms.Toolkit.WP.Controls.Calendar;

[assembly: ExportRenderer(typeof(CalendarView), typeof(CalendarViewRenderer))]
namespace Xamarin.Forms.Toolkit.WP.Controls.Calendar
{
    public class CalendarViewRenderer : ViewRenderer<CalendarView, WPControls.Calendar>
    {
        protected override void OnModelSet()
        {
            base.OnModelSet();
            var calendar = new WPControls.Calendar();
            calendar.DateClicked +=
                (object sender, WPControls.SelectionChangedEventArgs e) =>
                {
                    Model.NotifyDateSelected(e.SelectedDate);
                };
            this.SetNativeControl(calendar);
        }
    }
}
