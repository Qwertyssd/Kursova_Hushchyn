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
            return BusRoutes.Where(r => r.Stops.First() == departurePoint).ToList();
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
            return BusRoutes.Where(r => (r.Price> priceLow && r.Price< priceHigh) ).ToList();
        }

        public List<BusRoute> SearchRoutes(string model =null, bool? hasAirConditioner=null, bool? hasToilet = null, bool? hasPowerOutlets=null, bool? hasInternet = null, string routeNumber = null, string carrierCompany = null, double? priceLow = null, double? priceHigh = null, DateTime? departureDate=null, DateTime? arrivalDate= null,TimeSpan ? departureTime = null, TimeSpan? arrivalTime = null)
        {
            RouteList routes = this;
            if (model!=null)
            {
                routes.SearchRoutesByModel(model);
            }

            if (hasAirConditioner != null)
            {
                routes.SearchRoutesByAirConditioner();
            }
            if (hasToilet != null)
            {
                routes.SearchRoutesByToilet();
            }
            if (hasPowerOutlets != null)
            {
                routes.SearchRoutesByPowerOutlets();
            }
            if (hasInternet != null)
            {
                routes.SearchRoutesByInternet();
            }
            if (routeNumber != null)
            {
                routes.SearchRoutesByRouteNumber(routeNumber);
            }
            if (carrierCompany != null)
            {
                routes.SearchRoutesByCarrierCompany(carrierCompany);
            }
            if ((priceLow != null&& priceHigh!=null) && priceHigh>priceLow)
            {
                routes.SearchRoutesByPrice(priceLow,priceHigh);
            }
            if (departureDate != null)
            {
                routes.SearchRoutesByDepartureDate((DateTime)departureDate);
            }
            if (arrivalDate != null)
            {
                routes.SearchRoutesByArrivalDate((DateTime)arrivalDate);
            }
            if (departureTime != null)
            {
                routes.SearchRoutesByDepartureTime((TimeSpan)departureTime);
            }
             if (arrivalDate != null)
            {
                routes.SearchRoutesByArrivalTime((TimeSpan)arrivalTime);
            }
            return routes.BusRoutes;
        }
           

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
