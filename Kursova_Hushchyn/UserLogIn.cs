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
    public partial class UserLogIn : Form
    {
        List<User> users = new List<User>();
        User admin = new User("admin", "admin",DateTime.Parse("07/12/2005 00:00:00"),"admin@gmail.com","admin",true);
        User justUser = new User("Mykhailo", "Hushchyn", DateTime.Parse("07/12/2005 00:00:00"), "user@gmail.com", "user", false);
        private RouteList routeList;
        private TicketList ticketList;
        private TicketList userTickets;
        public UserLogIn()
        {

            InitializeComponent();
            this.routeList = new RouteList();
            this.ticketList = new TicketList();
            this.userTickets = new TicketList();
            users.Add(justUser);
            users.Add(admin);
            if (File.Exists("routes.txt"))
            {
                FileInfo fileInfo = new FileInfo("routes.txt");
                if (fileInfo.Length > 0)
                {
                    routeList.LoadRoutesFromFile("routes.txt");
                }
                else
                {
                    MessageBox.Show("Routes file is empty");
                }
            }
            else
            {
                MessageBox.Show("Routes file doesn`t exist");
            }
            if (File.Exists("tickets.txt"))
            {
                FileInfo fileInfo = new FileInfo("tickets.txt");
                if (fileInfo.Length > 0)
                {
                    ticketList.LoadTicketsFromFile("tickets.txt");
                   
                }
                else
                {
                    MessageBox.Show("Tickets file is empty");
                }
            }
            else
            {
                MessageBox.Show("Tickets file doesn`t exist");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool gotThrough = false;
            foreach (User user in users)
            {
                if (user.Email==txtEmail.Text&&user.Password == txtPassword.Text)
                {
                    if (user.IsAdmin==true)
                    {
                        gotThrough = true;
                        MainForm mainForm = new MainForm(this.routeList,this.ticketList);
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();

                    }
                    if (user.IsAdmin == false)
                    {
                        if (ticketList.GetTicketsByPassenger(user.FirstName, user.LastName).Count!=0)
                        {
                            userTickets.Tickets = ticketList.GetTicketsByPassenger(user.FirstName, user.LastName);
                        }
                        else
                        {
                            userTickets.Tickets = null;
                        }
                       
                        gotThrough = true;
                        UserMainForm userMain = new UserMainForm(this.routeList, this.ticketList,this.userTickets);
                        this.Hide();
                        userMain.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (gotThrough==false) 
            {
                MessageBox.Show("Incorrect Password or Email");
            }

        }
    }
}
