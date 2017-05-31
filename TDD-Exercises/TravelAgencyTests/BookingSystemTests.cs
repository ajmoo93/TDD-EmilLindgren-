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
        // för att kunna nå dem i metoderna nere
        private TourScheduleStub tourschedule;
        private BookingSystem sut;
        private Passenger passenger;

        [SetUp]
        public void Setup()
        {
            tourschedule = new TourScheduleStub();
            sut = new BookingSystem(tourschedule);
            passenger = new Passenger { FirstName = "Samelam", LastName = "Kalimani" };
    }
        [Test]
        public void CanCreateBooking()
        {

            tourschedule.tours = new List<Tour>
            {
                //för att göra såhär måste du ha två constructor
                //en som tar in dina parametrar och en som är tom.
                new Tour{TourName = "Kenya", When = new DateTime(2017,05,05), Seats = 1},
                
            };

            sut.CreateBooking("Kenya", new DateTime(2017, 05, 05),15, passenger);
            var result = sut.GetBookingsFor(passenger);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Samelam", result[0].passanger.FirstName);
            Assert.AreEqual("Kenya", result[0].tour.TourName);
           
        }
        [Test]
        public void TourAllocationException()
        {
            // Skapar vi upp en ny lista av tour
            tourschedule.tours = new List<Tour>();
            //om det är dubbelbokat så kastar den ett exception tar in 4 argument som crateBooking har
            Assert.Throws<NoneExistensExeption>(() => sut.CreateBooking("Summer Safari", new DateTime(2017, 05, 22),15, passenger));

        }

        [Test]
        public void FullBookedTour()
        {
           // tourschedule.tours.Add(new Tour { TourName = "Kenya Mega Safari", When = new DateTime(2017, 05, 22), Seats = 3 });
           //Ny Lista av tour
            tourschedule.tours = new List<Tour>();
            //Skapar vi upp en ny tour för att se så att exceptionet kastas
            tourschedule.tours.Add(new Tour { TourName = "Kenya travel", When = new DateTime(2017, 05, 22), Seats = 15 });
            //om det är fullbokat så kastar den ett exception tar in 4 argument som crateBooking har
            Assert.Throws<NoneAvailableSeats>(() => sut.CreateBooking("Kenya Mega Safari", new DateTime(2017, 05, 22),15, passenger));

        }
    }
}
