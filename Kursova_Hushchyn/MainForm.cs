using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public MainForm(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;

            

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
            this.Hide();
            var addRouteForm = new AddRouteForm(routeList);
            addRouteForm.ShowDialog();
           addRouteForm = null;
            this.Show();
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchRoutesForm = new SearchRoutesForm(routeList);
            searchRoutesForm.ShowDialog();
            this.Show();
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticketsForm = new ticketsForm(routeList, ticketList);
            ticketsForm.ShowDialog();
            this.Show();
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteRouteForm = new deleteRouteForm(routeList,ticketList);
            deleteRouteForm.ShowDialog();
            this.Show();
        }

        private void btnFileOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fileOperationsForm = new fileOperationsForm(routeList,ticketList);
            fileOperationsForm.ShowDialog();
            this.Show();
        }

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchTickets searchTickets = new SearchTickets(routeList, ticketList);
            searchTickets.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
