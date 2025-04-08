using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 自製Subject;

namespace Youtuber訂閱推送
{
    public class User
    {
        public string UserName { get; set; }

        public User(string userName)
        {
            UserName = userName;
        }

        public void VideoReceived(MessageModel<YoutuberMessage> video)
        {
            YoutuberMessage youtuberMessage = new YoutuberMessage($"{UserName} 收到了{video.Message.title} 的影片通知\r\n", "");

            MessageModel<YoutuberMessage> message = new MessageModel<YoutuberMessage>(SenderType.User, youtuberMessage);

            // 要做什麼
            MessageHandler<YoutuberMessage>.SendMessage(message);
        }
    }
}
