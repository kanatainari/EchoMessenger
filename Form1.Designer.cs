namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtChatWindow = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstShowChat = new System.Windows.Forms.ListBox();
            this.lblDeco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(359, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 128);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Echo Messenger";
            // 
            // txtChatWindow
            // 
            this.txtChatWindow.Font = new System.Drawing.Font("맑은 고딕", 24F);
            this.txtChatWindow.Location = new System.Drawing.Point(294, 719);
            this.txtChatWindow.Name = "txtChatWindow";
            this.txtChatWindow.Size = new System.Drawing.Size(645, 71);
            this.txtChatWindow.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSend.Location = new System.Drawing.Point(986, 702);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(232, 105);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전 송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstShowChat
            // 
            this.lstShowChat.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstShowChat.FormattingEnabled = true;
            this.lstShowChat.ItemHeight = 48;
            this.lstShowChat.Location = new System.Drawing.Point(294, 204);
            this.lstShowChat.Name = "lstShowChat";
            this.lstShowChat.Size = new System.Drawing.Size(924, 436);
            this.lstShowChat.TabIndex = 3;
            // 
            // lblDeco
            // 
            this.lblDeco.AutoSize = true;
            this.lblDeco.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDeco.ForeColor = System.Drawing.Color.White;
            this.lblDeco.Location = new System.Drawing.Point(288, 148);
            this.lblDeco.Name = "lblDeco";
            this.lblDeco.Size = new System.Drawing.Size(934, 32);
            this.lblDeco.TabIndex = 4;
            this.lblDeco.Text = "----------------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1464, 856);
            this.Controls.Add(this.lblDeco);
            this.Controls.Add(this.lstShowChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtChatWindow);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtChatWindow;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstShowChat;
        private System.Windows.Forms.Label lblDeco;
    }
}

