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
        string filepath = "routes.txt";
        public fileOperationsForm(RouteList routeList)
        {
            InitializeComponent();
            this.routeList = routeList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
             
            if (routeList.BusRoutes.Count>0)
            {
                routeList.SaveRoutesToFile(filepath);
                MessageBox.Show("Data is successfully saved");
            }
            else
            {
                MessageBox.Show("There`s nothing to save");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                FileInfo fileInfo = new FileInfo(filepath);
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
    }
}
