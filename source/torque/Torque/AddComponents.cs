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
    public partial class AddComponents : Form
    {
        TorqueMainWindow mainWindow;
        WindowMode mode;
        ComponentType compType;
        /// <summary>
        /// The format for this list is going to be
        /// segmentid, categoryid, groupid
        /// </summary>
        List<int> foreignKeyList = new List<int>();

        public AddComponents(TorqueMainWindow tmw, WindowMode mode = WindowMode.Add, ComponentType addComponent = ComponentType.Category)
        {
            InitializeComponent();

            this.mainWindow = tmw;
            this.mode = mode;
            this.compType = addComponent;

            this.Text = "Add " + this.compType.ToString();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            // Build the required foreign key list first.
            this.BuildForeignKeyList();

            Hashtable insertHash = new Hashtable();
            
            if (this.VerifyData())
            {
                if (this.compType == ComponentType.Category)
                {
                    insertHash.Add("segmentid", this.foreignKeyList[0]);
                    insertHash.Add("categoryname", this.nameTxtBox.Text);
                    insertHash.Add("categorycode", this.codeTxtBox.Text);
                    insertHash.Add("categoryisrelevant", this.relevanceCB.Checked);

                    this.mainWindow.projDB.OpenConnection();
                    try
                    {
                        this.mainWindow.projDB.Insert("asset_categories", insertHash);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.mainWindow.projDB.CloseConnection();
                        this.mainWindow.RefreshCategoriesList();
                    }
                }
                else if (this.compType == ComponentType.Group)
                {
                    insertHash.Add("segmentid", this.foreignKeyList[0]);
                    insertHash.Add("categoryid", this.foreignKeyList[1]);
                    insertHash.Add("groupname", this.nameTxtBox.Text);
                    insertHash.Add("groupcode", this.codeTxtBox.Text);
                    insertHash.Add("groupisrelevant", this.relevanceCB.Checked);

                    this.mainWindow.projDB.OpenConnection();
                    try
                    {
                        this.mainWindow.projDB.Insert("asset_groups", insertHash);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.mainWindow.projDB.CloseConnection();
                        this.mainWindow.RefreshGroupsList();
                    }
                }
                else if (this.compType == ComponentType.Asset)
                {
                    insertHash.Add("segmentid", this.foreignKeyList[0]);
                    insertHash.Add("categoryid", this.foreignKeyList[1]);
                    insertHash.Add("groupid", this.foreignKeyList[2]);
                    insertHash.Add("assetname", this.nameTxtBox.Text);
                    insertHash.Add("assetcode", this.codeTxtBox.Text);
                    insertHash.Add("assetisrelevant", this.relevanceCB.Checked);

                    this.mainWindow.projDB.OpenConnection();
                    try
                    {
                        this.mainWindow.projDB.Insert("assets", insertHash);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.mainWindow.projDB.CloseConnection();
                        this.mainWindow.RefreshAssetList();
                    }
                }                
                else if (this.compType == ComponentType.Department)
                {
                    insertHash.Add("departmentname", this.nameTxtBox.Text);
                    insertHash.Add("departmentcode", this.codeTxtBox.Text);

                    this.mainWindow.projDB.OpenConnection();
                    try
                    {
                        this.mainWindow.projDB.Insert("departments", insertHash);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.mainWindow.projDB.CloseConnection();
                        this.mainWindow.addTaskWin.RefreshDepartmentList();
                    }
                }
            }
            
        }

        /// <summary>
        /// Depending on the cateogry, builds the foreign key list
        /// needed to add stuff into the database.
        /// </summary>
        private void BuildForeignKeyList()
        {
            // Clear any previous additions...
            this.foreignKeyList.Clear();

            // The segment is pretty much a default thing. So that goes in first.
            this.foreignKeyList.Add(Convert.ToInt32(this.mainWindow.segmentIds[this.mainWindow.segmentNameList.SelectedItem.ToString()]));

            List<string> columnNames = new List<string>();
            List<Hashtable> IDs = new List<Hashtable>();
            Hashtable fkParams = new Hashtable();
            fkParams.Add("SegmentName", this.mainWindow.segmentNameList.SelectedItem.ToString());
            // We need to action this only and only if the 
            // components to be added are asset groups or assets
            if (this.compType == ComponentType.Group)
            {
                columnNames.Add("CategoryID");
                fkParams.Add("CategoryName", this.mainWindow.assetCategoryList.SelectedItem.ToString());
                this.mainWindow.projDB.OpenConnection();
                try
                {
                    IDs = this.mainWindow.projDB.Select(columnNames, "segment_categories_details", fkParams);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                this.foreignKeyList.Add(Convert.ToInt32(IDs[0]["CategoryID"]));
                
            }
            else if (this.compType == ComponentType.Asset)
            {
                columnNames.Add("CategoryID");
                columnNames.Add("GroupID");
                fkParams.Add("CategoryName", this.mainWindow.assetCategoryList.SelectedItem.ToString());
                fkParams.Add("GroupName", this.mainWindow.assetGroupsList.SelectedItem.ToString());
                this.mainWindow.projDB.OpenConnection();
                try
                {
                    IDs = this.mainWindow.projDB.Select(columnNames, "segment_groups_details", fkParams);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                this.foreignKeyList.Add(Convert.ToInt32(IDs[0]["CategoryID"]));
                this.foreignKeyList.Add(Convert.ToInt32(IDs[0]["GroupID"]));
            }
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

            // Also, add in checks to see if this component already exists at its level.
            // Eg. You cannot have two categories called characters in the same segment,
            // or two asset groups called mainChars in the same category. And so on, 
            // and so forth.
            // So just get a basic list of objects from the DB, to make sure they don't
            // exist. Sounds whacky, I know.
            this.BuildForeignKeyList();
            List<string> selColumns = new List<string>();
            Hashtable selHashTab = new Hashtable();
            if (this.compType == ComponentType.Category)
            {
                List<Hashtable> categories = new List<Hashtable>();
                selHashTab.Add("SegmentName", this.mainWindow.segmentNameList.SelectedItem.ToString());
                selHashTab.Add("CategoryName", this.nameTxtBox.Text);
                this.mainWindow.projDB.OpenConnection();
                try
                {
                    categories = this.mainWindow.projDB.Select(selColumns, "segment_categories_details", selHashTab);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                if (categories.Count > 0)
                {
                    MessageBox.Show("The item " + this.nameTxtBox.Text + " already exists in the segment " + this.mainWindow.segmentNameList.SelectedItem.ToString());
                    return false;
                }
            }
            else if (this.compType == ComponentType.Group)
            {
                List<Hashtable> groups = new List<Hashtable>();
                selHashTab.Add("SegmentName", this.mainWindow.segmentNameList.SelectedItem.ToString());
                selHashTab.Add("CategoryName", this.mainWindow.assetCategoryList.SelectedItem.ToString());
                selHashTab.Add("GroupName", this.nameTxtBox.Text);
                this.mainWindow.projDB.OpenConnection();
                try
                {
                    groups = this.mainWindow.projDB.Select(selColumns, "segment_groups_details", selHashTab);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                if (groups.Count > 0)
                {
                    MessageBox.Show("The item " + this.nameTxtBox.Text + " already exists in the segment " + this.mainWindow.segmentNameList.SelectedItem.ToString() + " and category " + this.mainWindow.assetCategoryList.SelectedItem.ToString());
                    return false;
                }
            }
            else if (this.compType == ComponentType.Asset)
            {
                List<Hashtable> assets = new List<Hashtable>();
                selHashTab.Add("SegmentName", this.mainWindow.segmentNameList.SelectedItem.ToString());
                selHashTab.Add("CategoryName", this.mainWindow.assetCategoryList.SelectedItem.ToString());
                selHashTab.Add("AssetGroupName", this.mainWindow.assetGroupsList.SelectedItem.ToString());
                selHashTab.Add("AssetName", this.nameTxtBox.Text);
                this.mainWindow.projDB.OpenConnection();
                try
                {
                    assets = this.mainWindow.projDB.Select(selColumns, "segment_asset_details", selHashTab);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                if (assets.Count > 0)
                {
                    MessageBox.Show("The item " + this.nameTxtBox.Text + " already exists in the segment " + this.mainWindow.segmentNameList.SelectedItem.ToString() + ", category " + this.mainWindow.assetCategoryList.SelectedItem.ToString() + " and group " + this.mainWindow.assetGroupsList.SelectedItem.ToString());
                    return false;
                }
            }
            else if (this.compType == ComponentType.Department)
            {
                List<Hashtable> departments = new List<Hashtable>();
                selHashTab.Add("departmentname", this.nameTxtBox.Text);
                selHashTab.Add("departmentcode", this.codeTxtBox.Text);

                this.mainWindow.projDB.OpenConnection();
                try
                {
                    departments = this.mainWindow.projDB.Select(selColumns, "departments", selHashTab);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mainWindow.projDB.CloseConnection();
                }
                if (departments.Count > 0)
                {
                    MessageBox.Show("The item " + this.nameTxtBox.Text + " already exists.");
                    return false;
                }
            }

            return true;
        }
    }
}
