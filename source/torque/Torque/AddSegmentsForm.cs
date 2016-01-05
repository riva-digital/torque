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
    public partial class AddSegmentsForm : Form
    {
        TorqueMainWindow mainWindow;
        int selSegmentId = 0;
        backend.ProjectDatabase projDB = new backend.ProjectDatabase("173.194.234.148", "don", "riva-root", "EzioOnAThursday");

        public AddSegmentsForm(TorqueMainWindow tmw, string mode="add")
        {
            InitializeComponent();
            this.mainWindow = tmw;

            this.durationDTP.Format = DateTimePickerFormat.Time;
            this.durationDTP.ShowUpDown = true;
            this.durationDTP.Value = DateTime.Now.Date;

            // Disabling these for now, find a way to enable them
            this.notesTxtBox.Enabled = false;
            this.addAnotherSegBtn.Enabled = false;

            if (mode == "edit")
            {
                // In edit mode, block out some of the inputs
                // and show the default values from the database here.
                this.nameTxtBox.Enabled = false;
                this.codeTxtBox.Enabled = false;
                this.aliasTxtBox.Enabled = false;
                this.startDateDTP.Enabled = false;
                this.endDateDTP.Enabled = false;

                // Identify the selected segment
                string selSegment = this.mainWindow.segmentNameList.SelectedItem.ToString();
                selSegmentId = Convert.ToInt32(this.mainWindow.segmentIds[selSegment]);

                this.Text = "Edit Segment - " + selSegment;

                // Re-direct the apply button to a function that updates the selected segment,
                // and doesn't insert a new thing in there.
                this.applyBtn.Click -= new System.EventHandler(this.applyBtn_Click);
                this.applyBtn.Click += new System.EventHandler(this.updateBtn_Click);

                FillEditBox();
            }
            else
            {
                this.applyBtn.Click -= new System.EventHandler(this.updateBtn_Click);
                this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            }
        }

        private void FillEditBox()
        {
            List<string> segCols = new List<string> {"segmentname", "segmentcode", "segmentalias", "segmentdeliveryformat",
                                                     "segmentnotes", "segmentdeliverables", "segmentisstereo", "segmentisrelevant",
                                                     "segmentframerate", "segmentduration", "segmentstartdate", "segmentenddate"};
            Hashtable segId = new Hashtable();
            segId.Add("segmentid", this.selSegmentId);

            this.projDB.OpenConnection();
            List<Hashtable> segmentDetails = this.projDB.Select(segCols, "segments", segId);
            this.projDB.CloseConnection();

            this.nameTxtBox.Text = segmentDetails[0]["segmentname"].ToString();
            this.codeTxtBox.Text = segmentDetails[0]["segmentcode"].ToString();
            this.aliasTxtBox.Text = segmentDetails[0]["segmentalias"].ToString();

            this.delFormatTxtBox.Text = segmentDetails[0]["segmentdeliveryformat"].ToString();
            this.notesTxtBox.Text = segmentDetails[0]["segmentnotes"].ToString();
            this.deliverablesTxtBox.Text = segmentDetails[0]["segmentdeliverables"].ToString();

            this.stereoCB.Checked = (bool)segmentDetails[0]["segmentisstereo"];
            this.relevanceCB.Checked = (bool)segmentDetails[0]["segmentisrelevant"];

            this.frmrateSpnr.Value = (decimal)segmentDetails[0]["segmentframerate"];

            DateTime duration;
            DateTime.TryParse(segmentDetails[0]["segmentduration"].ToString(), out duration);
            this.durationDTP.Value = duration;

            DateTime start;
            DateTime.TryParse(segmentDetails[0]["segmentstartdate"].ToString(), out start);
            this.startDateDTP.Value = start;

            DateTime end;
            DateTime.TryParse(segmentDetails[0]["segmentenddate"].ToString(), out end);
            this.endDateDTP.Value = end;
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Hashtable updates = new Hashtable();
            Hashtable keys = new Hashtable();

            keys.Add("segmentid", selSegmentId);

            updates.Add("segmentduration", this.durationDTP.Value);
            updates.Add("segmentframerate", this.frmrateSpnr.Value);
            updates.Add("segmentisstereo", this.stereoCB.Checked);
            updates.Add("segmentisrelevant", this.relevanceCB.Checked);
            updates.Add("segmentdeliveryformat", this.delFormatTxtBox.Text);
            updates.Add("segmentdeliverables", this.deliverablesTxtBox.Text);
            //updates.Add("segmentnotes", this.notesTxtBox.Text);

            this.projDB.OpenConnection();
            this.projDB.Update("segments", updates, keys);
            this.projDB.CloseConnection();

            this.Close();
        }

        /// <summary>
        /// Submits the data in the form to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyBtn_Click(object sender, EventArgs e)
        {
            // Get all the data in the form and pass it off to
            // the verify function.
            string segName = this.nameTxtBox.Text;
            string segCode = this.codeTxtBox.Text;
            string segAlias = this.aliasTxtBox.Text;
            string segDelFrmt = this.delFormatTxtBox.Text;
            string segNotes = this.notesTxtBox.Text;
            string segDeliverables = this.deliverablesTxtBox.Text;

            bool segIsStereo = this.stereoCB.Checked;
            bool segIsRelevant = this.relevanceCB.Checked;

            decimal frameRate = this.frmrateSpnr.Value;

            DateTime segDuration = this.durationDTP.Value;
            DateTime segStartDate = this.startDateDTP.Value;
            DateTime segEndDate = this.endDateDTP.Value;

            bool verifyData = VerifyData(segName, segCode, segAlias, frameRate, segDuration, segStartDate, segEndDate);

            if (verifyData)
            {
                AddSegmentToDatabase(segName, segCode, segAlias, segDelFrmt, segNotes, segDeliverables,
                                     segIsStereo, segIsRelevant, frameRate, segDuration, segStartDate, segEndDate);
                this.mainWindow.RefreshSegmentList();
                this.Close();
            }
                
        }

        private void addAnotherSegBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddSegmentToDatabase(string segName, string segCode, string segAlias, string segDelFrmt,
                                          string segNotes, string segDeliverables, bool segIsStereo,
                                          bool segIsRelevant, decimal frameRate, DateTime segDuration, 
                                          DateTime segStartDate, DateTime segEndDate)
        {
            // Convert notes into a byte array.
            byte[] notesBytes = backend.ProjectDatabase.GetBytes(segNotes);

            // Build a Hashtable
            Hashtable segmentHash = new Hashtable();
            segmentHash.Add("segmentname", segName);
            segmentHash.Add("segmentcode", segCode);
            segmentHash.Add("segmentAlias", segAlias);
            segmentHash.Add("segmentdeliveryformat", segDelFrmt);
            //segmentHash.Add("segmentnotes", notesBytes);
            segmentHash.Add("segmentdeliverables", segDeliverables);
            segmentHash.Add("segmentisstereo", segIsStereo);
            segmentHash.Add("segmentisrelevant", segIsRelevant);
            segmentHash.Add("segmentframerate", frameRate);
            segmentHash.Add("segmentduration", segDuration);
            segmentHash.Add("segmentstartdate", segStartDate);
            segmentHash.Add("segmentenddate", segEndDate);

            this.projDB.OpenConnection();
            try
            {
                this.projDB.Insert("segments", segmentHash);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.projDB.CloseConnection();
            }
        }

        private bool VerifyData(string segName, string segCode, string segAlias, decimal frameRate,
                                DateTime segDuration, DateTime segStartDate, DateTime segEndDate)
        {
            if (segName.Length == 0)
            {
                MessageBox.Show("Name, Code, and Alias values can't be empty. Please put something in there.");
                return false;
            }

            if (segCode.Length == 0)
            {
                MessageBox.Show("Name, Code, and Alias values can't be empty. Please put something in there.");
                return false;
            }

            if (segAlias.Length == 0)
            {
                MessageBox.Show("Name, Code, and Alias values can't be empty. Please put something in there.");
                return false;
            }

            if (frameRate == 0)
            {
                MessageBox.Show("Please enter a valid frame rate.");
                return false;
            }

            DateTime zeroTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            if (DateTime.Compare(this.durationDTP.Value, zeroTime) == 0)
            {
                MessageBox.Show("Please enter a valid, non-zero duration.");
                return false;
            }

            if (DateTime.Compare(segEndDate, segStartDate) < 0)
            {
                MessageBox.Show("The end date cannot be less than the start date.");
                return false;
            }

            return true;
        }
    }
}
