using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.DataUtils.EncryptUtils;
using Azylee.Core.DataUtils.SerializeUtils;
using Azylee.Core.DataUtils.StringUtils;
using BigClipboard.Commons;
using BigClipboard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigClipboard.Modules.ClipboardDataModule
{
    public static class ClipboardDataMan
    {
        public static List<ClipboardData> ClipboardDataList = new List<ClipboardData>();

        public static void ReadClipboard()
        {
            ClipboardData data = new ClipboardData();
            data.Id = Guid.NewGuid();
            data.CreateTime = DateTime.Now;

            //读取纯文本
            try { if (Clipboard.ContainsText()) data.Text = Clipboard.GetText(); } catch { }

            //读取富文本（实在是解决不了内存的占用问题，所以暂时不读取富文本内容了）
            //try
            //{
            //    RichTextBox _rt = new RichTextBox();
            //    _rt.Paste();
            //    using (Stream s = new MemoryStream())
            //    {
            //        _rt.SaveFile(s, RichTextBoxStreamType.RichText);
            //        data.RichText = new byte[(int)s.Length];
            //        s.Position = 0;
            //        s.Read(data.RichText, 0, data.RichText.Length);
            //    }
            //}
            //catch { }

            //读取图片
            try { if (Clipboard.ContainsImage()) data.Image = Clipboard.GetImage(); } catch { }

            //计算综合MD5值
            string md5_text = MD5Tool.Encrypt(SerializeTool.Serialize(data.Text));
            //string md5_rich = MD5Tool.Encrypt(data.RichText);
            string md5_image = MD5Tool.Encrypt(SerializeTool.Serialize(data.Image));
            data.MD5 = $"{md5_text}{md5_image}";

            byte[] _data = SerializeTool.Serialize(data);
            if (_data != null) data.Size = _data.Length;

            if (Str.Ok(data.MD5) && (Str.Ok(data.Text) || data.Image != null)) Add(data);
        }
        public static void Add(ClipboardData data)
        {
            if (!ClipboardDataList.Any(x => x.MD5 == data.MD5))
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
        public static void Search(string words)
        {
            Task.Factory.StartNew(() =>
            {
                R.MainUI.UI_DGV_Clear();
                if (Str.Ok(words))
                {
                    List<ClipboardData> record = ClipboardDataList.Where(x => x.Text != null && x.Text.Contains(words)).ToList();
                    if (ListTool.HasElements(record))
                    {
                        foreach (var item in record) R.MainUI.UI_DGV_Add(item);
                    }
                }
                else
                {
                    if (ListTool.HasElements(ClipboardDataList))
                    {
                        foreach (var item in ClipboardDataList) R.MainUI.UI_DGV_Add(item);
                    }
                }
            });
        }
        public static void Clear()
        {
            ClipboardDataList.Clear();
            R.MainUI.UI_DGV_Clear();
        }
    }
}
