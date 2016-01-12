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
    public partial class AddTasks : Form
    {
        TorqueMainWindow mainWindow;
        
        public AddTasks(TorqueMainWindow tmw)
        {
            InitializeComponent();

            this.mainWindow = tmw;
            this.RefreshDepartmentList();
        }

        private void defineNewBtn_Click(object sender, EventArgs e)
        {
            AddComponents addDeptWin = new AddComponents(this.mainWindow, addComponent: ComponentType.Department);
            addDeptWin.ShowDialog();
        }

        public void RefreshDepartmentList()
        {
            this.deptListBox.Items.Clear();

            this.mainWindow.projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("departmentname");

                List<Hashtable> depts = this.mainWindow.projDB.Select(columnNames, "departments", keyVals);
                foreach (Hashtable dept in depts)
                {
                    this.deptListBox.Items.Add(dept["departmentname"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.mainWindow.projDB.CloseConnection();
            }
        }

        private void addSelBtn_Click(object sender, EventArgs e)
        {
            string segName = this.mainWindow.segmentNameList.SelectedItem.ToString();
            string catName = this.mainWindow.assetCategoryList.SelectedItem.ToString();

            List<Hashtable> catIds = new List<Hashtable>();
            List<string> columns = new List<string> { "CategoryId" };
            Hashtable whereHash = new Hashtable();
            
            whereHash.Add("SegmentName", segName);
            whereHash.Add("CategoryName", catName);
            
            this.mainWindow.projDB.OpenConnection();
            try
            {
                catIds = this.mainWindow.projDB.Select(columns, "segment_categories_details", whereHash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.mainWindow.projDB.CloseConnection();
            }

            int catId = Convert.ToInt32(catIds[0]["CategoryID"]);

            this.mainWindow.projDB.OpenConnection();
            foreach (string item in this.deptListBox.CheckedItems)
            {
                // first, get the department id
                Hashtable depts = new Hashtable();
                depts.Add("departmentname", item);

                List<Hashtable> deptIds = this.mainWindow.projDB.Select(new List<string> { "departmentid" }, "departments", depts);
                int deptId = Convert.ToInt32(deptIds[0]["departmentid"]);

                depts.Clear();
                depts.Add("categoryid", catId);
                depts.Add("departmentid", deptId);

                // Now, add the combo of the catId and the deptId into the asset_category_has_departments table.
                this.mainWindow.projDB.Insert("asset_category_has_departments", depts);
                
            }
            this.mainWindow.projDB.CloseConnection();
        }
    }
}
