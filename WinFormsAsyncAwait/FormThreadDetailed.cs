using System.Diagnostics;
using System.Text;

namespace WinFormsAsyncAwait
{
    public partial class FormThreadDetailed : Form
    {
        public FormThreadDetailed()
        {
            InitializeComponent();
        }

        private readonly StringBuilder strResult = new();
        private void Test_ConfigureAwait(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            bool state = cbConfigureAwait.Checked;
            strResult.Clear();
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程开始：{(cbAwait.Checked ? "Await  " : "")}ConfigureAwait({state.ToString()})");

            ChildMethod();

            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程开始等待");

            //主程序后续逻辑部分
            Thread.Sleep(3000);


            sw.Stop();
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程结束{sw.ElapsedMilliseconds}ms");

            MessageBox.Show(Owner, "主线程结束，输出结果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Print(strResult.ToString());
        }

        private async void ChildMethod()
        {
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】ChildMethod开始......");

            Stopwatch sw = Stopwatch.StartNew();
            if (cbAwait.Checked)
            {
                await Task.Run(() =>
                {
                    strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程开始......");

                    //子线程逻辑部分
                    Thread.Sleep(2000);

                    strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程延时2000ms结束");
                }).ConfigureAwait(cbConfigureAwait.Checked);
            }
            else
            {
                Task.Run(() =>
                {
                    strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程开始......");

                    //子线程逻辑部分
                    Thread.Sleep(2000);

                    strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程延时2000ms结束");
                }).ConfigureAwait(cbConfigureAwait.Checked);
            }

            sw.Stop();
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】ChildMethod结束{sw.ElapsedMilliseconds}ms");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(strResult.ToString());
        }

        private void Print(string text)
        {
            resultTextBox.AppendText(string.IsNullOrEmpty(resultTextBox.Text) ? text : $"{Environment.NewLine}{text}");
            resultTextBox.ScrollToCaret();       //把控件内容滚动到当前插入符号位置
            resultTextBox.Refresh();
        }
    }
}
