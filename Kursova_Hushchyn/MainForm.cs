using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_Hushchyn
{
    public partial class MainForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;
        private UserList  list;
        private User user;

        public MainForm(RouteList routeList, TicketList ticketList,UserList list,User user)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
            this.user = user;
            this.list = list;
           
            this.KeyPreview = true;


        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addRouteForm = new AddRouteForm(routeList);
            addRouteForm.ShowDialog();
           addRouteForm = null;
            this.Show();
        }

        private void btnSearchRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchRoutesForm = new SearchRoutesForm(routeList);
            searchRoutesForm.ShowDialog();
            this.Show();
        }

        private void btnTicketOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticketsForm = new ticketsForm(routeList, ticketList,user);
            ticketsForm.ShowDialog();
            this.Show();
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            var deleteRouteForm = new deleteRouteForm(routeList,ticketList,user);
            deleteRouteForm.ShowDialog();
            this.Show();
        }

        private void btnFileOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fileOperationsForm = new fileOperationsForm(routeList,ticketList);
            fileOperationsForm.ShowDialog();
            this.Show();
        }

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchTickets searchTickets = new SearchTickets(routeList, ticketList);
            searchTickets.ShowDialog();
            this.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
         
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.list.SaveToFile("users.txt");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                   
                        SelectNextControl(ActiveControl, true, true, true, true);
                    e.Handled = true;
                    break;
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

            MessageBox.Show("Menu for navigating for admin", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
