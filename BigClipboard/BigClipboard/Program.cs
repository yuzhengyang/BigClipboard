using BigClipboard.Commons;
using BigClipboard.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BigClipboard
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            R.MainUI = new MainForm();
            Application.Run(R.MainUI);
        }
    }
}
