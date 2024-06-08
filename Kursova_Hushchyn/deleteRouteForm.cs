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
        private User user;
        public deleteRouteForm(RouteList routeList, TicketList ticketList, User user)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
            this.user = user;
            this.KeyPreview = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin==true)
            {
                Delete();
            }
            else
            {
                DeleteUser();
            }
            
        }

        private void DeleteUser()
        {
            string ticketNumber = txtTicketNumber.Text;

            if (string.IsNullOrWhiteSpace(ticketNumber))
            {
                MessageBox.Show("Please enter a valid ticket number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Ticket> list = ticketList.GetTicketsByID(ticketNumber);

            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Ticket not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ticket ticket = list[0];

            if (ticket.LastName != user.LastName || ticket.FirstName != user.FirstName)
            {
                MessageBox.Show("The ticket does not belong to the current user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ticketList.Tickets = ticketList.DeleteTicketByTicketID(ticketNumber);
            MessageBox.Show("Ticket successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Delete()
        {
            if (routeList.BusRoutes.Count < 1)
            {
                MessageBox.Show("You have nothing to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string routeNumber = txtRouteNumber.Text;
            string model = txtModel.Text;
            string carrierCompany = txtCarrier.Text;
            string ticketNumber = txtTicketNumber.Text;

            bool isDeleted = false;

            if (!string.IsNullOrWhiteSpace(routeNumber))
            {
                routeList.BusRoutes = routeList.RemoveRouteByRouteNumber(routeNumber);
                ticketList.Tickets = ticketList.DeleteTicketByRouteNumber(routeNumber);
                isDeleted = true;
            }

            if (!string.IsNullOrWhiteSpace(model))
            {
                ticketList.Tickets = ticketList.DeleteTicketByModel(model, routeList.BusRoutes);
                routeList.BusRoutes = routeList.RemoveRouteByModel(model);
                isDeleted = true;
            }

            if (!string.IsNullOrWhiteSpace(carrierCompany))
            {
                ticketList.Tickets = ticketList.DeleteTicketByCarrierCompany(carrierCompany, routeList.BusRoutes);
                routeList.BusRoutes = routeList.RemoveRouteByCarrierCompany(carrierCompany);
                isDeleted = true;
            }

            if (!string.IsNullOrWhiteSpace(ticketNumber))
            {
                ticketList.Tickets = ticketList.DeleteTicketByTicketID(ticketNumber);
                isDeleted = true;
            }

            if (isDeleted)
            {
                MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No valid input provided for deletion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ShowHelp()
        {

            MessageBox.Show("Menu for deleting", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (ActiveControl is TextBox || ActiveControl is ComboBox)
                    {
                        SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    else
                    {
                        Delete();
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

        private void deleteRouteForm_Load(object sender, EventArgs e)
        {
            if(user.IsAdmin) 
            {
                lblCarrier.Show();
                lblModel.Show();
                lblRouteNumber.Show();
                txtCarrier.Show();
                txtModel.Show();
                txtRouteNumber.Show();
            }
            else
            {
                lblCarrier.Hide();
                lblModel.Hide();
                lblRouteNumber.Hide();
                txtCarrier.Hide();
                txtModel.Hide();
                txtRouteNumber.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
