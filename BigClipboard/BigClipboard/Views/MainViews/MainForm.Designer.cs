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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.DGVList = new System.Windows.Forms.DataGridView();
            this.RTBText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TCData = new System.Windows.Forms.TabControl();
            this.TPText = new System.Windows.Forms.TabPage();
            this.TPImage = new System.Windows.Forms.TabPage();
            this.COLTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.PNMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TCData.SuspendLayout();
            this.TPText.SuspendLayout();
            this.TPImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBImage
            // 
            this.PBImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBImage.Location = new System.Drawing.Point(3, 3);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(408, 364);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVList.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVList.Location = new System.Drawing.Point(0, 0);
            this.DGVList.Name = "DGVList";
            this.DGVList.ReadOnly = true;
            this.DGVList.RowHeadersVisible = false;
            this.DGVList.RowTemplate.Height = 23;
            this.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVList.Size = new System.Drawing.Size(283, 396);
            this.DGVList.TabIndex = 2;
            this.DGVList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVList_CellClick);
            this.DGVList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVList_KeyDown);
            // 
            // RTBText
            // 
            this.RTBText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBText.Location = new System.Drawing.Point(3, 3);
            this.RTBText.Name = "RTBText";
            this.RTBText.ReadOnly = true;
            this.RTBText.Size = new System.Drawing.Size(408, 364);
            this.RTBText.TabIndex = 3;
            this.RTBText.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLVersion
            // 
            this.TSSLVersion.Name = "TSSLVersion";
            this.TSSLVersion.Size = new System.Drawing.Size(45, 17);
            this.TSSLVersion.Text = "1.0.0.0";
            // 
            // MSMain
            // 
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(725, 25);
            this.MSMain.TabIndex = 5;
            this.MSMain.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // PNMain
            // 
            this.PNMain.Controls.Add(this.panel3);
            this.PNMain.Controls.Add(this.panel2);
            this.PNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNMain.Location = new System.Drawing.Point(0, 25);
            this.PNMain.Name = "PNMain";
            this.PNMain.Padding = new System.Windows.Forms.Padding(10);
            this.PNMain.Size = new System.Drawing.Size(725, 416);
            this.PNMain.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 396);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TCData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 396);
            this.panel3.TabIndex = 1;
            // 
            // TCData
            // 
            this.TCData.Controls.Add(this.TPText);
            this.TCData.Controls.Add(this.TPImage);
            this.TCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCData.Location = new System.Drawing.Point(0, 0);
            this.TCData.Name = "TCData";
            this.TCData.SelectedIndex = 0;
            this.TCData.Size = new System.Drawing.Size(422, 396);
            this.TCData.TabIndex = 4;
            // 
            // TPText
            // 
            this.TPText.Controls.Add(this.RTBText);
            this.TPText.Location = new System.Drawing.Point(4, 22);
            this.TPText.Name = "TPText";
            this.TPText.Padding = new System.Windows.Forms.Padding(3);
            this.TPText.Size = new System.Drawing.Size(414, 370);
            this.TPText.TabIndex = 0;
            this.TPText.Text = "文本";
            this.TPText.UseVisualStyleBackColor = true;
            // 
            // TPImage
            // 
            this.TPImage.Controls.Add(this.PBImage);
            this.TPImage.Location = new System.Drawing.Point(4, 22);
            this.TPImage.Name = "TPImage";
            this.TPImage.Padding = new System.Windows.Forms.Padding(3);
            this.TPImage.Size = new System.Drawing.Size(414, 370);
            this.TPImage.TabIndex = 1;
            this.TPImage.Text = "图片";
            this.TPImage.UseVisualStyleBackColor = true;
            // 
            // COLTime
            // 
            this.COLTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            this.COLTime.DefaultCellStyle = dataGridViewCellStyle3;
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
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 463);
            this.Controls.Add(this.PNMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MSMain);
            this.MainMenuStrip = this.MSMain;
            this.Name = "MainForm";
            this.Text = "BigClipboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.PNMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.TCData.ResumeLayout(false);
            this.TPText.ResumeLayout(false);
            this.TPImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBImage;
        private System.Windows.Forms.DataGridView DGVList;
        private System.Windows.Forms.RichTextBox RTBText;
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
    }
}