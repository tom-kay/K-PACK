using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace P01_K_DESIGN_WIN
{
    public partial class frmLoginFrame : Form
    {
        TextBox[] txtList;
        const string IdPlaceholder = "사용자 계정(User ID)";
        const string PwPlaceholder = "비밀번호(Password)";

        public frmLoginFrame()
        {
            InitializeComponent();

            txtList = new TextBox[] { txtUser, txtPass };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txtUser) txt.Text = IdPlaceholder;
                else if (txt == txtPass) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        #region Drag Form/ Move Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void MoveWindow(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.LightGray; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txtPass) txtPass.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.Silver; //Placeholder 흐린 글씨
                if (txt == txtUser) txt.Text = IdPlaceholder;
                else if (txt == txtPass) { txt.Text = PwPlaceholder; txtPass.PasswordChar = default; }
            }
        }
        #endregion 

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

    }
}
