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
        public RouteList routeList;

        public string SelectedRoute {  get; set; }
        public SearchRoutesForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
          
            this.KeyPreview = true;
        }

        private void Search()
        {

            DateTime? departureDate = null;
            if (!string.IsNullOrWhiteSpace(txtDepartureDate.Text))
            {
                if (DateTime.TryParse(txtDepartureDate.Text, out DateTime parsedDate))
                {
                    departureDate = parsedDate;
                }

            }
            DateTime? arrivalDate = null;
            if (!string.IsNullOrWhiteSpace(txtArrivalDate.Text))
            {
                if (DateTime.TryParse(txtArrivalDate.Text, out DateTime parsedDate))
                {
                    arrivalDate = parsedDate;
                }

            }
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

            string departure = string.IsNullOrWhiteSpace(txtDeparture.Text) ? null : txtDeparture.Text;
            string arrival = string.IsNullOrWhiteSpace(txtArrival.Text) ? null : txtArrival.Text;
            string intermediate = string.IsNullOrWhiteSpace(txtIntermediate.Text) ? null : txtIntermediate.Text;
            string model = string.IsNullOrWhiteSpace(txtModel.Text) ? null : txtModel.Text;
            string carrierCompany = string.IsNullOrWhiteSpace(txtCarrierCompany.Text) ? null : txtCarrierCompany.Text;
            string routeNumber = string.IsNullOrWhiteSpace(txtRouteNumber.Text) ? null : txtRouteNumber.Text;
            bool? hasAirConditioner = chbConditioner.Checked ? (bool?)chbConditioner.Checked : null;
            bool? hasToilet = chbToilet.Checked ? (bool?)chbToilet.Checked : null;
            bool? hasPowerOutlets = chbPowerOutlets.Checked ? (bool?)chbPowerOutlets.Checked : null;
            bool? hasInternet = chbInternet.Checked ? (bool?)chbInternet.Checked : null;
            double? priceLow = string.IsNullOrWhiteSpace(txtPriceLow.Text) ? -1 : (double?)double.Parse(txtPriceLow.Text);
            double? priceHigh = string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? -1 : (double?)double.Parse(txtPriceHigh.Text);
            int? capacity = null;
            if (!string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                if (int.TryParse(txtCapacity.Text, out int parsedCapacity))
                {
                    capacity = parsedCapacity;
                }

            }

            RouteList routes = new RouteList();
            routes.BusRoutes = routeList.BusRoutes;

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
            if (routeNumber != null)
            {
                routes.BusRoutes = routes.SearchRoutesByRouteNumber(routeNumber);
            }
            if (carrierCompany != null)
            {
                routes.BusRoutes = routes.SearchRoutesByCarrierCompany(carrierCompany);
            }
            if ((priceLow != null && priceHigh != null) && priceHigh > priceLow)
            {
                routes.BusRoutes = routes.SearchRoutesByPrice(priceLow, priceHigh);
            }

            if (departureDate != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureDate((DateTime)departureDate);
            }
            if (arrivalDate != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrivalDate((DateTime)arrivalDate);
            }
            if (departureTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureTime((TimeSpan)departureTime);
            }
            if (arrivalTime != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrivalTime((TimeSpan)arrivalTime);
            }
            if (departure != null && arrival != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDepartureAndArrival(departure, arrival);
            }
            else if (departure != null)
            {
                routes.BusRoutes = routes.SearchRoutesByDeparture(departure);
            }
            else if (arrival != null)
            {
                routes.BusRoutes = routes.SearchRoutesByArrival(arrival);
            }
            
            dgvRoutes.DataSource = routes.BusRoutes;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            Search();
        }




        private void btnView_Click(object sender, EventArgs e)
        {

            dgvRoutes.DataSource = routeList.BusRoutes;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSchedule.Rows.Clear();
            int rowIndex = this.dgvSchedule.Rows.Add();

          
            var row = this.dgvSchedule.Rows[rowIndex];
            
           
           
            if (e.RowIndex >= 0 && e.RowIndex < dgvRoutes.Rows.Count)
            {
                
                BusRoute selectedRoute = dgvRoutes.Rows[e.RowIndex].DataBoundItem as BusRoute;
                int countDep = 0;
                if (selectedRoute != null)
                {
                    SelectedRoute = selectedRoute.RouteNumber;
                 
                   
                    foreach (TimeSpan arrival in selectedRoute.Arrivals)
                    {
                        
                        row.Cells["Arrival"].Value = arrival;
                        row.Cells["Departure"].Value = selectedRoute.Departures[countDep];
                        row.Cells["Stop"].Value = selectedRoute.Stops[countDep];
                        row.Cells["Date"].Value = (selectedRoute.DepartureDate.AddDays(selectedRoute.TimeAdd[countDep]));
                        countDep++;
                        if (countDep< selectedRoute.Arrivals.Count)
                        {
                            rowIndex = this.dgvSchedule.Rows.Add();
                            row = this.dgvSchedule.Rows[rowIndex];
                        }
                        



                    }
                    
                    

                }
            }
        }

        private void rbHighToLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHighToLow.Checked == true)
            {
                rbLowToHigh.Checked = false;

               routeList.BusRoutes= routeList.SortByPriceHighToLow();
               
                dgvRoutes.DataSource=routeList.BusRoutes;
                dgvRoutes.Refresh();
            }
        }

        private void rbLowToHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLowToHigh.Checked == true)
            {
                rbHighToLow.Checked = false;

                routeList.BusRoutes = routeList.SortByPriceLowToHigh();
                dgvRoutes.DataSource = routeList.BusRoutes;
                dgvRoutes.Refresh();
            }
        }

        private void UserMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (ActiveControl is TextBox || ActiveControl is ComboBox)
                    {
                        SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    else
                    {
                        Search();
                    }
                    
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
            if (ActiveControl == txtIntermediate)
                txtArrival.Focus();
            else if (ActiveControl == txtArrival)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtArrivalDate.Focus();
            else if (ActiveControl == txtArrivalDate)
                txtDepartureDate.Focus();
            else if (ActiveControl == txtDepartureDate)
                txtCapacity.Focus();
            else if (ActiveControl == txtCapacity)
                txtCarrierCompany.Focus();

            if (ActiveControl == txtArrivalTime)
                txtDepartureTime.Focus();
            else if (ActiveControl == txtDepartureTime)
                txtPriceHigh.Focus();
            else if (ActiveControl == txtPriceHigh)
                txtPriceLow.Focus();
            else if (ActiveControl == txtPriceLow)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtRouteNumber.Focus();
           
        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtCarrierCompany)
                txtCapacity.Focus();
            else if (ActiveControl == txtCapacity)
                txtDepartureDate.Focus();
            else if (ActiveControl == txtDepartureDate)
                txtArrivalDate.Focus();
            else if (ActiveControl == txtArrivalDate)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtArrival.Focus();
            else if (ActiveControl == txtArrival)
                txtIntermediate.Focus();

            if (ActiveControl == txtRouteNumber)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtPriceLow.Focus();
            else if (ActiveControl == txtPriceLow)
                txtPriceHigh.Focus();
            else if (ActiveControl == txtPriceHigh)
                txtDepartureTime.Focus();
            else if (ActiveControl == txtDepartureTime)
                txtArrivalTime.Focus();
        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtRouteNumber)
                txtCarrierCompany.Focus();
            else if (ActiveControl == txtModel)
                txtCapacity.Focus();
            else if (ActiveControl == txtPriceLow)
                txtDepartureDate.Focus();
            else if (ActiveControl == txtPriceHigh)
                txtArrivalDate.Focus();
            else if (ActiveControl == txtDepartureTime)
                txtDeparture.Focus();
            else if (ActiveControl == txtArrivalTime)
                txtArrival.Focus();
           
        }

        private void MoveFocusRight()
        {
            if (ActiveControl == txtCarrierCompany)
                txtRouteNumber.Focus();
            else if (ActiveControl == txtCapacity)
                txtModel.Focus();
            else if (ActiveControl == txtDepartureDate)
                txtPriceLow.Focus();
            else if (ActiveControl == txtArrivalDate)
                txtPriceHigh.Focus();
            else if (ActiveControl == txtDeparture)
                txtDepartureTime.Focus();
            else if (ActiveControl == txtArrival)
                txtArrivalTime.Focus();
            else if (ActiveControl == txtIntermediate)
                txtArrivalTime.Focus();
        }

        private void ShowHelp()
        {

            MessageBox.Show("Menu for searching all availible roads", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
