
namespace SocketProgramming.UDP
{
    partial class Udp_Client
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
            this.tb_log = new System.Windows.Forms.RichTextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(15, 75);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(387, 363);
            this.tb_log.TabIndex = 19;
            this.tb_log.Text = "";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(15, 36);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(105, 21);
            this.tb_port.TabIndex = 18;
            this.tb_port.Text = "5500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port";
            // 
            // Udp_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 489);
            this.MinimumSize = new System.Drawing.Size(431, 489);
            this.Name = "Udp_Client";
            this.Text = "Udp_Client";
            this.Load += new System.EventHandler(this.Udp_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_log;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
    }
}