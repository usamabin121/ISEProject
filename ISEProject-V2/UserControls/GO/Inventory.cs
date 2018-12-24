using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISEProject_V2.UserControls.GO;
using System.IO;

namespace ISEProject_V2.UserControls.GO
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            ProductPanel.Hide();
        }

        private void Btnview_Click(object sender, EventArgs e)
        {
            ProductPanel.Show();
        }

        private void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
