using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtuber訂閱推送
{
    public static class InputUserNameBox
    {
        //public static void Show()
        //{
        //    Form inputBox = new Form()
        //    {
        //        Width = 200,
        //        Height = 50,
        //        FormBorderStyle = FormBorderStyle.FixedDialog,
        //        Text = "輸入用戶名稱",
        //        StartPosition = FormStartPosition.CenterScreen,
        //    };

        //    Label textLabel = new Label() { Left = 10, Top = 20, Text = "輸入用戶名稱", Width = 200 };
        //    TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 200 };
        //    Button confirmButton = new Button() { Text = "確定", Left = 70, Width = 60, Top = 80, DialogResult = textBox.Text != "" ? DialogResult.OK : MessageBox.Show("用戶名稱不可空白！！") };

        //    inputBox.Controls.Add(textLabel);
        //    inputBox.Controls.Add(textBox);
        //    inputBox.Controls.Add(confirmButton);
        //    inputBox.AcceptButton = confirmButton;

        //    string username = textBox.Text;
        //    User user = inputBox.ShowDialog() == DialogResult.OK ? new User(username) : null;
        //    UserForm userForm = new UserForm(user);
        //    userForm.Show();
        //    inputBox.Close();
        //}
    }
}
