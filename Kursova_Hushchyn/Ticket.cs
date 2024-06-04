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
        public DateTime DateOfBirth { get; set; }
        public string RouteNumber { get; set; }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }

        

        public Ticket(string ticketID, string firstName, string lastName, DateTime dateOfBirth, string routeNumber,string departure,string arrival)
        {
            TicketID = ticketID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            RouteNumber = routeNumber;
            DeparturePoint = departure;
            ArrivalPoint = arrival;
        }
    }

}
