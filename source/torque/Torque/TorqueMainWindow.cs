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
    public enum WindowMode
    {
        Add,
        Edit
    }

    public enum ComponentType
    {
        Category,
        Group,
        Asset,
        Department
    }

    public struct TSegment
    {
        
    }

    public struct TCategory
    {

    }

    public struct TGroup
    {

    }

    public struct TAsset
    {

    }

    public struct TAssetDetails
    {

    }

    public struct TTask
    {

    }

    public struct TTransaction
    {

    }

    public struct TTaskStatus
    {

    }

    public struct TUsers
    {

    }

    public struct TDepartments
    {

    }

    public partial class TorqueMainWindow : Form
    {

        public backend.ProjectDatabase projDB = new backend.ProjectDatabase(host: "173.194.86.207", uid: "riva-root", pwd: "EzioOnAThursday");
        public Hashtable segmentIds = new Hashtable();
        public AddTasks addTaskWin;
        
        public TorqueMainWindow()
        {            
            InitializeComponent();
            this.projectDataView.ReadOnly = true;
            // Init the Torque Toolbar

            // 
            // donToolStripMenuItem
            // 
            this.donToolStripMenuItem.Name = "donToolStripMenuItem";
            this.donToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.donToolStripMenuItem.Text = "Don";
            this.donToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);

            // The default database is Don, so make sure the title bar
            // reflects that
            this.donToolStripMenuItem.Checked = true;
            this.Text = "Torque - Don";
            // 
            // raOneToolStripMenuItem
            // 
            this.raOneToolStripMenuItem.Name = "raOneToolStripMenuItem";
            this.raOneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.raOneToolStripMenuItem.Text = "RaOne";
            this.raOneToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);

            this.taskList.DoubleClick += new System.EventHandler(this.taskList_DoubleClick);

            this.SetProjDatabase();
            RefreshSegmentList();
        }

        public void SetProjDatabase(string projectName = "don")
        {
            this.projDB.SetDatabase(projectName);
        }

        private void addSegmentsBtn_Click(object sender, EventArgs e)
        {
            AddSegmentsForm addSeg = new AddSegmentsForm(this);            
            addSeg.ShowDialog();
        }
        
        public void RefreshSegmentList()
        {
            this.segmentNameList.Items.Clear();
            this.assetCategoryList.Items.Clear();
            this.assetGroupsList.Items.Clear();
            this.assetList.Items.Clear();
            this.taskList.Items.Clear();

            List<string> columnNames = new List<string>();
            Hashtable keyVals = new Hashtable();
            this.projDB.OpenConnection(true);
            try
            {
                List<Hashtable> segments = this.projDB.Select(columnNames, "segments", keyVals);
                foreach (Hashtable segment in segments)
                {
                    segmentNameList.Items.Add(segment["segmentname"].ToString());
                    if (!segmentIds.Contains(segment["segmentname"]))
                    {
                        segmentIds.Add(segment["segmentname"], segment["segmentid"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection(true);
            }

            this.addCatBtn.Enabled = false;
            this.remCatBtn.Enabled = false;
            this.addGrpBtn.Enabled = false;
            this.remGrpBtn.Enabled = false;
            this.addAstBtn.Enabled = false;
            this.remAstBtn.Enabled = false;
            this.addTskBtn.Enabled = false;
            this.remTskBtn.Enabled = false;
        }

        public void RefreshCategoriesList()
        {
            this.assetCategoryList.Items.Clear();
            this.assetGroupsList.Items.Clear();
            this.assetList.Items.Clear();
            this.taskList.Items.Clear();

            string selSegment = segmentNameList.SelectedItem.ToString();

            this.projDB.OpenConnection(true);
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("CategoryName");
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> categories = this.projDB.Select(columnNames, "segment_categories_details", keyVals);
                foreach (Hashtable category in categories)
                {
                    assetCategoryList.Items.Add(category["CategoryName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection(true);
            }

            this.addGrpBtn.Enabled = false;
            this.remGrpBtn.Enabled = false;
            this.addAstBtn.Enabled = false;
            this.remAstBtn.Enabled = false;
            this.addTskBtn.Enabled = false;
            this.remTskBtn.Enabled = false;
        }

        public void RefreshGroupsList()
        {
            this.assetGroupsList.Items.Clear();
            this.assetList.Items.Clear();
            this.taskList.Items.Clear();

            string selSegment = segmentNameList.SelectedItem.ToString();
            string selAssetCat = assetCategoryList.SelectedItem.ToString();

            this.projDB.OpenConnection(true);
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("GroupName");
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> groups = this.projDB.Select(columnNames, "segment_groups_details", keyVals);
                foreach (Hashtable group in groups)
                {
                    assetGroupsList.Items.Add(group["GroupName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection(true);
            }

            this.addAstBtn.Enabled = false;
            this.remAstBtn.Enabled = false;
            this.addTskBtn.Enabled = false;
            this.remTskBtn.Enabled = false;
        }

        public void RefreshAssetList()
        {
            this.assetList.Items.Clear();
            this.taskList.Items.Clear();

            string selSegment = this.segmentNameList.SelectedItem.ToString();
            string selAssetCat = this.assetCategoryList.SelectedItem.ToString();
            string selAssetGrp = this.assetGroupsList.SelectedItem.ToString();

            this.projDB.OpenConnection(true);
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("AssetName");
                keyVals.Add("AssetGroupName", selAssetGrp);
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> assets = projDB.Select(columnNames, "segment_asset_details", keyVals);
                foreach (Hashtable asset in assets)
                {
                    assetList.Items.Add(asset["AssetName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection(true);
            }

            this.addTskBtn.Enabled = false;
            this.remTskBtn.Enabled = false;
        }

        public void RefreshTaskList()
        {
            this.taskList.Items.Clear();

            string selSegment = this.segmentNameList.SelectedItem.ToString();
            string selAssetCat = this.assetCategoryList.SelectedItem.ToString();
            string selAssetGrp = this.assetGroupsList.SelectedItem.ToString();
            string selAsset = this.assetList.SelectedItem.ToString();

            this.projDB.OpenConnection(true);
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("TaskName");
                keyVals.Add("AssetName", selAsset);
                keyVals.Add("GroupName", selAssetGrp);
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> assets = projDB.Select(columnNames, "segment_task_details", keyVals);
                foreach (Hashtable asset in assets)
                {
                    this.taskList.Items.Add(asset["TaskName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection(true);
            }
        }

        public void RefreshProjectDataView()
        {
            this.projectDataView.DataSource = null;
            this.projectDataView.Refresh();

            string selString = "SELECT TaskID, SegmentName, CategoryName, GroupName, AssetName, TaskName, TaskStartDate, TaskEndDate, TaskStatus FROM " + this.projDB.GetDatabase() + ".segment_task_details WHERE SegmentName=\"" + this.segmentNameList.SelectedItem.ToString() + "\"";
            if (this.assetCategoryList.SelectedItems.Count > 0)
            {
                selString += " AND CategoryName=\"" + this.assetCategoryList.SelectedItem.ToString() + "\"";
            }
            if (this.assetGroupsList.SelectedItems.Count > 0)
            {
                selString += " AND GroupName=\"" + this.assetGroupsList.SelectedItem.ToString() + "\"";
            }
            if (this.assetList.SelectedItems.Count > 0)
            {
                selString += " AND AssetName=\"" + this.assetList.SelectedItem.ToString() + "\"";
            }
            selString += ";";

            this.projDB.OpenConnection(true);
            MySql.Data.MySqlClient.MySqlDataAdapter data = new MySql.Data.MySqlClient.MySqlDataAdapter(selString, this.projDB.connection);

            DataSet ds = new DataSet();
            data.Fill(ds);
            this.projectDataView.DataSource = ds.Tables[0];
            this.projDB.CloseConnection(true);
        }

        private void segmentNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.segmentNameList.SelectedItems.Count > 0)
            {
                this.assetCategoryList.Items.Clear();
                this.assetGroupsList.Items.Clear();
                this.assetList.Items.Clear();
                this.taskList.Items.Clear();

                RefreshCategoriesList();
                this.RefreshProjectDataView();
                this.addCatBtn.Enabled = true;
                this.remCatBtn.Enabled = true;
            }
        }

        private void segmentNameList_DoubleClick(object sender, EventArgs e)
        {
            AddSegmentsForm addSeg = new AddSegmentsForm(this, mode: WindowMode.Edit);
            addSeg.ShowDialog();
        }

        private void assetCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.assetCategoryList.SelectedItems.Count > 0)
            {
                this.assetGroupsList.Items.Clear();
                this.assetList.Items.Clear();
                this.taskList.Items.Clear();

                RefreshGroupsList();
                this.RefreshProjectDataView();
                this.addGrpBtn.Enabled = true;
                this.remGrpBtn.Enabled = true;
            }
        }

        private void assetCategoryList_DoubleClick(object sender, EventArgs e)
        {
            this.addTaskWin = new AddTasks(this);
            this.addTaskWin.ShowDialog();
        }

        private void assetGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.assetGroupsList.SelectedItems.Count > 0)
            {
                this.assetList.Items.Clear();
                this.taskList.Items.Clear();

                RefreshAssetList();
                this.RefreshProjectDataView();
                this.addAstBtn.Enabled = true;
                this.remAstBtn.Enabled = true;
            }
        }

        private void assetGroupsList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void assetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.assetList.SelectedItems.Count > 0)
            {
                this.taskList.Items.Clear();

                this.RefreshTaskList();
                this.RefreshProjectDataView();
                this.addTskBtn.Enabled = true;
                this.remTskBtn.Enabled = true;
            }
        }

        private void assetList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskList_DoubleClick(object sender, EventArgs e)
        {
            EditTasks editTasksWin = new EditTasks(this);
            editTasksWin.ShowDialog();
        }

        private void addCatBtn_Click(object sender, EventArgs e)
        {
            AddComponents addCompWin = new AddComponents(this);
            addCompWin.ShowDialog();
        }

        private void addGrpBtn_Click(object sender, EventArgs e)
        {
            AddComponents addCompWin = new AddComponents(this, addComponent: ComponentType.Group);
            addCompWin.ShowDialog();
        }

        private void addAstBtn_Click(object sender, EventArgs e)
        {
            AddComponents addCompWin = new AddComponents(this, addComponent: ComponentType.Asset);
            addCompWin.ShowDialog();
        }

        private void addTskBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (!menuItem.Checked)
            {
                foreach (ToolStripMenuItem item in this.projectToolStripMenuItem.DropDownItems)
                {
                    item.Checked = false;
                }
                menuItem.Checked = true;

                this.SetProjDatabase(menuItem.ToString().ToLower());
                this.RefreshSegmentList();

                this.Text = "Torque - " + menuItem.ToString();
            }
        }
    }
}
