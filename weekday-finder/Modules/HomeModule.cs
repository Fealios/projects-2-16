using Nancy;
using System.Collections.Generic;
using WeekdayApp.Objects;

namespace WeekdayApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };
            Post["/"] = _ =>
            {
                string dateString = Request.Form["new-date"];
                int newDay = int.Parse(dateString.Substring(3, 2));
                int newMonth = int.Parse(dateString.Substring(0, 2));
                int newYear = int.Parse(dateString.Substring(6, 4));
                Weekday newWeekday = new Weekday(newDay, newMonth, newYear);
                return View["result.cshtml", newWeekday];
            };
        }
    }
}
