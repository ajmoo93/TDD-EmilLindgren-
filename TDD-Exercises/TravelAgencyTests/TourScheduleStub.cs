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
        public List<Tour> tours;

        public void CreateTour(string name, DateTime dateTime, int seats)
        {
            throw new NotImplementedException();
        }

        public List<Tour> GetToursFor(DateTime dateTime)
        {
            return tours;
        }
    }
}
