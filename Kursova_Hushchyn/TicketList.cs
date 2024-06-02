using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class TicketList
    {
        public RouteList list { get; set; }
        public List<Ticket> Tickets { get; set; }

        public TicketList()
        {
            list = new RouteList();
            Tickets = new List<Ticket>();
        }
        public void AddTicket(Ticket ticket)
        { 
            Tickets.Add(ticket);
            RouteList l = new RouteList();
            RouteList l1 = new RouteList();

        }
        public List<Ticket> GetTicketsByID(string ticketID)
        {
            return Tickets.Where(t => t.TicketID == ticketID).ToList();
        }

        public List<Ticket> GetTicketsByName(string firstName, string lastName)
        {
            return Tickets.Where(t => t.FirstName == firstName && t.LastName == lastName).ToList();
        }

        public List<Ticket> GetTicketsByRouteNumber(string routeNumber)
        {
            return Tickets.Where(t => t.RouteNumber == routeNumber).ToList();
        }

        public void SaveTicketsToFile(string filePath)
        {
            // Implement file saving logic
        }

        public void LoadTicketsFromFile(string filePath)
        {
            // Implement file loading logic
        }
    }

}
