using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISEProject_V2.UserControls.Supplier
{
    public partial class SendStocks : UserControl
    {
        public SendStocks()
        {
            InitializeComponent();
            ProductPanel.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ProductPanel.Show();
        }

        private void SendStocks_Load(object sender, EventArgs e)
        {

        }
    }
}
