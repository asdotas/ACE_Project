using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace ACE_Project
{
    public class Dgv : DgvBase
    {
        ReadDatas speakers;

        public Dgv()//(DataGridViewContentAlignment alig, int intWidth, bool isVisible)
        {
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Dock = DockStyle.Fill;
            this.ScrollBars = ScrollBars.Both;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 222, 222);
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.ColumnHeadersVisible = false;
        }

        /// <summary>
        /// データグリッドのレイアウト
        /// </summary>
        /// <param name="dgv1"></param>
        /// 
        //レイアウト①
        //データグリッドビューの全データのデザイン
        public void ShowAllDataGridViewLayout(DataGridView dgv1)
        {
            //フォント指定
            //dgv1.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[18].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[19].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[20].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[21].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[22].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[23].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[24].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[25].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[26].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[27].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[28].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[29].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
            dgv1.Columns[30].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);

            //a.データグリッドビュの幅と高さ
            SetDgvWidth(dgv1);

            //b.データグリッドビュのテキストの位置
            SetDgvAlignment(dgv1);

            //c.データグリッドビュの列の表示、非表示
            IsVisibleSelect(dgv1);

          
        }

        //a.データグリッドビュの幅と高さ
        private void SetDgvWidth(DataGridView dgv1)
        {
            //行のデフォルトの高さ
            dgv1.RowTemplate.Height = 50;
            dgv1.Columns[0].Width = 40;
            dgv1.Columns[1].Width = 80;
            dgv1.Columns[2].Width = 60;
            dgv1.Columns[3].Width = 60;
            dgv1.Columns[4].Width = 60;
            dgv1.Columns[5].Width = 60;
            dgv1.Columns[6].Width = 60;
            dgv1.Columns[7].Width = 60;
            dgv1.Columns[8].Width = 60;
            dgv1.Columns[9].Width = 50;
            dgv1.Columns[10].Width = 50;
            dgv1.Columns[11].Width = 100;
            dgv1.Columns[12].Width = 50;
            dgv1.Columns[13].Width = 50;
            dgv1.Columns[14].Width = 293;
            dgv1.Columns[15].Width = 250;
            dgv1.Columns[16].Width = 100;
            dgv1.Columns[17].Width = 100;
            dgv1.Columns[18].Width = 63;
            dgv1.Columns[19].Width = 63;
            dgv1.Columns[20].Width = 63;
            dgv1.Columns[21].Width = 63;
            dgv1.Columns[22].Width = 63;
            dgv1.Columns[23].Width = 63;
            dgv1.Columns[24].Width = 79;
            dgv1.Columns[25].Width = 71;
            dgv1.Columns[26].Width = 115;
            dgv1.Columns[27].Width = 60;
            dgv1.Columns[28].Width = 0;
            dgv1.Columns[29].Width = 0;
            dgv1.Columns[30].Width = 0;
        }
     
        //b.データグリッドビュのテキストの位置
        private void SetDgvAlignment(DataGridView dgv1)
        {
            for (int i = 0; i < dgv1.Columns.Count; i++)
            {
                dgv1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            //テキストをセンターに配置
            dgv1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //c1.データグリッドビュの列の表示、非表示
        public void IsVisibleAll(DataGridView dgv1)
        {
            for (int c = 0; c < dgv1.Columns.Count; c++)
            {
                dgv1.Columns[c].Visible = true;
            }
            dgv1.Columns[25].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
        }

        //c2.データグリッドビュの列の表示、非表示
        public void IsVisibleSelect(DataGridView dgv1)
        {
            dgv1.Columns[0].Visible = true;
            dgv1.Columns[1].Visible = false;
            dgv1.Columns[2].Visible = false;
            dgv1.Columns[3].Visible = false;
            dgv1.Columns[4].Visible = false;
            dgv1.Columns[5].Visible = false;
            dgv1.Columns[6].Visible = false;
            dgv1.Columns[7].Visible = false;
            dgv1.Columns[8].Visible = false;
            dgv1.Columns[9].Visible = false;
            dgv1.Columns[10].Visible = true;
            dgv1.Columns[11].Visible = true;
            dgv1.Columns[12].Visible = true;
            dgv1.Columns[13].Visible = true;
            dgv1.Columns[14].Visible = true;
            dgv1.Columns[15].Visible = true;
            dgv1.Columns[16].Visible = false;
            dgv1.Columns[17].Visible = false;
            dgv1.Columns[18].Visible = false;
            dgv1.Columns[19].Visible = false;
            dgv1.Columns[20].Visible = false;
            dgv1.Columns[21].Visible = false;
            dgv1.Columns[22].Visible = false;
            dgv1.Columns[23].Visible = false;
            dgv1.Columns[24].Visible = false;
            dgv1.Columns[25].Visible = false;
            dgv1.Columns[26].Visible = false;
            dgv1.Columns[27].Visible = true;
            dgv1.Columns[28].Visible = false;
            dgv1.Columns[29].Visible = false;
            dgv1.Columns[30].Visible = false;

            //for (int c = 0; c < dgv1.Columns.Count; c++)
            //{
            //    dgv1.Columns[c].Visible = true;
            //}

            dgv1.Columns[25].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
        }

        //c3.データグリッドビュの列の表示、非表示
        public void IsVisibleIcon(DataGridView dgv1)
        {
            
            //列の表示、非表示
            dgv1.Columns[0].Visible = true;
            dgv1.Columns[1].Visible = false;
            dgv1.Columns[2].Visible = false;
            dgv1.Columns[3].Visible = false;
            dgv1.Columns[4].Visible = false;
            dgv1.Columns[5].Visible = false;
            dgv1.Columns[6].Visible = false;
            dgv1.Columns[7].Visible = false;
            dgv1.Columns[8].Visible = false;
            dgv1.Columns[9].Visible = false;
            dgv1.Columns[10].Visible = true;
            dgv1.Columns[11].Visible = true;
            dgv1.Columns[12].Visible = false;
            dgv1.Columns[13].Visible = false;
            dgv1.Columns[14].Visible = false;
            dgv1.Columns[15].Visible = false;
            dgv1.Columns[16].Visible = false;
            dgv1.Columns[17].Visible = false;
            dgv1.Columns[18].Visible = true;
            dgv1.Columns[19].Visible = true;
            dgv1.Columns[20].Visible = true;
            dgv1.Columns[21].Visible = true;
            dgv1.Columns[22].Visible = true;
            dgv1.Columns[23].Visible = true;
            dgv1.Columns[24].Visible = true;
            dgv1.Columns[25].Visible = true;
            dgv1.Columns[26].Visible = true;
            dgv1.Columns[27].Visible = true;
            dgv1.Columns[28].Visible = false;
            dgv1.Columns[29].Visible = false;
            dgv1.Columns[30].Visible = false;

            //for (int c = 0; c < dgv1.Columns.Count; c++)
            //{
            //    dgv1.Columns[c].Visible = true;
            //}

            dgv1.Columns[25].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
        }



        /// <summary>
        /// データグリッドの値の表示
        /// </summary>
        /// <param name="dgv1"></param>
        /// 
        /// 
        //レイアウト①を使用
        //データグリッドビューの全データの表示
        public void ShowAllDataGridView(DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            //行のデフォルトの高さと幅
            ShowAllDataGridViewLayout(dgv1);
            //ヘッダー表示
            dgv1.ColumnHeadersVisible = true;
            var p = speakers.GetListData;
            int r = 0;
            List<EventInfo_dgvs> listdatas = p.EDgvList;

            foreach (var listdata in listdatas)
            {
                var text = listdata.Place;
                if (Regex.IsMatch(text, ""))
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
                    dgv1.Rows[r].Cells[1].Value = p.EventDate;
                    dgv1.Rows[r].Cells[2].Value = p.Venue;
                    dgv1.Rows[r].Cells[3].Value = p.Title;
                    dgv1.Rows[r].Cells[4].Value = p.Theme;
                    dgv1.Rows[r].Cells[5].Value = p.SavePathMain;
                    dgv1.Rows[r].Cells[6].Value = p.SavePathSub;
                    dgv1.Rows[r].Cells[7].Value = p.Reserve;
                    dgv1.Rows[r].Cells[8].Value = listdata.Place;
                    dgv1.Rows[r].Cells[9].Value = listdata.Session;
                    dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
                    dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
                    dgv1.Rows[r].Cells[12].Value = listdata.Start;
                    dgv1.Rows[r].Cells[13].Value = listdata.End;
                    dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

                    //申送りremarksの表示
                    var remarksFilePath = listdata.Open1 + "/_remarks.txt";
                    if (File.Exists(remarksFilePath))
                    {
                        var txt = File.ReadAllText(remarksFilePath);
                        //spinfoformの送信ボタンを押すごとに\r\nが作られるので除去する
                        txt = txt.Replace("\r", null);
                        txt = txt.Replace("\n", null);
                        dgv1.Rows[r].Cells[15].Value = txt;
                    }
                    else
                    {
                        dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
                    }

                    dgv1.Rows[r].Cells[16].Value = listdata.Open1;
                    dgv1.Rows[r].Cells[17].Value = listdata.Open2;
                    dgv1.Rows[r].Cells[18].Value = listdata.Pc;
                    dgv1.Rows[r].Cells[19].Value = listdata.Audio;
                    dgv1.Rows[r].Cells[20].Value = listdata.Video;
                    dgv1.Rows[r].Cells[21].Value = listdata.Request;
                    dgv1.Rows[r].Cells[22].Value = listdata.Fix;
                    dgv1.Rows[r].Cells[23].Value = listdata.PresenterTool;
                    dgv1.Rows[r].Cells[24].Value = listdata.PcPodium;
                    dgv1.Rows[r].Cells[25].Value = listdata.PowerPoint;
                    dgv1.Rows[r].Cells[26].Value = listdata.Done;
                    dgv1.Rows[r].Cells[27].Value = listdata.PowerPoint2010;
                    dgv1.Rows[r].Cells[28].Value = listdata.PowerPoint2013;
                    dgv1.Rows[r].Cells[29].Value = listdata.PowerPoint2016;
                    dgv1.Rows[r].Cells[30].Value = listdata.PowerPoint2019;
                    r++;
                }
            }
        }
        /// 
        //レイアウト①を使用
        //データグリッドビューの全データの表示
        public void ShowAllDataGridView(DataGridView dgv1, string placeName)
        {
            dgv1.Rows.Clear();
            //行のデフォルトの高さと幅
            ShowAllDataGridViewLayout(dgv1);
            //ヘッダー表示
            dgv1.ColumnHeadersVisible = true;
            var p = speakers.GetListData;
            int r = 0;
            List<EventInfo_dgvs> listdatas = p.EDgvList;

            foreach (var listdata in listdatas)
            {
                var text = listdata.Place;
                if (Regex.IsMatch(text, placeName))
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
                    dgv1.Rows[r].Cells[1].Value = p.EventDate;
                    dgv1.Rows[r].Cells[2].Value = p.Venue;
                    dgv1.Rows[r].Cells[3].Value = p.Title;
                    dgv1.Rows[r].Cells[4].Value = p.Theme;
                    dgv1.Rows[r].Cells[5].Value = p.SavePathMain;
                    dgv1.Rows[r].Cells[6].Value = p.SavePathSub;
                    dgv1.Rows[r].Cells[7].Value = p.Reserve;
                    dgv1.Rows[r].Cells[8].Value = listdata.Place;
                    dgv1.Rows[r].Cells[9].Value = listdata.Session;
                    dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
                    dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
                    dgv1.Rows[r].Cells[12].Value = listdata.Start;
                    dgv1.Rows[r].Cells[13].Value = listdata.End;
                    dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

                    //申送りremarksの表示
                    var remarksFilePath = listdata.Open1 + "/_remarks.txt";
                    if (File.Exists(remarksFilePath))
                    {
                        var txt = File.ReadAllText(remarksFilePath);
                        dgv1.Rows[r].Cells[15].Value = txt;
                    }
                    else
                    {
                        dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
                    }

                    dgv1.Rows[r].Cells[16].Value = listdata.Open1;
                    dgv1.Rows[r].Cells[17].Value = listdata.Open2;
                    dgv1.Rows[r].Cells[18].Value = listdata.Pc;
                    dgv1.Rows[r].Cells[19].Value = listdata.Audio;
                    dgv1.Rows[r].Cells[20].Value = listdata.Video;
                    dgv1.Rows[r].Cells[21].Value = listdata.Request;
                    dgv1.Rows[r].Cells[22].Value = listdata.Fix;
                    dgv1.Rows[r].Cells[23].Value = listdata.PresenterTool;
                    dgv1.Rows[r].Cells[24].Value = listdata.PcPodium;
                    dgv1.Rows[r].Cells[25].Value = listdata.PowerPoint;
                    dgv1.Rows[r].Cells[26].Value = listdata.Done;
                    dgv1.Rows[r].Cells[27].Value = listdata.PowerPoint2010;
                    dgv1.Rows[r].Cells[28].Value = listdata.PowerPoint2013;
                    dgv1.Rows[r].Cells[29].Value = listdata.PowerPoint2016;
                    dgv1.Rows[r].Cells[30].Value = listdata.PowerPoint2019;

                    r++;
                }
            }
        }

        //レイアウト①を使用
        //データグリッドビューの全データの表示
        public void ShowAllDataGridViewSession(DataGridView dgv1, string session)
        {
            MessageBox.Show("2 dgv 361 ShowAllDataGridViewSession");
            dgv1.Rows.Clear();
            //行のデフォルトの高さと幅
            ShowAllDataGridViewLayout(dgv1);
            //ヘッダー表示
            dgv1.ColumnHeadersVisible = true;
            var p = speakers.GetListData;
            int r = 0;
            List<EventInfo_dgvs> listdatas = p.EDgvList;

            foreach (var listdata in listdatas)
            {
                var text = listdata.Session;
                if (Regex.IsMatch(text, session))
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
                    dgv1.Rows[r].Cells[1].Value = p.EventDate;
                    dgv1.Rows[r].Cells[2].Value = p.Venue;
                    dgv1.Rows[r].Cells[3].Value = p.Title;
                    dgv1.Rows[r].Cells[4].Value = p.Theme;
                    dgv1.Rows[r].Cells[5].Value = p.SavePathMain;
                    dgv1.Rows[r].Cells[6].Value = p.SavePathSub;
                    dgv1.Rows[r].Cells[7].Value = p.Reserve;
                    dgv1.Rows[r].Cells[8].Value = listdata.Place;
                    dgv1.Rows[r].Cells[9].Value = listdata.Session;
                    dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
                    dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
                    dgv1.Rows[r].Cells[12].Value = listdata.Start;
                    dgv1.Rows[r].Cells[13].Value = listdata.End;
                    dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

                    //申送りremarksの表示
                    var remarksFilePath = listdata.Open1 + "/_remarks.txt";
                    if (File.Exists(remarksFilePath))
                    {
                        var txt = File.ReadAllText(remarksFilePath);
                        dgv1.Rows[r].Cells[15].Value = txt;
                    }
                    else
                    {
                        dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
                    }

                    dgv1.Rows[r].Cells[16].Value = listdata.Open1;
                    dgv1.Rows[r].Cells[17].Value = listdata.Open2;
                    dgv1.Rows[r].Cells[18].Value = listdata.Pc;
                    dgv1.Rows[r].Cells[19].Value = listdata.Audio;
                    dgv1.Rows[r].Cells[20].Value = listdata.Video;
                    dgv1.Rows[r].Cells[21].Value = listdata.Request;
                    dgv1.Rows[r].Cells[22].Value = listdata.Fix;
                    dgv1.Rows[r].Cells[23].Value = listdata.PresenterTool;
                    dgv1.Rows[r].Cells[24].Value = listdata.PcPodium;
                    dgv1.Rows[r].Cells[25].Value = listdata.PowerPoint;
                    dgv1.Rows[r].Cells[26].Value = listdata.Done;
                    dgv1.Rows[r].Cells[27].Value = listdata.PowerPoint2010;
                    dgv1.Rows[r].Cells[28].Value = listdata.PowerPoint2013;
                    dgv1.Rows[r].Cells[29].Value = listdata.PowerPoint2016;
                    dgv1.Rows[r].Cells[30].Value = listdata.PowerPoint2019;
                    r++;
                }
            }
        }

        /// <summary>
        /// データグリッドのオープンファイルダイアログ
        /// </summary>
        /// <param name="dgv1"></param>
        ///
        //オープンファイルダイアログ
        private OpenFileDialog GetOpenFileDialog(string fileName, string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = fileName;
            ofd.Filter = filter;
            ofd.InitialDirectory = @"";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            return ofd;
        }
        ///
        //データグリッドビューのデータをオープンファイルダイアログで、CSVファイルから読み込む
        public void ShowOfdDgv(DataGridView dgv1)
        {
            var ofd = GetOpenFileDialog("import.csv", "Csvファイル(*.csv;)|*.csv|すべてのファイル(*.*)|*.*");
            dgv1.Rows.Clear();
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                speakers = new ReadDatas(ofd.FileName);
                //ShowDgv(dgv1);
                
            }
        }

        //データグリッドビューのデータをオープンファイルダイアログで、CSVファイルから読み込む/////工事中
        public void ShowOfdSessionDgv(DataGridView dgv1, string place)
        {
            var ofd = GetOpenFileDialog(@"import.csv", "Csvファイル(*.csv;)|*.csv|すべてのファイル(*.*)|*.*");
            dgv1.Rows.Clear();
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                speakers = new ReadDatas(ofd.FileName);
                GetEventList();  //読み込んだCSVファイルをListにして他のクラスの RaadData speakersに返す
                //ShowSelectDgv(dgv1, place);
                ShowAllDataGridView(dgv1, place);
                
            }
        }
        /// <summary>
        /// データグリッドのオートサイズ
        /// </summary>
        /// <param name="dgv1"></param>
        ///
        //データグリッドビューのカラムのオートサイズ
        public void DgvAutoSizeColumnsMode(DataGridView dgv1)
        {
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //フォルダー内の全ファイルのファイルパスを配列にする 
        public string[] GetFileNameArray(string filePath)
        {

                string[] subFolders = Directory.GetFiles(filePath, "*");
                var fileNameArray = new string[subFolders.Length];

                //ファイル名のみに変換して配列にする
                for (int i = 0; i < subFolders.Length; i++)
                {
                    fileNameArray[i] = Path.GetFileNameWithoutExtension(subFolders[i]);
                }
                return fileNameArray;


        }

        //データグリッドビューをリスト化 引数なし
        public List<string> GetEventList()
        {
            speakers = new ReadDatas(@"./temp/temp.csv");
            List<string> list = new List<string>();
            for (int i = 0; i < speakers.GetListData.EDgvList.Count; i++)
            {
                list.Add(speakers.GetListData.EDgvList[i].RegNum);
                list.Add(speakers.GetListData.EventDate);
                list.Add(speakers.GetListData.Venue);
                list.Add(speakers.GetListData.Title);
                list.Add(speakers.GetListData.Theme);
                list.Add(speakers.GetListData.SavePathMain);
                list.Add(speakers.GetListData.SavePathSub);
                list.Add(speakers.GetListData.Reserve);
                list.Add(speakers.GetListData.EDgvList[i].Place);
                list.Add(speakers.GetListData.EDgvList[i].Session);
                list.Add(speakers.GetListData.EDgvList[i].SpeakerId);
                list.Add(speakers.GetListData.EDgvList[i].Speaker);
                list.Add(speakers.GetListData.EDgvList[i].Start);
                list.Add(speakers.GetListData.EDgvList[i].End);
                list.Add(speakers.GetListData.EDgvList[i].SpeakerTitle);
                list.Add(speakers.GetListData.EDgvList[i].Remarks);
                list.Add(speakers.GetListData.EDgvList[i].Open1);
                list.Add(speakers.GetListData.EDgvList[i].Open2);
                list.Add(speakers.GetListData.EDgvList[i].Pc);
                list.Add(speakers.GetListData.EDgvList[i].Audio);
                list.Add(speakers.GetListData.EDgvList[i].Video);
                list.Add(speakers.GetListData.EDgvList[i].Request);
                list.Add(speakers.GetListData.EDgvList[i].Fix);
                list.Add(speakers.GetListData.EDgvList[i].PresenterTool);
                list.Add(speakers.GetListData.EDgvList[i].PcPodium);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint);
                list.Add(speakers.GetListData.EDgvList[i].Done);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2010);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2013);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2016);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2019);
            }
            return list;
        }

        //データグリッドビューをリスト化 引数あり
        public List<string> GetEventList(string filePath)
        {
            speakers = new ReadDatas(filePath);
            List<string> list = new List<string>();
            for (int i = 0; i < speakers.GetListData.EDgvList.Count; i++)
            {
                list.Add(speakers.GetListData.EDgvList[i].RegNum);
                list.Add(speakers.GetListData.EventDate);
                list.Add(speakers.GetListData.Venue);
                list.Add(speakers.GetListData.Title);
                list.Add(speakers.GetListData.Theme);
                list.Add(speakers.GetListData.SavePathMain);
                list.Add(speakers.GetListData.SavePathSub);
                list.Add(speakers.GetListData.Reserve);
                list.Add(speakers.GetListData.EDgvList[i].Place);
                list.Add(speakers.GetListData.EDgvList[i].Session);
                list.Add(speakers.GetListData.EDgvList[i].SpeakerId);
                list.Add(speakers.GetListData.EDgvList[i].Speaker);
                list.Add(speakers.GetListData.EDgvList[i].Start);
                list.Add(speakers.GetListData.EDgvList[i].End);
                list.Add(speakers.GetListData.EDgvList[i].SpeakerTitle);
                list.Add(speakers.GetListData.EDgvList[i].Remarks);
                list.Add(speakers.GetListData.EDgvList[i].Open1);
                list.Add(speakers.GetListData.EDgvList[i].Open2);
                list.Add(speakers.GetListData.EDgvList[i].Pc);
                list.Add(speakers.GetListData.EDgvList[i].Audio);
                list.Add(speakers.GetListData.EDgvList[i].Video);
                list.Add(speakers.GetListData.EDgvList[i].Request);
                list.Add(speakers.GetListData.EDgvList[i].Fix);
                list.Add(speakers.GetListData.EDgvList[i].PresenterTool);
                list.Add(speakers.GetListData.EDgvList[i].PcPodium);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint);
                list.Add(speakers.GetListData.EDgvList[i].Done);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2010);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2013);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2016);
                list.Add(speakers.GetListData.EDgvList[i].PowerPoint2019);
            }
            return list;
        }


        /// <summary>
        /// 作業中
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>

        //選択された行の値を配列化
        public String[] GetSelectRowsArray(DataGridView dgv1)
        {
            var cellsCount = dgv1.ColumnCount; //データグリッドビューのセルの数
            var array = new String[cellsCount]; //
            var num = int.Parse(dgv1.CurrentRow.Cells[0].Value.ToString()) - 101; //選択された行の番号
            var p = speakers.GetListData;
            array[0] = p.EDgvList[num].RegNum;
            array[1] = p.EventDate;
            array[2] = p.Venue;
            array[3] = p.Title;
            array[4] = p.Theme;
            array[5] = p.SavePathMain;
            array[6] = p.SavePathSub;
            array[7] = p.Reserve;

            array[8] = p.EDgvList[num].Place;
            array[9] = p.EDgvList[num].Session;
            array[10] = p.EDgvList[num].SpeakerId;
            array[11] = p.EDgvList[num].Speaker;
            array[12] = p.EDgvList[num].Start;
            array[13] = p.EDgvList[num].End;
            array[14] = p.EDgvList[num].SpeakerTitle;
            array[15] = p.EDgvList[num].Remarks;
            array[16] = p.EDgvList[num].Open1;
            array[17] = p.EDgvList[num].Open2;
            array[18] = p.EDgvList[num].Pc;
            array[19] = p.EDgvList[num].Audio;
            array[20] = p.EDgvList[num].Video;
            array[21] = p.EDgvList[num].Request;
            array[22] = p.EDgvList[num].Fix;
            array[23] = p.EDgvList[num].PresenterTool;
            array[24] = p.EDgvList[num].PcPodium;
            array[25] = p.EDgvList[num].PowerPoint;
            array[26] = p.EDgvList[num].Done;
            array[27] = p.EDgvList[num].PowerPoint2010;
            array[28] = p.EDgvList[num].PowerPoint2013;
            array[29] = p.EDgvList[num].PowerPoint2016;
            array[30] = p.EDgvList[num].PowerPoint2019;

            return array;
        }



        //レイアウト②を使用
        //データグリッドビューの7行の表示(上記とセット)
        //public void ShowSelectDgv(DataGridView dgv1, string placeName) //placeNameは実際に検索したいワード　第１会場燈
        //{
        //    dgv1.Rows.Clear();
        //    this.ColumnHeadersVisible = false;
        //    //行のデフォルトの高さと幅
        //    ShowSelectDgvLayout(dgv1);
        //    var p = speakers.GetListData;
        //    int r = 0;
        //    List<EventInfo_dgvs> listdatas = p.eDgvList;
        //    foreach (var listdata in listdatas)
        //    {
        //        var text = listdata.Place;
        //        {
        //            if (Regex.IsMatch(text, placeName))
        //            {
        //                dgv1.Rows.Add();
        //                dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
        //                dgv1.Rows[r].Cells[1].Value = p.EventDate;//
        //                dgv1.Rows[r].Cells[2].Value = p.Venue;//
        //                dgv1.Rows[r].Cells[3].Value = p.Title;//
        //                dgv1.Rows[r].Cells[4].Value = p.Theme;//
        //                dgv1.Rows[r].Cells[5].Value = p.SavePathMain;//
        //                dgv1.Rows[r].Cells[6].Value = p.SavePathSub;//
        //                dgv1.Rows[r].Cells[7].Value = p.Reserve;//
        //                dgv1.Rows[r].Cells[8].Value = listdata.Place;
        //                dgv1.Rows[r].Cells[9].Value = listdata.Session;
        //                dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
        //                dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
        //                dgv1.Rows[r].Cells[12].Value = listdata.Start;
        //                dgv1.Rows[r].Cells[13].Value = listdata.End;
        //                dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

        //                //申送りremarksの表示
        //                var remarksFilePath = listdata.Open1 + "/_remarks.txt";
        //                if (File.Exists(remarksFilePath))
        //                {
        //                    var txt = File.ReadAllText(remarksFilePath);
        //                    //spinfoformの送信ボタンを押すごとに\r\nが作られるので除去する
        //                    txt = txt.Replace("\r", null);
        //                    txt = txt.Replace("\n", null);
        //                    dgv1.Rows[r].Cells[15].Value = txt;
        //                }
        //                else
        //                {
        //                    dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
        //                }
        //                dgv1.Rows[r].Cells[16].Value = listdata.Open1;
        //                dgv1.Rows[r].Cells[17].Value = listdata.Open2;
        //                r++;
        //            }
        //        }
        //    }
        //}
        /// 
        ///レイアウト②を使用
        //セッションボタンの押した時の動作　////////////////////////////工事中
        //public void ShowSessionDgv(DataGridView dgv1, string session)
        //{
        //    dgv1.Rows.Clear();
        //    this.ColumnHeadersVisible = false;
        //    //行のデフォルトの高さと幅
        //    ShowSelectDgvLayout(dgv1);
        //    var p = speakers.GetListData;
        //    int r = 0;
        //    List<EventInfo_dgvs> listdatas = p.eDgvList;
        //    foreach (var listdata in listdatas)
        //    {
        //        var text = listdata.Session;
        //        {
        //            if (Regex.IsMatch(text, session))
        //            {
        //                dgv1.Rows.Add();
        //                dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
        //                dgv1.Rows[r].Cells[1].Value = p.EventDate;//
        //                dgv1.Rows[r].Cells[2].Value = p.Venue;//
        //                dgv1.Rows[r].Cells[3].Value = p.Title;//
        //                dgv1.Rows[r].Cells[4].Value = p.Theme;//
        //                dgv1.Rows[r].Cells[5].Value = p.SavePathMain;//
        //                dgv1.Rows[r].Cells[6].Value = p.SavePathSub;//
        //                dgv1.Rows[r].Cells[7].Value = p.Reserve;//
        //                dgv1.Rows[r].Cells[8].Value = listdata.Place;
        //                dgv1.Rows[r].Cells[9].Value = listdata.Session;
        //                dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
        //                dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
        //                dgv1.Rows[r].Cells[12].Value = listdata.Start;
        //                dgv1.Rows[r].Cells[13].Value = listdata.End;
        //                dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

        //                //申送りremarksの表示
        //                var remarksFilePath = listdata.Open1 + "/_remarks.txt";
        //                if (File.Exists(remarksFilePath))
        //                {
        //                    var txt = File.ReadAllText(remarksFilePath);
        //                    //spinfoformの送信ボタンを押すごとに\r\nが作られるので除去する
        //                    txt = txt.Replace("\r", null);
        //                    txt = txt.Replace("\n", null);
        //                    dgv1.Rows[r].Cells[15].Value = txt;
        //                }
        //                else
        //                {
        //                    dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
        //                }
        //                dgv1.Rows[r].Cells[16].Value = listdata.Open1;
        //                dgv1.Rows[r].Cells[17].Value = listdata.Open2;
        //                r++;
        //            }
        //        }
        //    }
        //}
        /// 
        //レイアウト②を使用
        //データグリッドビューのsession別での7行の表示(上記とセット)
        //public void ShowSelectSessionDgv(DataGridView dgv1, string placeName, string session) //placeNameは実際に検索したいワード　第１会場燈
        //{
        //    dgv1.Rows.Clear();
        //    this.ColumnHeadersVisible = false;

        //    //行のデフォルトの高さと幅
        //    ShowSelectDgvLayout(dgv1);

        //    var p = speakers.GetListData;
        //    int r = 0;
        //    List<EventInfo_dgvs> listdatas = p.eDgvList;
        //    foreach (var listdata in listdatas)
        //    {
        //        var textPlace = listdata.Place;
        //        var textSession = listdata.Session;
        //        {
        //            if (Regex.IsMatch(textPlace, placeName) && Regex.IsMatch(textSession, session))
        //            {
        //                dgv1.Rows.Add();
        //                dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
        //                dgv1.Rows[r].Cells[1].Value = p.EventDate;//
        //                dgv1.Rows[r].Cells[2].Value = p.Venue;//
        //                dgv1.Rows[r].Cells[3].Value = p.Title;//
        //                dgv1.Rows[r].Cells[4].Value = p.Theme;//
        //                dgv1.Rows[r].Cells[5].Value = p.SavePathMain;//
        //                dgv1.Rows[r].Cells[6].Value = p.SavePathSub;//
        //                dgv1.Rows[r].Cells[7].Value = p.Reserve;//
        //                dgv1.Rows[r].Cells[8].Value = listdata.Place;
        //                dgv1.Rows[r].Cells[9].Value = listdata.Session;
        //                dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
        //                dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
        //                dgv1.Rows[r].Cells[12].Value = listdata.Start;
        //                dgv1.Rows[r].Cells[13].Value = listdata.End;
        //                dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

        //                ////申送りremarksの表示
        //                var remarksFilePath = listdata.Open1 + "/_remarks.txt";
        //                if (File.Exists(remarksFilePath))
        //                {
        //                    var txt = File.ReadAllText(remarksFilePath);
        //                    dgv1.Rows[r].Cells[15].Value = txt;
        //                }
        //                else
        //                {
        //                    dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
        //                }
        //                dgv1.Rows[r].Cells[16].Value = listdata.Open1;
        //                dgv1.Rows[r].Cells[17].Value = listdata.Open2;
        //                r++;
        //            }
        //        }
        //    }
        //}
        /// 
        //レイアウト②を使用
        //データグリッドビューの表示　デザイン 初期画面
        //public void ShowDgv(DataGridView dgv1)
        //{
        //    dgv1.Rows.Clear();
        //    //行のデフォルトの高さと幅
        //    ShowSelectDgvLayout(dgv1);
        //    var p = speakers.GetListData;
        //    int r = 0;
        //    List<EventInfo_dgvs> listdatas = p.eDgvList;
        //    foreach (var listdata in listdatas)
        //    {
        //        var text = listdata.Place;
        //        if (Regex.IsMatch(text, ""))
        //        {
        //            dgv1.Rows.Add();
        //            dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
        //            dgv1.Rows[r].Cells[1].Value = p.EventDate;//
        //            dgv1.Rows[r].Cells[2].Value = p.Venue;//
        //            dgv1.Rows[r].Cells[3].Value = p.Title;//
        //            dgv1.Rows[r].Cells[4].Value = p.Theme;//
        //            dgv1.Rows[r].Cells[5].Value = p.SavePathMain;//
        //            dgv1.Rows[r].Cells[6].Value = p.SavePathSub;//
        //            dgv1.Rows[r].Cells[7].Value = p.Reserve;//
        //            dgv1.Rows[r].Cells[8].Value = listdata.Place;
        //            dgv1.Rows[r].Cells[9].Value = listdata.Session;
        //            dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
        //            dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
        //            dgv1.Rows[r].Cells[12].Value = listdata.Start;
        //            dgv1.Rows[r].Cells[13].Value = listdata.End;
        //            dgv1.Rows[r].Cells[14].Value = listdata.SpeakerTitle;

        //            //申送りremarksの表示
        //            var remarksFilePath = listdata.Open1 + "/_remarks.txt";
        //            if (File.Exists(remarksFilePath))
        //            {
        //                var txt = File.ReadAllText(remarksFilePath);
        //                dgv1.Rows[r].Cells[15].Value = txt;
        //            }
        //            else
        //            {
        //                dgv1.Rows[r].Cells[15].Value = listdata.Remarks;
        //            }
        //            dgv1.Rows[r].Cells[16].Value = listdata.Open1;
        //            dgv1.Rows[r].Cells[17].Value = listdata.Open2;
        //            r++;
        //        }
        //    }
        //}
        /// 
        //レイアウト③を使用
        //全会場アイコン一覧
        //public void ShowIconDgv(DataGridView dgv1)
        //{
        //    dgv1.Rows.Clear();
        //    ////ヘッダー表示
        //    //dgv1.ColumnHeadersVisible = true;
        //    //行のデフォルトの高さと幅
        //    ShowIconDgvLayout(dgv1);
        //    var p = speakers.GetListData;
        //    int r = 0;
        //    List<EventInfo_dgvs> listdatas = p.eDgvList;
        //    foreach (var listdata in listdatas)
        //    {
        //        var text = listdata.Place;
        //        if (Regex.IsMatch(text, ""))
        //        {
        //            dgv1.Rows.Add();
        //            dgv1.Rows[r].Cells[0].Value = listdata.RegNum;
        //            dgv1.Rows[r].Cells[1].Value = listdata.Place;
        //            dgv1.Rows[r].Cells[2].Value = listdata.Session;
        //            dgv1.Rows[r].Cells[10].Value = listdata.SpeakerId;
        //            dgv1.Rows[r].Cells[11].Value = listdata.Speaker;
        //            dgv1.Rows[r].Cells[16].Value = listdata.Open1;
        //            dgv1.Rows[r].Cells[17].Value = listdata.Open2;
        //            dgv1.Rows[r].Cells[18].Value = listdata.Pc;
        //            dgv1.Rows[r].Cells[19].Value = listdata.Audio;
        //            dgv1.Rows[r].Cells[20].Value = listdata.Video;
        //            dgv1.Rows[r].Cells[21].Value = listdata.Request;
        //            dgv1.Rows[r].Cells[22].Value = listdata.Fix;
        //            dgv1.Rows[r].Cells[23].Value = listdata.PresenterTool;
        //            dgv1.Rows[r].Cells[24].Value = listdata.PcPodium;
        //            dgv1.Rows[r].Cells[25].Value = listdata.PowerPoint2003;
        //            dgv1.Rows[r].Cells[26].Value = listdata.PowerPoint2007;
        //            dgv1.Rows[r].Cells[27].Value = listdata.PowerPoint2010;
        //            dgv1.Rows[r].Cells[28].Value = listdata.PowerPoint2013;
        //            dgv1.Rows[r].Cells[29].Value = listdata.PowerPoint2016;
        //            dgv1.Rows[r].Cells[30].Value = listdata.PowerPoint2019;
        //            r++;
        //            ////////フォルダ内のファイルリストの配列とデータグリッドのヘッダが一致すればデータグリッドに反映させる/////
        //            ////現在フォルダ内にあるファイルを配列にする
        //            //var filePath = listdata.Open1;
        //            //var iconArray = GetFileNameMainArray(filePath);
        //            //for (int i = 0; i < 8; i++)
        //            //{
        //            //    if (iconArray.Contains(dgvHeaderLblArray[i]))
        //            //    {
        //            //        dgv1.Rows[r].Cells[18].Value = listdata.Pc;
        //            //    }
        //            //}

        //        }
        //    }

        //}

        //レイアウト③
        //全会場アイコン一覧レイアウト(下記とセット)
        //public void ShowIconDgvLayout(DataGridView dgv1)
        //{
        //    //フォント指定
        //    dgv1.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 10, FontStyle.Regular);
        //    //行のデフォルトの高さ
        //    dgv1.RowTemplate.Height = 50;
        //    dgv1.Columns[0].Width = 38;
        //    dgv1.Columns[1].Width = 0;
        //    dgv1.Columns[2].Width = 0;
        //    dgv1.Columns[3].Width = 0;
        //    dgv1.Columns[4].Width = 0;
        //    dgv1.Columns[5].Width = 0;
        //    dgv1.Columns[6].Width = 0;
        //    dgv1.Columns[7].Width = 0;
        //    dgv1.Columns[8].Width = 0;
        //    dgv1.Columns[9].Width = 0;
        //    dgv1.Columns[10].Width = 55;
        //    dgv1.Columns[11].Width = 100;
        //    dgv1.Columns[12].Width = 0;
        //    dgv1.Columns[13].Width = 0;
        //    dgv1.Columns[14].Width = 0;
        //    dgv1.Columns[15].Width = 0;
        //    dgv1.Columns[16].Width = 0;
        //    dgv1.Columns[17].Width = 0;
        //    dgv1.Columns[18].Width = 73;
        //    dgv1.Columns[19].Width = 71;
        //    dgv1.Columns[20].Width = 71;
        //    dgv1.Columns[21].Width = 71;
        //    dgv1.Columns[22].Width = 71;
        //    dgv1.Columns[23].Width = 89;
        //    dgv1.Columns[24].Width = 81;
        //    dgv1.Columns[25].Width = 113;
        //    dgv1.Columns[26].Width = 0;
        //    dgv1.Columns[27].Width = 0;
        //    dgv1.Columns[28].Width = 0;
        //    dgv1.Columns[29].Width = 0;
        //    dgv1.Columns[30].Width = 0;

        //    //テキストをセンターに配置
        //    dgv1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv1.Columns[25].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    //列の表示、非表示
        //    dgv1.Columns[0].Visible = true;
        //    dgv1.Columns[1].Visible = true;
        //    dgv1.Columns[2].Visible = true;
        //    dgv1.Columns[3].Visible = false;
        //    dgv1.Columns[4].Visible = false;
        //    dgv1.Columns[5].Visible = false;
        //    dgv1.Columns[6].Visible = false;
        //    dgv1.Columns[7].Visible = false;
        //    dgv1.Columns[8].Visible = false;
        //    dgv1.Columns[9].Visible = false;
        //    dgv1.Columns[10].Visible = true;
        //    dgv1.Columns[11].Visible = true;
        //    dgv1.Columns[12].Visible = false;
        //    dgv1.Columns[13].Visible = false;
        //    dgv1.Columns[14].Visible = false;
        //    dgv1.Columns[15].Visible = false;
        //    dgv1.Columns[16].Visible = true;
        //    dgv1.Columns[17].Visible = true;
        //    dgv1.Columns[18].Visible = true;
        //    dgv1.Columns[19].Visible = true;
        //    dgv1.Columns[20].Visible = true;
        //    dgv1.Columns[21].Visible = true;
        //    dgv1.Columns[22].Visible = true;
        //    dgv1.Columns[23].Visible = true;
        //    dgv1.Columns[24].Visible = true;
        //    dgv1.Columns[25].Visible = true;
        //    dgv1.Columns[26].Visible = false;
        //    dgv1.Columns[27].Visible = false;
        //    dgv1.Columns[28].Visible = false;
        //    dgv1.Columns[29].Visible = false;
        //    dgv1.Columns[30].Visible = false;

        //    dgv1.Columns[25].DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
        //}

        /// 
        //レイアウト②
        //データグリッドビューの7行のデザイン(下記とセット)
        //public void ShowSelectDgvLayout(DataGridView dgv1)
        //{
        //    dgv1.ColumnHeadersVisible = false;
        //    dgv1.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 10, FontStyle.Regular);
        //    //行のデフォルトの高さ
        //    dgv1.RowTemplate.Height = 50;
        //    dgv1.Columns[0].Width = 40;
        //    dgv1.Columns[1].Width = 0;
        //    dgv1.Columns[2].Width = 0;
        //    dgv1.Columns[3].Width = 0;
        //    dgv1.Columns[4].Width = 0;
        //    dgv1.Columns[5].Width = 0;
        //    dgv1.Columns[6].Width = 0;
        //    dgv1.Columns[7].Width = 0;
        //    dgv1.Columns[8].Width = 0;
        //    dgv1.Columns[9].Width = 0;
        //    dgv1.Columns[10].Width = 70;
        //    dgv1.Columns[11].Width = 100;
        //    dgv1.Columns[12].Width = 50;
        //    dgv1.Columns[13].Width = 50;
        //    dgv1.Columns[14].Width = 300;
        //    dgv1.Columns[15].Width = 800;
        //    dgv1.Columns[16].Width = 0;
        //    dgv1.Columns[17].Width = 0;
        //    dgv1.Columns[18].Width = 0;
        //    dgv1.Columns[19].Width = 0;
        //    dgv1.Columns[20].Width = 0;
        //    dgv1.Columns[21].Width = 0;
        //    dgv1.Columns[22].Width = 0;
        //    dgv1.Columns[23].Width = 0;
        //    dgv1.Columns[24].Width = 0;
        //    dgv1.Columns[25].Width = 0;
        //    dgv1.Columns[26].Width = 0;
        //    dgv1.Columns[27].Width = 0;
        //    dgv1.Columns[28].Width = 0;
        //    dgv1.Columns[29].Width = 0;
        //    dgv1.Columns[30].Width = 0;


        //    dgv1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    dgv1.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        //    dgv1.Columns[0].Visible = true;
        //    dgv1.Columns[1].Visible = false;
        //    dgv1.Columns[2].Visible = false;
        //    dgv1.Columns[3].Visible = false;
        //    dgv1.Columns[4].Visible = false;
        //    dgv1.Columns[5].Visible = false;
        //    dgv1.Columns[6].Visible = false;
        //    dgv1.Columns[7].Visible = false;
        //    dgv1.Columns[8].Visible = true;
        //    dgv1.Columns[9].Visible = true;
        //    dgv1.Columns[10].Visible = true;
        //    dgv1.Columns[11].Visible = true;
        //    dgv1.Columns[12].Visible = true;
        //    dgv1.Columns[13].Visible = true;
        //    dgv1.Columns[14].Visible = true;
        //    dgv1.Columns[15].Visible = true;
        //    dgv1.Columns[16].Visible = true;
        //    dgv1.Columns[17].Visible = true;
        //    dgv1.Columns[18].Visible = false;
        //    dgv1.Columns[19].Visible = false;
        //    dgv1.Columns[20].Visible = false;
        //    dgv1.Columns[21].Visible = false;
        //    dgv1.Columns[22].Visible = false;
        //    dgv1.Columns[23].Visible = false;
        //    dgv1.Columns[24].Visible = false;
        //    dgv1.Columns[25].Visible = false;
        //    dgv1.Columns[26].Visible = false;
        //    dgv1.Columns[27].Visible = false;
        //    dgv1.Columns[28].Visible = false;
        //    dgv1.Columns[29].Visible = false;
        //    dgv1.Columns[30].Visible = false;
        //}
        /// 


    }
}
