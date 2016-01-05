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
            assetCategoryList.Items.Clear();
            assetGroupsList.Items.Clear();
            assetList.Items.Clear();

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
                    segmentNameList.Items.Add(segment["segmentname"]);
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
    }
}
