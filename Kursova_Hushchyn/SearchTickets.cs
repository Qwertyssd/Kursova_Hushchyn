using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_Hushchyn
{
    public partial class SearchTickets : Form
    {
        private RouteList routes = new RouteList();
        private TicketList tickets = new TicketList();
        private Ticket ticket;
        public SearchTickets(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routes = routeList;
            this.tickets = ticketList;
            this.KeyPreview = true;
        }

        private void SearchTickets_Load(object sender, EventArgs e)
        {
            dgvTickets.DataSource = tickets.Tickets;
        }
        private void Search()
        {
            string name = string.IsNullOrEmpty(txtName.Text) ? null : txtName.Text;
            string surname = string.IsNullOrEmpty(txtSurname.Text) ? null : txtSurname.Text;
            string departurePoint = string.IsNullOrEmpty(txtDeparture.Text) ? null : txtDeparture.Text;
            string arrivalPoint = string.IsNullOrEmpty(txtArrival.Text) ? null : txtArrival.Text;
            string routeNumber = string.IsNullOrEmpty(txtRouteNumber.Text) ? null : txtRouteNumber.Text;
            TicketList list = new TicketList();
            list.Tickets = tickets.Tickets;

            if (name != null && surname != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, surname);
            }
            else if (name != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, 1);
            }
            else if (name != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, 1);
            }
            else if (departurePoint != null)
            {
                list.Tickets = list.GetTicketsByDeparturePoint(departurePoint);
            }
            else if (arrivalPoint != null)
            {
                list.Tickets = list.GetTicketsByArrivalPoint(arrivalPoint);
            }
            if (routeNumber != null)
            {
                list.Tickets = list.GetTicketsByRouteNumber(routeNumber);
            }
            if (list.Tickets.Count == 0)
            {
                MessageBox.Show("There are no tickets with given parameters");
                return;
            }
            dgvTickets.DataSource = list.Tickets;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvTickets.DataSource = tickets.Tickets;
        }
        private void ShowHelp()
        {

            MessageBox.Show("Menu for searching all tickets", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SearchTickets_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Search();
                    e.Handled = true;
                    break;
                case Keys.F1:
                    ShowHelp();
                    e.Handled = true;
                    break;
                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
                case Keys.Up:
                    MoveFocusUp();
                    e.Handled = true;
                    break;
                case Keys.Down:
                    MoveFocusDown();
                    e.Handled = true;
                    break;
                case Keys.Left:
                    MoveFocusLeft();
                    e.Handled = true;
                    break;
                case Keys.Right:
                    MoveFocusRight();
                    e.Handled = true;
                    break;
                case Keys.Tab:
                    if (e.Shift)
                    {

                        this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                    else
                    {

                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    e.Handled = true;
                    break;
            }
        }
        private void MoveFocusUp()
        {
            if (ActiveControl == txtArrival)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtRouteNumber.Focus();


            if (ActiveControl == txtName)
                txtSurname.Focus();


        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtRouteNumber)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtArrival.Focus();


            if (ActiveControl == txtName)
                txtSurname.Focus();

        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtRouteNumber)
                txtName.Focus();
            else if (ActiveControl == txtDeparture)
                txtName.Focus();
            else if (ActiveControl == txtArrival)
                txtSurname.Focus();


        }

        private void MoveFocusRight()
        {
            if (ActiveControl == txtName)
                txtRouteNumber.Focus();
            else if (ActiveControl == txtSurname)
                txtDeparture.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintTicket();

        }
       
            private void PrintTicket()
        {     
            var results = (List<Ticket>)dgvTickets.DataSource;

            if (results == null || !results.Any())
            {
                MessageBox.Show("No search results to print.");
                return;
            }
            string filePath = "";
            

            if (ticket!=null)
            {
                 filePath = $"{ticket.TicketID}.txt";
                            
            }

            if (File.Exists(filePath)==false&& ticket != null)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    writer.WriteLine(new string('-', 50));
                    writer.WriteLine($"Ticket ID: {ticket.TicketID}");
                    writer.WriteLine($"First Name: {ticket.FirstName}");
                    writer.WriteLine($"Last Name: {ticket.LastName}");
                    writer.WriteLine($"Route Number: {ticket.RouteNumber}");
                    foreach (BusRoute item in routes.BusRoutes)
                    {
                        if (ticket.RouteNumber == item.RouteNumber)
                        {
                            writer.WriteLine($"Bus Model: {item.Model}");

                            writer.WriteLine($"Carrier Company: {item.CarrierCompany}");
                            writer.WriteLine($"Price: {item.Price}");
                            foreach (var item1 in item.Stops)
                            {
                                if (ticket.DeparturePoint == item1)
                                {
                                   int i = item.Stops.IndexOf(item1);
                                    
                                    writer.WriteLine($"Departure Time: {item.Arrivals[i]}");
                                    writer.WriteLine($"Arrival Time: {item.Arrivals[i+1]}");
                                    string dep = item.DepartureDate.Date.ToShortDateString();
                                    string arr = item.DepartureDate.AddDays(item.TimeAdd[i]).Date.ToShortDateString();
                                    writer.WriteLine($"Departure Date: {dep}");
                                    writer.WriteLine($"Arrival Date: {arr}");
                                }
                               
                               
                            }
                            
                            writer.WriteLine($"Departure Point: {ticket.DeparturePoint}");
                            writer.WriteLine($"Arrival Point: {ticket.ArrivalPoint}");
                           
                            
                            writer.WriteLine(new string('-', 50));
                        }
                    }


                }

             

            }
            if (ticket!=null)
            {
                MessageBox.Show("Ticket search results printed successfully.");
                Process.Start("notepad.exe", filePath);
            }
            else
            {
                MessageBox.Show("Choose ticket to print");
            }

        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

             ticket = dgvTickets.Rows[e.RowIndex].DataBoundItem as Ticket;
           
        }
    }
}
