using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Toolkit.iOS.Controls.Calendar;
using Xamarin.Forms.Toolkit.Controls;
using escoz;


[assembly: ExportRenderer(typeof(CalendarView), typeof(CalendarViewRenderer))]
namespace Xamarin.Forms.Toolkit.iOS.Controls.Calendar
{
    public class CalendarViewRenderer : NativeRenderer
    {
        CalendarView _view;
        public CalendarViewRenderer()
        {
        }

        protected override void OnModelSet(VisualElement model)
        {
            _view = (CalendarView)model;
            base.OnModelSet(model);

            var calendarView = new CalendarMonthView(DateTime.Now, true);

            calendarView.OnDateSelected += (date) =>
            {
                _view.NotifyDateSelected(date);
            };

            base.SetNativeControl(calendarView);
        }
    }
}