using Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }




        //最小化
        private void lblmini_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        //閉じる
        private void lblclose_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtcerialcode.Text == "5931")
            {
                //【註】クラス名は Person でなく EventInfo のため、右辺を修正
                var n = new NewUser();
                n.NewUserName = txtnewuser.Text;
                n.NewPassword = txtnewpass.Text;
                var personalPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "key.aed");
                BinaryStream.SaveToBinaryFile(n, personalPath);

                MessageBox.Show("キーファイルが作成されました。");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("シリアルコードが違います。もう一度確認して入力してください。");
            }

        }

        //キャンセル
        private void btncancel_Click(object sender, EventArgs e) { Application.Exit(); }

        private void txtnewuser_Enter(object sender, EventArgs e)
        {
            if (txtnewuser.Text == "NEW USER")
            {
                txtnewuser.Text = "";
                txtnewuser.ForeColor = Color.LightGray;
            }
        }

        private void txtnewuser_Leave(object sender, EventArgs e)
        {
            if (txtnewuser.Text == "")
            {
                txtnewuser.Text = "NEW USER";
                txtnewuser.ForeColor = Color.DimGray;
            }
        }

        private void txtnewpass_Enter(object sender, EventArgs e)
        {
            if (txtnewpass.Text == "NEW PASSWORD")
            {
                txtnewpass.Text = "";
                txtnewpass.ForeColor = Color.LightGray;
            }
        }

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text == "")
            {
                txtnewpass.Text = "NEW PASSWORD";
                txtnewpass.ForeColor = Color.DimGray;
            }
        }

        private void txtcerialcode_Enter(object sender, EventArgs e)
        {
            if (txtcerialcode.Text == "SERIAL CODE")
            {
                txtcerialcode.Text = "";
                txtcerialcode.ForeColor = Color.LightGray;
            }
        }

        private void txtcerialcode_Leave(object sender, EventArgs e)
        {
            if (txtcerialcode.Text == "")
            {
                txtcerialcode.Text = "SERIAL CODE";
                txtcerialcode.ForeColor = Color.DimGray;
            }
        }

        //起動時にuser名にフォーカスしてuserが表示されないのでlabelにフォーカスさせる
        private void NewUserForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl =  label;
        }
    }
}
