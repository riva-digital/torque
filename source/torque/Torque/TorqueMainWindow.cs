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
        Asset
    }

    public partial class TorqueMainWindow : Form
    {

        backend.ProjectDatabase projDB = new backend.ProjectDatabase("173.194.234.148", "don", "riva-root", "EzioOnAThursday");
        public Hashtable segmentIds = new Hashtable();
        
        public TorqueMainWindow()
        {
            InitializeComponent();
            RefreshSegmentList();
        }

        private void addSegmentsBtn_Click(object sender, EventArgs e)
        {
            AddSegmentsForm addSeg = new AddSegmentsForm(this);            
            addSeg.ShowDialog();
        }

        private void segmentNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.assetCategoryList.Items.Clear();
            this.assetGroupsList.Items.Clear();
            this.assetList.Items.Clear();
            this.taskList.Items.Clear();

            RefreshCategoriesList();
            this.addCatBtn.Enabled = true;
            this.remCatBtn.Enabled = true;
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
            projDB.OpenConnection();
            try
            {
                List<Hashtable> segments = projDB.Select(columnNames, "segments", keyVals);
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
                projDB.CloseConnection();
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

            projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("CategoryName");
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> categories = projDB.Select(columnNames, "segment_categories_details", keyVals);
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
                projDB.CloseConnection();
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

            projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("GroupName");
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> groups = projDB.Select(columnNames, "segment_groups_details", keyVals);
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
                projDB.CloseConnection();
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

            projDB.OpenConnection();
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
                projDB.CloseConnection();
            }

            this.addTskBtn.Enabled = false;
            this.remTskBtn.Enabled = false;
        }

        public void RefreshTaskList()
        {
            this.taskList.Items.Clear();
        }

        private void segmentNameList_DoubleClick(object sender, EventArgs e)
        {
            AddSegmentsForm addSeg = new AddSegmentsForm(this, mode: WindowMode.Edit);
            addSeg.ShowDialog();
        }

        private void assetCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.assetGroupsList.Items.Clear();
            this.assetList.Items.Clear();

            RefreshGroupsList();
            this.addGrpBtn.Enabled = true;
            this.remGrpBtn.Enabled = true;
        }

        private void assetCategoryList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void assetGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.assetList.Items.Clear();

            RefreshAssetList();
            this.addAstBtn.Enabled = true;
            this.remAstBtn.Enabled = true;
        }

        private void assetGroupsList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void assetList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assetList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskList_DoubleClick(object sender, EventArgs e)
        {

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
    }
}
