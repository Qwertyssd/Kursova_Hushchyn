using System;
using System.Collections;
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
        private User user;
        private string DeparturePoint { get; set; }
        private string ArrivalPoint { get; set; }
        private DateTime DateOfTrip { get; set; }
        public ticketsForm(RouteList routeList, TicketList ticketList, User user)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
            this.user = user;
            this.KeyPreview = true;
            txtDateOfTrip.Focus();
        }


        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            
            string departure = txtDeparture.Text;
            int inpLength = departure.Length;
            dgvShowDepartures.Rows.Clear();
            List<string> list = new List<string>();
            foreach (BusRoute route in routeList.BusRoutes)
            {
                if (DateOfTrip.Date==route.DepartureDate)
                {

                    foreach (string stop in route.Stops)
                    {
                        string tmp = stop;

                        if ((tmp.Substring(0, inpLength)).ToLower() == departure.ToLower())
                        {
                            if (list.Count == 0)
                            {
                                list.Add(stop);
                                int rowIndex = this.dgvShowDepartures.Rows.Add();
                                var row = this.dgvShowDepartures.Rows[rowIndex];
                                row.Cells["Departures"].Value = stop;
                            }
                            if (list.Contains(stop) == false)
                            {
                                list.Add(stop);
                                int rowIndex = this.dgvShowDepartures.Rows.Add();
                                var row = this.dgvShowDepartures.Rows[rowIndex];
                                row.Cells["Departures"].Value = stop;
                            }
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
            List<string> list = new List<string>();
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
                            if (list.Count == 0)
                            {
                                list.Add(stop);
                                int rowIndex = this.dgvShowArrivals.Rows.Add();
                                var row = this.dgvShowArrivals.Rows[rowIndex];
                                row.Cells["Arrivals"].Value = stop;
                                continue;
                            }
                           
                            
                                if (list.Contains(stop)==false)
                                {
                                    list.Add(stop);
                                    int rowIndex = this.dgvShowArrivals.Rows.Add();
                                    var row = this.dgvShowArrivals.Rows[rowIndex];
                                    row.Cells["Arrivals"].Value = stop;
                                }
                            
                            

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

        private void btnAddTicket_Click(object sender, EventArgs e)
        {

            AddTicket();
        }
       
        private void AddTicket()
        {
            if (DeparturePoint != null && ArrivalPoint != null)
            {
                this.Hide();
                createTicketForm createTicketForm = new createTicketForm(routeList, ticketList, DateOfTrip, DeparturePoint, ArrivalPoint, user);
                createTicketForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose departure and arrival points");
            }
        }
        private void MoveFocusUp()
        {
            if (ActiveControl == txtDateOfTrip)
                txtArrival.Focus();
            else if (ActiveControl == txtArrival)
                txtDeparture.Focus();
        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtDeparture)
                txtDateOfTrip.Focus();
            else if (ActiveControl == txtArrival)
                txtDateOfTrip.Focus();
           
            
        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtArrival)
                txtDeparture.Focus();
            if (ActiveControl == dgvShowArrivals)
                dgvShowDepartures.Focus();

        }

        private void MoveFocusRight()
        {
            if (ActiveControl == txtDeparture)
                txtArrival.Focus();

            if (ActiveControl == dgvShowDepartures)
                dgvShowArrivals.Focus();

        }
        private void ShowHelp()
        {

            MessageBox.Show("Menu for finding a route by city and date", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ticketsForm_KeyDown(object sender, KeyEventArgs e)
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
                        AddTicket();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
