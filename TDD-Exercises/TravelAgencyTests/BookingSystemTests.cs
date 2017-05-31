using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgencyTests
{
    public class BookingSystemTests
    {
        private TourScheduleStub tourschedule;
        private BookingSystem sut;

        [SetUp]
        public void Setup()
        {
            tourschedule = new TourScheduleStub();
            sut = new BookingSystem(tourschedule)
    }
        [Test]
        public void CanCreateBooking()
        {

            tourschedule.tours = new List<TourBooking>
            {
                //för att göra såhär måste du ha två constructor
                //en som tar in dina parametrar och en som är tom.
                new TourBooking{TourName = "Kenya", When = new DateTime(2017,05,05), Seats = 1},
                
            };
        }
    }

}
