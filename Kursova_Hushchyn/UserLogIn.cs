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
        
        
        private RouteList routeList;
        private TicketList ticketList;
        private TicketList userTickets;
        private User finalUser;
        public UserList userList;
        public UserLogIn()
        {

            InitializeComponent();
            this.routeList = new RouteList();
            this.ticketList = new TicketList();
            this.userTickets = new TicketList();
            this.userList = new UserList();
           
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
            if (File.Exists("users.txt"))
            {
                FileInfo fileInfo = new FileInfo("users.txt");
                if (fileInfo.Length > 0)
                {
                    userList.LoadFromFile("users.txt");
                }
                else
                {
                    MessageBox.Show("Users file is empty");
                }
            }
            else
            {
                MessageBox.Show("Users file doesn`t exist");
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
            foreach (User user in userList.Users)
            {
                if (user.Email==txtEmail.Text&&user.Password == txtPassword.Text)
                {
                    if (user.IsAdmin==true)
                    {
                        gotThrough = true;
                        MainForm mainForm = new MainForm(this.routeList,this.ticketList,this.userList,user);
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
                        UserMainForm userMain = new UserMainForm(this.routeList, this.ticketList,this.userTickets,this.userList, user);
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser(userList);
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
