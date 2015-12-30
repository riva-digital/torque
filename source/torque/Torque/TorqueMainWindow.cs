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
        public TorqueMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable hasher = new Hashtable();
            Decimal framerate = 45;
            TimeSpan duration = new TimeSpan(0, 5, 0);
            DateTime start = new DateTime(2015, 12, 30);
            DateTime end = new DateTime(2016, 1, 30);

            hasher.Add("segmentname", "Torque Test");
            hasher.Add("segmentcode", "TOTE");
            hasher.Add("segmentalias", "Torque");
            hasher.Add("segmentframerate", framerate);
            hasher.Add("segmentduration", duration);
            hasher.Add("segmentstartdate", start);
            hasher.Add("segmentenddate", end);
            hasher.Add("segmentisstereo", true);
            hasher.Add("segmentdeliveryformat", "quicktime");
            hasher.Add("segmentisrelevant", true);

            backend.ProjectDatabase projDB = new backend.ProjectDatabase("173.194.234.148", "don",
                                                                         "riva-root", "EzioOnAThursday");

            projDB.Insert("segments", hasher);
        }
    }
}
