using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class Schedule
    {
        public List<BusRoute> BusRoutes { get; set; }

        public Schedule()
        {
            BusRoutes = new List<BusRoute>();
        }

        public List<BusRoute> SortByDepartureTime()
        {
            return BusRoutes.OrderBy(r => r.DepartureDate).ToList();
        }

        /*public List<BusRoute> SortByTravelDuration()
        {
            return BusRoutes.OrderBy(r => r.TravelDurations.Sum(d => d.TotalMinutes)).ToList();
        }*/

        public List<BusRoute> SortByDeparturePoint()
        {
            return BusRoutes.OrderBy(r => r.Stops.First()).ToList();
        }

        public List<BusRoute> SortByArrivalPoint()
        {
            return BusRoutes.OrderBy(r => r.Stops.Last()).ToList();
        }

        public List<BusRoute> SortByArrivalTime()
        {
            return BusRoutes.OrderBy(r => r.ArrivalDate).ToList();
        }
    }

}
