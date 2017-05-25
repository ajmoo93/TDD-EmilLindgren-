using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgencyTests
{
    [TestFixture]
    public class TourScheduleTests
    {
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            this.sut = new TourSchedule();
        }
        [Test]
        public void CanCreateNewTour()
        {
            sut.CreateTour("WOW Kenyan Safari", new DateTime(2017, 05, 23), 27);

            var Booking = sut.GetToursFor(new DateTime(2017, 05, 23));
            Assert.AreEqual(1, Booking.Count, "Having one booking");
        }
        
        [Test]
        public void ToursAreScheduledByDateOnly()
        {
            
            sut.CreateTour("Elephant safari", new DateTime(2017, 05, 23, 10, 00, 00), 27);
            var Booking = sut.GetToursFor(new DateTime(2017, 05, 23, 10, 00, 00));
            Assert.AreEqual(1, Booking.Count, "having one of same booking");
        }
        [Test]
        public void GetToursForGivenDayOnly()
        {
            sut.CreateTour("Tiger Safari Exclusive",
                new DateTime(2017, 05, 23), 18);
            sut.CreateTour("Monkey Safari",
                new DateTime(2017, 04, 10), 10);
            var Booking = sut.GetToursFor(new DateTime(2017, 05, 23));
            Assert.AreEqual(1, Booking.Count, "Only one booking");
        }
        [Test]
        public void BookingMoreThenTreeBookings_ThrowException()
        {
            
            sut.CreateTour("Monkey and tiger Safari",
                new DateTime(2017, 05, 23), 10);
            sut.CreateTour("Giraffe Exclusive safari",
               new DateTime(2017, 05, 23), 18);

            var booking = sut.GetToursFor(new DateTime(2017, 05, 23));
            
            var ex = Assert.Throws<TourAllocationException>(() =>

             sut.CreateTour("Tiger Safari",
               new DateTime(2017, 05, 23), 18)
            
            );
            Assert.AreEqual(1, booking.Count, "One booking only");
        }
    }
}
