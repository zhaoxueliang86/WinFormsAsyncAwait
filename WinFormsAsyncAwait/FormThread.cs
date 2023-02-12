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
        /// ͬ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();    //��ʱ��
            resultTextBox.Clear();
            AppendLine("ͬ��������ʼ......");
            int idx = 0;

            Data.Books.ForEach(book => AppendLine($"{++idx}.{book.Search()}"));

            sw.Stop();
            AppendLine($"ͬ��������ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
        }
        /// <summary>
        /// �첽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("�첽������ʼ......");
            AppendLine($"ThreadId��{Environment.CurrentManagedThreadId}");

            int idx = 0;

            foreach (var book in Data.Books)
            {
                var task = await Task.Run(book.Search).ConfigureAwait(true);
                AppendLineThread($"{++idx}.{task}        ThreadId��{Environment.CurrentManagedThreadId}");
            }

            sw.Stop();
            AppendLineThread($"�첽������ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
        }
        /// <summary>
        /// �첽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAsyncCallbak_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine("�첽�ص�������ʼ......");
            int idx = 0;

            foreach (var book in Data.Books)
            {
                Task.Run(book.Search).ContinueWith(t => AppendLineThread($"{++idx}.{t.Result}"));
            }

            sw.Stop();
            AppendLine($"�첽�ص�������ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnConcurrencyAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            resultTextBox.Clear();
            AppendLine($"���м�����ʼ......");
            int idx = 0;

            List<Task<string>> Tasks = new();
            Data.Books.ForEach(book => Tasks.Add(Task.Run(book.Search)));

            var tasks = await Task.WhenAll(Tasks).ConfigureAwait(false);
            foreach (var result in tasks)
            {
                AppendLine($"{++idx}.{result}");
            }
            sw.Stop();
            AppendLine($"���м�����ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
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
            AppendLine("���лص�������ʼ......");

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
                AppendLine($"���лص�������ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
            });
        }

        private void AppendLine(string text)
        {
            resultTextBox.AppendText(string.IsNullOrEmpty(resultTextBox.Text) ? text : $"{Environment.NewLine}{text}");
            resultTextBox.ScrollToCaret();       //�ѿؼ����ݹ�������ǰ�������λ��
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
            AppendLine("������ʼ......");

            List<Task> Tasks = new();
            foreach (var book in Data.Books)
            {
                Tasks.Add(Task.Run(book.SearchEvent));
            }
            await Task.WhenAll(Tasks);
            sw.Stop();
            AppendLine($"������ɣ�{Convert.ToSingle(sw.ElapsedMilliseconds) / 1000}��");
        }


        private StringBuilder strResult = new();
        private void Test_ConfigureAwait(object sender, EventArgs e)
        {
            bool state = ((Button)sender).Text == "True";
            strResult.Clear();
            strResult.AppendLine($"��{Environment.CurrentManagedThreadId}�����߳̿�ʼ��ConfigureAwait({state.ToString()})");
            
            ChildMethod(state);
            
            strResult.AppendLine($"��{Environment.CurrentManagedThreadId}�����߳̿�ʼ�ȴ�");
            
            Thread.Sleep(3000);
            
            strResult.AppendLine($"��{Environment.CurrentManagedThreadId}�����߳̽���");
            MessageBox.Show("success","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private async void ChildMethod(bool state)
        {
            strResult.AppendLine($"��{Environment.CurrentManagedThreadId}��ChildMethod��ʼ");

            Stopwatch sw = Stopwatch.StartNew();

            await Task.Run(() =>
            {
                strResult.AppendLine($"��{Environment.CurrentManagedThreadId}�����߳̿�ʼ");
                Thread.Sleep(2000);
                strResult.AppendLine($"��{Environment.CurrentManagedThreadId}�����߳̽���");
            }).ConfigureAwait(state);

            sw.Stop();
            strResult.AppendLine($"��{Environment.CurrentManagedThreadId}��ChildMethod����{sw.ElapsedMilliseconds}");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            AppendLine(strResult.ToString());
        }
    }
}