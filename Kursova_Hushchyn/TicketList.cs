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
           // return Tickets.Where(t => t.TicketID == ticketID).ToList();
           List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.TicketID==ticketID)
                {
                    list.Add(ticket);
                }
            }
            return list;
        }

        public List<Ticket> GetTicketsByName(string firstName, string lastName)
        {
            //return Tickets.Where(t => t.FirstName == firstName && t.LastName == lastName).ToList();
            List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.FirstName == firstName && ticket.LastName == lastName)
                {
                    list.Add(ticket);
                }
            }
            return list;
        }

        public List<Ticket> GetTicketsByRouteNumber(string routeNumber)
        {
            // return Tickets.Where(t => t.RouteNumber == routeNumber).ToList();
            List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.RouteNumber == routeNumber)
                {
                    list.Add(ticket);
                }
            }
            return list;
        }

        public List<Ticket> GetTicketsByDeparturePoint(string departurePoint)
        {
            // return Tickets.Where(t => t.RouteNumber == routeNumber).ToList();
            List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.DeparturePoint==departurePoint)
                {
                    list.Add(ticket);
                }
            }
            return list;
        }
        public List<Ticket> GetTicketsByArrivalPoint(string arrivalPoint)
        {
           
            List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.ArrivalPoint == arrivalPoint)
                {
                    list.Add(ticket);
                }
            }
            return list;
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
                    writer.WriteLine(ticket.DeparturePoint);
                    writer.WriteLine(ticket.ArrivalPoint);
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
                    string departure = reader.ReadLine();
                    string arrival = reader.ReadLine();

                    Ticket ticket = new Ticket(ticketId,name,surname,date,routeNumber,departure,arrival);
                    Tickets.Add(ticket);
                }
            }
        }
    }

}
