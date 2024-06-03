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
        public RouteList routeList;
        private TicketList ticketList;

        public MainForm()
        {
            InitializeComponent();
            this.routeList = new RouteList();
            this.ticketList = new TicketList();
            routeList.LoadRoutesFromFile("routes.txt");

            /*var route1 = new BusRoute(
             "Mercedes-Benz Sprinter", 20, true, false, true, true, "A101",
                "Speedy Travels",
                15.50,
                DateTime.Parse("2023-06-01 08:00"),
                DateTime.Parse("2023-06-01 12:00"),
                new List<TimeSpan> { TimeSpan.Parse("02:00:00"), TimeSpan.Parse("03:00:00"), TimeSpan.Parse("04:00:00") },
                new List<TimeSpan> { TimeSpan.Parse("02:20:00"), TimeSpan.Parse("03:20:00"), TimeSpan.Parse("04:20:00") },
                new List<string> { "City A", "City B", "City C", "City D" },
                10
            );
            routeList.AddRoute(route1);*/
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            var addRouteForm = new AddRouteForm(routeList);
            addRouteForm.Show();
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            var searchRoutesForm = new SearchRoutesForm(routeList);
            searchRoutesForm.Show();
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            var ticketsForm = new ticketsForm(routeList, ticketList);
            ticketsForm.Show();
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            var deleteRouteForm = new deleteRouteForm(routeList);
            deleteRouteForm.Show();
        }

        private void btnFileOperations_Click(object sender, EventArgs e)
        {
            var fileOperationsForm = new fileOperationsForm(routeList);
            fileOperationsForm.Show();
        }

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            SearchTickets searchTickets = new SearchTickets(routeList, ticketList);
            searchTickets.Show();
        }
    }
}
