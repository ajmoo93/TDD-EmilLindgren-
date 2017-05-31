using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelAgency
{
    public class BookingSystem
    {
        private ITourSchedule tourschedule;
    //Skapas en ny liska av Booking för att vi skall kunna för tag i den sedan
        List<Booking> ListBooking = new List<Booking>();
        
        public BookingSystem(ITourSchedule tourschedule)
        {
            this.tourschedule = tourschedule;

        }
        //Metod med 4 argument för att v iskall få ut dem till testet sen
        public void CreateBooking(string name, DateTime dateTime,int seats, Passenger passenger)
        {
          var resulutlist = tourschedule.GetToursFor(dateTime);
            //Letar vi upp TourName
          var tour = resulutlist.FirstOrDefault(x => x.TourName == name);

            //om tour har ett null så kastar den NoneExistensExeption
            if (tour == null)
            {
                throw new NoneExistensExeption();
            }
           else
            {
                // om inte något i tours är null så lägger den till en ny booking
                ListBooking.Add(new Booking() { passanger = passenger, tour = tour, Seats = seats });
            }
            // fungerar inte än
            //if(tour.Seats > 0 )
            //{
            //    throw new NoneAvailableSeats();
            //}
          }

        public List<Booking> GetBookingsFor(Passenger passenger)
        {
            // Hät letar vi efter passagerare och listar dem dem träffas
            var BookingList = ListBooking.Where(x => x.passanger == passenger).ToList();
            return ListBooking;
        }
    }
}