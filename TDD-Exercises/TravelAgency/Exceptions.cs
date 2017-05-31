using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class TourAllocationException : Exception
    {
        public DateTime TimeSgguestion { get; set; }

        public TourAllocationException(DateTime timeSgguestion)
        {
            TimeSgguestion = timeSgguestion;
        }

        public TourAllocationException()
        {
        }
    }

    public class NoneExistensExeption : Exception
    {

        public NoneExistensExeption()
        {
            Console.WriteLine("This Tour does not exist");
        }

    }

    public class NoneAvailableSeats : Exception
    {

        public NoneAvailableSeats()
        {
            Console.WriteLine("All seats are full");
        }

    }
}
