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
using Edit;
using System.IO;

namespace ACE_Project
{
    public partial class Form5 : Form
    {
        /// <summary>
        /// 初期設定
        /// </summary>
        public Form5() 
        { 
            InitializeComponent(); 
        }
        //タイトルバーのないフォームを移動させる
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hwnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        //ログインの仕方
        /*
         Loginformより"NEW USER"を押して"NewUserForm"を開く
        名前とパスワードとシリアル「５９３１」を打ってOKを押す
        マイドキュメントに"key.aed"ファイルが生成される。
        Loginformより、先ほどのUSER名とパスワードを入力する。
        この時マイドキュメントにキーファイルがないとログインできない。
        マイドキュメントにキーファイルがある状態でもう一度"NEW USER"を押しても
        一台にひとつしか登録できない。

        このパスワードは実行ファイルをフォルダーごと他のPCにコピー
        しても簡単に起動できないようにするシステムです。
         */

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }
        //終了
        private void lblclose_Click(object sender, EventArgs e) { Application.Exit(); }
        //最小化
        private void lblmini_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        /// <summary>
        /// テキスト入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //テキストボックスがＵＳＥＲでもで登録される
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USER")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }
        //テキストボックスに入力しなかった場合は元の薄い文字に戻る
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USER";
                txtuser.ForeColor = Color.DimGray;
            }
        }
        //テキストボックスがＰＡＳＳＷＯＲＤでもで登録される
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "PASSWORD")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true; //pwを伏字で
            }
        }
        //テキストボックスに入力しなかった場合は元の薄い文字に戻る
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "PASSWORD";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;　//pwを伏字解除
            }
        }
        private void OkBtn()
        {
            //シリアル読み込み
            NewUser n;
            var personalPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "key.aed");
            if (File.Exists(personalPath))
            {
                n = (NewUser)BinaryStream.LoadFromBinaryFile(personalPath);
                if (txtuser.Text == n.NewUserName && txtpass.Text == n.NewPassword)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ユーザー名あるいはパスワードが違います");
                }
            }
            else
            {
                MessageBox.Show("まだユーザー登録できていません。");
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            OkBtn();
        }

        private void btnnewuser_Click(object sender, EventArgs e)
        {
            var personalPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "key.aed");
            if (File.Exists(personalPath))
            {
                MessageBox.Show("ひとつのPCにはアカウントはひとつまでしか登録できません。");
            }
            else
            {
                var nf = new NewUserForm();
                nf.Show();
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //シリアル読み込み
            NewUser n;
            var personalPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "key.aed");
            if (File.Exists(personalPath))
            {
                n = (NewUser)BinaryStream.LoadFromBinaryFile(personalPath);
                if (txtuser.Text == n.NewUserName && txtpass.Text == n.NewPassword)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("ユーザー名あるいはパスワードが違います");
                }
            }
            else
            {
                MessageBox.Show("まだユーザー登録できていません。");
            }
        }
    }
}
