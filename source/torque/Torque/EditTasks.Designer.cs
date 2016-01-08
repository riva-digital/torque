namespace Torque
{
    partial class EditTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.endDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.frmrateSpnr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.blkTaskCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aUserCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aReviewerCombo = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.addReviewerBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmrateSpnr)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "End Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endDateDTP
            // 
            this.endDateDTP.CustomFormat = "DateTimePickerFormat.Time";
            this.endDateDTP.Location = new System.Drawing.Point(93, 39);
            this.endDateDTP.Name = "endDateDTP";
            this.endDateDTP.Size = new System.Drawing.Size(142, 20);
            this.endDateDTP.TabIndex = 47;
            this.endDateDTP.Value = new System.DateTime(2015, 12, 28, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Start Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startDateDTP
            // 
            this.startDateDTP.CustomFormat = "DateTimePickerFormat.Time";
            this.startDateDTP.Location = new System.Drawing.Point(93, 13);
            this.startDateDTP.Name = "startDateDTP";
            this.startDateDTP.Size = new System.Drawing.Size(142, 20);
            this.startDateDTP.TabIndex = 45;
            this.startDateDTP.Value = new System.DateTime(2015, 12, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Retakes Allowed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmrateSpnr
            // 
            this.frmrateSpnr.Location = new System.Drawing.Point(93, 65);
            this.frmrateSpnr.Name = "frmrateSpnr";
            this.frmrateSpnr.Size = new System.Drawing.Size(141, 20);
            this.frmrateSpnr.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Approval Format";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 49;
            // 
            // blkTaskCombo
            // 
            this.blkTaskCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blkTaskCombo.FormattingEnabled = true;
            this.blkTaskCombo.Location = new System.Drawing.Point(93, 118);
            this.blkTaskCombo.Name = "blkTaskCombo";
            this.blkTaskCombo.Size = new System.Drawing.Size(141, 21);
            this.blkTaskCombo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Blocks Task";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Assigned User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aUserCombo
            // 
            this.aUserCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aUserCombo.FormattingEnabled = true;
            this.aUserCombo.Location = new System.Drawing.Point(93, 145);
            this.aUserCombo.Name = "aUserCombo";
            this.aUserCombo.Size = new System.Drawing.Size(141, 21);
            this.aUserCombo.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Reviewer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aReviewerCombo
            // 
            this.aReviewerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aReviewerCombo.FormattingEnabled = true;
            this.aReviewerCombo.Location = new System.Drawing.Point(93, 172);
            this.aReviewerCombo.Name = "aReviewerCombo";
            this.aReviewerCombo.Size = new System.Drawing.Size(141, 21);
            this.aReviewerCombo.TabIndex = 55;
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(142, 210);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(67, 23);
            this.closeBtn.TabIndex = 60;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(69, 210);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(67, 23);
            this.applyBtn.TabIndex = 59;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // addReviewerBtn
            // 
            this.addReviewerBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addReviewerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addReviewerBtn.Location = new System.Drawing.Point(240, 172);
            this.addReviewerBtn.Name = "addReviewerBtn";
            this.addReviewerBtn.Size = new System.Drawing.Size(21, 21);
            this.addReviewerBtn.TabIndex = 58;
            this.addReviewerBtn.UseVisualStyleBackColor = true;
            this.addReviewerBtn.Click += new System.EventHandler(this.addReviewerBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserBtn.Location = new System.Drawing.Point(240, 145);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(21, 21);
            this.addUserBtn.TabIndex = 57;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // EditTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(270, 243);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.addReviewerBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aReviewerCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aUserCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blkTaskCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDateDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.frmrateSpnr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTasks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.frmrateSpnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker endDateDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDateDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown frmrateSpnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox blkTaskCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aUserCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox aReviewerCombo;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button addReviewerBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button applyBtn;
    }
}