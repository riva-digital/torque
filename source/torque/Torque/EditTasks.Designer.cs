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
            this.revDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.maxRetakesSpnr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
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
            this.durationSpnr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxRetakesSpnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSpnr)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Review Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // revDateDTP
            // 
            this.revDateDTP.CustomFormat = "DateTimePickerFormat.Time";
            this.revDateDTP.Location = new System.Drawing.Point(93, 63);
            this.revDateDTP.Name = "revDateDTP";
            this.revDateDTP.Size = new System.Drawing.Size(142, 20);
            this.revDateDTP.TabIndex = 47;
            this.revDateDTP.Value = new System.DateTime(2015, 12, 28, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 17);
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
            this.label6.Location = new System.Drawing.Point(1, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Retakes Allowed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxRetakesSpnr
            // 
            this.maxRetakesSpnr.Location = new System.Drawing.Point(94, 88);
            this.maxRetakesSpnr.Name = "maxRetakesSpnr";
            this.maxRetakesSpnr.Size = new System.Drawing.Size(141, 20);
            this.maxRetakesSpnr.TabIndex = 42;
            this.maxRetakesSpnr.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Approval Format";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blkTaskCombo
            // 
            this.blkTaskCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blkTaskCombo.FormattingEnabled = true;
            this.blkTaskCombo.Location = new System.Drawing.Point(94, 138);
            this.blkTaskCombo.Name = "blkTaskCombo";
            this.blkTaskCombo.Size = new System.Drawing.Size(141, 21);
            this.blkTaskCombo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Blocks Task";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 168);
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
            this.aUserCombo.Location = new System.Drawing.Point(94, 164);
            this.aUserCombo.Name = "aUserCombo";
            this.aUserCombo.Size = new System.Drawing.Size(141, 21);
            this.aUserCombo.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 194);
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
            this.aReviewerCombo.Location = new System.Drawing.Point(94, 190);
            this.aReviewerCombo.Name = "aReviewerCombo";
            this.aReviewerCombo.Size = new System.Drawing.Size(141, 21);
            this.aReviewerCombo.TabIndex = 55;
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(142, 224);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(67, 23);
            this.closeBtn.TabIndex = 60;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(69, 224);
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
            this.addReviewerBtn.Location = new System.Drawing.Point(241, 190);
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
            this.addUserBtn.Location = new System.Drawing.Point(241, 164);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(21, 21);
            this.addUserBtn.TabIndex = 57;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // durationSpnr
            // 
            this.durationSpnr.Location = new System.Drawing.Point(93, 38);
            this.durationSpnr.Name = "durationSpnr";
            this.durationSpnr.Size = new System.Drawing.Size(142, 20);
            this.durationSpnr.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Duration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 49;
            // 
            // EditTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(270, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationSpnr);
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
            this.Controls.Add(this.revDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDateDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxRetakesSpnr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTasks";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.maxRetakesSpnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSpnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker revDateDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDateDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown maxRetakesSpnr;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.NumericUpDown durationSpnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}