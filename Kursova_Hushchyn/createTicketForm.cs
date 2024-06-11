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
        public RouteList routeList;
        public TicketList ticketList;
        public User user;
        
        private DateTime DateOfTrip;
        private string DepartuePoint;
        private string ArrivalPoint;
        RouteList Sortedroutes = new RouteList();
        public createTicketForm(RouteList routeList, TicketList ticketList, DateTime dateOfTrip, string departuePoint, string arrivalPoint, User user)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.user = user;
            this.routeList = routeList;
            this.ticketList = ticketList; 
            DateOfTrip = dateOfTrip;
            DepartuePoint = departuePoint;
            ArrivalPoint = arrivalPoint;
        }

        private void createTicketForm_Load(object sender, EventArgs e)
        {
            txtDOB.Text = user.DateOfBirth.ToString();
            txtName.Text=user.FirstName.ToString();
            txtSurname.Text=user.LastName.ToString();
            Sortedroutes.BusRoutes = routeList.BusRoutes;

            Sortedroutes.BusRoutes = Sortedroutes.SearchRoutesByDepartureDate(DateOfTrip);
            Sortedroutes.BusRoutes = Sortedroutes.SearchRoutesByDepartureAndArrival(DepartuePoint,ArrivalPoint);
           
            dgvRoutes.DataSource = Sortedroutes.BusRoutes;

            txtDeparturePoint.Text = DepartuePoint;
            txtArrivalPoint.Text = ArrivalPoint;


        }

        private void Search()
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
            double? priceLow = string.IsNullOrWhiteSpace(txtPriceLow.Text) ? null : (double?)double.Parse(txtPriceLow.Text);
            double? priceHigh = string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? null : (double?)double.Parse(txtPriceHigh.Text);


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
            if (priceLow != null && priceHigh == null)
            {
                routes.BusRoutes = routes.SearchRoutesByPriceLow(priceLow);
            }
            else if (priceLow == null && priceHigh != null)
            {
                routes.BusRoutes = routes.SearchRoutesByPriceHigh(priceHigh);
            }
            else if ((priceHigh != null && priceHigh != null) && priceLow < priceHigh)
            {
                routes.BusRoutes = routes.SearchRoutesByPriceHigh(priceHigh);
                routes.BusRoutes = routes.SearchRoutesByPriceLow(priceLow);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {

            Search();
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
            if (!string.IsNullOrWhiteSpace(txtName.Text)&& !string.IsNullOrWhiteSpace(txtSurname.Text) && !string.IsNullOrWhiteSpace(txtDOB.Text))
            {
                RouteList list = new RouteList();
                list.BusRoutes = routeList.BusRoutes;
                list.BusRoutes = list.SearchRoutesByRouteNumber(txtRouteNumber.Text);
                if (user.Money >= list.BusRoutes[0].Price||user.IsAdmin==true)
                {
                    if(user.IsAdmin==false)
                    {
                        user.Money -= list.BusRoutes[0].Price;
                    }
                 
                    string tID = (txtName.Text).Substring(0, 2) + "_" + (txtSurname.Text).Substring(0, 2)
                   + "_" + (txtRouteNumber).Text + "_" + ((DateTime.Now).Day).ToString()
                   + "_" + ((DateTime.Now).Month).ToString() + "_" + ((DateTime.Now).Year).ToString();
                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    DateTime dateTime = DateTime.Parse(txtDOB.Text);
                    string routeNumber = txtRouteNumber.Text;
                    string departure = txtDeparturePoint.Text;
                    string arrival = txtArrivalPoint.Text;
                    int i = 0;
                    bool isDep = false;
                    foreach (var item in list.BusRoutes[0].Stops)
                    {
                        if (item == departure)
                        {
                            isDep = true;
                        }
                        if (isDep==true)
                        {
                            if (list.BusRoutes[0].AvailableSeats[i]<=0)
                            {
                                MessageBox.Show("Not enough seats");
                                return;
                            }
                        }
                        if (item == arrival)
                        {
                            isDep = false;
                        }
                        i++;
                    }
                    Ticket ticket = new Ticket(tID, name, surname, dateTime, routeNumber, departure, arrival);
                    ticketList.AddTicket(ticket);

                    routeList.BusRoutes = routeList.DecreaseSeat(routeNumber,departure,arrival);
                    MessageBox.Show("Ticket created sucessfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not enough money");
                }
            }
            else
            {
                MessageBox.Show("Input your personal data");
            }
        }

       

        private void rbHighToLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHighToLow.Checked == true)
            {
                rbLowToHigh.Checked = false;

                Sortedroutes.BusRoutes = Sortedroutes.SortByPriceHighToLow();

                dgvRoutes.DataSource = Sortedroutes.BusRoutes;
                dgvRoutes.Refresh();
            }
        }

        private void rbLowToHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLowToHigh.Checked == true)
            {
                rbHighToLow.Checked = false;

                Sortedroutes.BusRoutes = Sortedroutes.SortByPriceLowToHigh();
                dgvRoutes.DataSource = Sortedroutes.BusRoutes;
                dgvRoutes.Refresh();
            }
        }


        private void MoveFocusUp()
        {
           
            if (ActiveControl == txtArrivalTime)
                txtDepartureTime.Focus();
            else if (ActiveControl == txtDepartureTime)
                txtPriceHigh.Focus();
            else if (ActiveControl == txtPriceHigh)
                txtPriceLow.Focus();
            else if (ActiveControl == txtPriceLow)
                txtModel.Focus();
           
            else if (ActiveControl == txtModel)
                txtCarrierCompany.Focus();
            else if (ActiveControl == txtDOB)
                txtSurname.Focus();
             else if (ActiveControl == txtSurname)
                txtSurname.Focus();


        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtCarrierCompany)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtPriceLow.Focus();
            else if (ActiveControl == txtPriceLow)
                txtPriceHigh.Focus();
            else if (ActiveControl == txtPriceHigh)
                txtDepartureTime.Focus();
            else if (ActiveControl == txtDepartureTime)
                txtArrivalTime.Focus();
            else if (ActiveControl == txtSurname)
                txtDOB.Focus();
            else if (ActiveControl == txtDOB)
                txtCarrierCompany.Focus();
        }

        private void ShowHelp()
        {

            MessageBox.Show("Menu for creating ticket", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createTicketForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
