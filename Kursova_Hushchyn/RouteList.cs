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

        /*public List<BusRoute> SearchRoutesByDeparture(string departurePoint)
        {
            return BusRoutes.Where(r => r.Stops.First() == departurePoint).ToList();
        }

        public List<BusRoute> SearchRoutesByArrival(string arrivalPoint)
        {
            return BusRoutes.Where(r => r.Stops.Last() == arrivalPoint).ToList();
        }

        public List<BusRoute> SearchRoutesByIntermediateStop(string stop)
        {
            return BusRoutes.Where(r => r.Stops.Contains(stop)).ToList();
        }

        public List<BusRoute> SearchRoutesByDate(DateTime date)
        {
            return BusRoutes.Where(r => r.DepartureDate.Date == date.Date).ToList();
        }

        public List<BusRoute> SearchRoutesByTicketAvailability()
        {
            return BusRoutes.Where(r => r.AvailableSeats > 0).ToList();
        }

        public List<BusRoute> SearchRoutesByAmenities(bool? hasAirConditioner = null, bool? hasToilet = null, bool? hasPowerOutlets = null, bool? hasInternet = null)
        {
            return BusRoutes.Where(r =>
                (hasAirConditioner == null || r.HasAirConditioner == hasAirConditioner) &&
                (hasToilet == null || r.HasToilet == hasToilet) &&
                (hasPowerOutlets == null || r.HasPowerOutlets == hasPowerOutlets) &&
                (hasInternet == null || r.HasInternet == hasInternet)
            ).ToList();
        }*/
        public List<BusRoute> SearchRoutes(string departurePoint = null, string arrivalPoint = null, string intermediateStop = null, DateTime? date = null, bool? hasAirConditioner = null,bool? hasToilet = null,bool? hasPowerOutlets = null, bool? hasInternet = null, int? AvailableTickets = null)
        {
            return BusRoutes.Where(r =>
                (departurePoint == null || r.Stops.First() == departurePoint) &&
                (arrivalPoint == null || r.Stops.Last() == arrivalPoint) &&
                (intermediateStop == null || r.Stops.Contains(intermediateStop)) &&
                (date == null || r.DepartureDate.Date == date.Value.Date) &&
                (hasAirConditioner == null || r.HasAirConditioner == hasAirConditioner) &&
                (hasToilet == null || r.HasToilet == hasToilet) &&
                (hasPowerOutlets == null || r.HasPowerOutlets == hasPowerOutlets) &&
                (hasInternet == null || r.HasInternet == hasInternet) &&
                (AvailableTickets == null || r.AvailableSeats > 0)).ToList();
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
