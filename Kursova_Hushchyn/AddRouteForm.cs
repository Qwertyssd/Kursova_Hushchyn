using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursova_Hushchyn
{
    public partial class AddRouteForm : Form
    {
        private RouteList routeList;
        public AddRouteForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.KeyPreview = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Add();
            
        }

        private void Add()
        {
            if (!TimeSpan.TryParse(txtStopsDuration.Text, out TimeSpan time))
            {
                MessageBox.Show("Invalid stops duration format. Please use the format HH:mm:ss.");
                return;
            }


            List<TimeSpan> Arrivals = new List<TimeSpan>();
            List<TimeSpan> Departures = new List<TimeSpan>();
            List<int> DateAdd = new List<int>();
            List<int> Capacity = new List<int>();
            foreach (DataGridViewRow row in dgvTravelDurations.Rows)
            {
                if (row.Cells["StopsTime"].Value != null)
                {
                    if (row.Cells["Date"].Value != null)
                    {
                        int date;
                        TimeSpan duration = new TimeSpan();
                        if (TimeSpan.TryParse(row.Cells["StopsTime"].Value.ToString(), out duration))
                        {
                            if (int.TryParse(row.Cells["Date"].Value.ToString(), out date))
                            {
                                Arrivals.Add(duration);
                                Capacity.Add(int.Parse(txtCapacity.Text));
                                TimeSpan timePotentially = time;
                                timePotentially.Add(Arrivals.Last());

                                if (duration.CompareTo(timePotentially) >= 0 && timePotentially != null)
                                {
                                    TimeSpan t = new TimeSpan();
                                    t = time.Add(duration);
                                    DateAdd.Add(date);
                                    Departures.Add(t);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid duration format. Time management");
                                    return;
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid duration format. Please use the format HH:mm:ss.");
                            return;
                        }
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model cannot be empty.");
                return;
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
                    new List<string>(txtStops.Text.Split(',')),
                    Capacity
                );

            routeList.AddRoute(route);
            MessageBox.Show("Route added successfully!");

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtModel.Clear();
            txtCapacity.Clear();
            chbConditioner.Checked = false;
            chbToilet.Checked = false;
            chbPowerOutlets.Checked = false;
            chbInternet.Checked = false;
            txtRouteNumber.Clear();
            txtCarrierCompany.Clear();
            txtPrice.Clear();
            txtDepartureDate.Clear();
           
            txtStops.Clear();
            txtCapacity.Clear();
            txtStopsDuration.Clear();
        }

        private void ShowHelp()
        {

            MessageBox.Show("Menu for registration", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RegisterUser_KeyDown(object sender, KeyEventArgs e)
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
                        Add(); 
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
            if (ActiveControl == txtStops)
                txtDepartureDate.Focus();
            else if (ActiveControl == txtDepartureDate)
                txtCarrierCompany.Focus();
            else if (ActiveControl == txtCarrierCompany)
                txtStopsDuration.Focus();
            else if (ActiveControl == txtStopsDuration)
                txtRouteNumber.Focus();

            if (ActiveControl == txtPrice)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtRouteNumber.Focus();

        }
        private void MoveFocusDown()
        {
            if (ActiveControl == txtStops)
                txtDepartureDate.Focus();
            else if (ActiveControl == txtDepartureDate)
                txtCarrierCompany.Focus();
            else if (ActiveControl == txtCarrierCompany)
                txtStopsDuration.Focus();
            else if (ActiveControl == txtStopsDuration)
                txtRouteNumber.Focus();

            if (ActiveControl == txtPrice)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtRouteNumber.Focus();
        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtModel)
                txtStopsDuration.Focus();
            else if (ActiveControl == txtPrice)
                txtCarrierCompany.Focus();

          
        }
        private void MoveFocusRight()
        {
            if (ActiveControl == txtStopsDuration)
                txtModel.Focus();
            else if (ActiveControl == txtCarrierCompany)
                txtPrice.Focus();
        }



    }
}
