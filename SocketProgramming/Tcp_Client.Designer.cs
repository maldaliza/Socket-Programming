
namespace SocketProgramming
{
    partial class Tcp_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.send_btn = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.RichTextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.send_btn.Location = new System.Drawing.Point(319, 410);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(83, 28);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(15, 414);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(298, 21);
            this.tb_message.TabIndex = 14;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(15, 75);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(387, 323);
            this.tb_log.TabIndex = 13;
            this.tb_log.Text = "";
            // 
            // connect_btn
            // 
            this.connect_btn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connect_btn.Location = new System.Drawing.Point(302, 13);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(100, 43);
            this.connect_btn.TabIndex = 12;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(174, 35);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(105, 21);
            this.tb_port.TabIndex = 11;
            this.tb_port.Text = "5500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(172, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(15, 35);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(137, 21);
            this.tb_ip.TabIndex = 8;
            this.tb_ip.Text = "192.168.2.106";
            // 
            // Tcp_Client
            // 
            this.AcceptButton = this.send_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ip);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 489);
            this.MinimumSize = new System.Drawing.Size(431, 489);
            this.Name = "Tcp_Client";
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.Tcp_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.RichTextBox tb_log;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ip;
    }
}