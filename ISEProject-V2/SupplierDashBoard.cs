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
    public partial class SupplierDashBoard : Form
    {
        public SupplierDashBoard()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            checkSTock1.Visible = true;
            checkSTock1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sendStocks1.Visible = true;
            sendStocks1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            generateStocks1.Visible = true;
            generateStocks1.BringToFront();
        }
    }
}
