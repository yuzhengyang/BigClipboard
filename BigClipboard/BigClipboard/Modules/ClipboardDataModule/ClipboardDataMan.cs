using Azylee.Core.DataUtils.StringUtils;
using BigClipboard.Commons;
using BigClipboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Modules.ClipboardDataModule
{
    public static class ClipboardDataMan
    {
        public static List<ClipboardData> ClipboardDataList = new List<ClipboardData>();

        public static void ReadClipboard()
        {
            try
            {
                ClipboardData data = new ClipboardData();
                data.Id = Guid.NewGuid();
                data.CreateTime = DateTime.Now;

                //显示剪贴板中的文本信息
                if (Clipboard.ContainsText())
                {
                    data.Type = ClipboardDataType.Text;
                    data.Data = Clipboard.GetText();
                }
                //显示剪贴板中的图片信息
                if (Clipboard.ContainsImage())
                {
                    data.Type = ClipboardDataType.Image;
                    data.Data = Clipboard.GetImage();
                }
                Add(data);
            }
            catch { }
        }
        public static void Add(ClipboardData data)
        {
            if (data.Type == ClipboardDataType.Text)
            {
                if (!ClipboardDataList.Any(x => x.Data.ToString() == data.Data.ToString()) && Str.Ok(data.Data.ToString()))
                {
                    ClipboardDataList.Add(data);
                    R.MainUI.UI_DGV_Add(data);
                }
            }

            if (data.Type == ClipboardDataType.Image)
            {
                ClipboardDataList.Add(data);
                R.MainUI.UI_DGV_Add(data);
            }
        }
        public static ClipboardData Get(string id)
        {
            try { return ClipboardDataList.FirstOrDefault(x => x.Id.ToString() == id); }
            catch { return null; }
        }
        public static void Clear()
        {
            ClipboardDataList.Clear();
            R.MainUI.UI_DGV_Clear();
        }
    }
}
