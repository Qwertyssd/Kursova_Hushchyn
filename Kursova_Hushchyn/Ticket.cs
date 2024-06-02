using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RouteNumber { get; set; }
        public BusRoute Route { get; set; }

        public Ticket(string ticketID, string firstName, string lastName, string routeNumber, BusRoute route)
        {
            TicketID = ticketID;
            FirstName = firstName;
            LastName = lastName;
            RouteNumber = routeNumber;
            Route = route;
        }
    }

}
