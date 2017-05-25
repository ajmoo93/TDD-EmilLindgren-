using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class TourSchedule
    {
        // private Dictionary<DateTime, List<TourBooking>> ScheduleByDay =
        // new Dictionary<DateTime, List<TourBooking>>();
        public List<TourBooking> ScheduleByDay = new List<TourBooking>();

        public List<TourBooking> GetToursFor(DateTime dateTime)
        {
            var TourDate = ScheduleByDay.Where(x => x.When == dateTime).ToList();
          return TourDate;
        }

        public void CreateTour(string name, DateTime dateTime, int seats)
        {
            var ListResult = ScheduleByDay[dateTime.Day];
               //= new List<TourBooking> {
            var Overlapping = ScheduleByDay.Where(x => x.When == dateTime).ToList().Count;
            if (Overlapping >= 3)
                throw new TourAllocationException();
            else
                ScheduleByDay.Add(new TourBooking(name, dateTime, seats));
            
            

                

            //dailyBooking.Add(new TourBooking(name, dateTime, seats));

            //.Add(new TourBooking(name, dateTime, seats));
        }
    }
}
