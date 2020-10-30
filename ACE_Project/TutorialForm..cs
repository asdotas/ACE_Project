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
using System.IO;

namespace ACE_Project
{
    public partial class Form6 : Form
    {
        /// <summary>
        /// 初期設定
        /// </summary>
        public Form6() { InitializeComponent(); }
        //タイトルバーのないフォームを移動させる
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hwnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        private void Form6_MouseDown(object sender, MouseEventArgs e)
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

        //新規データを選択した場合、作成した後も先に進み、オープンファイルダイアログを開くのを防ぐ
        public bool isNextForm = false;

        //CSVふぁいるを開きフォルダを作成
        private void CsvOpenBtn_Click(object sender, EventArgs e)
        {
            isNextForm = true;
            this.DialogResult = DialogResult.OK;
        }

        //新規データ作成時の動作　テンプレートのファイルをデスクトップにコピーする
        private void NewDataBtn_Click(object sender, EventArgs e)
        {
            //デスクトップのパスを探す
            var desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //デスクトップのパスをファイルを結合させる
            var desktopFilePath = Path.Combine(desktopPath, "newdata.csv");
            //テンプレートのＣＳＶファイルをデスクトップに作成する
            if (File.Exists(desktopFilePath))
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("ファイルを上書きしますか？",
                    "質問",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    //「はい」が選択された時
                    System.IO.File.Copy(@"./temp/newdata.csv", desktopFilePath, true);
                    MessageBox.Show("デスクトップにテンプレートが上書き保存されました。");
                }
                else if (result == DialogResult.No)
                {
                    //「いいえ」が選択された時
                    MessageBox.Show("アプリケーションを終了します。");
                }
                else if (result == DialogResult.Cancel)
                {
                    //「キャンセル」が選択された時
                    MessageBox.Show("キャンセルされました。");
                }
            }
            else
            {
                System.IO.File.Copy(@"./temp/newdata.csv", desktopFilePath);
                MessageBox.Show("デスクトップにテンプレートが作成されました。");
            }
            //動作を閉じる
            this.Close();
        }

        private void CsvOpenBtn_Click_1(object sender, EventArgs e)
        {
            isNextForm = true;
            this.DialogResult = DialogResult.No;
        }
    }
}
