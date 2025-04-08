using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 自製Subject;
namespace Youtuber訂閱推送
{
    public partial class NotifyForm : Form
    {
        Youtuber Orochimaru = new Youtuber();
        User User { get; set; }
        public NotifyForm()
        {
            InitializeComponent();

            MessageHandler<YoutuberMessage>.SubscribeMessage(ReceivedMessage);

        }

        private void ReceivedMessage(MessageModel<YoutuberMessage> message)
        {
            if (message.SenderType == SenderType.Youtuber)
                textbox1.Text += $"發表新消息！\r\n標題：{message.Message.title}\r\n內容：{message.Message.content}\r\n";

            if (message.SenderType == SenderType.User) // 問這個
                textbox2.Text += $"{message.Message.title}\r\n";
        }

        private void ReceiveUser(User user)
        {
            this.User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoutuberForm youtuberForm = new YoutuberForm(Orochimaru);
            youtuberForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(Orochimaru);
            userForm.Show();
        }

        private void NotifyForm_Load(object sender, EventArgs e)
        {

        }
    }
}                     // 多個channel 和 取消訂閱
