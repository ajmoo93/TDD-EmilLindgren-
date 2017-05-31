﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
   public class TourBooking
    {
        public string TourName { get; set; }
        public DateTime When { get; set; }
        public int Seats { get; set; }

        public TourBooking(string tName, DateTime date, int seat)
        {
            TourName = tName;
            When = date;
            Seats = seat;
        }
        public TourBooking()
        {

        }
    }
}
