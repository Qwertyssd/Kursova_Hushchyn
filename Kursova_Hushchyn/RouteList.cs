using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class RouteList
    {
        public List<BusRoute> BusRoutes { get; set; }

        public RouteList()
        {
            BusRoutes = new List<BusRoute>();
        }

        public void AddRoute(BusRoute route)
        {
            BusRoutes.Add(route);
        }

        public void RemoveRoute(string routeNumber)
        {
            BusRoutes.RemoveAll(r => r.RouteNumber == routeNumber);
        }

        public List<BusRoute> SearchRoutesByDeparture(string departurePoint)
        {
            List<BusRoute> list = new List<BusRoute>();

            list.Where(r => r.Stops.First() == departurePoint).ToList();
            return list;
        }

        public List<BusRoute> SearchRoutesByArrival(string arrivalPoint)
        {
            return BusRoutes.Where(r => r.Stops.Last() == arrivalPoint).ToList();
        }
        public List<BusRoute> SearchRoutesByRouteNumber(string routeNumber)
        {
            return BusRoutes.Where(r => r.RouteNumber == routeNumber).ToList();
        }
        public List<BusRoute> SearchRoutesByModel(string model)
        {
            return BusRoutes.Where(r => r.Model == model).ToList();
        }
        public List<BusRoute> SearchRoutesByCarrierCompany(string company)
        {
            return BusRoutes.Where(r => r.CarrierCompany == company).ToList();
        }
        public List<BusRoute> SearchRoutesByIntermediate(string intermediatePoint)
        {
            return BusRoutes.Where(r => r.Stops.Contains(intermediatePoint) ).ToList();
        }

        public List<BusRoute> SearchRoutesByDepartureDate(DateTime date)
        {
            return BusRoutes.Where(r => r.DepartureDate.Date == date.Date).ToList();
        }

        public List<BusRoute> SearchRoutesByArrivalDate(DateTime date)
        {
            return BusRoutes.Where(r => r.ArrivalDate.Date == date.Date).ToList();
        }

        public List<BusRoute> SearchRoutesByDepartureTime(TimeSpan time)
        {
            return BusRoutes.Where(r => r.TravelDurations.First() == time).ToList();
        }

        public List<BusRoute> SearchRoutesByArrivalTime(TimeSpan time)
        {
            return BusRoutes.Where(r => r.TravelDurations.Last() == time).ToList();
        }

        public List<BusRoute> SearchRoutesByTicketAvailability()
        {
            return BusRoutes.Where(r => r.AvailableSeats > 0).ToList();
        }

        public List<BusRoute> SearchRoutesByToilet()
        {
            return BusRoutes.Where(r => r.HasToilet== true).ToList();
        }
        public List<BusRoute> SearchRoutesByInternet()
        {
            return BusRoutes.Where(r => r.HasInternet == true).ToList();
        }

        public List<BusRoute> SearchRoutesByAirConditioner()
        {
            return BusRoutes.Where(r => r.HasAirConditioner == true).ToList();
        }
        public List<BusRoute> SearchRoutesByPowerOutlets()
        {
            return BusRoutes.Where(r => r.HasPowerOutlets == true).ToList();
        }
        public List<BusRoute> SearchRoutesByPrice(double? priceLow, double? priceHigh)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.Price<priceHigh&& bus.Price > priceLow)
                {
                    list.Add(bus);
                }
            }
            return list;
        }

     
      
        public void SaveRoutesToFile(string filePath)
        {
            // Implement file saving logic
        }

        public void LoadRoutesFromFile(string filePath)
        {
            // Implement file loading logic
        }
    }

}
