using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using 自製Subject;

namespace Youtuber訂閱推送
{
    public class Channel
    {
        public string ChannelName { get; set; }
        public Subject<MessageModel<YoutuberMessage>> subject = new Subject<MessageModel<YoutuberMessage>>();
        public Dictionary<User, Subscription<MessageModel<YoutuberMessage>>> subscribers = new Dictionary<User, Subscription<MessageModel<YoutuberMessage>>>();


        public Channel(string channelName)
        {
            this.ChannelName = channelName;
        }
        public Subscription<MessageModel<YoutuberMessage>> Subscribe(Action<MessageModel<YoutuberMessage>> message)
        {
            return subject.Subscribe(message, null, null);
        }

        public void SendMessage(MessageModel<YoutuberMessage> message)
        {
            subject.Next(message);
        }

        public void AddSubscriber(User user, Subscription<MessageModel<YoutuberMessage>> userKey)
        {
            subscribers.Add(user, userKey);
        }
    }
}
