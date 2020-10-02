using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessCommunication
{
    public partial class Form1 : Form
    {
        private Process processCmd;
        private NamedPipeServerStream _pipeServerStream;
        private StreamWriter _pipeServerStreamWriter;
        private StreamReader _pipeServerStreamReader;
        private NamedPipeClientStream _pipeClientStream;
        private StreamWriter _pipeClientStreamWriter;
        private StreamReader _pipeClientStreamReader;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCmdShutdown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这就算了吧...");
        }

        private void btnCmdGetmac_Click(object sender, EventArgs e)
        {
            if (processCmd == null)
            {
                processCmd = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe",
                        CreateNoWindow = true,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false
                    }
                };
                processCmd.OutputDataReceived += (o, args) =>
                    tbCmd.Invoke(new AppendText(data => tbCmd.AppendText(data + "\r\n")), args.Data);
                processCmd.Start();
                processCmd.BeginOutputReadLine();
            }

            processCmd.StandardInput.WriteLine("getmac");
        }

        private delegate void AppendText(string data);

        private void btnPipeClientConnect_Click(object sender, EventArgs e)
        {
            btnPipeClientConnect.Enabled = false;
            if (_pipeClientStream == null)
            {
                _pipeClientStream = new NamedPipeClientStream("127.0.0.1", "MYPIPE", PipeDirection.InOut,
                    PipeOptions.Asynchronous);
                // _pipeClientStream.ReadMode = PipeTransmissionMode.Message;
            }

            try
            {
                _pipeClientStream.Connect(5000);
            }
            catch (TimeoutException)
            {
                btnPipeClientConnect.Enabled = true;
                MessageBox.Show("连接超时！");
                return;
            }

            MessageBox.Show("连接成功！");

            _pipeClientStream.ReadMode = PipeTransmissionMode.Message;
            _pipeClientStreamWriter = new StreamWriter(_pipeClientStream) {AutoFlush = true};
            new Thread(() =>
            {
                _pipeClientStreamReader = new StreamReader(_pipeClientStream);
                while (true)
                {
                    string s = _pipeClientStreamReader.ReadLine();
                    if (s != null)
                        tbPipeClient.Invoke((MethodInvoker) delegate { tbPipeClient.AppendText(s + "\r\n"); });
                }
            }) {IsBackground = true}.Start();
        }

        private void btnPipeServerOpen_Click(object sender, EventArgs e)
        {
            btnPipeServerOpen.Enabled = false;
            if (_pipeServerStream == null)
            {
                _pipeServerStream = new NamedPipeServerStream("MYPIPE", PipeDirection.InOut, 1,
                    PipeTransmissionMode.Message, PipeOptions.Asynchronous);
            }

            ThreadPool.QueueUserWorkItem(state =>
            {
                _pipeServerStream.BeginWaitForConnection(ar =>
                {
                    NamedPipeServerStream pipeServerStream = (NamedPipeServerStream) ar.AsyncState;
                    _pipeServerStreamReader = new StreamReader(_pipeServerStream);
                    _pipeServerStreamWriter = new StreamWriter(_pipeServerStream);
                    pipeServerStream.EndWaitForConnection(ar);
                    _pipeServerStreamWriter.WriteLine("hello~这是来自服务端的消息");
                    while (true)
                    {
                        string s = _pipeServerStreamReader.ReadLine();
                        if (s != null)
                            tbPipeServer.Invoke((MethodInvoker) delegate
                            {
                                tbPipeServer.AppendText(s + "\r\n");
                            });
                    }
                }, _pipeServerStream);
            });
        }

        private void btnPipeClientSend_Click(object sender, EventArgs e)
        {
            if (_pipeClientStream == null)
            {
                MessageBox.Show("未建立连接");
                return;
            }

            if (_pipeClientStreamWriter == null)
            {
                MessageBox.Show("正在处理点小事情，请重试一遍~");
                return;
            }

            _pipeClientStreamWriter.WriteLine(tbPipeClientSend.Text);
        }

        private void btnPipeServerSend_Click(object sender, EventArgs e)
        {
            if (_pipeServerStream == null)
            {
                MessageBox.Show("未开启服务");
                return;
            }

            if (_pipeServerStreamWriter == null)
            {
                MessageBox.Show("正在处理点小事情，请重试一遍~");
                return;
            }

            _pipeServerStreamWriter.WriteLine(tbPipeServerSend.Text);
        }

    }
}