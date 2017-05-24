using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class TourSchedule
    {
        private Dictionary<DateTime, List<TourBooking>> ScheduleByDay =
            new Dictionary<DateTime, List<TourBooking>>();

        public List<TourBooking> GetToursFor(DateTime dateTime)
        {
            return ScheduleByDay[dateTime.Date];
        }

        public void CreateTour(string name, DateTime dateTime, int seats)
        {
            ScheduleByDay[dateTime.Date] = new List<TourBooking> {
                new TourBooking(name, dateTime, seats)
            };
            var Overlapping = ScheduleByDay.FirstOrDefault(x => x.Key == dateTime);
            if (Overlapping.Equals(dateTime))
                throw new TourAllocationException();



                //.Add(new TourBooking(name, dateTime, seats));
        }
    }
}
