using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winForms_Practice
{
    class TimeUtil
    {
        public static bool IsSameDay(DateTime d1, DateTime d2)
        {
            return d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day;
        }
        public static bool IsSameMinute(DateTime d1, DateTime d2)
        {
            return d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day && d1.Hour == d2.Hour && d1.Minute == d2.Minute;
        }
    }
}
