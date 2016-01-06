using System;
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
    public partial class AddComponents : Form
    {
        TorqueMainWindow mainWindow;
        WindowMode mode;
        ComponentType compType;

        public AddComponents(TorqueMainWindow tmw, WindowMode mode = WindowMode.Add, ComponentType component = ComponentType.Category)
        {
            InitializeComponent();

            this.mainWindow = tmw;
            this.mode = mode;
            this.compType = component;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string tableName = "asset_categories";
            
            if (this.compType == ComponentType.Group)
            {
                tableName = "asset_groups";
            }
            else if (this.compType == ComponentType.Asset)
            {
                tableName = "assets";
            }

            this.VerifyData();
        }

        private void AddComponentToDatabase()
        {

        }

        private bool VerifyData()
        {
            if (this.nameTxtBox.Text.Length == 0)
            {
                MessageBox.Show("The " + this.compType.ToString() + " name and code can't be empty.");
                return false;
            }

            if (this.codeTxtBox.Text.Length == 0)
            {
                MessageBox.Show("The " + this.compType.ToString() + " name and code can't be empty.");
                return false;
            }

            return true;
        }
    }
}
