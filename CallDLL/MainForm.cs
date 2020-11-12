using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpSimpleDLL;

namespace CallDLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString());
        }

        [DllImport("VcSimpleDLL.dll", EntryPoint = "my_sub", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Sub(int x, int y);

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyClass.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString());
        }
    }
}
