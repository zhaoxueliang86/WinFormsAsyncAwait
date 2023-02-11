namespace WinFormsAsyncAwait
{
    /// <summary>
    /// 食物
    /// </summary>
    public class Food
    {
        /// <summary>
        /// 食物
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="second">制作时间，单位：秒</param>
        public Food(string name, int second)
        {
            Name = name;
            Duration = second;
        }
        /// <summary>
        /// 食物名称
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 制作时间，单位：秒
        /// </summary>
        public int Duration { get; } = 0;

        private string Result { get => $"制作完成：{Name} ----- {Duration}秒"; }
        /// <summary>
        /// 制作食物，同步方法
        /// </summary>
        /// <returns></returns>
        public string Make()
        {
            //为了测试，延时设定的时间
            Thread.Sleep(Duration * 1000);  

            //制作完成，返回消息
            return Result;
        }
        /// <summary>
        /// 制作食物，异步方法
        /// </summary>
        /// <returns></returns>
        public async Task<string> MakeAsync()
        {
            await Task.Delay(Duration * 1000);
            return Result;
        }
    }
}
