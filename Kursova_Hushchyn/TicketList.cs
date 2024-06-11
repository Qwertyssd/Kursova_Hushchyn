using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Hushchyn
{
    public class TicketList
    {
       
        public List<Ticket> Tickets { get; set; }

        public TicketList()
        {
            
            Tickets = new List<Ticket>();
        }
        public void AddTicket(Ticket ticket)
        {
          Tickets.Add(ticket);

        }
        public List<Ticket> DeleteTicketByRouteNumber(string routeNumber)
        {
            List<Ticket> list = new List<Ticket>();
            
            foreach (Ticket ticket in Tickets)
            {
                if (routeNumber!=ticket.RouteNumber)
                {
                    list.Add(ticket);
                }
            }
            return list;

        }
        public List<Ticket> DeleteTicketByModel(string model,List<BusRoute> routes)
        {
            TicketList list = this;

            foreach (BusRoute bus in routes)
            {
                if (bus.Model==model)
                {
                    string number = bus.RouteNumber;
                    list.Tickets = list.DeleteTicketByRouteNumber(number);
                }
            }
            
            return list.Tickets;

        }
        public List<Ticket> DeleteTicketByCarrierCompany(string carrierCompany, List<BusRoute> routes)
        {
            TicketList list = this;

            foreach (BusRoute bus in routes)
            {
                if (bus.CarrierCompany == carrierCompany)
                {
                    string number = bus.RouteNumber;
                    list.Tickets = list.DeleteTicketByRouteNumber(number);
                }
            }

            return list.Tickets;

        }
        public List<Ticket> DeleteTicketByTicketID(string id , RouteList route)
        {
            List<Ticket> list = new List<Ticket>();

            foreach (Ticket ticket in Tickets)
            {
                if (id != ticket.TicketID)
                {
                    list.Add(ticket);
                }
                else
                {
                    string l = ticket.RouteNumber;
                    
                    foreach (BusRoute bus in route.BusRoutes)
                    {
                        int i = 0;
                        if (bus.RouteNumber==l)
                        {
                            foreach (var stop in bus.Stops)
                            {
                                if (stop==ticket.DeparturePoint||stop==ticket.ArrivalPoint)
                                {
                                    bus.AvailableSeats[i]++;
                                }
                                i++;
                            }
                            
                        }
                        
                    }
                }
            }
            return list;

        }
        public List<Ticket> GetTicketsByID(string ticketID)
        {
           
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

        public List<Ticket> GetTicketsByPassenger(string firstName, string lastName)
        {
            
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
        public List<Ticket> GetTicketsByPassenger(string name, int type)
        {
            List<Ticket> list = new List<Ticket>();
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.FirstName == name && type == 1)
                {
                    list.Add(ticket);
                }
                if (ticket.LastName == name && type == 2)
                {
                    list.Add(ticket);
                }
            }
            return list;
        }
        
        public List<Ticket> GetTicketsByRouteNumber(string routeNumber)
        {
           
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
