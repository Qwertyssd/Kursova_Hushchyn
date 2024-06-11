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
            
            this.KeyPreview = true; 
           
            this.routeList = routeList;
            this.ticketList = ticketList;
            this.userTicketList = userTicketList;
            this.userList = userList;
            this.user = user;
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            SearchRoutes();
        }
        public void SearchRoutes()
        {
            this.Hide();
            var searchRoutesForm = new SearchRoutesForm(routeList,ticketList);
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

            AddMoney();
        }
        private void AddMoney()
        {
            if (double.TryParse(txtMoney.Text,out double money)==true)
            {
                user.Money+=money;
            }
            else 
            {
                MessageBox.Show("Input amount of money");
            }
        }
        private void UserMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (ActiveControl is TextBox || ActiveControl is ComboBox || ActiveControl is DateTimePicker)
                    {
                        SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    else
                    {
                        AddMoney();
                    }
                   
                    e.Handled = true; break;
                case Keys.F1:
                    ShowHelp();
                    e.Handled = true; break;
                case Keys.Escape:
                    this.Close();
                    e.Handled = true; break;
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
        private void ShowHelp()
        {
            
            MessageBox.Show("Menu for navigating", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            deleteRouteForm deleteRoute = new deleteRouteForm(routeList,ticketList,user);
            this.Hide();
            deleteRoute.ShowDialog();
            this.Show();
        }
    }
}
