using Xunit;
using System.Collections.Generic;

namespace WeekdayApp.Objects
{
    public class WeekdayTest
    {
        // [Fact]
        // public void WeekdayConstructor_ReturnProperDate_YYYYMMDD()
        // {
        //     int newDay = 12;
        //     int newMonth = 1;
        //     int newYear = 2021;
        //     string formatDate = "2021112";
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //
        //     Assert.Equal(formatDate, newWeekday.GetFullDate());
        // }
        //
        // [Fact]
        // public void CountYears_CountYearsBetween_Years()
        // {
        //     int newDay = 12;
        //     int newMonth = 1;
        //     int newYear = 2021;
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //     newWeekday.CountYearsBetween();
        //
        //     Assert.Equal(4, newWeekday.GetYearsBetween());
        // }
        //
        // [Fact]
        // public void TallyLeapYears_GetTotalLeapYears_Number()
        // {
        //     int newDay = 12;
        //     int newMonth = 1;
        //     int newYear = 2021;
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //
        //     Assert.Equal(1, newWeekday.TallyLeapYears());
        // }
        //
        // [Fact]
        // public void CheckMarkerYear_IfLeapYear_ReturnTrue()
        // {
        //     int newDay = 12;
        //     int newMonth = 1;
        //     int newYear = 2021;
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //
        //     Assert.Equal(false, newWeekday.IsLeapYear(newWeekday.GetYear()));
        // }
        //
        // [Fact]
        // public void TallyMonthDays_GetTotalDays_NumberofDays()
        // {
        //     int newDay = 1;
        //     int newMonth = 3;
        //     int newYear = 2020;
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //
        //     Assert.Equal(60, newWeekday.TallyMonthDays());
        // }
        //
        // [Fact]
        // public void TallyTotalDays_GetTotalDays_16()
        // {
        //     int newDay = 1;
        //     int newMonth = 1;
        //     int newYear = 2021;
        //     Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
        //     Assert.Equal(1461, newWeekday.TallyTotalDays());
        // }

        [Fact]
        public void GetDOW_Today()
        {
            int newDay = 16;
            int newMonth = 2;
            int newYear = 2017;
            Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
            Assert.Equal("Thursday", newWeekday.GetDOW());
        }
    }
}
