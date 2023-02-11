using System.Diagnostics;
using System.Text;

namespace WinFormsAsyncAwait
{
    public partial class FormThread : Form
    {
        public FormThread()
        {
            InitializeComponent();

            Data.Books.ForEach(book => { book.EventCompleted += Book_EventCompleted; });
        }
        private void Book_EventCompleted(object? sender, Book.BookEventArgs e)
        {
            AppendLineThread(e.Result!);
        }

        /// <summary>
        /// 同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();    //计时器
            resultTextBox.Clear();
            AppendLine("同步检索开始......");
            int idx = 0;

            Data.Books.ForEach(book => AppendLine($"{++idx}.{book.Search()}"));

            sw.Stop();
            AppendLine($"同步检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }
        /// <summary>
        /// 异步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("异步检索开始......");
            AppendLine($"ThreadId：{Environment.CurrentManagedThreadId}");

            int idx = 0;

            foreach (var book in Data.Books)
            {
                var task = await Task.Run(book.Search).ConfigureAwait(true);
                AppendLineThread($"{++idx}.{task}        ThreadId：{Environment.CurrentManagedThreadId}");
            }

            sw.Stop();
            AppendLineThread($"异步检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }
        /// <summary>
        /// 异步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAsyncCallbak_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("异步回调检索开始......");
            int idx = 0;

            foreach (var book in Data.Books)
            {
                Task.Run(book.Search).ContinueWith(t => AppendLineThread($"{++idx}.{t.Result}"));
            }

            sw.Stop();
            AppendLine($"异步回调检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }
        /// <summary>
        /// 并行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnConcurrencyAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine($"并行检索开始......");
            int idx = 0;

            List<Task<string>> Tasks = new();
            Data.Books.ForEach(book => Tasks.Add(Task.Run(book.Search)));

            var tasks = await Task.WhenAll(Tasks).ConfigureAwait(false);
            foreach (var result in tasks)
            {
                AppendLine($"{++idx}.{result}");
            }
            sw.Stop();
            AppendLine($"并行检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConcurrencyCallback_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("并行回调检索开始......");

            int idx = 0;
            List<Task<string>> Tasks = new();
            foreach (var book in Data.Books)
            {
                Tasks.Add(Task.Run(book.Search));
            }

            Task.WhenAll(Tasks).ContinueWith(t =>
            {
                foreach (var result in t.Result)
                {
                    AppendLine($"{++idx}.{result}");
                }
                sw.Stop();
                AppendLine($"并行回调检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
            });
        }

        private void AppendLine(string text)
        {
            resultTextBox.AppendText(string.IsNullOrEmpty(resultTextBox.Text) ? text : $"{Environment.NewLine}{text}");
            resultTextBox.ScrollToCaret();       //把控件内容滚动到当前插入符号位置
            resultTextBox.Refresh();
        }

        private void AppendLineThread(string text)
        {
            this.Invoke(() => AppendLine(text));
        }

        private async void BtnEvent_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("检索开始......");

            List<Task> Tasks = new();
            foreach (var book in Data.Books)
            {
                Tasks.Add(Task.Run(book.SearchEvent));
            }
            await Task.WhenAll(Tasks);
            sw.Stop();
            AppendLine($"检索完成：{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}秒");
        }


        private StringBuilder strResult = new();
        private void Test_ConfigureAwait(object sender, EventArgs e)
        {
            bool state = ((Button)sender).Text == "True";
            strResult.Clear();
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程开始：ConfigureAwait({state.ToString()})");
            
            ChildMethod(state);
            
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程开始等待");
            
            Thread.Sleep(3000);
            
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】主线程结束");
            MessageBox.Show("success","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private async void ChildMethod(bool state)
        {
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】ChildMethod开始");

            Stopwatch sw = Stopwatch.StartNew();

            await Task.Run(() =>
            {
                strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程开始");
                Thread.Sleep(2000);
                strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】子线程结束");
            }).ConfigureAwait(state);

            sw.Stop();
            strResult.AppendLine($"【{Environment.CurrentManagedThreadId}】ChildMethod结束{sw.ElapsedMilliseconds}");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            AppendLine(strResult.ToString());
        }
    }
}