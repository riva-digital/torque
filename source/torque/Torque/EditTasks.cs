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
    public enum AddUserMode
    {
        AddUser,
        AddReviewer
    }

    public partial class EditTasks : Form
    {
        public TorqueMainWindow mainWindow;
        
        public EditTasks(TorqueMainWindow tmw)
        {
            InitializeComponent();

            this.mainWindow = tmw;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            Users addUser = new Users(this);
            addUser.ShowDialog();
        }

        private void addReviewerBtn_Click(object sender, EventArgs e)
        {
            Users addReviewer = new Users(this, AddUserMode.AddReviewer);
            addReviewer.ShowDialog();
        }

        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            AddComponents addDeptWin = new AddComponents(this.mainWindow, addComponent: ComponentType.Department);
            addDeptWin.ShowDialog();
        }
    }
}
