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

        /// <summary>
        /// Given a Start Date and Task Duration, calculate when the task will end by excluding
        /// all the holidays that lie during the duration of task.
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="Duration"></param>
        /// <returns>DateTime EndDate</returns>
        private DateTime GetEndDate(DateTime StartDate, decimal Duration)
        {
            DateTime EndDate = StartDate;

            while (EndDate < StartDate.AddDays(Convert.ToDouble(Duration)))
            {
                if (EndDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    // Add a day for each Sunday encountered in
                    // the duration of the task.
                    Duration += 1;
                }
                EndDate = EndDate.AddDays(1);
            }

            // Remove one day, as man days start on the first day itself.
            EndDate = EndDate.AddDays(-1);

            return EndDate;
        }
    }
}
