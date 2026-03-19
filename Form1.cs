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

            // 초기 메시지 수 표시
            UpdateMessageCount();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // txtChatWindow의 텍스트를 lstShowChat에 추가
            // 사용자 입력의 앞뒤 불필요한 공백 제거
            string typed_msg = txtChatWindow.Text.Trim();

            // 입력된 메시지가 비어있거나 공백으로만 이루어진 경우, 메시지를 추가하지 않음
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtChatWindow.Clear();
                txtChatWindow.Focus();
                return;
            }

            // 현재 시간 [HH:mm:ss]를 메시지 앞에 붙여서 리스트에 추가
            string display = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";
            lstShowChat.Items.Add(display);

            // 메시지 개수 업데이트
            UpdateMessageCount();

            // 입력창 초기화 및 포커스
            txtChatWindow.Clear();
            txtChatWindow.Focus();
        }

        // lstShowChat에 쌓인 메시지 개수를 lblCount에 표시
        private void UpdateMessageCount()
        {
            if (lblCount == null || lstShowChat == null)
                return;

            int count = lstShowChat.Items.Count;
            lblCount.Text = $"현재 대화 : {count}개";
        }
    }
}
