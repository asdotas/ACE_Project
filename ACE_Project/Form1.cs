using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class CheckDeskForm : Form
    {
        ReadDatas rd;

        public CheckDeskForm()
        {
            InitializeComponent();
        }
        public CheckDeskForm(OpenFileDialog ofd)
        {
            InitializeComponent();
            rd = new ReadDatas(ofd.FileName);
        }
        //スタートアップ
        private void CheckDesk_Load(object sender, EventArgs e)
        {
            //全てのセッションをデータグリッドビューに表示(起動時、ｔａｂｂｔｎの会場一覧)
            //ShowAllsession();
            ShowDgvValue();

            // フォントを変更する
            dgv1.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 10, FontStyle.Regular);
            dgv1.ColumnHeadersDefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 6, FontStyle.Regular);
            dgv1.Columns[0].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[10].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            ////ｓｔａｒｔとｅｎｄの位置のバランスがおかしいので調整
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //インフォラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            ShowInfolbl(p.Venue, p.Title, p.Theme);
            InfoLbl.ForeColor = Color.White;

            //パスラベル表示
            ShowAllPath(p.SavePathMain, p.EventDate, p.Title);

            //アイコン情報更新
            MainIconUpdate();

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }
        //済アイコンの表示切替ボタンを使用可能にする
        private void BtnEnabledTrue()
        {
            GrayBtn.Enabled = true;
            AllBtn.Enabled = true;
            HideBtn.Enabled = true;
        }
        //済アイコンの表示切替ボタンを使用不可にする
        private void BtnEnabledFalse()
        {
            GrayBtn.Enabled = false;
            AllBtn.Enabled = false;
            HideBtn.Enabled = false;
        }
        /// <summary>
        /// TabRadioボタンのクリックチェンジ時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabRadioBtn0_CheckedChanged(object sender, EventArgs e)
        {
            TabRadioBtn tbb = new TabRadioBtn();
            tbb.TabRadioBtnAction(tabRadioBtn0);
            //セッションボタンをクリアする
            var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            ShowAllPath(p.SavePathMain, p.EventDate, p.Title);

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn1.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn1);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(0, flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn2.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn2);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(1, flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn3.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn3);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(2, flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn4_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn4.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn4);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(3, flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn5_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn5.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn5);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(4, flowLayoutPanel1);

            //パスラベル表示
           // var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void TabRadioBtn6_CheckedChanged(object sender, EventArgs e)
        {
            var place = tabRadioBtn6.Text;
            TabRadioBtn tbb = new TabRadioBtn(); tbb.TabRadioBtnAction(tabRadioBtn6);
            ////セッションボタンの設置
            //var sflp = new SessionFlowLayoutPanel();
            //sflp.ClearSessyonBtn(flowLayoutPanel1);
            //sflp.SetsessionAllBtn(flowLayoutPanel1, place);
            //sflp.SetSessyonBtn(5, flowLayoutPanel1);

            //パスラベル表示
            //var rd = new ReadDatas("import3.csv");
            var p = rd.GetListData;
            //List<EventInfo_dgvs> listdatas = p.eDgvList;
            ShowPlacePath(p.SavePathMain, p.EventDate, p.Title, place);
            //データセレクトラベルの変更
            DataSelectLbl.Text = "Main Speaker Data";

            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        /// <summary>
        /// 会場一覧 TabRadioボタンのクリック時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabRadioBtn0_MouseClick(object sender, MouseEventArgs e)
        {
            //ShowMain();
            ShowDgvValue();

            //アイコン情報更新
            MainIconUpdate();
        }

        private void TabRadioBtn1_MouseClick(object sender, MouseEventArgs e)
        {

            ShowAllSessionMain("第１会場");



            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();

        }

        private void TabRadioBtn2_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAllSessionMain("第２会場");
            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();
        }

        private void TabRadioBtn3_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAllSessionMain("第３会場");
            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();
        }

        private void TabRadioBtn4_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAllSessionMain("第４会場");
            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();
        }

        private void TabRadioBtn5_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAllSessionMain("第５会場");
            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();
        }

        private void TabRadioBtn6_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAllSessionMain("第６会場");
            //現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
            //SaveNowDgvCsv();
            var bsc = new BinaryStreamCsv();
            bsc.SaveNowDgvDefaultCsv(dgv1);

            //アイコン情報更新
            MainIconUpdate();
        }

        /// <summary>
        /// 未完成ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //checkdeskformのラベルで表記されているデータグリッドビューのヘッダーを配列にする
        private string[] GetDgvHeaderLblArray()
        {
            var dgvheaderLblArray = new string[13]
            {
                dgv1.Columns[18].HeaderText,
                dgv1.Columns[19].HeaderText,
                dgv1.Columns[20].HeaderText,
                dgv1.Columns[21].HeaderText,
                dgv1.Columns[22].HeaderText,
                dgv1.Columns[23].HeaderText,
                dgv1.Columns[24].HeaderText,
                dgv1.Columns[25].HeaderText,
                dgv1.Columns[26].HeaderText,
                dgv1.Columns[27].HeaderText,
                dgv1.Columns[28].HeaderText,
                dgv1.Columns[29].HeaderText,
                dgv1.Columns[30].HeaderText
            };
            return dgvheaderLblArray;
        }
        /// <summary>
        /// データグリッドビュー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        //データグリッドビューダブルクリック時の動作
        private void Dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv dgv = new Dgv();
            dgv.GetEventList();
            var sendArray = dgv.GetSelectRowsArray(dgv1);
            var si = new SpInfoForm();
            //モードレスフォーム
            si.ShowSpeakerInfoForm(sendArray);

        }

        //全データ表示
        private void ShowDgvValue()
        {
            //DgvAutoSizeColums(); //幅の自動調整　時間がかかる
            Dgv dgv = new Dgv();
            dgv.GetEventList();
            dgv.ShowAllDataGridView(dgv1);
        }



        //データグリッドの幅を自動調整　時間がかかる　使用なし
        private void DgvAutoSizeColums()
        {
            MessageBox.Show("自動で幅の調整をします。しばらくお待ちください。時間がかかる場合があります。");
            Dgv dgv = new Dgv();
            dgv.DgvAutoSizeColumnsMode(dgv1);
        }

        //メインのアイコン情報更新 int c はメインのファイルパスの配列のセル番号
        private void ShowIconUpdate(int c)
        {
            //データグリッドビューのヘッダーを配列
            var dgvHeaderLblArray = GetDgvHeaderLblArray();
            for (int i = 0; i < dgv1.RowCount - 1; i++)
            {
                var dgv = new Dgv();
                var fileNameArray = dgv.GetFileNameArray(dgv1.Rows[i].Cells[c].Value.ToString());

                for (int j = 0; j < fileNameArray.Length; j++)
                {
                    //{持込　音声　動画　申送　修正　発表者　演台持上　PowerPoint} の配列dgvHeaderLblArray[0]の持込が、
                    //メインの演者フォルダのファイル一覧の配列fileNameMainArrayに一致すればデータグリッドビューの0行目の
                    //18列目にファイル名を拡張子なしで表示させる
                    for (int r = 0; r < dgvHeaderLblArray.Length; r++)
                    {
                        if (fileNameArray[j].Contains(dgvHeaderLblArray[r]))
                        {
                            dgv1.Rows[i].Cells[18 + r].Value = fileNameArray[j];
                        }
                    }
                }
            }
        }

        //メインアイコン更新 メインのファイルパスの配列のセル番号が１６
        public void MainIconUpdate()
        {
            if (dgv1.Rows[0].Cells[18].Value != null) ShowIconUpdate(16);

            //受付済の行の色を変える
            DoneValueColor();
        }

        //サブアイコン更新 サブのファイルパスの配列のセル番号が１７
        private void SubIconUpdate()
        {
            if (dgv1.Rows[0].Cells[18].Value != null) ShowIconUpdate(17);

            //受付済の行の色を変える
            DoneValueColor();
        }



        private void ShowMain()
        {
            var dgv = new Dgv();
            dgv.GetEventList(); //読み込んだCSVファイルをListにして他のクラスの RaadData speakersに返す
            //dgv.ShowDgv(dgv1);
        }



        //引数の会場を表示する　ALL session
        private void ShowAllSessionMain(string session)
        {
            var dgv = new Dgv();
            dgv.GetEventList();  //読み込んだCSVファイルをListにして他のクラスの RaadData speakersに返す
            //dgv.ShowSelectDgv(dgv1, session);
            dgv.ShowAllDataGridView(dgv1, session);



        }



        public static void DgvClear()
        {
            var c = new CheckDeskForm();
            c.dgv1.Rows.Clear();
        }

        //インフォラベル表示 
        public void ShowInfolbl(string Venue, string Title, string Theme)
        {
            InfoLbl.Text = Venue + ">" + Title + ">" + Theme;
        }

        //パスラベル表示　all
        public void ShowAllPath(string SavePath, string EventDate, string Title)
        {
            var e = new Expression();
            var eventDate_Title = e.GetLongDate(EventDate) + "_" + Title;
            PathLbl.Text = SavePath + ">" + eventDate_Title;
        }


        //パスラベル表示　place
        public void ShowPlacePath(string SavePath, string EventDate, string Title, string Place)
        {
            var e = new Expression();
            var eventDate_Title = e.GetLongDate(EventDate) + "_" + Title;
            PathLbl.Text = SavePath + ">" + eventDate_Title + ">" + Place;
        }

        //パスラベル表示　session
        public void ShowSessionPath(string SavePath, string EventDate, string Title, string Place, string Session)
        {
            var e = new Expression();
            var eventDate_Title = e.GetLongDate(EventDate) + "_" + Title;
            PathLbl.Text = SavePath + ">" + eventDate_Title + ">" + Place + Session;
        }

        //Uplblをクリックし時の動作
        private void Uplbl_MouseClick(object sender, MouseEventArgs e)
        {

            ////受付済の行の色を変える
            //DoneValueColor();

            var dgv = new Dgv();
            switch (DataSelectLbl.Text)
            {
                case "Main Speaker Data":
                    DataSelectLbl.Text = "Sub Folder Data";
                    dgv.IsVisibleIcon(dgv1);
                    SubIconUpdate();
                    break;
                case "Sub Folder Data":
                    DataSelectLbl.Text = "All The Sub Data";
                    dgv.IsVisibleAll(dgv1);
                    SubIconUpdate();
                    break;
                case "All The Sub Data":
                    DataSelectLbl.Text = "Sub Speaker Data";
                    dgv.IsVisibleSelect(dgv1);
                    SubIconUpdate();
                    break;
                case "Sub Speaker Data":
                    DataSelectLbl.Text = "Main Folder Data";
                    dgv.IsVisibleIcon(dgv1);
                    MainIconUpdate();
                    break;
                case "Main Folder Data":
                    DataSelectLbl.Text = "All The Main Data";
                    dgv.IsVisibleAll(dgv1);
                    MainIconUpdate();
                    break;
                case "All The Main Data":
                    DataSelectLbl.Text = "Main Speaker Data";
                    dgv.IsVisibleSelect(dgv1);
                    MainIconUpdate();
                    break;
                default:
                    break;
            }
        }
        //Downlblをクリックし時の動作
        private void DownLbl_MouseClick(object sender, MouseEventArgs e)
        {

            ////受付済の行の色を変える
            //DoneValueColor();


            var dgv = new Dgv();
            switch (DataSelectLbl.Text)
            {
                case "Main Speaker Data":
                    DataSelectLbl.Text = "All The Main Data";
                    dgv.IsVisibleAll(dgv1);
                    MainIconUpdate();
                    break;
                case "All The Main Data":
                    DataSelectLbl.Text = "Main Folder Data";
                    dgv.IsVisibleIcon(dgv1);
                    MainIconUpdate();
                    break;
                case "Main Folder Data":
                    DataSelectLbl.Text = "Sub Speaker Data";
                    dgv.IsVisibleSelect(dgv1);
                    SubIconUpdate();
                    break;
                case "Sub Speaker Data":
                    DataSelectLbl.Text = "All The Sub Data";
                    dgv.IsVisibleAll(dgv1);
                    SubIconUpdate();
                    break;
                case "All The Sub Data":
                    DataSelectLbl.Text = "Sub Folder Data";
                    dgv.IsVisibleIcon(dgv1);
                    SubIconUpdate();
                    break;
                case "Sub Folder Data":
                    DataSelectLbl.Text = "Main Speaker Data";
                    dgv.IsVisibleSelect(dgv1);
                    MainIconUpdate();
                    break;
                default:
                    break;
            }
        }

        private void DownLbl_MouseHover(object sender, EventArgs e)
        {
            DownLbl.Text = "▼";
        }

        private void Uplbl_MouseHover(object sender, EventArgs e)
        {
            Uplbl.Text = "▲";
        }

        private void Uplbl_MouseLeave(object sender, EventArgs e)
        {
            Uplbl.Text = "△";
        }

        private void DownLbl_MouseLeave(object sender, EventArgs e)
        {
            DownLbl.Text = "▽";
        }

        //受付済の行の色を変える
        public void DoneValueColor()
        {
            for (int r = 0; r < dgv1.Rows.Count - 1; r++)
            {
                if (dgv1.Rows[r].Cells[27].Value.ToString().Contains("済"))
                {
                    if (GrayBtn.Checked) 
                    {
                        dgv1.Rows[r].DefaultCellStyle.ForeColor = Color.Gray;
                        dgv1.Rows[r].Visible = true;
                    }
                    else if (HideBtn.Checked) 
                    {
                        dgv1.Rows[r].Visible = false;
                    }
                    else if (AllBtn.Checked)
                    {
                        dgv1.Rows[r].DefaultCellStyle.ForeColor = Color.Black;
                        dgv1.Rows[r].Visible = true;
                    }
                }
            }
        }
        //受付済の行の色を変えるラジオボタンをクリックした時にデータグリッドビューを再表示
        private void GrayBtn_MouseClick(object sender, MouseEventArgs e)
        {
            MainIconUpdate();
            var dgv = new Dgv();
            dgv.IsVisibleSelect(dgv1);
        }
        //受付済の行の色を変えるラジオボタンをクリックした時にデータグリッドビューを再表示
        private void HideBtn_MouseClick(object sender, MouseEventArgs e)
        {

            MainIconUpdate();
            var dgv = new Dgv();
            dgv.IsVisibleSelect(dgv1);
        }
        //受付済の行の色を変えるラジオボタンをクリックした時にデータグリッドビューを再表示
        private void AllBtn_MouseClick(object sender, MouseEventArgs e)
        {
            MainIconUpdate();
            var dgv = new Dgv();
            dgv.IsVisibleSelect(dgv1);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SpeakerSearch();
        }
        //演者の名前を検索する
        private void SpeakerSearch()
        {
            ShowDgvValue();
            var count = 0;
            for (int r = 0; r < dgv1.Rows.Count - 1; r++)
            {
                var dgvValue = (dgv1.Rows[r].Cells[11].Value.ToString()).Trim(null).Replace(" ", "");
                var searchTxtBox = (searchTxtbox.Text).Trim(null).Replace(" ", "").Replace("　", "");
                if (dgvValue.Contains(searchTxtBox))
                {
                    count++;
                }
                if (!dgvValue.Contains(searchTxtBox))
                {
                    dgv1.Rows[r].Visible = false;
                }

            }
            MessageBox.Show(count + "件見つかりました。");

            //済アイコンの表示切替ボタンを使用不可にする
            BtnEnabledFalse();
        }
        private void DownLbl_MouseDown(object sender, MouseEventArgs e)
        {
            //アイコン情報更新
            MainIconUpdate();

            ShowDgvValue();
        }

        private void searchTxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SpeakerSearch();

            }
        }

        private void DownLbl_Click(object sender, EventArgs e)
        {
            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }

        private void Uplbl_Click(object sender, EventArgs e)
        {
            // 済アイコンの表示切替ボタンを使用可能にする
            BtnEnabledTrue();
        }








        ////アイコンのヘッダーを表示
        //private void ShowIconHeader()
        //{
        //    var isResult = true;
        //    if (PcLbl.ForeColor == Color.Snow && isResult)
        //    {
        //        PcLbl.ForeColor = Color.Black;
        //        AudioLbl.ForeColor = Color.Black;
        //        VideoLbl.ForeColor = Color.Black;
        //        RequestLbl.ForeColor = Color.Black;
        //        FixLbl.ForeColor = Color.Black;
        //        PresenterToolLbl.ForeColor = Color.Black;
        //        PcPodiumLbl.ForeColor = Color.Black;
        //        PowerPointLbl.ForeColor = Color.Black;
        //        isResult = false;
        //    }
        //}

        //////全会場アイコン一覧
        //private void ShowDgvValue()
        //{
        //    ShowIconHeader();//アイコンのヘッダーを表示
        //    var dgv = new Dgv();
        //    dgv.GetEventList();  //読み込んだCSVファイルをListにして他のクラスの RaadData speakersに返す
        //    var dgvHeaderLblArray = GetDgvHeaderLblArray();
        //    dgv.ShowAllDataGridView(dgv1);
        //}


        ////全てのセッションをデータグリッドビューに表示(起動時、ｔａｂｂｔｎの会場一覧)
        //private void ShowAllsession()
        //{
        //    Dgv dgv = new Dgv();
        //    dgv.GetEventList();
        //    dgv.ShowDgv(dgv1);
        //}

        /// <summary>
        /// ボタン工事中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ////////////全会場アイコン一覧 メイン
        //////////private void IconMainBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    dgv1.Rows.Clear();
        //////////    ShowDgvValue();
        //////////    //メインアイコン更新
        //////////    MainIconUpdate();
        //////////}

        ////////////全会場アイコン一覧　サブ
        //////////private void IconSubBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    dgv1.Rows.Clear();
        //////////    ShowDgvValue();
        //////////    //サブアイコン更新
        //////////    SubIconUpdate();
        //////////}

        ////////////全データ表示
        //////////private void AllMainBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    ShowDgvValue();
        //////////    //メインアイコン更新
        //////////    MainIconUpdate();
        //////////}

        //////////private void AllSubBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    ShowDgvValue();
        //////////    //サブアイコン更新
        //////////    SubIconUpdate();
        //////////}

        ////////////会場一覧 メイン
        //////////private void ShowMainBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    //ShowMain();
        //////////    ShowDgvValue();
        //////////}
        ////会場一覧 サブ
        //private void ShowSubBtn_Click(object sender, EventArgs e)
        //{
        //    var dgv = new Dgv();
        //    dgv.GetEventList(); //読み込んだCSVファイルをListにして他のクラスの RaadData speakersに返す
        //    //dgv.ShowDgv(dgv1);

        //}

        ////////////第１会場　ALL session
        //////////private void ShowAllSessionMainBtn_Click(object sender, EventArgs e)
        //////////{
        //////////    ShowAllSessionMain("第１会場");
        //////////}
        //////////private void ShowAllSessionSubBtn_Click(object sender, EventArgs e)
        //////////{

        //////////}

        //public void FlatBtn_Action(string session)
        //{
        //    MessageBox.Show("1 form1 453");
        //    var dgv = new Dgv();
        //    dgv.GetEventList("./temp/nowdgv.csv");
        //    dgv.ShowAllDataGridViewSession(dgv1, session);
        //    //ShowDgvValue();
        //}
    }
}
