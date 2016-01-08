namespace Torque
{
    partial class TorqueMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorqueMainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.projectDataView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.remSegBtn = new System.Windows.Forms.Button();
            this.addSegBtn = new System.Windows.Forms.Button();
            this.segmentNameList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.remCatBtn = new System.Windows.Forms.Button();
            this.addCatBtn = new System.Windows.Forms.Button();
            this.assetCategoryList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.remAstBtn = new System.Windows.Forms.Button();
            this.addAstBtn = new System.Windows.Forms.Button();
            this.assetList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.remGrpBtn = new System.Windows.Forms.Button();
            this.addGrpBtn = new System.Windows.Forms.Button();
            this.assetGroupsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.remTskBtn = new System.Windows.Forms.Button();
            this.addTskBtn = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.projectDataView);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 531);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 0;
            // 
            // projectDataView
            // 
            this.projectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDataView.Location = new System.Drawing.Point(0, 24);
            this.projectDataView.Name = "projectDataView";
            this.projectDataView.Size = new System.Drawing.Size(1126, 219);
            this.projectDataView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donToolStripMenuItem,
            this.raOneToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // donToolStripMenuItem
            // 
            this.donToolStripMenuItem.Name = "donToolStripMenuItem";
            this.donToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // raOneToolStripMenuItem
            // 
            this.raOneToolStripMenuItem.Name = "raOneToolStripMenuItem";
            this.raOneToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1126, 280);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.remSegBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addSegBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.segmentNameList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 274);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // remSegBtn
            // 
            this.remSegBtn.BackgroundImage = global::Torque.Properties.Resources.minus;
            this.remSegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remSegBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remSegBtn.Location = new System.Drawing.Point(187, 0);
            this.remSegBtn.Margin = new System.Windows.Forms.Padding(0);
            this.remSegBtn.Name = "remSegBtn";
            this.remSegBtn.Size = new System.Drawing.Size(32, 32);
            this.remSegBtn.TabIndex = 3;
            this.remSegBtn.UseVisualStyleBackColor = true;
            // 
            // addSegBtn
            // 
            this.addSegBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addSegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSegBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSegBtn.Location = new System.Drawing.Point(155, 0);
            this.addSegBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addSegBtn.Name = "addSegBtn";
            this.addSegBtn.Size = new System.Drawing.Size(32, 32);
            this.addSegBtn.TabIndex = 2;
            this.addSegBtn.UseVisualStyleBackColor = true;
            this.addSegBtn.Click += new System.EventHandler(this.addSegmentsBtn_Click);
            // 
            // segmentNameList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.segmentNameList, 3);
            this.segmentNameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentNameList.FormattingEnabled = true;
            this.segmentNameList.ItemHeight = 15;
            this.segmentNameList.Location = new System.Drawing.Point(1, 33);
            this.segmentNameList.Margin = new System.Windows.Forms.Padding(1);
            this.segmentNameList.Name = "segmentNameList";
            this.segmentNameList.Size = new System.Drawing.Size(217, 240);
            this.segmentNameList.TabIndex = 0;
            this.segmentNameList.SelectedIndexChanged += new System.EventHandler(this.segmentNameList_SelectedIndexChanged);
            this.segmentNameList.DoubleClick += new System.EventHandler(this.segmentNameList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Segments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.remCatBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.addCatBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.assetCategoryList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 274);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // remCatBtn
            // 
            this.remCatBtn.BackgroundImage = global::Torque.Properties.Resources.minus;
            this.remCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remCatBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remCatBtn.Enabled = false;
            this.remCatBtn.Location = new System.Drawing.Point(187, 0);
            this.remCatBtn.Margin = new System.Windows.Forms.Padding(0);
            this.remCatBtn.Name = "remCatBtn";
            this.remCatBtn.Size = new System.Drawing.Size(32, 32);
            this.remCatBtn.TabIndex = 3;
            this.remCatBtn.UseVisualStyleBackColor = true;
            // 
            // addCatBtn
            // 
            this.addCatBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCatBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCatBtn.Enabled = false;
            this.addCatBtn.Location = new System.Drawing.Point(155, 0);
            this.addCatBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.Size = new System.Drawing.Size(32, 32);
            this.addCatBtn.TabIndex = 2;
            this.addCatBtn.UseVisualStyleBackColor = true;
            this.addCatBtn.Click += new System.EventHandler(this.addCatBtn_Click);
            // 
            // assetCategoryList
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.assetCategoryList, 3);
            this.assetCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetCategoryList.FormattingEnabled = true;
            this.assetCategoryList.ItemHeight = 15;
            this.assetCategoryList.Location = new System.Drawing.Point(1, 33);
            this.assetCategoryList.Margin = new System.Windows.Forms.Padding(1);
            this.assetCategoryList.Name = "assetCategoryList";
            this.assetCategoryList.Size = new System.Drawing.Size(217, 240);
            this.assetCategoryList.TabIndex = 0;
            this.assetCategoryList.SelectedIndexChanged += new System.EventHandler(this.assetCategoryList_SelectedIndexChanged);
            this.assetCategoryList.DoubleClick += new System.EventHandler(this.assetCategoryList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categories";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Controls.Add(this.remAstBtn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.addAstBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.assetList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(678, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(219, 274);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // remAstBtn
            // 
            this.remAstBtn.BackgroundImage = global::Torque.Properties.Resources.minus;
            this.remAstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remAstBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remAstBtn.Enabled = false;
            this.remAstBtn.Location = new System.Drawing.Point(187, 0);
            this.remAstBtn.Margin = new System.Windows.Forms.Padding(0);
            this.remAstBtn.Name = "remAstBtn";
            this.remAstBtn.Size = new System.Drawing.Size(32, 32);
            this.remAstBtn.TabIndex = 3;
            this.remAstBtn.UseVisualStyleBackColor = true;
            // 
            // addAstBtn
            // 
            this.addAstBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addAstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAstBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAstBtn.Enabled = false;
            this.addAstBtn.Location = new System.Drawing.Point(155, 0);
            this.addAstBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addAstBtn.Name = "addAstBtn";
            this.addAstBtn.Size = new System.Drawing.Size(32, 32);
            this.addAstBtn.TabIndex = 2;
            this.addAstBtn.UseVisualStyleBackColor = true;
            this.addAstBtn.Click += new System.EventHandler(this.addAstBtn_Click);
            // 
            // assetList
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.assetList, 3);
            this.assetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetList.FormattingEnabled = true;
            this.assetList.ItemHeight = 15;
            this.assetList.Location = new System.Drawing.Point(1, 33);
            this.assetList.Margin = new System.Windows.Forms.Padding(1);
            this.assetList.Name = "assetList";
            this.assetList.Size = new System.Drawing.Size(217, 240);
            this.assetList.TabIndex = 0;
            this.assetList.SelectedIndexChanged += new System.EventHandler(this.assetList_SelectedIndexChanged);
            this.assetList.DoubleClick += new System.EventHandler(this.assetList_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Assets";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Controls.Add(this.remGrpBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.addGrpBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.assetGroupsList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(453, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(219, 274);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // remGrpBtn
            // 
            this.remGrpBtn.BackgroundImage = global::Torque.Properties.Resources.minus;
            this.remGrpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remGrpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remGrpBtn.Enabled = false;
            this.remGrpBtn.Location = new System.Drawing.Point(187, 0);
            this.remGrpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.remGrpBtn.Name = "remGrpBtn";
            this.remGrpBtn.Size = new System.Drawing.Size(32, 32);
            this.remGrpBtn.TabIndex = 3;
            this.remGrpBtn.UseVisualStyleBackColor = true;
            // 
            // addGrpBtn
            // 
            this.addGrpBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addGrpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addGrpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGrpBtn.Enabled = false;
            this.addGrpBtn.Location = new System.Drawing.Point(155, 0);
            this.addGrpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addGrpBtn.Name = "addGrpBtn";
            this.addGrpBtn.Size = new System.Drawing.Size(32, 32);
            this.addGrpBtn.TabIndex = 2;
            this.addGrpBtn.UseVisualStyleBackColor = true;
            this.addGrpBtn.Click += new System.EventHandler(this.addGrpBtn_Click);
            // 
            // assetGroupsList
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.assetGroupsList, 3);
            this.assetGroupsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetGroupsList.FormattingEnabled = true;
            this.assetGroupsList.ItemHeight = 15;
            this.assetGroupsList.Location = new System.Drawing.Point(1, 33);
            this.assetGroupsList.Margin = new System.Windows.Forms.Padding(1);
            this.assetGroupsList.Name = "assetGroupsList";
            this.assetGroupsList.Size = new System.Drawing.Size(217, 240);
            this.assetGroupsList.TabIndex = 0;
            this.assetGroupsList.SelectedIndexChanged += new System.EventHandler(this.assetGroupsList_SelectedIndexChanged);
            this.assetGroupsList.DoubleClick += new System.EventHandler(this.assetGroupsList_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Groups";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.Controls.Add(this.remTskBtn, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.addTskBtn, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.taskList, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(903, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(220, 274);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // remTskBtn
            // 
            this.remTskBtn.BackgroundImage = global::Torque.Properties.Resources.minus;
            this.remTskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remTskBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remTskBtn.Enabled = false;
            this.remTskBtn.Location = new System.Drawing.Point(188, 0);
            this.remTskBtn.Margin = new System.Windows.Forms.Padding(0);
            this.remTskBtn.Name = "remTskBtn";
            this.remTskBtn.Size = new System.Drawing.Size(32, 32);
            this.remTskBtn.TabIndex = 3;
            this.remTskBtn.UseVisualStyleBackColor = true;
            // 
            // addTskBtn
            // 
            this.addTskBtn.BackgroundImage = global::Torque.Properties.Resources.add18;
            this.addTskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTskBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTskBtn.Enabled = false;
            this.addTskBtn.Location = new System.Drawing.Point(156, 0);
            this.addTskBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addTskBtn.Name = "addTskBtn";
            this.addTskBtn.Size = new System.Drawing.Size(32, 32);
            this.addTskBtn.TabIndex = 2;
            this.addTskBtn.UseVisualStyleBackColor = true;
            this.addTskBtn.Click += new System.EventHandler(this.addTskBtn_Click);
            // 
            // taskList
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.taskList, 3);
            this.taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 15;
            this.taskList.Location = new System.Drawing.Point(1, 33);
            this.taskList.Margin = new System.Windows.Forms.Padding(1);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(218, 240);
            this.taskList.TabIndex = 0;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.taskList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tasks";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TorqueMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1128, 531);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1144, 569);
            this.MinimumSize = new System.Drawing.Size(1144, 569);
            this.Name = "TorqueMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torque";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView projectDataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remSegBtn;
        private System.Windows.Forms.Button addSegBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button remAstBtn;
        private System.Windows.Forms.Button addAstBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button remGrpBtn;
        private System.Windows.Forms.Button addGrpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button remCatBtn;
        private System.Windows.Forms.Button addCatBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button remTskBtn;
        private System.Windows.Forms.Button addTskBtn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox segmentNameList;
        public System.Windows.Forms.ListBox assetList;
        public System.Windows.Forms.ListBox assetGroupsList;
        public System.Windows.Forms.ListBox assetCategoryList;
        public System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raOneToolStripMenuItem;




    }
}