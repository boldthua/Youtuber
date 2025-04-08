using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtuber訂閱推送
{
    public class Youtuber
    {
        public List<Channel> channels = null;
        public Youtuber()
        {
            channels = new List<Channel>()
            {
                new Channel("蛇丸"),
                new Channel("大蛇丸"),
                new Channel("中蛇丸"),
                new Channel("小蛇丸")
            };
        }

        public void Publish(YoutuberMessage message, Channel channel)
        {
            YoutuberMessage youtuberMessage = new YoutuberMessage(
                $"頻道 {channel.ChannelName} 發布新影片 {message.title}", "");
            MessageModel<YoutuberMessage> messageModel = new MessageModel<YoutuberMessage>(SenderType.Youtuber, youtuberMessage);
            channel.SendMessage(messageModel);
        }
    }
}
