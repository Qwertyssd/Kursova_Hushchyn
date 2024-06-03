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
                foreach (string stop in route.Stops)
                {
                    string tmp = stop;
                       
                    if ((tmp.Substring(0, inpLength)).ToLower()== departure.ToLower())
                    {
                        
                        int rowIndex = this.dgvShowDepartures.Rows.Add();
                        var row = this.dgvShowDepartures.Rows[rowIndex];
                        row.Cells["Departures"].Value = stop;
                        
                    }
                }
            }
        }

        private void dgvShowDepartures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
