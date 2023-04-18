using System;
using System.Globalization;

namespace Monpl.Utils.Extensions
{
    public static class DateTimeExtensions
    {
        private static readonly DateTime oneOfSunday = new DateTime(2020, 1, 19);

        public static int ReturnWeekCount(this DateTime target)
        {
            var days = (target - oneOfSunday).Days;

            return days / 7;
        }

        public static bool AlreadyPastWeek(this DateTime target, DateTime target2)
        {
            return target.ReturnWeekCount() > target2.ReturnWeekCount();
        }

        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(this DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
                time = time.AddDays(3);

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}