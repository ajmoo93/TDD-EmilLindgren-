using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class TourSchedule : ITourSchedule
    {
        // private Dictionary<DateTime, List<TourBooking>> ScheduleByDay =
        // new Dictionary<DateTime, List<TourBooking>>();
        public List<Tour> ScheduleByDay = new List<Tour>();

        public List<Tour> GetToursFor(DateTime dateTime)
        {
            var TourDate = ScheduleByDay.Where(x => x.When == dateTime).ToList();
          return TourDate;
        }

        public void CreateTour(string name, DateTime dateTime, int seats)
        {
            var RelsultList = ScheduleByDay.Count(x => x.When.Date == dateTime.Date);
            //var ListResult = ScheduleByDay[dateTime.Day];
               //= new List<TourBooking> {
            var Overlapping = ScheduleByDay.Any(x => x.When.Date == dateTime.Date);
            if (RelsultList >= 3)
                throw new TourAllocationException();
            else
                ScheduleByDay.Add(new Tour(name, dateTime, seats));





            //dailyBooking.Add(new TourBooking(name, dateTime, seats));

            //.Add(new TourBooking(name, dateTime, seats));
        }
    }
}
