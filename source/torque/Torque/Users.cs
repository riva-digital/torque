using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torque
{
    public partial class Users : Form
    {
        AddUserMode addUserMode;
        EditTasks addTaskWin;
        
        public Users(EditTasks atw, AddUserMode addMode = AddUserMode.AddUser)
        {
            InitializeComponent();

            this.Text = "Add User";
            this.addUserMode = addMode;
            this.addTaskWin = atw;
            
            if (addMode == AddUserMode.AddReviewer)
            {
                this.isReviewerCB.Checked = true;
                this.isReviewerCB.Enabled = false;

                this.Text = "Add Reviewer";
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (this.VerifyData())
            {
                Hashtable insertHash = new Hashtable();
                insertHash.Add("username", this.usernameTxtBox.Text);
                insertHash.Add("firstname", this.firstNameTxtBox.Text);
                insertHash.Add("lastname", this.lastNameTxtBox.Text);
                insertHash.Add("email", this.emailTxtBox.Text);
            }
        }

        private bool VerifyData()
        {
            // As of now the two cumpolsury fields that need to be
            // added are the username and the email address
            if (this.usernameTxtBox.Text.Length == 0 || this.emailTxtBox.Text.Length == 0)
            {
                MessageBox.Show("The username and email fields cannot be blank.");
                return false;
            }   

            // Also check if this username and email combination already exists....
            List<string> selColumns = new List<string>();
            Hashtable selHashTab = new Hashtable();

            selHashTab.Add("username", this.usernameTxtBox.Text);
            selHashTab.Add("email", this.emailTxtBox.Text);

            List<Hashtable> existingUsers = new List<Hashtable>();

            this.addTaskWin.mainWindow.projDB.OpenConnection();
            try
            {
                existingUsers = this.addTaskWin.mainWindow.projDB.Select(selColumns, "users", selHashTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.addTaskWin.mainWindow.projDB.CloseConnection();
            }

            if (existingUsers.Count > 0)
            {
                MessageBox.Show("A user with this username and email address already exists.");
                return false;
            }

            return true;
        }
    }
}
