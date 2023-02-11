namespace WinFormsAsyncAwait
{
    public class Data
    {
        /// <summary>
        /// 书目
        /// </summary>
        public readonly static List<Book> Books = new() {
            new Book("封神演义",1),
            new Book("三国演义",2),
            new Book("水浒传",3),
            new Book("西游记",4),
            new Book("红楼梦",2),
            new Book("聊斋志异",3),
            new Book("儒林外史",1),
            new Book("隋唐演义",1)
        };
            
        /// <summary>
        /// 
        /// </summary>
        public readonly static List<string> UrlCollect = new() {
            "https://www.sina.com.cn/",
            "https://www.baidu.com/",
            "https://www.csdn.net/",
            "https://www.cnblogs.com/",
            "https://www.oschina.net/",
            "https://mail.163.com/",
            "https://www.aliyun.com/",
            "https://cloud.tencent.com/",
            "https://mp.weixin.qq.com/",
            "https://www.sdu.edu.cn/",
            "https://www.sdust.edu.cn/",
            "http://www.sdnu.edu.cn/",
            "https://www.sdut.edu.cn/",
            "http://www.mukcloud.net/",
            "https://www.python.org/",
            "https://gitee.com/"
        };
    }
}
