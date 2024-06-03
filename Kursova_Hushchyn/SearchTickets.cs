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
    }
}
