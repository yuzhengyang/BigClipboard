using Azylee.Core.AppUtils;
using Azylee.Core.ThreadUtils.SleepUtils;
using BigClipboard.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BigClipboard.Modules.GCModule
{
    public static class AutoGC
    {
        private static int Times = 0;
        public static void Start()
        {
            Task.Factory.StartNew(() =>
            {
                while (!R.MainUI.IsDisposed)
                {
                    R.AppRam = AppInfoTool.RAM() * 1024;
                    if (Times > 20)
                    { Times = 0; Clear(); }
                    else
                    { if (R.AppRam > 50 * 1024 * 1024) Clear(); }

                    Times++;
                    Sleep.S(1);
                }
            });
        }
        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void Clear()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion
    }
}
