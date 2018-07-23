using Azylee.Core.FormUtils;
using Azylee.Core.VersionUtils;
using BigClipboard.Models;
using BigClipboard.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Commons
{
    public static class R
    {
        internal static string EmailAddress = "yuzhyn@163.com";
        internal static MainForm MainUI;
        internal static Version Version = VersionTool.Format(Application.ProductVersion);
        internal static FormManTool FormMan = new FormManTool();//窗体管理器
        internal static long AppRam = 0;
    }
}
