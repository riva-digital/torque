namespace Torque
{
    partial class AddTasks
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
            this.deptListBox = new System.Windows.Forms.CheckedListBox();
            this.defineNewBtn = new System.Windows.Forms.Button();
            this.addSelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deptListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.deptListBox, 3);
            this.deptListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deptListBox.FormattingEnabled = true;
            this.deptListBox.Location = new System.Drawing.Point(3, 3);
            this.deptListBox.Name = "deptListBox";
            this.deptListBox.Size = new System.Drawing.Size(200, 225);
            this.deptListBox.TabIndex = 0;
            // 
            // defineNewBtn
            // 
            this.defineNewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineNewBtn.Location = new System.Drawing.Point(26, 234);
            this.defineNewBtn.Name = "defineNewBtn";
            this.defineNewBtn.Size = new System.Drawing.Size(76, 25);
            this.defineNewBtn.TabIndex = 1;
            this.defineNewBtn.Text = "Define New";
            this.defineNewBtn.UseVisualStyleBackColor = true;
            this.defineNewBtn.Click += new System.EventHandler(this.defineNewBtn_Click);
            // 
            // addSelBtn
            // 
            this.addSelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSelBtn.Location = new System.Drawing.Point(108, 234);
            this.addSelBtn.Name = "addSelBtn";
            this.addSelBtn.Size = new System.Drawing.Size(95, 25);
            this.addSelBtn.TabIndex = 2;
            this.addSelBtn.Text = "Add Selected";
            this.addSelBtn.UseVisualStyleBackColor = true;
            this.addSelBtn.Click += new System.EventHandler(this.addSelBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.deptListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addSelBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.defineNewBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.18565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.81435F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 262);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AddTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Departments";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox deptListBox;
        private System.Windows.Forms.Button defineNewBtn;
        private System.Windows.Forms.Button addSelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}