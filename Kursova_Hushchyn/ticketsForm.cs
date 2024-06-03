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
    public partial class ticketsForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;
        private string DeparturePoint { get; set; }
        private string ArrivalPoint { get; set; }
        private DateTime DateOfTrip { get; set; }
        public ticketsForm(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routeList = routeList;
            ticketList = new TicketList();
        }


        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            
            string departure = txtDeparture.Text;
            int inpLength = departure.Length;
            dgvShowDepartures.Rows.Clear();
            foreach (BusRoute route in routeList.BusRoutes)
            {
                if (DateOfTrip.Date==route.DepartureDate)
                {

                    foreach (string stop in route.Stops)
                    {
                        string tmp = stop;

                        if ((tmp.Substring(0, inpLength)).ToLower() == departure.ToLower())
                        {

                            int rowIndex = this.dgvShowDepartures.Rows.Add();
                            var row = this.dgvShowDepartures.Rows[rowIndex];
                            row.Cells["Departures"].Value = stop;

                        }
                    }
                }
            }
        }

        private void dgvShowDepartures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            if (e.RowIndex >= 0 && e.RowIndex < dgvShowDepartures.Rows.Count)
            {

                string point = dgvShowDepartures.Rows[e.RowIndex].Cells["Departures"].Value as string;
                this.DeparturePoint = point;
            }
        }

        private void txtArrival_TextChanged(object sender, EventArgs e)
        {
            string arrival = txtArrival.Text;
            int inpLength = arrival.Length;
            bool cathced = false;
            dgvShowArrivals.Rows.Clear();
            foreach (BusRoute route in routeList.BusRoutes)
            {
                if (DateOfTrip.Date == route.DepartureDate)
                {
                    foreach (string stop in route.Stops)
                    {
                        string tmp = stop;

                        if (tmp.Substring(0, inpLength).ToLower() == arrival.ToLower() && cathced == true)
                        {
                            int rowIndex = this.dgvShowArrivals.Rows.Add();
                            var row = this.dgvShowArrivals.Rows[rowIndex];
                            row.Cells["Arrivals"].Value = stop;
                        }
                        if (stop == DeparturePoint)
                        {
                            cathced = true;
                        }
                    }
                    cathced = false;

                }
            }
        }

        private void dgvShowArrivals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvShowDepartures.Rows.Count)
            {

                string point = dgvShowArrivals.Rows[e.RowIndex].Cells["Arrivals"].Value as string;
                this.ArrivalPoint = point;
            }
        }

        private void txtDateOfTrip_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDateOfTrip.Text))
            {
                if (DateTime.TryParse(txtDateOfTrip.Text, out DateTime parsedDate))
                {
                    DateOfTrip = parsedDate;
                    

                }
            }           
        }
    }
}
