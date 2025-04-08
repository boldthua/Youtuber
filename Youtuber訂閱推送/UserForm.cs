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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Youtuber訂閱推送
{
    public partial class UserForm : Form
    {

        public Channel channel { get; set; }

        public UserForm(Youtuber youtuber)
        {
            InitializeComponent();
            comboBox1.DataSource = youtuber.channels;
            comboBox1.DisplayMember = "ChannelName";
            this.channel = (Channel)comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            if (userName == "")
            {
                MessageBox.Show("用戶名稱不可空白！！");
                return;
            }
            User user = new User(userName);

            Subscription<MessageModel<YoutuberMessage>> userKey = channel.Subscribe(user.VideoReceived);

            channel.AddSubscriber(user, userKey);
            YoutuberMessage userMessage = new YoutuberMessage($"{userName} 已經訂閱頻道 {channel.ChannelName}", "123");
            MessageModel<YoutuberMessage> subcriberMessage = new MessageModel<YoutuberMessage>(SenderType.User, userMessage);
            MessageHandler<YoutuberMessage>.SendMessage(subcriberMessage);

            // 送 user 到 notifyform 讓user 呼叫 Channel

            ShowSubscriber(user, userKey);

            textBox1.Text = "";
            userName = "";

            //textbox2.Text = "";
            //for (int i = 0; i < subscribers.Count; i++)
            //{
            //    textbox2.Text += $"{i + 1}:{subscribers[i].UserName} \r\n";
            //}
        }

        public void ShowSubscriber(User user, Subscription<MessageModel<YoutuberMessage>> userKey)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            Label label = new Label()
            {
                Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.OrangeRed,
                Width = 200,
                Text = $"訂閱者：{user.UserName}"
            };
            Button button = new Button()
            {
                Text = "取消訂閱",
                Tag = userKey
            };
            flowLayoutPanel.Controls.Add(label);
            flowLayoutPanel.Controls.Add(button);
            this.flowLayoutPanel1.Controls.Add(flowLayoutPanel);

            button.Click += UnSunscribe_Click;
        }

        private void UnSunscribe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Subscription<MessageModel<YoutuberMessage>> userKey = btn.Tag as Subscription<MessageModel<YoutuberMessage>>;
            FlowLayoutPanel flowpanel = (FlowLayoutPanel)btn.Parent;
            Label label = flowpanel.Controls.OfType<Label>().First();
            userKey.UnSubscribe("");
            string userName = label.Text.Split('：')[1];
            YoutuberMessage userMessage = new YoutuberMessage($"背骨仔 {label.Text} 已經取消訂閱 {((Channel)comboBox1.SelectedItem).ChannelName}", "123");
            MessageModel<YoutuberMessage> unSubcriberMessage = new MessageModel<YoutuberMessage>(SenderType.User, userMessage);
            MessageHandler<YoutuberMessage>.SendMessage(unSubcriberMessage);
            this.flowLayoutPanel1.Controls.Remove(flowpanel);
            User user = (User)(channel.subscribers.Keys.First(x => x.UserName == userName));
            channel.subscribers.Remove(user);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem as Channel;
            if (selected != null)
            {
                this.flowLayoutPanel1.Controls.Clear();
                this.channel = selected;
                foreach (var user in channel.subscribers)
                {
                    ShowSubscriber(user.Key, user.Value);
                }
            }
        }
    }
}

// 通知的間距再改一下
// 多個channel
