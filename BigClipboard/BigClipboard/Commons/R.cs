using Azylee.Core.VersionUtils;
using BigClipboard.Models;
using BigClipboard.Views.MainViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Commons
{
    public static class R
    { 
        internal static MainForm MainUI;
        internal static Version Version = VersionTool.Format(Application.ProductVersion);
    }
}
