using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISEProject_V2.UserControls.MTO
{
    public partial class RequestMaintances : UserControl
    {
        public RequestMaintances()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            RequestMantaincePanl.Show();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            maintanceRequest.Show();
        }

        private void MantainceGrdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestMaintance_Load(object sender, EventArgs e)
        {
            RequestMantaincePanl.Visible = false;
        }
    }
}
