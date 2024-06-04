using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public SearchTickets(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routes = routeList;
            this.tickets = ticketList;
        }

        private void SearchTickets_Load(object sender, EventArgs e)
        {
            dgvTickets.DataSource = tickets.Tickets;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = string.IsNullOrEmpty(txtName.Text)?null:txtName.Text;
            string surname = string.IsNullOrEmpty(txtSurname.Text)?null:txtSurname.Text;
            string departurePoint = string.IsNullOrEmpty(txtDeparture.Text)?null: txtDeparture.Text;
            string arrivalPoint = string.IsNullOrEmpty(txtArrival.Text)?null: txtArrival.Text;
            TicketList list = new TicketList();
            list.Tickets = tickets.Tickets;

            if (name != null && surname!=null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, surname);
            }
            else if (name!=null)
            {
                list.Tickets = list.GetTicketsByPassenger(name,1);
            }
            else if(name != null)
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
            if (list.Tickets.Count==0)
            {
                MessageBox.Show("There are no tickets with given parameters");
                return;
            }
            dgvTickets.DataSource = list.Tickets;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvTickets.DataSource=tickets.Tickets;
        }
    }
}
