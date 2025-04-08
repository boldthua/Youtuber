using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtuber訂閱推送
{
    public partial class YoutuberForm : Form
    {
        public Youtuber youtuber { get; set; }

        public YoutuberForm(Youtuber youtuber)
        {
            this.youtuber = youtuber;
            InitializeComponent();
            comboBox1.DataSource = youtuber.channels;
            comboBox1.DisplayMember = "ChannelName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string content = textBox2.Text;
            YoutuberMessage youtuberMessage = new YoutuberMessage(title, content);

            if (title == "" || content == "")
            {
                MessageBox.Show("標題或內容不可空白！！");
                return;
            }
            MessageModel<YoutuberMessage> subcriberMessage = new MessageModel<YoutuberMessage>(SenderType.Youtuber, youtuberMessage);
            MessageHandler<YoutuberMessage>.SendMessage(subcriberMessage);

            youtuber.Publish(youtuberMessage, (Channel)comboBox1.SelectedItem);
            MessageBox.Show("文章發表成功！！");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
