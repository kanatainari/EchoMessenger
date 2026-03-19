using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 엔터를 눌렀을때 btnSend_Click 이벤트가 발생하도록 설정
            this.AcceptButton = btnSend;
            // No-op removed: don't call IsNullOrWhiteSpace here
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // txtChatWindow의 텍스트를 lstShowChat에 추가
            string typed_msg = txtChatWindow.Text;

            // 입력된 메시지가 비어있거나 공백으로만 이루어진 경우, 메시지를 추가하지 않음
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                // txtChatWindow를 초기화하고 포커스를 설정
                txtChatWindow.Clear();
                txtChatWindow.Focus();
                return;
            }
            // 입력된 메시지가 유효한 경우, lstShowChat에 추가
            lstShowChat.Items.Add(typed_msg);

            // txtChatWindow를 초기화하고 포커스를 설정
            txtChatWindow.Clear();
            txtChatWindow.Focus();
        }
    }
}
