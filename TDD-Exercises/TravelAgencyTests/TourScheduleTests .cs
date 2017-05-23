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
        [Test]
        public void CanCreateNewTour()
        {
            var sut = new TourSchedule();

            sut.CreateTour("WOW Kenyan Safari", new DateTime(2017, 05, 23), 27);

            var Booking = sut.GetToursFor(new DateTime(2017, 05, 23));
            Assert.AreEqual(1, Booking.Count, "");
        }
    }
}
