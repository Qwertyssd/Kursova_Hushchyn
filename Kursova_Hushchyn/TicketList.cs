using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class TicketList
    {
        //public RouteList list { get; set; }
        public List<Ticket> Tickets { get; set; }

        public TicketList()
        {
            //list = new RouteList();
            Tickets = new List<Ticket>();
        }
        public void AddTicket(Ticket ticket)
        {
          Tickets.Add(ticket);

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
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var ticket in Tickets)
                {
                    writer.WriteLine(ticket.TicketID);
                    writer.WriteLine(ticket.FirstName);
                    writer.WriteLine(ticket.LastName);
                    writer.WriteLine(ticket.DateOfBirth);
                    writer.WriteLine(ticket.RouteNumber);
                }
            }
        }

        public void LoadTicketsFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string ticketId = reader.ReadLine();
                    string name = reader.ReadLine();
                    string surname = reader.ReadLine();
                    DateTime date = DateTime.Parse(reader.ReadLine());
                    string routeNumber = reader.ReadLine();

                    Ticket ticket = new Ticket(ticketId,name,surname,date,routeNumber);
                    Tickets.Add(ticket);
                }
            }
        }
    }

}
