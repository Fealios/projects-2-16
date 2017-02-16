using System;
using System.Collections.Generic;

namespace WeekdayApp.Objects
{
    public class Weekday
    {
        private int _day;
        private int _month;
        private int _year;
        private int _markerDay = 1;
        private int _markerMonth = 1;
        private int _markerYear = 2017;
        private int _yearsBetween;

        public Weekday(int newDay, int newMonth, int newYear)
        {
            _day = newDay;
            _month = newMonth;
            _year = newYear;
            CountYearsBetween();
        }

        public int TallyMonthDays()
        {
            return 9999999;
        }

        public string GetFullDate()
        {
            return _year.ToString() + _month.ToString() + _day.ToString();
        }

        public int GetYear()
        {
            return _year;
        }

        public int GetYearsBetween()
        {
            return _yearsBetween;
        }

        public void CountYearsBetween()
        {
            _yearsBetween = Math.Abs(_year - _markerYear);
        }

        public int TallyLeapYears()
        {
            int yesCount = 0;
            Console.WriteLine(_yearsBetween);
            for(int i = 1; i <= _yearsBetween;i++)
            {
                Console.WriteLine(_markerYear + i);
                if(IsLeapYear(_markerYear + i))
                {
                    yesCount++;
                }
            }
            return yesCount;
        }

        public bool IsLeapYear(int year)
        {
            if(year % 400 == 0)
            {
                return true;
            }
            if(year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//end class
}//end namespace







// private int _targetYear;
// private int _targetMonth;
// private int _targetDay;
// private int _alpha;
// private int _jyear;
// private int _jmonth;
// private int _JDN;
//
// public Weekday(int year, int month, int day)
// {
//     _targetYear = year;
//     _targetMonth = month;
//     _targetDay = day;
//
//     _alpha = Math.Floor(((14 - _targetMonth)/12));
//     _jyear = (_targetYear + 4800 - _alpha);
//     _jmonth = (_targetMonth + 12(_alpha) - 3);
//     _JDN = (_targetDay + Math.Floor(((153(_jmonth) + 2)/5)) + 365(_jyear) + Math.Floor((_jyear/4)) - Math.Floor((_jyear/100)) + Math.Floor((_jyear/400)) - 32083);
// }
