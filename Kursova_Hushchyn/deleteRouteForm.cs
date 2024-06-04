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
    public partial class deleteRouteForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;
        public deleteRouteForm(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (routeList.BusRoutes.Count < 1)
            {
                MessageBox.Show("You have nothing to delete");
            }
            else
            {
               
                string routeNumber = txtRouteNumber.Text;
                string model = txtModel.Text;
                string carrierCompany = txtCarrier.Text;
                if (routeNumber != null)
                {
                    routeList.BusRoutes = routeList.RemoveRouteByRouteNumber(routeNumber);
                    ticketList.Tickets = ticketList.DeleteTicketByRouteNumber(routeNumber);
                }
                if (model!=null)
                {
                    ticketList.Tickets = ticketList.DeleteTicketByModel(model, routeList.BusRoutes);
                    routeList.BusRoutes = routeList.RemoveRouteByModel(model);
                    
                }
                if (carrierCompany!=null)
                {
                    ticketList.Tickets = ticketList.DeleteTicketByCarrierCompany(carrierCompany, routeList.BusRoutes);
                    routeList.BusRoutes = routeList.RemoveRouteByCarrierCompany(carrierCompany);
                }
                MessageBox.Show("Route deleted successfully!");
            }
            
        }
    }
}
