using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class PrintForm : Form
    {

        public PrintForm()
        {
            InitializeComponent();
        }




        private void PrintForm_Load(object sender, EventArgs e)
        {
            //フォント指定
            dgvP1.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);

            //行が足りないときは２行表示する
            dgvP1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvP1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvP1.RowTemplate.Height = 30;

            using (var sr = new StreamReader(@"./temp/print.csv"))
            {
                var r = 0;
                var itemsArray = sr.ReadLine().Trim(null).Split(',');
                foreach (var item in itemsArray)
                {
                    dgvP1.Rows.Add();
                    //dgvP2.Rows.Add();
                    dgvP1.Rows[r].Cells[0].Value = item.ToString();
                    dgvP1.Rows[r].Cells[2].Value = item.ToString();
                    //dgvP2.Rows[r].Cells[0].Value = item.ToString();
                    r++;
                }

            }

            //ShowPrintDialog();

            ////コントロールの外観を描画するBitmapの作成
            //Bitmap bmp = new Bitmap(dgvP1.Width, dgvP1.Height);
            ////キャプチャする
            //dgvP1.DrawToBitmap(bmp, new Rectangle(0, 0, dgvP1.Width, dgvP1.Height));
            ////ファイルに保存する
            //bmp.Save("./temp/1.png");
            ////後始末
            //bmp.Dispose();
        }

        //スクショ



        //データグリッドの反転選択を解除する
        private void dgvP1_SelectionChanged(object sender, EventArgs e)
        {
            dgvP1.ClearSelection();
        }



        //}

        //プリントダイアログを開く
        public void ShowPrintDialog()
        {
            //PrintDocumentオブジェクトの作成
            var pd = new PrintDocument();
            //PrintPageイベントハンドラの追加
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //紙の向き　trueで横向き
            pd.DefaultPageSettings.Landscape = true;

            //紙のサイズ　Ｂ５
            foreach (PaperSize ps in pd.PrinterSettings.PaperSizes)
            {
                if (ps.Kind == PaperKind.B5)
                {
                    pd.DefaultPageSettings.PaperSize = ps;
                    break;
                }
            }


            //PrintDialogクラスの作成
            var pdlg = new PrintDialog();
            //PrintDocumentを指定
            pdlg.Document = pd;
            //印刷の選択ダイアログを表示する
            if (pdlg.ShowDialog() == DialogResult.OK)
            {
                //OKがクリックされた時は印刷する
                pd.Print();
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            //コントロールの外観を描画するBitmapの作成
            var bmp = new Bitmap(dgvP1.Width, dgvP1.Height);

            //キャプチャする
            dgvP1.DrawToBitmap(bmp, new Rectangle(0, 0, dgvP1.Width, dgvP1.Height));
            //ファイルに保存する
            bmp.Save("./temp/print.png");
            //後始末
            bmp.Dispose();

            //画像を読み込む
            Image img = Image.FromFile("./temp/print.png");
            //画像を描画する
            e.Graphics.DrawImage(img, e.MarginBounds);
            //次のページがないことを通知する
            e.HasMorePages = false;
            //後始末をする
            img.Dispose();

        }
    }
}
