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
        public deleteRouteForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (routeList.BusRoutes.Count < 1)
            {
                MessageBox.Show("You have nothing to delete");
            }
            else
            {
                RouteList routes = new RouteList();
                routes.BusRoutes = routeList.BusRoutes;
                string routeNumber = txtRouteNumber.Text;
                string model = txtModel.Text;
                string carrierCompany = txtCarrier.Text;
                if (routeNumber != null)
                {
                    routes.RemoveRouteByRouteNumber(routeNumber);
                }
                MessageBox.Show("Route deleted successfully!");
            }
            
        }
    }
}
