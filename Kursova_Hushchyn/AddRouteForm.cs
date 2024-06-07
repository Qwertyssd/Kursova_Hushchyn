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
    public partial class AddRouteForm : Form
    {
        private RouteList routeList;
        public AddRouteForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan time = TimeSpan.Parse(txtStopsDuration.Text);
                List<TimeSpan> Arrivals = new List<TimeSpan>();
                List<TimeSpan> Departures = new List<TimeSpan>();
                List<int> DateAdd = new List<int>();
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
                    DateTime.Parse(txtDepartureDate.Text).AddDays(DateAdd[DateAdd.Count-1]),

                    
                    Arrivals,Departures, DateAdd,
                    new List<string>(txtStops.Text.Split(',')),
                    int.Parse(txtCapacity.Text)
                );

                routeList.AddRoute(route);
                MessageBox.Show("Route added successfully!");
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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


    }
}
