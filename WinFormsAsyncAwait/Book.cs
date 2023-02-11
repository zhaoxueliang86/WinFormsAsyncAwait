using System.Diagnostics;

namespace WinFormsAsyncAwait
{
    public class Book
    {
        public class BookEventArgs : EventArgs
        {
            public BookEventArgs(string Name, string Result)
            {
                this.Name = Name;
                this.Result = Result;
            }

            public string? Name { get; }
            public string? Result { get; }
        }

        public event Action<object?, BookEventArgs>? EventCompleted;

        /// <summary>
        /// 书
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="second">制作时间，单位：秒</param>
        public Book(string name, int second)
        {
            Name = name;
            Duration = second;
        }
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 查询测试延时秒数
        /// </summary>
        public int Duration { get; } = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <returns></returns>
        private string Result(long milliseconds) { return $"{Name.PadRight(12, '—')}用时： {Convert.ToSingle(milliseconds) / 1000}秒"; }
        /// <summary>
        /// 检索
        /// </summary>
        /// <returns></returns>
        public string Search()
        {
            Stopwatch sw = Stopwatch.StartNew();

            //检索逻辑
            Thread.Sleep(Duration * 1000);
            //...
            //...

            sw.Stop();
            //完成，返回消息
            return Result(sw.ElapsedMilliseconds);
        }
        /// <summary>
        /// 带事件的检索方法
        /// </summary>
        public void SearchEvent()
        {
            Stopwatch sw = Stopwatch.StartNew();

            //检索逻辑
            Thread.Sleep(Duration * 1000);
            //...
            //...

            sw.Stop();
            EventCompleted?.Invoke(this, new BookEventArgs(Name, Result(sw.ElapsedMilliseconds)));
        }
        /// <summary>
        /// 检索，异步方法
        /// </summary>
        /// <returns></returns>
        public async Task<string> SearchAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            await Task.Delay(Duration * 1000);
            sw.Stop();
            return Result(sw.ElapsedMilliseconds);
        }
    }
}
