using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISEProject_V2.Helper.Classes
{
    internal class Messages
    {
        public void SystemErrorMessage()
        {
            MessageBox.Show("Server Conection Time Out\nOperation Terminated\nPlease Contact your admistrator for details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UserErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UserNotificationMessage(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SystemNotificationMessage()
        {
            MessageBox.Show("Operation Succeed.", "Notifcation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult YesNoMessage(string msgs)
        {
            return MessageBox.Show(msgs, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
