using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtuber訂閱推送
{
    public class YoutuberMessage
    {
        public string title { get; set; }
        public string content { get; set; }

        public YoutuberMessage(string title, string content)
        {
            this.title = title;
            this.content = content;
        }
    }
}
