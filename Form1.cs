using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 리스트뷰 색상 직접 그리기 이벤트 연결
            lvwLeftDir.OwnerDraw = true;
            lvwLeftDir.DrawColumnHeader += Lvw_DrawColumnHeader;
            lvwLeftDir.DrawItem += Lvw_DrawItem;
            lvwLeftDir.DrawSubItem += Lvw_DrawSubItem;

            lvwRightdir.OwnerDraw = true;
            lvwRightdir.DrawColumnHeader += Lvw_DrawColumnHeader;
            lvwRightdir.DrawItem += Lvw_DrawItem;
            lvwRightdir.DrawSubItem += Lvw_DrawSubItem;
        }

        private void Lvw_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void Lvw_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = false;
        }

        private void Lvw_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, e.Bounds, e.Item.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        // [과제 2] 리스트 출력
        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                var dirs = Directory.EnumerateDirectories(folderPath)
                   .Select(p => new DirectoryInfo(p))
                   .OrderBy(d => d.Name);

                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                var files = Directory.EnumerateFiles(folderPath)
                   .Select(p => new FileInfo(p))
                   .OrderBy(f => f.Name);

                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(f.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        // [과제 4 적용] 상태 결정 및 색상 적용 (폴더와 파일을 묶어서 한 번에 처리)
        private void CompareAndColor()
        {
            if (!Directory.Exists(txtLeftDir.Text) || !Directory.Exists(txtRightDir.Text)) return;

            // ⭐ FileSystemInfo를 사용해 폴더와 파일을 구분 없이 딕셔너리에 담음 (과제 4 핵심)
            var leftItems = new DirectoryInfo(txtLeftDir.Text).GetFileSystemInfos().ToDictionary(info => info.Name, info => info, StringComparer.OrdinalIgnoreCase);
            var rightItems = new DirectoryInfo(txtRightDir.Text).GetFileSystemInfos().ToDictionary(info => info.Name, info => info, StringComparer.OrdinalIgnoreCase);

            // 왼쪽 리스트 색상 처리
            foreach (ListViewItem litem in lvwLeftDir.Items)
            {
                string name = litem.Text;
                leftItems.TryGetValue(name, out FileSystemInfo leftInfo);
                rightItems.TryGetValue(name, out FileSystemInfo rightInfo);

                if (rightInfo != null)
                {
                    string leftTime = leftInfo.LastWriteTime.ToString("g");
                    string rightTime = rightInfo.LastWriteTime.ToString("g");

                    if (leftTime == rightTime) litem.ForeColor = Color.Black;
                    else if (leftInfo.LastWriteTime > rightInfo.LastWriteTime) litem.ForeColor = Color.Red;
                    else litem.ForeColor = Color.Gray;
                }
                else
                {
                    litem.ForeColor = Color.Purple;
                }
            }

            // 오른쪽 리스트 색상 처리
            foreach (ListViewItem ritem in lvwRightdir.Items)
            {
                string name = ritem.Text;
                leftItems.TryGetValue(name, out FileSystemInfo leftInfo);
                rightItems.TryGetValue(name, out FileSystemInfo rightInfo);

                if (leftInfo != null)
                {
                    string leftTime = leftInfo.LastWriteTime.ToString("g");
                    string rightTime = rightInfo.LastWriteTime.ToString("g");

                    if (rightTime == leftTime) ritem.ForeColor = Color.Black;
                    else if (rightInfo.LastWriteTime > leftInfo.LastWriteTime) ritem.ForeColor = Color.Red;
                    else ritem.ForeColor = Color.Gray;
                }
                else
                {
                    ritem.ForeColor = Color.Purple;
                }
            }
        }

        // [과제 3] 단일 파일 복사
        private void CopyFileWithConfirmation(string srcPath, string destPath)
        {
            bool shouldCopy = true;
            if (File.Exists(destPath))
            {
                FileInfo src = new FileInfo(srcPath);
                FileInfo dest = new FileInfo(destPath);
                if (src.LastWriteTime < dest.LastWriteTime)
                {
                    if (MessageBox.Show($"'{src.Name}' 대상 파일이 더 최신입니다. 덮어쓰시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        shouldCopy = false;
                }
            }
            if (shouldCopy) File.Copy(srcPath, destPath, true);
        }

        // [과제 4] 폴더 및 내부 항목 통째로 복사하는 재귀 함수
        private void CopyDirectoryRecursively(string sourceDir, string destDir)
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists) return;

            DirectoryInfo[] subDirs = dir.GetDirectories();
            Directory.CreateDirectory(destDir); // 대상 폴더 생성

            // 1. 현재 폴더 안의 파일들 복사
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destDir, file.Name);
                file.CopyTo(targetFilePath, true); // 하위 항목은 알림 없이 일괄 덮어쓰기
            }

            // 2. 현재 폴더 안의 하위 폴더들 복사 (자기 자신을 다시 호출!)
            foreach (DirectoryInfo subDir in subDirs)
            {
                string newDestDir = Path.Combine(destDir, subDir.Name);
                CopyDirectoryRecursively(subDir.FullName, newDestDir);
            }
        }

        private void btnCopyToRight_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtLeftDir.Text) || !Directory.Exists(txtRightDir.Text)) return;

            foreach (ListViewItem item in lvwLeftDir.SelectedItems)
            {
                var name = item.Text;
                string src = Path.Combine(txtLeftDir.Text, name);
                string dest = Path.Combine(txtRightDir.Text, name);

                if (File.Exists(src)) // 파일일 경우
                {
                    CopyFileWithConfirmation(src, dest);
                }
                else if (Directory.Exists(src)) // 폴더일 경우 (과제 4 적용)
                {
                    CopyDirectoryRecursively(src, dest);
                }
            }
            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightdir, txtRightDir.Text);
            CompareAndColor();
        }

        private void btnCopyToLeft_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtLeftDir.Text) || !Directory.Exists(txtRightDir.Text)) return;

            foreach (ListViewItem item in lvwRightdir.SelectedItems)
            {
                var name = item.Text;
                string src = Path.Combine(txtRightDir.Text, name);
                string dest = Path.Combine(txtLeftDir.Text, name);

                if (File.Exists(src)) // 파일일 경우
                {
                    CopyFileWithConfirmation(src, dest);
                }
                else if (Directory.Exists(src)) // 폴더일 경우 (과제 4 적용)
                {
                    CopyDirectoryRecursively(src, dest);
                }
            }
            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightdir, txtRightDir.Text);
            CompareAndColor();
        }

        private void btnLeftDir_Click_1(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, txtLeftDir.Text);
                    CompareAndColor();
                }
            }
        }
         
        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwRightdir, txtRightDir.Text);
                    CompareAndColor();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lvwRightdir_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
    }
}