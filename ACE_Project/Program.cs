using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    static class Program
    {
        static ReadDatas speakers;
        static OpenFileDialog ofd1;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CheckDeskForm());
            var f5 = new Form5();//LoginForm
            var f5Res = f5.ShowDialog();
            f5.Dispose();
            if (f5Res == DialogResult.OK)
            {
                //チュートリアルを開く
                var f6 = new Form6();
                var f6Res = f6.ShowDialog();

                if (f6.isNextForm)//新規データを選択した場合、作成した後も先に進み、オープンファイルダイアログを開くのを防ぐ
                {
                    ofd1 = GetOpenFileDialog("import.csv", "Csvファイル(*.csv;)|*.csv|すべてのファイル(*.*)|*.*");
                    ////ダイアログを表示する
                    if (ofd1.ShowDialog() == DialogResult.OK)
                    {
                        //
                        speakers = new ReadDatas(ofd1.FileName);
                        f6.Dispose();
                    }
                    else
                    {
                        Application.Exit();
                        Environment.Exit(0);
                    }
                }

                if (f6Res == DialogResult.OK)
                {
                    var f3 = new MakeDirInfoForm(ofd1);
                    
                    //一番前に表示する　これがないと前にでてこない
                    f3.TopMost = !f3.TopMost;
                    System.IO.File.Copy(ofd1.FileName, @"./temp/temp.csv", true);

                    var f3Res = f3.ShowDialog();
                    var mdf = new MakeDirInfoForm();

                    mdf.ShowLabel(ofd1.FileName);
                    f3.Dispose();
                    if (f3Res == DialogResult.OK)
                    {

                        //var cdf = new CheckDeskForm();
                        //cdf.ReadDatasOfd(ofd);
                        Application.Run(new CheckDeskForm(ofd1));
                        
                    }
                }
                else
                {
                    //System.IO.File.Copy(ofd1.FileName, @"./temp/temp.csv", true);
                    //チュートリアルのＣＳＶファイルを開くボタンの動作
                    ofd1 = GetOpenFileDialog("*.csv", "Csvファイル(*.csv;)|*.csv|すべてのファイル(*.*)|*.*");
                    //ダイアログを表示する
                    if (ofd1.ShowDialog() == DialogResult.OK)
                    {
                        speakers = new ReadDatas(ofd1.FileName);
                        //Application.Run(new CheckDeskForm(ofd1));
                    }
                    else
                    {
                        Application.Exit();
                        Environment.Exit(0);
                    }

                }
            }
        }
        //オープンファイルダイアログ
        private static OpenFileDialog GetOpenFileDialog(string fileName, string filter)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.FileName = fileName;
            ofd1.Filter = filter;
            ofd1.InitialDirectory = @"";
            ofd1.FilterIndex = 1;
            ofd1.Title = "開くファイルを選択してください";
            ofd1.RestoreDirectory = true;
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            return ofd1;
        }
    }
}
