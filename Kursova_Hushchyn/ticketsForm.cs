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
    public partial class ticketsForm : Form
    {
        private RouteList routeList;
        private TicketList ticketList;

        public ticketsForm()
        {
            InitializeComponent();
            routeList = new RouteList();
            ticketList = new TicketList();
        }
    }
}
