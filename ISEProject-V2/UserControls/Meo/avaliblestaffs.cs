using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISEProject_V2.UserControls.Meo
{
    public partial class avaliblestaffs : UserControl
    {
        public avaliblestaffs()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TransportGrdvw.Show();
            label2.Show();
            RefrideratorGrdvw.Hide();
            label4.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TransportGrdvw.Hide();
            label2.Hide();
            RefrideratorGrdvw.Show();
            label4.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TransportGrdvw.Hide();
            RefrideratorGrdvw.Hide();
        }

        private void RefrideratorGrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void avaliblestaffs_Load(object sender, EventArgs e)
        {
            TransportGrdvw.Visible = false;
            RefrideratorGrdvw.Visible = false;
            label2.Hide();
            label4.Hide();
        }
    }
}
