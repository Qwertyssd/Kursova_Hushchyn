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
    public partial class createTicketForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;
        
        private DateTime DateOfTrip;
        private string DepartuePoint;
        private string ArrivalPoint;
        RouteList Sortedroutes = new RouteList();
        public createTicketForm(RouteList routeList, TicketList ticketList, DateTime dateOfTrip, string departuePoint, string arrivalPoint)
        {
            InitializeComponent();
           
            
            this.routeList = routeList;
            this.ticketList = ticketList; 
            DateOfTrip = dateOfTrip;
            DepartuePoint = departuePoint;
            ArrivalPoint = arrivalPoint;
        }

        private void createTicketForm_Load(object sender, EventArgs e)
        {
           
            Sortedroutes.BusRoutes = routeList.BusRoutes;

            Sortedroutes.BusRoutes = Sortedroutes.SearchRoutesByDepartureDate(DateOfTrip);
            Sortedroutes.BusRoutes = Sortedroutes.SearchRoutesByDepartureAndArrival(DepartuePoint,ArrivalPoint);
           
            dgvRoutes.DataSource = Sortedroutes.BusRoutes;

            txtDeparturePoint.Text = DepartuePoint;
            txtArrivalPoint.Text = ArrivalPoint;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            TimeSpan? departureTime = null;
            if (!string.IsNullOrWhiteSpace(txtDepartureTime.Text))
            {
                if (TimeSpan.TryParse(txtDepartureTime.Text, out TimeSpan time))
                {
                    departureTime = time;
                }

            }
            TimeSpan? arrivalTime = null;
            if (!string.IsNullOrWhiteSpace(txtArrivalTime.Text))
            {
                if (TimeSpan.TryParse(txtArrivalTime.Text, out TimeSpan time))
                {
                    arrivalTime = time;
                }

            }
                     
            string model = string.IsNullOrWhiteSpace(txtModel.Text) ? null : txtModel.Text;
            string carrierCompany = string.IsNullOrWhiteSpace(txtCarrierCompany.Text) ? null : txtCarrierCompany.Text;

            bool? hasAirConditioner = chbConditioner.Checked ? (bool?)chbConditioner.Checked : null;
            bool? hasToilet = chbToilet.Checked ? (bool?)chbToilet.Checked : null;
            bool? hasPowerOutlets = chbPowerOutlets.Checked ? (bool?)chbPowerOutlets.Checked : null;
            bool? hasInternet = chbInternet.Checked ? (bool?)chbInternet.Checked : null;
            double? priceLow = string.IsNullOrWhiteSpace(txtPriceLow.Text) ? -1 : (double?)double.Parse(txtPriceLow.Text);
            double? priceHigh = string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? -1 : (double?)double.Parse(txtPriceHigh.Text);
            

            RouteList routes = new RouteList();
            routes.BusRoutes = Sortedroutes.BusRoutes;

            if (model != null)
            {
                routes.BusRoutes = routes.SearchRoutesByModel(model);
            }

            if (hasAirConditioner != null)
            {
                routes.BusRoutes = routes.SearchRoutesByAirConditioner();
            }
            if (hasToilet != null)
            {
                routes.BusRoutes = routes.SearchRoutesByToilet();
            }
            if (hasPowerOutlets != null)
            {
                routes.BusRoutes = routes.SearchRoutesByPowerOutlets();
            }
            if (hasInternet != null)
            {
                routes.BusRoutes = routes.SearchRoutesByInternet();
            }
           
            if (carrierCompany != null)
            {
                routes.BusRoutes = routes.SearchRoutesByCarrierCompany(carrierCompany);
            }
            if ((priceLow != null && priceHigh != null) && priceHigh > priceLow)
            {
                routes.BusRoutes = routes.SearchRoutesByPrice(priceLow, priceHigh);
            }

            if (departureTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureTime((TimeSpan)departureTime);
            }
            if (arrivalTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrivalTime((TimeSpan)arrivalTime);
            }
            dgvRoutes.DataSource = routes.BusRoutes;

        }
        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSchedule.Rows.Clear();
            int rowIndex = this.dgvSchedule.Rows.Add();

            //Obtain a reference to the newly created DataGridViewRow 
            var row = this.dgvSchedule.Rows[rowIndex];

            //Now this won't fail since the row and columns exist 
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvRoutes.Rows.Count)
            {

                BusRoute selectedRoute = dgvRoutes.Rows[e.RowIndex].DataBoundItem as BusRoute;
                int countDep = 0;
                if (selectedRoute != null)
                {

                    txtRouteNumber.Text =selectedRoute.RouteNumber;
                    //string routeNumber = selectedRoute.RouteNumber;
                    //row.Cells["Stop"].Value = selectedRoute.Stops;

                    foreach (TimeSpan arrival in selectedRoute.Arrivals)
                    {

                        row.Cells["Arrival"].Value = arrival;
                        row.Cells["Departure"].Value = selectedRoute.Departures[countDep];
                        row.Cells["Stop"].Value = selectedRoute.Stops[countDep];
                        countDep++;
                        if (countDep < selectedRoute.Arrivals.Count)
                        {
                            rowIndex = this.dgvSchedule.Rows.Add();
                            row = this.dgvSchedule.Rows[rowIndex];
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string tID = (txtName.Text).Substring(0, 2) + "_" + (txtSurname.Text).Substring(0, 2)
               + "_" + (txtRouteNumber).Text +"_"+ ((DateTime.Now).Date).ToString();
            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime dateTime = DateTime.Parse(txtDOB.Text);
            string routeNumber = txtRouteNumber.Text;
            Ticket ticket = new Ticket(tID,name,surname,dateTime,routeNumber);
            ticketList.AddTicket(ticket);
        }
    }
}
