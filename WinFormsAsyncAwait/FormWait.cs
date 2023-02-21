using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAsyncAwait
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
        }

        private void AppendLine(string text)
        {
            resultTextBox.AppendText(string.IsNullOrEmpty(resultTextBox.Text) ? text : $"{Environment.NewLine}{text}");
            resultTextBox.ScrollToCaret();       //把控件内容滚动到当前插入符号位置
            resultTextBox.Refresh();
        }

        private void InvworkAppendLine(string text)
        {
            BeginInvoke(() => AppendLine(text));
        }

        private void BtnWait_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();    //计时器
            resultTextBox.Clear();
            AppendLine("Wait开始......");

            for (int i = 0; i < Data.Books.Count; i++)
            {
                Task<string> task = Task.Run(() =>
                {
                    return Data.Books[i].Search();
                });
                //Task.Wait()方法，调用线程阻塞在Wait处，出现两种情况结束等待
                //1.线程执行完毕
                //2.任务本身已取消或引发异常
                task.Wait();
                AppendLine($"{i}.{task.Result}");
            }

            sw.Stop();
            AppendLine($"Wait完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }

        private void BtnWaitAll_Click(object sender, EventArgs e)
        {
            List<Task<string>> Tasks = new();
            Stopwatch sw = Stopwatch.StartNew();    //计时器
            resultTextBox.Clear();
            AppendLine("WaitAll开始......");

            for (int i = 0; i < Data.Books.Count; i++)
            {
                var book = Data.Books[i];
                Tasks.Add(Task.Run(() =>
                {
                    return book.Search();
                }));
            }
            Task.WaitAll(Tasks.ToArray());  //Tasks线程集合中全部线程结束，调用线程才继续向后执行
            foreach (var task in Tasks)
            {
                AppendLine($"{task.Result}  {task.Id}.{task.Status}");
            }
            sw.Stop();
            AppendLine($"WaitAll完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }

        private void BtnWaitAny_Click(object sender, EventArgs e)
        {
            List<Task<string>> Tasks = new();
            Stopwatch sw = Stopwatch.StartNew();    //计时器
            resultTextBox.Clear();
            AppendLine("WaitAny开始......");

            for (int i = 0; i < Data.Books.Count; i++)
            {
                var book = Data.Books[i];
                Tasks.Add(Task.Run(() =>
                {
                    return book.Search();
                }));
            }
            Task.WaitAny(Tasks.ToArray());  //Tasks线程集合中任一线程结束，调用线程就继续向后执行
            foreach (var task in Tasks)
            {
                AppendLine($"{task.Result}  {task.Id}.{task.Status}");
            }
            sw.Stop();
            AppendLine($"WaitAny完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }

        private void BtnDeadlock_Click(object sender, EventArgs e)
        {
            #region 死锁演示
            Stopwatch sw = Stopwatch.StartNew();    //计时器
            resultTextBox.Clear();
            AppendLine("Wait开始......");

            for (int i = 0; i < Data.Books.Count; i++)
            {
                var book = Data.Books[i];
                var idx = i + 1;
                var task = book.SearchAsync().ContinueWith(t => InvworkAppendLine($"{idx}.{t.Result}"));
            }

            sw.Stop();
            AppendLine($"Wait完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
            #endregion
        }
    }
}
