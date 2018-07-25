namespace BigClipboard.Views.MainViews
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.DGVList = new System.Windows.Forms.DataGridView();
            this.COLTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLDataSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLRamInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报告问题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提供建议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TCData = new System.Windows.Forms.TabControl();
            this.TPText = new System.Windows.Forms.TabPage();
            this.TBText = new System.Windows.Forms.TextBox();
            this.TPImage = new System.Windows.Forms.TabPage();
            this.PNImageContainer = new System.Windows.Forms.Panel();
            this.TPTable = new System.Windows.Forms.TabPage();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.BTSearch = new System.Windows.Forms.Button();
            this.TMMain = new System.Windows.Forms.Timer(this.components);
            this.NIMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMSMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.PNMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TCData.SuspendLayout();
            this.TPText.SuspendLayout();
            this.TPImage.SuspendLayout();
            this.PNImageContainer.SuspendLayout();
            this.TPTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CMSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBImage
            // 
            this.PBImage.Location = new System.Drawing.Point(3, 3);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(361, 325);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBImage.TabIndex = 1;
            this.PBImage.TabStop = false;
            // 
            // DGVList
            // 
            this.DGVList.AllowUserToAddRows = false;
            this.DGVList.AllowUserToDeleteRows = false;
            this.DGVList.AllowUserToResizeColumns = false;
            this.DGVList.AllowUserToResizeRows = false;
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLTime,
            this.COLContent,
            this.COLId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVList.Location = new System.Drawing.Point(0, 0);
            this.DGVList.Name = "DGVList";
            this.DGVList.ReadOnly = true;
            this.DGVList.RowHeadersVisible = false;
            this.DGVList.RowTemplate.Height = 23;
            this.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVList.Size = new System.Drawing.Size(283, 359);
            this.DGVList.TabIndex = 2;
            this.DGVList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVList_CellClick);
            this.DGVList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVList_KeyDown);
            // 
            // COLTime
            // 
            this.COLTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.COLTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.COLTime.HeaderText = "时间";
            this.COLTime.Name = "COLTime";
            this.COLTime.ReadOnly = true;
            this.COLTime.Width = 54;
            // 
            // COLContent
            // 
            this.COLContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COLContent.HeaderText = "内容";
            this.COLContent.Name = "COLContent";
            this.COLContent.ReadOnly = true;
            // 
            // COLId
            // 
            this.COLId.HeaderText = "Id";
            this.COLId.Name = "COLId";
            this.COLId.ReadOnly = true;
            this.COLId.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLDataSize,
            this.TSSLRamInfo,
            this.TSSLVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLDataSize
            // 
            this.TSSLDataSize.Name = "TSSLDataSize";
            this.TSSLDataSize.Size = new System.Drawing.Size(97, 17);
            this.TSSLDataSize.Text = "当前数据大小：*";
            // 
            // TSSLRamInfo
            // 
            this.TSSLRamInfo.Name = "TSSLRamInfo";
            this.TSSLRamInfo.Size = new System.Drawing.Size(97, 17);
            this.TSSLRamInfo.Text = "空间占用情况：*";
            // 
            // TSSLVersion
            // 
            this.TSSLVersion.Name = "TSSLVersion";
            this.TSSLVersion.Size = new System.Drawing.Size(49, 17);
            this.TSSLVersion.Text = "版本：*";
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(745, 25);
            this.MSMain.TabIndex = 5;
            this.MSMain.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "工具";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送反馈ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 发送反馈ToolStripMenuItem
            // 
            this.发送反馈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.报告问题ToolStripMenuItem,
            this.提供建议ToolStripMenuItem});
            this.发送反馈ToolStripMenuItem.Name = "发送反馈ToolStripMenuItem";
            this.发送反馈ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.发送反馈ToolStripMenuItem.Text = "发送反馈";
            // 
            // 报告问题ToolStripMenuItem
            // 
            this.报告问题ToolStripMenuItem.Name = "报告问题ToolStripMenuItem";
            this.报告问题ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.报告问题ToolStripMenuItem.Text = "报告问题";
            this.报告问题ToolStripMenuItem.Click += new System.EventHandler(this.报告问题ToolStripMenuItem_Click);
            // 
            // 提供建议ToolStripMenuItem
            // 
            this.提供建议ToolStripMenuItem.Name = "提供建议ToolStripMenuItem";
            this.提供建议ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.提供建议ToolStripMenuItem.Text = "提供建议";
            this.提供建议ToolStripMenuItem.Click += new System.EventHandler(this.提供建议ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // PNMain
            // 
            this.PNMain.Controls.Add(this.panel3);
            this.PNMain.Controls.Add(this.panel2);
            this.PNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNMain.Location = new System.Drawing.Point(0, 25);
            this.PNMain.Name = "PNMain";
            this.PNMain.Padding = new System.Windows.Forms.Padding(10);
            this.PNMain.Size = new System.Drawing.Size(745, 414);
            this.PNMain.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TCData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 394);
            this.panel3.TabIndex = 1;
            // 
            // TCData
            // 
            this.TCData.Controls.Add(this.TPText);
            this.TCData.Controls.Add(this.TPImage);
            this.TCData.Controls.Add(this.TPTable);
            this.TCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCData.Location = new System.Drawing.Point(0, 0);
            this.TCData.Name = "TCData";
            this.TCData.SelectedIndex = 0;
            this.TCData.Size = new System.Drawing.Size(442, 394);
            this.TCData.TabIndex = 4;
            // 
            // TPText
            // 
            this.TPText.Controls.Add(this.TBText);
            this.TPText.Location = new System.Drawing.Point(4, 22);
            this.TPText.Name = "TPText";
            this.TPText.Padding = new System.Windows.Forms.Padding(3);
            this.TPText.Size = new System.Drawing.Size(434, 368);
            this.TPText.TabIndex = 0;
            this.TPText.Text = "文本";
            this.TPText.UseVisualStyleBackColor = true;
            // 
            // TBText
            // 
            this.TBText.BackColor = System.Drawing.Color.White;
            this.TBText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBText.Location = new System.Drawing.Point(3, 3);
            this.TBText.Multiline = true;
            this.TBText.Name = "TBText";
            this.TBText.ReadOnly = true;
            this.TBText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBText.Size = new System.Drawing.Size(428, 362);
            this.TBText.TabIndex = 0;
            this.TBText.WordWrap = false;
            // 
            // TPImage
            // 
            this.TPImage.Controls.Add(this.PNImageContainer);
            this.TPImage.Location = new System.Drawing.Point(4, 22);
            this.TPImage.Name = "TPImage";
            this.TPImage.Padding = new System.Windows.Forms.Padding(3);
            this.TPImage.Size = new System.Drawing.Size(434, 368);
            this.TPImage.TabIndex = 1;
            this.TPImage.Text = "图片";
            this.TPImage.UseVisualStyleBackColor = true;
            // 
            // PNImageContainer
            // 
            this.PNImageContainer.AutoScroll = true;
            this.PNImageContainer.BackColor = System.Drawing.Color.White;
            this.PNImageContainer.Controls.Add(this.PBImage);
            this.PNImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNImageContainer.Location = new System.Drawing.Point(3, 3);
            this.PNImageContainer.Name = "PNImageContainer";
            this.PNImageContainer.Size = new System.Drawing.Size(428, 362);
            this.PNImageContainer.TabIndex = 2;
            // 
            // TPTable
            // 
            this.TPTable.Controls.Add(this.DGVData);
            this.TPTable.Location = new System.Drawing.Point(4, 22);
            this.TPTable.Name = "TPTable";
            this.TPTable.Padding = new System.Windows.Forms.Padding(3);
            this.TPTable.Size = new System.Drawing.Size(434, 368);
            this.TPTable.TabIndex = 2;
            this.TPTable.Text = "表格";
            this.TPTable.UseVisualStyleBackColor = true;
            // 
            // DGVData
            // 
            this.DGVData.AllowUserToAddRows = false;
            this.DGVData.AllowUserToDeleteRows = false;
            this.DGVData.BackgroundColor = System.Drawing.Color.White;
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVData.Location = new System.Drawing.Point(3, 3);
            this.DGVData.Name = "DGVData";
            this.DGVData.ReadOnly = true;
            this.DGVData.RowHeadersVisible = false;
            this.DGVData.RowTemplate.Height = 23;
            this.DGVData.Size = new System.Drawing.Size(428, 362);
            this.DGVData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 394);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 359);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBSearch);
            this.panel1.Controls.Add(this.BTSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 35);
            this.panel1.TabIndex = 3;
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(4, 6);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(192, 21);
            this.TBSearch.TabIndex = 1;
            // 
            // BTSearch
            // 
            this.BTSearch.Location = new System.Drawing.Point(202, 5);
            this.BTSearch.Name = "BTSearch";
            this.BTSearch.Size = new System.Drawing.Size(75, 23);
            this.BTSearch.TabIndex = 0;
            this.BTSearch.Text = "搜索";
            this.BTSearch.UseVisualStyleBackColor = true;
            this.BTSearch.Click += new System.EventHandler(this.BTSearch_Click);
            // 
            // TMMain
            // 
            this.TMMain.Enabled = true;
            this.TMMain.Interval = 1000;
            this.TMMain.Tick += new System.EventHandler(this.TMMain_Tick);
            // 
            // NIMain
            // 
            this.NIMain.ContextMenuStrip = this.CMSMain;
            this.NIMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NIMain.Icon")));
            this.NIMain.Text = "剪贴板";
            this.NIMain.Visible = true;
            this.NIMain.DoubleClick += new System.EventHandler(this.NIMain_DoubleClick);
            // 
            // CMSMain
            // 
            this.CMSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.CMSMain.Name = "CMSMain";
            this.CMSMain.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.BTSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 461);
            this.Controls.Add(this.PNMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MSMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "剪贴板 - BigClipboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.PNMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.TCData.ResumeLayout(false);
            this.TPText.ResumeLayout(false);
            this.TPText.PerformLayout();
            this.TPImage.ResumeLayout(false);
            this.PNImageContainer.ResumeLayout(false);
            this.PNImageContainer.PerformLayout();
            this.TPTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CMSMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.DataGridView DGVList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLVersion;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.Panel PNMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl TCData;
        private System.Windows.Forms.TabPage TPText;
        private System.Windows.Forms.TabPage TPImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLId;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.TabPage TPTable;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button BTSearch;
        private System.Windows.Forms.ToolStripStatusLabel TSSLDataSize;
        private System.Windows.Forms.ToolStripStatusLabel TSSLRamInfo;
        private System.Windows.Forms.Timer TMMain;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报告问题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提供建议ToolStripMenuItem;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.Panel PNImageContainer;
        private System.Windows.Forms.NotifyIcon NIMain;
        private System.Windows.Forms.ContextMenuStrip CMSMain;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}