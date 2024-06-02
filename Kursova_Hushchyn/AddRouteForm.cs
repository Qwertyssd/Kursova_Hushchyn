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
                List<TimeSpan> travelDurations = new List<TimeSpan>();
                
                foreach (DataGridViewRow row in dgvTravelDurations.Rows)
                {
                    if (row.Cells["StopsTime"].Value != null)
                    {
                        TimeSpan duration = new TimeSpan();
                        if (TimeSpan.TryParse(row.Cells["StopsTime"].Value.ToString(), out duration ))
                        {
                            travelDurations.Add(duration);
                            TimeSpan timePotentially = time;
                            timePotentially.Add(travelDurations.Last());
                           
                            if (duration.CompareTo(timePotentially)>=0&&timePotentially!=null)
                            {
                                TimeSpan t = new TimeSpan();
                                t=time.Add(duration);
                               
                                travelDurations.Add(t);
                            }
                            else
                            {
                                MessageBox.Show("Invalid duration format. Time management");
                                return;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid duration format. Please use the format HH:mm:ss.");
                            return;
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
                      DateTime.Parse(txtArrivalDate.Text),
                    travelDurations,
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



        private void AddRouteForm_Load(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtStops_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
