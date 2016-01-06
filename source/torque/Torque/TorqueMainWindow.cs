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
        public Dictionary<int, Dictionary<string, int>> categoryIds = new Dictionary<int, Dictionary<string, int>>();
        public Dictionary<int, Dictionary<string, int>> groupIds = new Dictionary<int, Dictionary<string, int>>();
        public Dictionary<int, Dictionary<string, int>> assetIds = new Dictionary<int, Dictionary<string, int>>();
        public Dictionary<int, Dictionary<string, int>> taskIds = new Dictionary<int, Dictionary<string, int>>();
        
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
            assetCategoryList.Items.Clear();
            assetGroupsList.Items.Clear();
            assetList.Items.Clear();

            RefreshCategoriesList();
            this.addCatBtn.Enabled = true;
            this.remCatBtn.Enabled = true;
        }
        
        public void RefreshSegmentList()
        {
            segmentNameList.Items.Clear();
            assetCategoryList.Items.Clear();
            assetGroupsList.Items.Clear();
            assetList.Items.Clear();

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
                    if (!categoryIds.ContainsKey(Convert.ToInt32(segment["segmentid"])))
                    {
                        Dictionary<string, int> segCatId = new Dictionary<string,int>();
                        categoryIds.Add(Convert.ToInt32(segment["segmentid"]), segCatId);
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
        }

        public void RefreshCategoriesList()
        {
            string selSegment = segmentNameList.SelectedItem.ToString();

            projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("CategoryName");
                columnNames.Add("CategoryID");
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> categories = projDB.Select(columnNames, "segment_categories_details", keyVals);
                foreach (Hashtable category in categories)
                {
                    assetCategoryList.Items.Add(category["CategoryName"].ToString());
                    if (!this.categoryIds[Convert.ToInt32(segmentIds[selSegment])].ContainsKey(category["CategoryName"].ToString()))
                    {
                        this.categoryIds[Convert.ToInt32(segmentIds[selSegment])].Add(category["CategoryName"].ToString(), Convert.ToInt32(category["CategoryID"]));
                    }
                    if (!this.groupIds.ContainsKey(Convert.ToInt32(category["CategoryID"])))
                    {
                        Dictionary<string, int> groupDetails = new Dictionary<string, int>();
                        this.groupIds.Add(Convert.ToInt32(category["CategoryID"]), groupDetails);
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
        }

        public void RefreshGroupsList()
        {
            string selSegment = segmentNameList.SelectedItem.ToString();
            string selAssetCat = assetCategoryList.SelectedItem.ToString();

            projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("GroupName");
                columnNames.Add("GroupID");
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> groups = projDB.Select(columnNames, "segment_groups_details", keyVals);
                foreach (Hashtable group in groups)
                {
                    assetGroupsList.Items.Add(group["GroupName"].ToString());
                    int catId = this.categoryIds[Convert.ToInt32(this.segmentIds[selSegment])][selAssetCat];
                    int grpId = Convert.ToInt32(group["GroupID"]);
                    if (!this.groupIds[catId].ContainsKey(group["GroupName"].ToString()))
                    {
                        this.groupIds[catId].Add(group["GroupName"].ToString(), grpId);
                    }
                    if(!this.assetIds.ContainsKey(grpId))
                    {
                        Dictionary<string, int> assetDetails = new Dictionary<string, int>();
                        this.assetIds.Add(grpId, assetDetails);
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
        }

        public void RefreshAssetList()
        {
            string selSegment = this.segmentNameList.SelectedItem.ToString();
            string selAssetCat = this.assetCategoryList.SelectedItem.ToString();
            string selAssetGrp = this.assetGroupsList.SelectedItem.ToString();

            projDB.OpenConnection();
            try
            {
                List<string> columnNames = new List<string>();
                Hashtable keyVals = new Hashtable();

                columnNames.Add("AssetName");
                columnNames.Add("AssetID");
                columnNames.Add("CategoryID");
                columnNames.Add("AssetGroupID");
                keyVals.Add("AssetGroupName", selAssetGrp);
                keyVals.Add("CategoryName", selAssetCat);
                keyVals.Add("SegmentName", selSegment);

                List<Hashtable> assets = projDB.Select(columnNames, "segment_asset_details", keyVals);
                foreach (Hashtable asset in assets)
                {
                    assetList.Items.Add(asset["AssetName"].ToString());
                    int catId = this.categoryIds[Convert.ToInt32(this.segmentIds[selSegment])][selAssetCat];
                    int grpId = Convert.ToInt32(asset["GroupID"]);
                    if (!this.groupIds[catId].ContainsKey(asset["GroupName"].ToString()))
                    {
                        this.groupIds[catId].Add(asset["GroupName"].ToString(), grpId);
                    }
                    if (!this.assetIds.ContainsKey(grpId))
                    {
                        Dictionary<string, int> assetDetails = new Dictionary<string, int>();
                        this.assetIds.Add(grpId, assetDetails);
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
        }

        public void RefreshTaskList()
        {

        }

        private void segmentNameList_DoubleClick(object sender, EventArgs e)
        {
            AddSegmentsForm addSeg = new AddSegmentsForm(this, mode: "edit");
            addSeg.ShowDialog();
        }

        private void assetCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            assetGroupsList.Items.Clear();
            assetList.Items.Clear();

            RefreshGroupsList();
        }

        private void assetCategoryList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void assetGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
