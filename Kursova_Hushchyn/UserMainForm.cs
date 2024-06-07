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
    public partial class UserMainForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;
        private TicketList userTicketList;
        private UserList userList;
        private User user;
        public UserMainForm(RouteList routeList, TicketList ticketList, TicketList userTicketList, UserList userList, User user)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
            this.userTicketList = userTicketList;
            this.userList = userList;
            this.user = user;
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchRoutesForm = new SearchRoutesForm(routeList);
            searchRoutesForm.ShowDialog();
            this.Show();
        }

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            userTicketList.Tickets = ticketList.GetTicketsByPassenger(user.FirstName, user.LastName);
            SearchTickets searchTickets = new SearchTickets(routeList, userTicketList);
            searchTickets.ShowDialog();
            this.Show();
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticketsForm = new ticketsForm(routeList, ticketList,user);
            ticketsForm.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userList.SaveToFile("users.txt");
            routeList.SaveRoutesToFile("routes.txt");
            ticketList.SaveTicketsToFile("tickets.txt");
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            user.Money = double.Parse(txtMoney.Text);
        }
    }
}
