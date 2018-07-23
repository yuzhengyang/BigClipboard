namespace BigClipboard.Views.HelpViews
{
    partial class AboutForm
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
            this.BTGithub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTGithub
            // 
            this.BTGithub.Location = new System.Drawing.Point(244, 31);
            this.BTGithub.Name = "BTGithub";
            this.BTGithub.Size = new System.Drawing.Size(75, 23);
            this.BTGithub.TabIndex = 0;
            this.BTGithub.Text = "Github";
            this.BTGithub.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "记录剪贴板历史的小应用\r\n\r\n目前支持：\r\n1、纯文本信息\r\n2、文本表格转换\r\n3、单张图片\r\n\r\n\r\n2018年7月23日";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTGithub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTGithub;
        private System.Windows.Forms.Label label1;
    }
}