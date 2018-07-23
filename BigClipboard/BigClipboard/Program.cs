using BigClipboard.Commons;
using BigClipboard.Modules.GCModule;
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
            AutoGC.Start();//开启自动GC

            Application.Run(R.MainUI);
        }
    }
}
