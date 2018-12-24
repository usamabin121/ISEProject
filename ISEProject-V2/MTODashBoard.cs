using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISEProject_V2
{
    public partial class MTODashBoard : Form
    {
        public MTODashBoard()
        {
            InitializeComponent();
            welcome2.Visible = true;
            viewTransportRequest1.Hide();
            avaiableTransports2.Visible = false;
            receivedVehicles1.Hide();
            requestMaintances1.Visible = false;
            
        }

      
       
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewrequestbtn_Click(object sender, EventArgs e)
        {
            viewTransportRequest1.Show();
            viewTransportRequest1.BringToFront();

        }

        private void avalibletransportbtn_Click(object sender, EventArgs e)
        {
            avaiableTransports2.Show();
            avaiableTransports2.BringToFront();
        }

        private void requestmaintaincebtn_Click(object sender, EventArgs e)
        {
            requestMaintances1.Visible = true;
            requestMaintances1.BringToFront();

        }

        private void requesttranspportbtn_Click(object sender, EventArgs e)
        {
            receivedVehicles1.Show();
            receivedVehicles1.BringToFront();
        }

       

      
    }
}
