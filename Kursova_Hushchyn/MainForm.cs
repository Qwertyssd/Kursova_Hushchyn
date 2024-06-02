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
            var route1 = new BusRoute(
             "Mercedes-Benz Sprinter", 20, true, false, true, true, "A101",
    "Speedy Travels",
    15.50,
    DateTime.Parse("2023-06-01 08:00"),
    DateTime.Parse("2023-06-01 12:00"),
    new List<TimeSpan> { TimeSpan.Parse("02:00:00"), TimeSpan.Parse("01:00:00"), TimeSpan.Parse("01:00:00") },
    new List<string> { "City A", "City B", "City C", "City D" },
    10
);
            var route2 = new BusRoute(
    "Volvo 9700",
    50,
    true,
    true,
    false,
    false,
    "B202",
    "Comfortable Travels",
    30.00,
    DateTime.Parse("2023-06-02 09:00"),
    DateTime.Parse("2023-06-02 18:00"),
    new List<TimeSpan> { TimeSpan.Parse("03:00:00"), TimeSpan.Parse("02:00:00"), TimeSpan.Parse("04:00:00") },
    new List<string> { "City E", "City F", "City G", "City H" },
    25
);
            var route3 = new BusRoute(
    "MAN Lion's Coach",
    40,
    false,
    true,
    true,
    true,
    "C303",
    "Budget Bus Lines",
    20.00,
    DateTime.Parse("2023-06-03 10:00"),
    DateTime.Parse("2023-06-03 14:00"),
    new List<TimeSpan> { TimeSpan.Parse("01:30:00"), TimeSpan.Parse("02:30:00") },
    new List<string> { "City I", "City J", "City K" },
    15
);
            var route4 = new BusRoute(
    "Setra S 417",
    45,
    true,
    false,
    false,
    true,
    "D404",
    "Luxury Lines",
    50.00,
    DateTime.Parse("2023-06-04 07:00"),
    DateTime.Parse("2023-06-04 13:00"),
    new List<TimeSpan> { TimeSpan.Parse("02:00:00"), TimeSpan.Parse("01:00:00"), TimeSpan.Parse("03:00:00") },
    new List<string> { "City L", "City M", "City N", "City O" },
    30
);


            routeList.AddRoute(route1); routeList.AddRoute(route2);
            routeList.AddRoute(route3); routeList.AddRoute(route4);
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
            /*var ticketForm = new TicketForm(routeList, ticketList);
            ticketForm.Show();*/
        }

 
    }
}
