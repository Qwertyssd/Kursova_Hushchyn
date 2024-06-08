using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_Hushchyn
{
    public class RouteList
    {
        public List<BusRoute> BusRoutes { get; set; }
        public int unique { get; set; }
        public RouteList()
        {
            BusRoutes = new List<BusRoute>();
        }

        public void AddRoute(BusRoute route)
        {
            BusRoute busTmp = route;
            BusRoutes.Add(busTmp);    
        }

        public List<BusRoute> RemoveRouteByRouteNumber(string routeNumber)
        {
            List<BusRoute> list = new List<BusRoute>();

            
            foreach (BusRoute route in BusRoutes)
            {
                if (route.RouteNumber!=routeNumber)
                {
                   list.Add(route);
                }
            }
            return list;
        }
        public List<BusRoute> RemoveRouteByModel(string model)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute route in BusRoutes)
            {
                if (route.Model != model)
                {
                    list.Add(route);
                }
            }
            return list;
        }
        public List<BusRoute> RemoveRouteByCarrierCompany(string carrierCompany)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute route in BusRoutes)
            {
                if (route.CarrierCompany != carrierCompany)
                {
                    list.Add(route);
                }
            }
            return list;
        }
       
        

        public List<BusRoute> SearchRoutesByDeparture(string departurePoint)
        {
            List<BusRoute> list = new List<BusRoute>();

          
            
            foreach (BusRoute route in BusRoutes)
            {
                int count = route.Stops.Count;
                foreach (var stop in route.Stops)
                {
                    if (stop == departurePoint && stop != route.Stops[count-1])
                    {
                        list.Add(route);
                    }
                }
            }
            return list;
        }
        public List<BusRoute> SearchRoutesByCapacity(int capacity)
        {
            List<BusRoute> list = new List<BusRoute>();



            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.PassengerCapacity == capacity)
                {
                    list.Add(bus);
                }
            }
            return list;
        }

        public List<BusRoute> SearchRoutesByArrival(string arrivalPoint)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                int count = bus.Stops.Count;
                foreach (var stop in bus.Stops)
                {
                    if (stop == arrivalPoint && stop != bus.Stops[0])
                    {
                        list.Add(bus);
                    }
                }
            }
            return list;
        }
        public List<BusRoute> SearchRoutesByDepartureAndArrival(string departurePoint, string arrivalPoint)
        {
            List<BusRoute> list = new List<BusRoute>();

            
            bool cathced = false;
            foreach (BusRoute route in BusRoutes)
            {
                    foreach (string stop in route.Stops)
                    {
                        string tmp = stop;

                        if (stop==arrivalPoint && cathced == true)
                        {

                            list.Add(route);
                        }
                        if (stop == departurePoint)
                        {
                            cathced = true;
                        }
                    }
                    cathced = false;
            }
            return list;

        }
        public List<BusRoute> SearchRoutesByRouteNumber(string routeNumber)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.RouteNumber == routeNumber)
                {
                    list.Add(bus);
                }
            }
            return list;
           
        }
        public List<BusRoute> SearchRoutesByModel(string model)
        {

            List<BusRoute> list = new List<BusRoute>();

            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.Model == model)
                {
                    list.Add(bus);
                }
            }
            return list;
        }
        public List<BusRoute> SearchRoutesByCarrierCompany(string company)
        {
            List<BusRoute> list = new List<BusRoute>();

            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.CarrierCompany == company)
                {
                    list.Add(bus);
                }
            }
            return list;
           
        }
        public List<BusRoute> SearchRoutesByIntermediate(string intermediatePoint)
        {
            List<BusRoute> list = new List<BusRoute>();

            foreach (BusRoute bus in BusRoutes)
            {
                foreach (string stop in bus.Stops)
                {
                    if (stop == intermediatePoint)
                    {
                        list.Add(bus);
                    }
                }
               
            }

            return list;
           
        }

        public List<BusRoute> SearchRoutesByDepartureDate(DateTime date)
        {
            List<BusRoute> list = new List<BusRoute>();

            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.DepartureDate.Date == date.Date)
                {
                    list.Add(bus);
                }
            }

            return list;
            
        }

        public List<BusRoute> SearchRoutesByArrivalDate(DateTime date)
        {
            List<BusRoute> list = new List<BusRoute>();

            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.ArrivalDate.Date == date.Date)
                {
                    list.Add(bus);
                }
            }

            return list;
           
        }

        public List<BusRoute> SearchRoutesByDepartureTime(TimeSpan time)
        {
            return BusRoutes.Where(r => r.Departures.First() == time).ToList();
        }

        public List<BusRoute> SearchRoutesByArrivalTime(TimeSpan time)
        {
            return BusRoutes.Where(r => r.Arrivals.Last() == time).ToList();
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
        public List<BusRoute> SearchRoutesByPriceLow(double? priceLow)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                if ( bus.Price > priceLow)
                {
                    list.Add(bus);
                }
            }
            return list;
        }
        public List<BusRoute> SearchRoutesByPriceHigh(double? priceHigh)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.Price < priceHigh)
                {
                    list.Add(bus);
                }
            }
            return list;
        }
        public List<BusRoute> DecreaseSeat(string routeNumber)
        {
            List<BusRoute> list = new List<BusRoute>();


            foreach (BusRoute bus in BusRoutes)
            {
                if (bus.RouteNumber == routeNumber)
                {
                    bus.AvailableSeats--;
                }
                list.Add(bus);
            }
            return list;


        }
        public List<BusRoute> SortByPriceHighToLow()
        {
            List<BusRoute> list = BusRoutes;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Price < list[j + 1].Price)
                    {
                        BusRoute tmp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = tmp;
                    }
                }
            }
            return list;
        }
        public List<BusRoute> SortByPriceLowToHigh()
        {

            List<BusRoute> list = BusRoutes;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Price > list[j + 1].Price)
                    {
                        BusRoute tmp = list[j+1];
                        list[j+1] = list[j];
                        list[j] = tmp;
                    }
                }
            }
            return list;
        }
        public void SaveRoutesToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var route in BusRoutes)
                {
                    writer.WriteLine(route.Model);
                    writer.WriteLine(route.PassengerCapacity);
                    writer.WriteLine(route.HasAirConditioner);
                    writer.WriteLine(route.HasToilet);
                    writer.WriteLine(route.HasPowerOutlets);
                    writer.WriteLine(route.HasInternet);
                    writer.WriteLine(route.RouteNumber);
                    writer.WriteLine(route.CarrierCompany);
                    writer.WriteLine(route.Price);
                    writer.WriteLine(route.DepartureDate);
                    writer.WriteLine(route.ArrivalDate);
                    writer.WriteLine(string.Join(",", route.Arrivals));
                    writer.WriteLine(string.Join(",", route.Departures));
                    writer.WriteLine(string.Join(",", route.TimeAdd));
                    writer.WriteLine(string.Join(",", route.Stops));
                    writer.WriteLine(route.AvailableSeats);
                }
            }
        }

        public void LoadRoutesFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string model = reader.ReadLine();
                    int passengerCapacity = int.Parse(reader.ReadLine());
                    bool hasAirConditioner = bool.Parse(reader.ReadLine());
                    bool hasToilet = bool.Parse(reader.ReadLine());
                    bool hasPowerOutlets = bool.Parse(reader.ReadLine());
                    bool hasInternet = bool.Parse(reader.ReadLine());
                    string routeNumber = reader.ReadLine();
                    string carrierCompany = reader.ReadLine();
                    double price = double.Parse(reader.ReadLine());
                    DateTime departureDate = DateTime.Parse(reader.ReadLine());
                    DateTime arrivalDate = DateTime.Parse(reader.ReadLine());
                    List<TimeSpan> arrivals = reader.ReadLine().Split(',').Select(TimeSpan.Parse).ToList();
                    List<TimeSpan> departures = reader.ReadLine().Split(',').Select(TimeSpan.Parse).ToList();
                    List<int> dateAdd = reader.ReadLine().Split(',').Select(int.Parse).ToList();
                    List<string> stops = reader.ReadLine().Split(',').ToList();
                    int availableSeats = int.Parse(reader.ReadLine());

                    BusRoute route = new BusRoute(model, passengerCapacity, hasAirConditioner, hasToilet, hasPowerOutlets, hasInternet,
                                                  routeNumber, carrierCompany, price, departureDate, arrivalDate, arrivals,departures,dateAdd, stops, availableSeats);
                    AddRoute(route);
                }
            }
        }
    }

}
