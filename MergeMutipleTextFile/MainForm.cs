using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeMutipleTextFile
{
    public partial class MainForm : Form
    {
        private FolderBrowserDialog _selectInputFolderDialog;
        private SaveFileDialog _saveFileDialog;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            if (SelectInputDirectory())
                EnumTextFiles();
        }

        private void EnumTextFiles()
        {
            if (!Directory.Exists(tbInputDirectory.Text)) return;

            lbTextFileName.Items.Clear();
            foreach (string fileName in Directory.EnumerateFiles(tbInputDirectory.Text, "*.txt",
                SearchOption.TopDirectoryOnly))
            {
                lbTextFileName.Items.Add(fileName);
            }
        }

        private bool SelectInputDirectory()
        {
            if (_selectInputFolderDialog == null)
            {
                _selectInputFolderDialog = new FolderBrowserDialog
                {
                    Description = "请选择文本文件所在目录",
                    ShowNewFolderButton = true
                };
            }

            DialogResult result = _selectInputFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbInputDirectory.Text = _selectInputFolderDialog.SelectedPath;
                return true;
            }

            return false;
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            SelectOutputPath();
        }

        private void SelectOutputPath()
        {
            if (_saveFileDialog == null)
            {
                _saveFileDialog = new SaveFileDialog
                {
                    OverwritePrompt = true,
                    AddExtension = true,
                    CheckPathExists = true,
                    Title = "请选择保存路径",
                    DefaultExt = "txt",
                    Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
                };
            }

            DialogResult result = _saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputFilePath.Text = _saveFileDialog.FileName;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = File.Open(tbOutputFilePath.Text, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        foreach (string filePath in lbTextFileName.Items)
                        {
                            writer.WriteLine(File.ReadAllText(filePath));
                        }
                    }
                    MessageBox.Show(this, "保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(this, "请选择正确的保存路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshFileList_Click(object sender, EventArgs e)
        {
            EnumTextFiles();
        }
    }
}