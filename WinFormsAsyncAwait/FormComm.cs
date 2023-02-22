using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsyncAwait
{
    public partial class FormComm : Form
    {

        private CancellationTokenSource? TokenSource;
        private ManualResetEvent? ManualReset;

        public FormComm()
        {
            InitializeComponent();
        }

        private void Print(string text)
        {
            BeginInvoke(() =>
            {
                richTextBox1.AppendText(text);
                richTextBox1.ScrollToCaret();
                richTextBox1.Refresh();
            });
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TokenSource = new();
            ManualReset = new(true);
            int i = 0;
            Task.Run(() =>
            {
                while (!TokenSource.Token.IsCancellationRequested)
                {
                    ManualReset.WaitOne();  //根据是否收到信号判断是否阻塞当前线程
                    Thread.Sleep(200);
                    Print($"线程【{Environment.CurrentManagedThreadId}】正在运行第{++i}次{Environment.NewLine}");
                }
            }, TokenSource.Token);
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            ManualReset?.Reset();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ManualReset?.Set();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TokenSource?.Cancel();
        }
    }
}
