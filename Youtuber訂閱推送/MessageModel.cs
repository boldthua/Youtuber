using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtuber訂閱推送
{
    public enum SenderType
    {
        User,
        Youtuber
    }
    public class MessageModel<T>
    {
        public SenderType SenderType { get; set; }
        public T Message { get; set; }

        public MessageModel(SenderType senderType, T Message) // 好想換掉喔
        {
            this.SenderType = senderType;
            this.Message = Message;
        }
    }
}
