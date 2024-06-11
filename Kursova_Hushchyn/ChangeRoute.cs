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
    public partial class ChangeRoute : Form
    {
        private BusRoute routeChange;
        private RouteList routeList;
        public TicketList ticketList;
        
        public ChangeRoute(BusRoute route, RouteList routeList,TicketList ticketList)
        {
            InitializeComponent();
            this.routeChange = route;
            this.routeList = routeList;
            this.ticketList = ticketList;
            LoadRouteDetails();
        }
       
            private void LoadRouteDetails()
            {
            foreach (BusRoute bus in routeList.BusRoutes)
            {
                if (bus== routeChange)
                {
                    txtRouteNumber.Text = routeChange.RouteNumber;
                    txtModel.Text = routeChange.Model;
                    txtCarrierCompany.Text = routeChange.CarrierCompany;
                    txtDepartureDate.Text = routeChange.DepartureDate.ToString();

                    txtPrice.Text = routeChange.Price.ToString();
                    txtCapacity.Text = routeChange.PassengerCapacity.ToString();
                    chbConditioner.Checked = routeChange.HasAirConditioner;
                    chbToilet.Checked = routeChange.HasToilet;
                    chbPowerOutlets.Checked = routeChange.HasPowerOutlets;
                    chbInternet.Checked = routeChange.HasInternet;

                    dgvSchedule.Rows.Clear();
                    int rowIndex = this.dgvSchedule.Rows.Add();


                    var row = this.dgvSchedule.Rows[rowIndex];

                    

                      
                        int countDep = 0;
                        if (bus != null)
                        {



                            foreach (TimeSpan arrival in bus.Arrivals)
                            {

                                row.Cells["Arrival"].Value = arrival;
                                row.Cells["Departure"].Value = bus.Departures[countDep];
                                row.Cells["Stop"].Value = bus.Stops[countDep];
                                row.Cells["Date"].Value = bus.TimeAdd[countDep];
                                countDep++;
                                if (countDep < bus.Arrivals.Count)
                                {
                                    rowIndex = this.dgvSchedule.Rows.Add();
                                    row = this.dgvSchedule.Rows[rowIndex];
                                }


                            }




                        
                    }
                    return;
                }
            }
           
            }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Change();

                MessageBox.Show("Route details updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the route details: {ex.Message}");
            }
        }
        private void Change()
        {
            RouteList routeList1 = new RouteList();
           
            
            
         
            foreach (var item in routeList.BusRoutes)
            {
                if (item!= routeChange)
                {
                    routeList1.BusRoutes.Add(item);
                }
            }
          routeList.BusRoutes.Clear();
            routeList.BusRoutes = routeList1.BusRoutes;

            List<TimeSpan> Arrivals = new List<TimeSpan>();
            List<TimeSpan> Departures = new List<TimeSpan>();
            List<int> DateAdd = new List<int>();
            List<int> AvailableSeats = new List<int>();
            List<string> Stops = new List<string>();
            int i = 0;
            
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.Cells["Arrival"].Value != null)
                {
                    if (row.Cells["Departure"].Value != null)
                    {
                        if (row.Cells["Stop"].Value != null)
                        {
                            if (row.Cells["Date"].Value != null)
                            {
                                int date;
                               
                                TimeSpan arrival = new TimeSpan();
                                TimeSpan departure = new TimeSpan();
                                if (TimeSpan.TryParse(row.Cells["Arrival"].Value.ToString(), out arrival))
                                {
                                    if (TimeSpan.TryParse(row.Cells["Departure"].Value.ToString(), out departure))
                                    {
                                        if (int.TryParse(row.Cells["Date"].Value.ToString(), out date))
                                        {
                                            if (int.TryParse(txtCapacity.Text, out int Capacity))
                                            {
                                                Arrivals.Add(arrival);
                                                Departures.Add(departure);
                                                Stops.Add((row.Cells["Stop"].Value.ToString()));
                                                DateAdd.Add(date);
                                                AvailableSeats.Add(Capacity);
                                                i++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }

            if (!int.TryParse(txtCapacity.Text, out int passengerCapacity))
            {
                MessageBox.Show("Invalid passenger capacity. Please enter a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRouteNumber.Text))
            {
                MessageBox.Show("Route number cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCarrierCompany.Text))
            {
                MessageBox.Show("Carrier company cannot be empty.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            if (!DateTime.TryParse(txtDepartureDate.Text, out DateTime departureDate))
            {
                MessageBox.Show("Invalid departure date format. Please use the format MM/dd/yyyy.");
                return;
            }

            if (DateAdd.Count == 0)
            {
                MessageBox.Show("No stops data found. Please enter stops information.");
                return;
            }
            if (Departures.Count != DateAdd.Count)
            {
                MessageBox.Show("Not enough data given");
                return;
            }
            BusRoute route = new BusRoute(
                    txtModel.Text,
                    int.Parse(txtCapacity.Text),
                    chbConditioner.Checked,
                    chbToilet.Checked,
                    chbPowerOutlets.Checked,
                    chbInternet.Checked,
                    txtRouteNumber.Text,
                    txtCarrierCompany.Text,
                    double.Parse(txtPrice.Text),
                    DateTime.Parse(txtDepartureDate.Text),
                    DateTime.Parse(txtDepartureDate.Text).AddDays(DateAdd[DateAdd.Count - 1]),


                    Arrivals, Departures, DateAdd,
                    Stops,
                    routeChange.AvailableSeats
                );

            routeList.AddRoute(route);
            bool isChanged = false;

           
            if (route.Stops.Count != routeChange.Stops.Count)
            {
                isChanged = true;
            }
            else
            {
               
                if (route.Arrivals.Count != route.Stops.Count ||
                    route.Departures.Count != route.Stops.Count ||
                    routeChange.Arrivals.Count != route.Stops.Count ||
                    routeChange.Departures.Count != route.Stops.Count ||
                    route.TimeAdd.Count != route.Stops.Count ||
                    routeChange.TimeAdd.Count != route.Stops.Count)
                {
                    isChanged = true;
                }

                for (int j = 0; j < route.Stops.Count; j++)
                {
                    if (route.Stops[j] != routeChange.Stops[j] ||
                        route.Arrivals[j] != routeChange.Arrivals[j] ||
                        route.Departures[j] != routeChange.Departures[j] ||
                        route.DepartureDate != routeChange.DepartureDate ||
                        route.TimeAdd[j] != routeChange.TimeAdd[j])
                    {
                        isChanged = true;
                        break;
                    }
                }
            }

            if (isChanged)
            {
                ticketList.Tickets = ticketList.DeleteTicketByRouteNumber(route.RouteNumber);
            }
            foreach (BusRoute bus in routeList.BusRoutes)
            {
                int k = 0;
                if (bus.RouteNumber == route.RouteNumber)
                {
                    foreach (var stop in bus.Stops)
                    {
                       
                            bus.AvailableSeats[k]=int.Parse(txtCapacity.Text);
                       
                        k++;
                    }

                }

            }




            this.Close();
        }
    }
}
