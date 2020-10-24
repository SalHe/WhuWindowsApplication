using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinRegInCSharp
{
    public partial class MainForm : Form
    {
        private string _keyPath = @"Software\WinRegManipulation";
        private string _subKeyPath = @"Software\WinRegManipulation\SubKey";

        public MainForm()
        {
            InitializeComponent();

            labelKeyPath.Text = _keyPath;
        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(_keyPath);
            if (key != null)
                MessageBox.Show(this, "创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "创建失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCreateSubKey_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(_subKeyPath);
            if (key != null)
                MessageBox.Show(this, "创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "创建失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_keyPath);
            if (key == null)
            {
                MessageBox.Show(this, "打开键失败！请检查键是否已创建", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbTestDword.Text = ((int) key.GetValue("TestDword")).ToString();
            tbTestString.Text = (string) key.GetValue("TestString");
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_keyPath, true);
            if (key == null)
            {
                MessageBox.Show(this, "打开键失败！请检查键是否已创建！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            key.SetValue("TestDword", int.Parse(tbTestDword.Text), RegistryValueKind.DWord);
            key.SetValue("TestString", tbTestString.Text, RegistryValueKind.String);
            MessageBox.Show(this, "写入完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCrateKey2_Click(object sender, EventArgs e)
        {
            IntPtr hKey;
            if (0 != RegUtil.RegCreateKey(RegUtil.HKEY_CURRENT_USER, _keyPath, out hKey))
            {
                MessageBox.Show(this, "创建失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(this, "创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RegUtil.RegCloseKey(hKey);
        }

        private void btnCreateSubKey2_Click(object sender, EventArgs e)
        {
            IntPtr hKey;
            if (0 != RegUtil.RegCreateKey(RegUtil.HKEY_CURRENT_USER, _subKeyPath, out hKey))
            {
                MessageBox.Show(this, "创建失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(this, "创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RegUtil.RegCloseKey(hKey);
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            IntPtr hKey;
            if (0 != RegUtil.RegOpenKey(RegUtil.HKEY_CURRENT_USER, _keyPath, out hKey))
            {
                MessageBox.Show(this, "打开失败，请检查键是否存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            uint type;
            int testDword = 0;
            uint size = sizeof(int);
            RegUtil.RegQueryValueEx(hKey, "TestDword", 0, out type, out testDword, ref size);
            tbTestDword.Text = testDword.ToString();

            RegUtil.RegQueryValueEx(hKey, "TestString", 0, out type, null, ref size);
            StringBuilder testStringBuilder = new StringBuilder((int)size + 2);
            RegUtil.RegQueryValueEx(hKey, "TestString", 0, out type, testStringBuilder, ref size);
            tbTestString.Text = testStringBuilder.ToString();

            RegUtil.RegCloseKey(hKey);
        }

        private void btnWrite2_Click(object sender, EventArgs e)
        {
            IntPtr hKey;
            if (0 != RegUtil.RegOpenKey(RegUtil.HKEY_CURRENT_USER, _keyPath, out hKey))
            {
                MessageBox.Show(this, "打开失败，请检查键是否存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dword = int.Parse(tbTestDword.Text);
            RegUtil.RegSetValueEx(hKey, "TestDword", 0, RegUtil.REG_DWORD, ref dword, sizeof(int));

            byte[] data = Encoding.Default.GetBytes(tbTestString.Text);
            RegUtil.RegSetValueEx(hKey, "TestString", 0, RegUtil.REG_SZ, tbTestString.Text, (uint)tbTestString.Text.Length * 2);

            RegUtil.RegCloseKey(hKey);
            MessageBox.Show(this, "写入完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}