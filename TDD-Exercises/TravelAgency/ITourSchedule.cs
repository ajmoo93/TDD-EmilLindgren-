using System;
using System.Collections.Generic;

namespace TravelAgency
{
    public interface ITourSchedule
    {
        void CreateTour(string name, DateTime dateTime, int seats);
        List<TourBooking> GetToursFor(DateTime dateTime);
    }
}