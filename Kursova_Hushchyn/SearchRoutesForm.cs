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
    public partial class SearchRoutesForm : Form
    {
        private RouteList routeList;

        public SearchRoutesForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                // Validate and parse the departure date
                DateTime? departureDate = null;
                if (!string.IsNullOrWhiteSpace(txtDepartureDate.Text))
                {
                    if (DateTime.TryParse(txtDepartureDate.Text, out DateTime parsedDate))
                    {
                        departureDate = parsedDate;
                    }
                    
                }

                // Initialize search parameters
                string departure = string.IsNullOrWhiteSpace(txtDeparture.Text) ? null : txtDeparture.Text;
                string arrival = string.IsNullOrWhiteSpace(txtArrival.Text) ? null : txtArrival.Text;
                string intermediate = string.IsNullOrWhiteSpace(txtIntermediate.Text) ? null : txtIntermediate.Text;
                bool? hasAirConditioner = chbConditioner.Checked ? (bool?)chbConditioner.Checked : null;
                bool? hasToilet = chbToilet.Checked ? (bool?)chbToilet.Checked : null;
                bool? hasPowerOutlets = chbPowerOutlets.Checked ? (bool?)chbPowerOutlets.Checked : null;
                bool? hasInternet = chbInternet.Checked ? (bool?)chbInternet.Checked : null;

                int? capacity = null;
                if (!string.IsNullOrWhiteSpace(txtCapacity.Text))
                {
                    if (int.TryParse(txtCapacity.Text, out int parsedCapacity))
                    {
                        capacity = parsedCapacity;
                    }
                   
                }

            RouteList results = routeList;
                results.SearchRoutes(
                    departure,
                    arrival,
                    intermediate,
                    departureDate,
                    hasAirConditioner,
                    hasToilet,
                    hasPowerOutlets,
                    hasInternet,
                    capacity
                );

                // Display the routes (implement logic to show the routes in a grid or list)
                dgvRoutes.DataSource = results.BusRoutes;
        }


        

        private void btnView_Click(object sender, EventArgs e)
        {
            
            dgvRoutes.DataSource = routeList.BusRoutes;
           
        }
    }
}
