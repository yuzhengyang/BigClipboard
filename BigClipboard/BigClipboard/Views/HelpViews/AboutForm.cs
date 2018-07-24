using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Views.HelpViews
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void BTGithub_Click(object sender, EventArgs e)
        {
            Process.Start($"https://github.com/yuzhengyang/BigClipboard");
        }
    }
}
