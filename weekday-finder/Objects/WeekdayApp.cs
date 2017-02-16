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
        private int _markerYear = 1700;
        private int _yearsBetween;

        private Dictionary<int, int> _months = new Dictionary<int, int>
        {
            {1, 31},
            {2, 28},
            {3, 31},
            {4, 30},
            {5, 31},
            {6, 30},
            {7, 31},
            {8, 31},
            {9, 30},
            {10, 31},
            {11, 30},
            {12, 31}
        };

        private List<string> Days = new List<string>
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        public Weekday(int newDay, int newMonth, int newYear)
        {
            _day = newDay;
            _month = newMonth;
            _year = newYear;
            CountYearsBetween();
        }

        public int TallyMonthDays()
        {
            int monthDayTally = 0;
            int index = 1;
            while (index != _month)
            {
                monthDayTally += _months[index];
                if (IsLeapYear(_year) && index == 2)
                {
                    monthDayTally += 1;
                }
                index++;
            }
            return monthDayTally;
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
            for(int i = 1; i <= _yearsBetween;i++)
            {
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

        public int TallyTotalDays()
        {
            int yearDays = (_yearsBetween*365) + TallyLeapYears();
            int monthDays = TallyMonthDays();
            int days = _day - _markerDay;
            int totalDays = yearDays + monthDays + days;
            return totalDays;
        }

        public string GetDOW()
        {
            return Days[((TallyTotalDays()+5) % 7)];
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
