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
            this.KeyPreview = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Delete();
        }

        private void Delete()
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
                string ticketNumber = txtTicketNumber.Text;
                if (routeNumber != null)
                {
                    routeList.BusRoutes = routeList.RemoveRouteByRouteNumber(routeNumber);
                    ticketList.Tickets = ticketList.DeleteTicketByRouteNumber(routeNumber);
                }
                if (model != null)
                {
                    ticketList.Tickets = ticketList.DeleteTicketByModel(model, routeList.BusRoutes);
                    routeList.BusRoutes = routeList.RemoveRouteByModel(model);

                }
                if (carrierCompany != null)
                {
                    ticketList.Tickets = ticketList.DeleteTicketByCarrierCompany(carrierCompany, routeList.BusRoutes);
                    routeList.BusRoutes = routeList.RemoveRouteByCarrierCompany(carrierCompany);
                }
                if (ticketNumber != null)
                {
                    ticketList.Tickets = ticketList.DeleteTicketByTicketID(ticketNumber);
                }

                MessageBox.Show("Done!");

            }
        }
       
        private void ShowHelp()
        {

            MessageBox.Show("Menu for deleting Routes", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MoveFocusUp()
        {
            if (ActiveControl == txtCarrier)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtRouteNumber.Focus();
            else if (ActiveControl == txtRouteNumber)
                txtTicketNumber.Focus();
        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtTicketNumber)
                txtRouteNumber.Focus();
            else if (ActiveControl == txtRouteNumber)
                txtModel.Focus();
            else if (ActiveControl == txtModel)
                txtCarrier.Focus();
           
        }

        private void deleteRouteForm_KeyDown(object sender, KeyEventArgs e)
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
                    Delete(); e.Handled = true;
                    break;

            }
        }
    }
}
