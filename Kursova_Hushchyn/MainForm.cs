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
    public partial class MainForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;

        public MainForm()
        {
            InitializeComponent();
            routeList = new RouteList();
            ticketList = new TicketList();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            var addRouteForm = new AddRouteForm(routeList);
            addRouteForm.Show();
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            /*var searchRoutesForm = new SearchRoutesForm(routeList);
            searchRoutesForm.Show();*/
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            /*var ticketForm = new TicketForm(routeList, ticketList);
            ticketForm.Show();*/
        }

 
    }
}
