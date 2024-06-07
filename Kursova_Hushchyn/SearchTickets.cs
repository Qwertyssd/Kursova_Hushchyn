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
    public partial class SearchTickets : Form
    {
        private RouteList routes = new RouteList();
        private TicketList tickets = new TicketList();
        public SearchTickets(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routes = routeList;
            this.tickets = ticketList;
            this.KeyPreview = true;
        }

        private void SearchTickets_Load(object sender, EventArgs e)
        {
            dgvTickets.DataSource = tickets.Tickets;
        }
        private void Search()
        {
            string name = string.IsNullOrEmpty(txtName.Text) ? null : txtName.Text;
            string surname = string.IsNullOrEmpty(txtSurname.Text) ? null : txtSurname.Text;
            string departurePoint = string.IsNullOrEmpty(txtDeparture.Text) ? null : txtDeparture.Text;
            string arrivalPoint = string.IsNullOrEmpty(txtArrival.Text) ? null : txtArrival.Text;
            string routeNumber = string.IsNullOrEmpty(txtRouteNumber.Text) ? null : txtRouteNumber.Text;
            TicketList list = new TicketList();
            list.Tickets = tickets.Tickets;

            if (name != null && surname != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, surname);
            }
            else if (name != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, 1);
            }
            else if (name != null)
            {
                list.Tickets = list.GetTicketsByPassenger(name, 1);
            }
            else if (departurePoint != null)
            {
                list.Tickets = list.GetTicketsByDeparturePoint(departurePoint);
            }
            else if (arrivalPoint != null)
            {
                list.Tickets = list.GetTicketsByArrivalPoint(arrivalPoint);
            }
            if (routeNumber != null)
            {
                list.Tickets = list.GetTicketsByRouteNumber(routeNumber);
            }
            if (list.Tickets.Count == 0)
            {
                MessageBox.Show("There are no tickets with given parameters");
                return;
            }
            dgvTickets.DataSource = list.Tickets;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvTickets.DataSource = tickets.Tickets;
        }
        private void ShowHelp()
        {

            MessageBox.Show("Menu for searching all tickets", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SearchTickets_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Search();
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
            }
        }
        private void MoveFocusUp()
        {
            if (ActiveControl == txtArrival)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtRouteNumber.Focus();


            if (ActiveControl == txtName)
                txtSurname.Focus();


        }

        private void MoveFocusDown()
        {
            if (ActiveControl == txtRouteNumber)
                txtDeparture.Focus();
            else if (ActiveControl == txtDeparture)
                txtArrival.Focus();


            if (ActiveControl == txtName)
                txtSurname.Focus();

        }

        private void MoveFocusLeft()
        {
            if (ActiveControl == txtRouteNumber)
                txtName.Focus();
            else if (ActiveControl == txtDeparture)
                txtName.Focus();
            else if (ActiveControl == txtArrival)
                txtSurname.Focus();


        }

        private void MoveFocusRight()
        {
            if (ActiveControl == txtName)
                txtRouteNumber.Focus();
            else if (ActiveControl == txtSurname)
                txtDeparture.Focus();

        }

    }
}
