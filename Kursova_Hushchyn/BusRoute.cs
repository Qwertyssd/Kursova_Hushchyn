using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class BusRoute : Bus
    {
        public string RouteNumber { get; set; }
        public string CarrierCompany { get; set; }
        public double Price { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public List<TimeSpan> Departures { get; set; }
        public List<TimeSpan> Arrivals { get; set; }
        public List<string> Stops { get; set; }
        public int AvailableSeats { get; set; }

        public BusRoute(string model, int passengerCapacity, bool hasAirConditioner, bool hasToilet, bool hasPowerOutlets, bool hasInternet,
                        string routeNumber, string carrierCompany, double price, DateTime departureDate, DateTime arrivalDate,
                        List<TimeSpan> arrivals, List <TimeSpan> departures, List<string> stops, int availableSeats)
            : base(model, passengerCapacity, hasAirConditioner, hasToilet, hasPowerOutlets, hasInternet)
        {
            RouteNumber = routeNumber;
            CarrierCompany = carrierCompany;
            Price = price;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            Arrivals = arrivals;
            Departures = departures;
            Stops = stops;
            AvailableSeats = availableSeats;
        }
    }
}
