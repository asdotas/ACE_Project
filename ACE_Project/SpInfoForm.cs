using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class SpInfoForm : ACE_Project.InfoFormBase
    {
        public SpInfoForm()
        {
            InitializeComponent();
        }

        public string[] SendArray { get; set; }
        public string text { get; set; }
        /// <summary>
        /// form set
        /// </summary>
        /// <param name="sendArray"></param>
        ////モードレスフォーム　両方のformが生きてる
        public void ShowSpeakerInfoForm(Array sendArray)
        {
            //日付を2020/02/18 から2020年2月18日に変換
            var ex = new Expression();

            var f = new SpInfoForm();
            f.Show();
            f.Focus();
            string[] array = new string[31];
            array = (string[])sendArray; //何故キャストが必要なのか？
            f.labelRegNum.Text = array[0];
            f.labelEventDate.Text = ex.GetLongDate(array[1]);//array[1];
            f.labelVenue.Text = array[2];
            f.labelTitle.Text = array[3];
            f.labelTheme.Text = array[4];
            f.labelPlace.Text = array[8];
            f.labelSession.Text = array[9];
            f.labelSpeakerId.Text = array[10];
            f.labelSpeaker.Text = array[11];
            f.labelStart.Text = array[12];
            f.labelEnd.Text = array[13];
            f.labelSpeakerTitle.Text = array[14];
            f.labelSavePathMain.Text = array[16];
            f.labelSavePathSub.Text = array[17];

            //申送りの表示
            var remarksFilePath = array[16] + "/_remarks.txt";
            f.textBoxRemarks.Text = remarksFilePath;
            if (File.Exists(remarksFilePath))
            {
                var txt = File.ReadAllText(remarksFilePath);
                f.textBoxRemarks.Text = txt;
            }
            else
            {
                f.textBoxRemarks.Text = array[15];
            }
        }
        private void SpInfoForm_Load(object sender, EventArgs e)
        {
            listView1.AllowDrop = true;
        }
        /// <summary>
        /// ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //ドラック中のアイテムがターゲットのエリアに入った時の処理
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //listViewにドラッグされたファイルの名前、時間、パスを表示する
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            //リスト追加の可否
            var isAdd = true;
            //リスト追加したファイル数
            var countAdd = 0;
            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //パス表示を"\\"から"/"に変更するとアイコンが表示されない
                //var filePath = _filePath.Replace("\\", "/");
                if (listView1.FindItemWithText(filePath) != null) //ファイルの重複を検査
                {
                    isAdd = false;
                }
                else if (isAdd) //重複しているファイルがひとつでもあればリストに追加しない。
                {
                    Icon icon = Icon.ExtractAssociatedIcon(filePath);
                    imageList20x20.Images.Add(icon);
                    imageList40X40.Images.Add(icon);
                    var index = this.imageList20x20.Images.Count - 1;

                    //リストビュー１ SendPathを表示
                    ListViewItem lvi1 = new ListViewItem();
                    lvi1.ImageIndex = index;
                    lvi1.Text = Path.GetFileNameWithoutExtension(filePath);
                    lvi1.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
                    /////lvi.SubItems.Add(Path.GetFullPath(filePath));// だと、逆スラッシュになるので以下に変更;
                    var strPath = Path.GetFullPath(filePath);
                    lvi1.SubItems.Add(strPath);
                    listView1.Items.Add(lvi1);

                    //リストビュー2　送り先のメインパスを表示
                    ListViewItem lvi2 = new ListViewItem();
                    lvi2.ImageIndex = index;
                    lvi2.Text = Path.GetFileNameWithoutExtension(filePath);
                    lvi2.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
                    /////lvi.SubItems.Add(Path.GetFullPath(filePath));// だと、逆スラッシュになるので以下に変更;
                    lvi2.SubItems.Add(labelSavePathMain.Text + '/' + Path.GetFileName(filePath));
                    listViewMain.Items.Add(lvi2);

                    //リストビュー3　送り先のサブパスを表示
                    ListViewItem lvi3 = new ListViewItem();
                    lvi3.ImageIndex = index;
                    lvi3.Text = Path.GetFileNameWithoutExtension(filePath);
                    lvi3.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
                    /////lvi.SubItems.Add(Path.GetFullPath(filePath));// だと、逆スラッシュになるので以下に変更;
                    lvi3.SubItems.Add(labelSavePathSub.Text + '/' + Path.GetFileName(filePath));
                    listViewSub.Items.Add(lvi3);

                    isAdd = true;
                    countAdd++;
                }
            }
            if (isAdd) MessageBox.Show(countAdd + "個のファイルをリストに追加しました。");
            else MessageBox.Show("重複しているファイルが存在していますので、リストに追加できませんでした。");
        }

        //ドラック中のアイテムがターゲットのエリアに入った時の処理
        private void speakerPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //パネルにドラッグされたファイルを、デスクトップに作成したフォルダにコピーする
        private void speakerPanel_DragDrop(object sender, DragEventArgs e)
        {
            //デスクトップのパスを収得
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var spakerDirName = "";

            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            //リスト追加の可否
            var isAdd = true;
            //リスト追加したファイル数
            var countAdd = 0;
            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                //GetDirectoryではなくて、最下層のディレクトリ名はGetFileNameで取得できる
                spakerDirName = Path.GetFileName(labelSavePathMain.Text);
                //デスクトップに作成するフォルダ名を取得
                var mkDirSpeakerPath = Path.Combine(desktopPath, spakerDirName);

                //ファイルコピーするために必要な送り先のパスを取得するためにファイル名と
                //先ほど作成したディレクトリ名を組み合わせてコピーする。
                var fileName = Path.GetFileName(filePath);
                var sendingFilePath = Path.Combine(mkDirSpeakerPath, fileName);

                //if (false) //ファイルの重複を検査
                if (File.Exists(sendingFilePath)) //ファイルの重複を検査
                {
                    isAdd = false;
                }
                else if (isAdd) //重複しているファイルがひとつでもあれば保存しない。
                {

                    //デスクトップにフォルダを作成
                    DirectoryInfo di = Directory.CreateDirectory(mkDirSpeakerPath);
                    //フォルダにコピー
                    File.Copy(filePath, sendingFilePath);

                    isAdd = true;
                    countAdd++;
                }
            }
            if (isAdd) MessageBox.Show("デスクトップに  " + spakerDirName + "  フォルダを作成し、その中に" + countAdd + "個のファイルを保存しました。");
            else MessageBox.Show("重複しているファイルが存在していますので、保存できませんでした。");


        }
        private void speakerPicBox_DoubleClick(object sender, EventArgs e)
        {
            //デスクトップのパスを収得
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //GetDirectoryではなくて、最下層のディレクトリ名はGetFileNameで取得できる
            var spakerDirName = Path.GetFileName(labelSavePathMain.Text);
            //デスクトップに作成するフォルダ名を取得
            var mkDirSpeakerPath = Path.Combine(desktopPath, spakerDirName);
            //指定ディレクトリを開く
            if (Directory.Exists(mkDirSpeakerPath))
            {
                System.Diagnostics.Process.Start(mkDirSpeakerPath);
            }
            else
            {
                MessageBox.Show("指定されたディレクトリは存在しませんでした。");
            }

        }

        //ListViewのアイコンスタイル
        private void ShowLargeIcon()
        {
            listView1.View = View.LargeIcon;
        }
        //ListViewのリストスタイル
        private void ShowListIcon()
        {
            listView1.View = View.List;
        }
        //ListViewの詳細スタイル
        private void ShowDetailsIcon()
        {
            listView1.View = View.Details;
        }
        //ListViewのアイコン削除
        private void DelIcon()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                // 選択されているか確認する
                if (item.Selected)
                {
                    listView1.Items.Remove(item);
                }
            }
        }
        //ListViewのアイコンスタイル(ラジオボタン)
        private void iconRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ShowLargeIcon();
        }
        //ListViewのリストスタイル(ラジオボタン)
        private void listRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ShowListIcon();
        }
        //ListViewの詳細スタイル(ラジオボタン)
        private void detailsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetailsIcon();
        }
        //ListViewのアイコン削除
        private void delBtn_Click(object sender, EventArgs e)
        {
            DelIcon();
        }
        //ドラッグアンドドロップされて表示されているリストビューからフォルダに送る一覧を配列化
        private string[] GetSendArray()
        {
            var sendArray = new string[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sendArray[i] = listView1.Items[i].SubItems[2].Text.Replace("\\", "/");
            }
            return sendArray;
        }
        //リストビューにドラッグアンドドロップされたファイルの送り先から、各受ける先のパスにコピーする
        private void ListViewFileCopy(string[] sendArray)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var receiveFileName = Path.GetFileName(sendArray[i]);
                var receivePathMain = labelSavePathMain.Text + '/' + receiveFileName;
                var receivePathSub = labelSavePathSub.Text + '/' + receiveFileName;

                if (File.Exists(receivePathMain) || File.Exists(receivePathSub))
                {
                    //メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("ファイルを上書きしますか？", receiveFileName,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.Yes)
                    {
                        //「はい」が選択された時
                        File.Copy(sendArray[i], receivePathMain, true);
                        File.Copy(sendArray[i], receivePathSub, true);
                        MessageBox.Show("上書き保存されました。");
                    }
                    else if (result == DialogResult.No)
                    {
                        //「いいえ」が選択された時
                        MessageBox.Show("保存しませんでした。");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        //「キャンセル」が選択された時
                        MessageBox.Show("キャンセルされました。");
                    }
                }
                else
                {
                    File.Copy(sendArray[i], receivePathMain);
                    File.Copy(sendArray[i], receivePathSub);
                    MessageBox.Show("保存されました。");
                }
            }
        }

        //フォームの左上に隠しボタン　押すとテキストが表示
        private void hideBtn_Click(object sender, EventArgs e)
        {
            var isResult = true;
            if (labelSavePathSub.ForeColor == Color.Black && isResult)
            {
                labelSavePathMain.ForeColor = Color.FromArgb(240, 240, 240);
                labelSavePathSub.ForeColor = Color.FromArgb(240, 240, 240);
                isResult = false;
            }
            if (labelSavePathSub.ForeColor == Color.FromArgb(240, 240, 240) && isResult)
            {
                labelSavePathMain.ForeColor = Color.Black;
                labelSavePathSub.ForeColor = Color.Black;
                isResult = false;
            }
        }
        //Mainのタブをクリックした時、ラジオボタンを無効にする
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage0") panelRadio.Enabled = true;
            else if (tabControl1.SelectedTab.Name == "tabPage1") panelRadio.Enabled = false;
            else if (tabControl1.SelectedTab.Name == "tabPage2") panelRadio.Enabled = false;
        }

        //リストビューのファイル名を配列にし、それを指定フォルダにコピーする
        private void fileSendSaveBtn_Click(object sender, EventArgs e)
        {
            var remarksMainPath = labelSavePathMain.Text + "/_remarks.txt";
            var remarksSubPath = labelSavePathSub.Text + "/_remarks.txt";
            if (File.Exists(remarksMainPath) && File.Exists(remarksSubPath))
            {
                var sendArray = GetSendArray();
                ListViewFileCopy(sendArray);
                var textMain = textBoxRemarks.Text;
                var textSub = textBoxRemarks.Text;
                textMain = textMain.Replace("\r\n", null).TrimEnd('\r', '\n');
                textSub = textSub.Replace("\r\n", null).TrimEnd('\r', '\n');


                using (var sw = new StreamWriter(remarksMainPath)) sw.Write(textMain);
                using (var sw = new StreamWriter(remarksSubPath)) sw.Write(textSub);

                ////////////////////////////////////////////////////////
                ///コピーの経緯のログのテキストファイルをフォルダーに作成
                var logMainPath = labelSavePathMain.Text + "/log.csv";
                var logSubPath = labelSavePathSub.Text + "/log.csv";

                var ex = new Expression();
                DateTime nowTime = DateTime.Now;
                for (int i = 0; i < sendArray.Length; i++)
                {
                    var logMainLine = nowTime + "," + labelSavePathMain.Text + "," + sendArray[i];
                    var logSubLine = nowTime + "," + labelSavePathSub.Text + "," + sendArray[i];
                    using (var sw = new StreamWriter(logMainPath, true)) sw.WriteLine(logMainLine);
                    using (var sw = new StreamWriter(logSubPath, true)) sw.WriteLine(logSubLine);
                }
                ///////////////////////////////////////////////////////////////////////////
            }

        }

        //listview2をダブルクリックした時にファルダを開く
        private void listViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(labelSavePathMain.Text);
        }
        //listview2をダブルクリックした時にファルダを開く
        private void listViewSub_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(labelSavePathSub.Text);
        }
        //listviewのメインタブをダブルクリックした時にメインファルダを開く
        //listviewのサブタブをダブルクリックした時にサブファルダを開く
        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageMain)
            {
                System.Diagnostics.Process.Start(labelSavePathMain.Text);
            }
            else if (tabControl1.SelectedTab == tabPageSub)
            {
                System.Diagnostics.Process.Start(labelSavePathSub.Text);
            }
        }

        //プリント
        private void printBtn_Click(object sender, EventArgs e)
        {
            var txt = @"NO " + labelRegNum.Text + "                                                " + labelEventDate.Text + "," +
                       "," +
                       labelSpeakerId.Text + "  " + labelSpeaker.Text + "," +
                       "場 所     " + labelVenue.Text + "," +
                       "," +
                       "学会名     " + "," + labelTitle.Text + "," +
                       "テーマ" + "," + labelTheme.Text + "," +
                       "," +
                       "会 場     " + labelPlace.Text + "," +
                       "開始時間     " + labelStart.Text + "     終了時間     " + labelEnd.Text + "," +
                       "セッション     " + labelSession.Text + "," +
                       "," +
                       "演 目" + "," + labelSpeakerTitle.Text;

                       
            if (File.Exists(@"./temp/print.csv"))
            {
                File.Delete(@"./temp/print.csv");
            }
            using (var sw = new StreamWriter(@"./temp/print.csv"))
            {
                sw.WriteLine(txt);
            }

            var pf = new PrintForm();
            pf.Show();
            pf.ShowPrintDialog();
            //pf.PrintOut();
        }





        //ログファイル作成　fileSendSaveBtnボタンを押した時の処理
        private void MakeLog(string filePath)
        {
            //ファイルを読み込みで開く
            var sr = new StreamReader(filePath);
            //一時ファイルを作成する
            string tmpPath = Path.GetTempFileName();
            //一時ファイルを書き込みで開く
            var sw = new StreamWriter(tmpPath);

            bool isFirstLine = true;
            //内容を一行ずつ読み込む
            while (sr.Peek() > -1)
            {
                //一行読み込む
                string line = sr.ReadLine();
                //はじめの行であれば、飛ばす
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }
                //一時ファイルに書き込む
                sw.WriteLine(line);
            }
            //閉じる
            sr.Close();
            sw.Close();

            //一時ファイルと入れ替える
            File.Copy(tmpPath, filePath, true);
            File.Delete(tmpPath);
        }

        //ログファイル表示
        private void LogBtn_Click(object sender, EventArgs e)
        {
            var ldf = new LogDgvForm();
            ldf.Show();
            var logPathMain = Path.Combine(labelSavePathMain.Text, @"log.csv");
            var logPathSub = Path.Combine(labelSavePathSub.Text, @"log.csv");
            ldf.ShowDgv(logPathMain, logPathSub);
        }


    }
}
