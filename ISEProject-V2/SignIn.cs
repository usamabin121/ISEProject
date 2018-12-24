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
    public partial class formSignIn : Form
    {
        public formSignIn()
        {
            InitializeComponent();
            labelErrors.Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            GODashboard go = new GODashboard();
            go.Show();
         
            //string username;
            //try
            //{
            //    //If Username is Empty
            //    if (tbUsername.Text == "")
            //    {
            //        labelErrors.Show();
            //        labelErrors.BackColor = Color.FromArgb(231, 76, 60);
            //        labelErrors.Text = "Please enter your username";
            //    }
            //    //If Password is Empty
            //    else if (tbPassword.Text == "")
            //    {
            //        labelErrors.Show();
            //        labelErrors.BackColor = Color.FromArgb(231, 76, 60);
            //        labelErrors.Text = "Please enter your password";
            //    }
            //    //If there is no error : Process Sign In
            //    else
            //    {
            //        //Success Label
            //        labelErrors.Show();
            //        labelErrors.BackColor = Color.FromArgb(39, 174, 96);
            //        labelErrors.Text = "Signing in...";
            //        username = this.tbUsername.Text.ToLower();
            //        //Query to Execute
            //        if (2 > 1)//IF USERNAME EXISTS
            //        {
            //            labelErrors.Show();
            //            labelErrors.BackColor = Color.FromArgb(39, 174, 96);
            //            labelErrors.Text = "You have logged in successfully";
            //            tbUsername.Text = null;
            //            tbPassword.Text = null;

            //            //Show Dashboard based on their Role
            //            //foreach (Employee obj in list)
            //            //{
            //            //    if (obj.Role == "Admin")
            //            //    {
            //            //        AdminDashboard form = new AdminDashboard();
            //            //        form.Show();
            //            //    }
            //            //    else if (obj.Role == "Salesman")
            //            //    {
            //            //        Dashboard form = new Dashboard();
            //            //        form.Show();
            //            //    }
            //            //}
            //            this.Hide();
            //        }
            //        else
            //        {
            //            labelErrors.BackColor = Color.FromArgb(231, 76, 60);
            //            labelErrors.Text = "Invalid username or password";
            //            tbPassword.Focus();
            //            tbPassword.Text = null;
            //        }
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("" + error + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
