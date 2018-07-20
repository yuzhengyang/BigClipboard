using Azylee.Core.DataUtils.CollectionUtils;
using Azylee.Core.DataUtils.StringUtils;
using Azylee.Core.WindowsUtils.HookUtils;
using BigClipboard.Commons;
using BigClipboard.Models;
using BigClipboard.Modules.ClipboardDataModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Views.MainViews
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            TSSLVersion.Text = R.Version.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mNextClipBoardViewerHWnd = SetClipboardViewer(this.Handle);
        }

        #region 按钮操作

        private void BTSearch_Click(object sender, EventArgs e)
        {
            ClipboardDataMan.Search(TBSearch.Text);
        }
        #endregion

        #region 菜单操作
        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClipboardDataMan.Clear();
        }
        #endregion

        #region 列表表格操作
        public void UI_DGV_Add(ClipboardData data)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    DGVList.Rows.Insert(0, data.CreateTime, data.Text?.Trim(), data.Id);
                }));
            }
            catch { }
        }
        public void UI_DGV_Clear()
        {
            try
            {
                Invoke(new Action(() =>
                {
                    DGVList.Rows.Clear();
                }));
            }
            catch { }
        }
        private void DGVList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVList_Select(e.RowIndex);
        }
        private void DGVList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int index = DGVList.CurrentRow.Index - 1;
                DGVList_Select(index);
            }

            if (e.KeyCode == Keys.Down)
            {
                int index = DGVList.CurrentRow.Index + 1;
                DGVList_Select(index);
            }

            DGVList.Focus();
        }
        private void DGVList_Select(int index)
        {
            if (index >= 0 && index < DGVList.RowCount)
            {
                string id = DGVList.Rows[index].Cells["COLId"].Value.ToString();
                ClipboardData data = ClipboardDataMan.Get(id);
                if (data != null)
                {
                    RTBText.Clear();
                    PBImage.Image = null;
                    DGVData.Rows.Clear();
                    DGVData.Columns.Clear();

                    if (data.Text != null)
                    {
                        //TCData.SelectTab("TPText");
                        RTBText.Text = data.Text;

                        string[] rows = data.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach (var _r in rows)
                        {
                            string[] _d = _r.Split('\t');
                            if (ListTool.HasElements(_d))
                            {
                                if (DGVData.Columns.Count < _d.Length)
                                {
                                    for (int i = DGVData.Columns.Count; i < _d.Length; i++)
                                    {
                                        DGVData.Columns.Add($"DGVData_COL{i}", $"{i + 1}");
                                    }
                                }
                                DGVData.Rows.Add(_d);
                            }
                        }
                    }

                    if (data.Image != null)
                    {
                        //TCData.SelectTab("TPImage");
                        PBImage.Image = (Image)data.Image;
                        PBImage.Update();
                    }
                }
            }
        }
        #endregion

        #region 监控剪贴板变化
        #region Definitions
        //Constants for API Calls...
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        //Handle for next clipboard viewer...
        private IntPtr mNextClipBoardViewerHWnd;

        //API declarations...
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion
        #region Message Process
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        ClipboardDataMan.ReadClipboard();
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        //Another clipboard viewer has removed itself...
                        if (m.WParam == (IntPtr)mNextClipBoardViewerHWnd)
                        {
                            mNextClipBoardViewerHWnd = m.LParam;
                        }
                        else
                        {
                            SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }

        #endregion 
        #endregion

    }
}
