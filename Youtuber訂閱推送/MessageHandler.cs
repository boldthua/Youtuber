using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 自製Subject;

namespace Youtuber訂閱推送
{

    internal class MessageHandler<T>// 收到一個物件，送出一個物件
    {
        static Subject<MessageModel<T>> subject = new Subject<MessageModel<T>>();

        public static void SendMessage(MessageModel<T> message)
        {
            subject.Next(message);
        }

        public static void SubscribeMessage(Action<MessageModel<T>> callback)
        {
            subject.Subscribe(callback, null, null);
        }


    }
}
