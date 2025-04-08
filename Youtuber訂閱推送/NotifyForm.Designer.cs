using System.Drawing;
using System.Windows.Forms;

namespace Youtuber訂閱推送
{
    partial class NotifyForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(42, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 154);
            this.button1.TabIndex = 0;
            this.button1.Text = "Youtuber專區";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(515, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 154);
            this.button2.TabIndex = 0;
            this.button2.Text = "訂閱者專區";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(45, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "消息大廳";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 270);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 389);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(460, 270);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(347, 389);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 678);


            textbox1.Multiline = true;
            textbox1.ScrollBars = ScrollBars.Vertical;
            textbox1.WordWrap = true;
            textbox1.Width = flowLayoutPanel1.ClientSize.Width;
            textbox1.Height = flowLayoutPanel1.ClientSize.Height;
            textbox1.Font = new Font("Microsoft JhengHei", 14, FontStyle.Bold);
            textbox1.ForeColor = Color.OrangeRed;

            textbox2.Multiline = true;
            textbox2.ScrollBars = ScrollBars.Vertical;
            textbox2.WordWrap = true;
            textbox2.Width = flowLayoutPanel2.ClientSize.Width;
            textbox2.Height = flowLayoutPanel2.ClientSize.Height;
            textbox2.Font = new Font("Microsoft JhengHei", 14, FontStyle.Bold);
            textbox2.ForeColor = Color.OrangeRed;


            this.flowLayoutPanel2.Controls.Add(textbox2);
            this.flowLayoutPanel1.Controls.Add(textbox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NotifyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NotifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private TextBox textbox1;
        private TextBox textbox2;
    }
}

