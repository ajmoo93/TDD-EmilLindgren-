using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgencyTests
{
   public class TourScheduleStub : ITourSchedule
    {
        public List<TourBooking> tours;

        public void CreateTour(string name, DateTime dateTime, int seats)
        {
            throw new NotImplementedException();
        }

        public List<TourBooking> GetToursFor(DateTime dateTime)
        {
            return tours;
        }
    }
}
