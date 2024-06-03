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
    public partial class fileOperationsForm : Form
    {
        public RouteList routeList;
        string routeFile = "routes.txt";
        public TicketList ticketList;
        string ticketFile = "tickets.txt";
        public fileOperationsForm(RouteList routeList, TicketList ticketList)
        {
            InitializeComponent();
            this.routeList = routeList;
            this.ticketList = ticketList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
             
            if (routeList.BusRoutes.Count>0)
            {
                routeList.SaveRoutesToFile(routeFile);
                MessageBox.Show("Data is successfully saved");
            }
            else
            {
                MessageBox.Show("There`s nothing to save");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (File.Exists(routeFile))
            {
                FileInfo fileInfo = new FileInfo(routeFile);
                if (fileInfo.Length>0)
                {
                    routeList.LoadRoutesFromFile("routes.txt");
                    MessageBox.Show("Data is successfully uploaded");
                }
                else
                {
                    MessageBox.Show("Given file is empty");
                }
               
            }
            else
            {
                MessageBox.Show("Given file doesn`t exist");
            }
        }

        private void fileOperationsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveTickets_Click(object sender, EventArgs e)
        {
            if (ticketList.Tickets.Count > 0)
            {
                ticketList.SaveTicketsToFile(ticketFile);
                MessageBox.Show("Data is successfully saved");
            }
            else
            {
                MessageBox.Show("There`s nothing to save");
            }
        }

        private void btnUploadTickets_Click(object sender, EventArgs e)
        {
            if (File.Exists(routeFile))
            {
                FileInfo fileInfo = new FileInfo(routeFile);
                if (fileInfo.Length > 0)
                {
                    ticketList.LoadTicketsFromFile("tickets.txt");
                    MessageBox.Show("Data is successfully uploaded");
                }
                else
                {
                    MessageBox.Show("Given file is empty");
                }

            }
            else
            {
                MessageBox.Show("Given file doesn`t exist");
            }
        }
    }
}
