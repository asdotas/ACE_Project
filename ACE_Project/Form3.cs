using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management; //tree
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class MakeDirInfoForm : ACE_Project.InfoFormBase
    {
        ReadDatas rd;
        public MakeDirInfoForm()
        {
            InitializeComponent();
        }
        public MakeDirInfoForm(OpenFileDialog ofd1)
        {
            InitializeComponent();
            ShowTreeView(ofd1.FileName);
        }

        private void MakeDirInfoForm_Load(object sender, EventArgs e)
        {
            // フォントを変更する
            Font = new Font("UD デジタル 教科書体 NK-R", 10, FontStyle.Regular);
        }

        public void ShowLabel(string filePath)
        {
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            SavePathMainLbl.Text = p.SavePathMain;
            SavePathSubLbl.Text = p.SavePathSub;
        }

        //Tree表示
        private void ShowTreeView(string filePath)
        {
            treeView1.Nodes.Clear();
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var placeList = GetPlaceList(filePath);
            var sessionList = GetSessionList(filePath);

            //日付を2020/02/18 から2020年2月18日に変換
            var ex = new Expression();
            var eventDate = ex.GetLongDate(p.EventDate);

            //ルート（日本感染症学会）からPlace(大ホール、小ホール)までのツリービュー
            TreeNode rootNode = new TreeNode();
            rootNode.Text = eventDate + "_" + p.Title;
            treeView1.Nodes.Add(rootNode);

            TreeNode[] childNode = new TreeNode[placeList.Count];
            for (int i = 0; i < placeList.Count; i++)
            {
                childNode[i] = new TreeNode();
                childNode[i].Text = placeList[i];
                rootNode.Nodes.Add(childNode[i]);
            }

            //Place(大ホール、小ホール)からセッション部分までのツリービュー
            var sessionCountList = GetSessionCountList(filePath);
            var placeCountList = GetPlaceCountList(filePath);
            TreeNode[] gChildNode = new TreeNode[sessionList.Count];
            int r = 0;
            for (int i = 0; i < placeList.Count; i++)
            {
                for (int j = 0; j < placeCountList[i] / sessionCountList[j]; j++)
                {
                    gChildNode[r] = new TreeNode();
                    gChildNode[r].Text = sessionList[r];
                    childNode[i].Nodes.Add(gChildNode[r]);
                    r++;
                }
            }

            //セッション部分から演者までのツリービュー
            var speakerList = GetSpeakerList(filePath);
            TreeNode[] ggChildNode = new TreeNode[speakerList.Count];
            int s = 0;
            for (int i = 0; i < sessionList.Count; i++)
            {
                for (int j = 0; j < sessionCountList[j]; j++)
                {
                    ggChildNode[s] = new TreeNode();
                    ggChildNode[s].Text = speakerList[s];
                    gChildNode[i].Nodes.Add(ggChildNode[s]);
                    s++;
                }
            }

            //TreeviewをExpandAllで展開すると展開した最下層を表示するので、一度高さをマックスにしてから展開し、もとの大きさに調整している。
            treeView1.BeginUpdate();
            var heightSave = treeView1.Height;
            treeView1.Height = Int32.MaxValue;
            treeView1.ExpandAll();
            treeView1.Height = heightSave;
            treeView1.EndUpdate();

            NodeNameLbl.Text = eventDate + "_" + p.Title;
            NodePathLbl.Text = eventDate + "_" + p.Title;
        }

        //PlaceList作成
        public List<string> GetPlaceList(string filePath)
        {
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var placeList = new List<string>() { p.EDgvList[0].Place };
            var r = 0;
            var placeName = "";
            foreach (var listdata in listdatas)
            {
                if (!Regex.IsMatch(listdata.Place, placeName))
                {
                    placeList.Add(listdata.Place);
                }
                placeName = listdata.Place;
                r++;
            }
            return placeList;
        }
        //sessionList作成
        private List<string> GetSessionList(string filePath)
        {
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var sessionList = new List<string>() { p.EDgvList[0].Session };
            var r = 0;
            var sessionName = "";
            foreach (var listdata in listdatas)
            {
                if (!Regex.IsMatch(listdata.Session, sessionName))
                {
                    sessionList.Add(listdata.Session);
                }
                sessionName = listdata.Session;
                r++;
            }
            return sessionList;
        }
        //speakerList作成
        private List<string> GetSpeakerList(string filePath)
        {
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var speakerList = new List<string>() { p.EDgvList[0].SpeakerId + "_" + p.EDgvList[0].Speaker };
            var r = 0;
            var speakerName = "";
            foreach (var listdata in listdatas)
            {
                if (!Regex.IsMatch(listdata.Speaker, speakerName))
                {
                    speakerList.Add(listdata.SpeakerId + "_" + listdata.Speaker);
                }
                speakerName = listdata.SpeakerId + "_" + listdata.Speaker;
                r++;
            }
            return speakerList;
        }
        //placeListのそれぞれの回数
        private List<int> GetPlaceCountList(string filePath)
        {
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            var placeList = GetPlaceList(filePath);
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var placeCountList = new List<int>();
            var r = 0;
            var count = 0;
            foreach (var item in placeList)
            {
                while (r <= listdatas.Count - 1)
                {
                    if (listdatas[r].Place == item)
                    {
                        r++;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                placeCountList.Add(count);
                count = 0;
            }
            return placeCountList;
        }
        //sessionListのそれぞれの回数
        private List<int> GetSessionCountList(string filePath)
        {
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            var sessionList = GetSessionList(filePath);
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var sessionCountList = new List<int>();
            var count = 0;
            var r = 0;
            foreach (var item in sessionList)
            {
                while (r <= listdatas.Count - 1)
                {
                    if (listdatas[r].Session == item)
                    {
                        r++;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                sessionCountList.Add(count);
                count = 0;
            }
            return sessionCountList;
        }

        //ツリービューをマウスクリックした時の情報処理
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            string s, name;
            treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y); //マウス座標から選択位置のノードを取得
            if (treeView1.SelectedNode != null)  //ノード上でクリックされたか？
            {
                s = treeView1.SelectedNode.FullPath; //ノードパスの取得
                name = treeView1.SelectedNode.Text; //ノード名の取得
                NodePathLbl.Text = s;
                NodeNameLbl.Text = name;
            }
        }

        //フォルダ作成するためのCSVファイル作成
        private void MakeFolderCsv(string filePath, string makeDirFilePath)
        {
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            var placeLIst = GetPlaceList(filePath);
            var sessionList = GetSessionList(filePath);
            var speakerList = GetSpeakerList(filePath);

            //日付を2020/02/18 から2020年2月18日に変換
            var dt = new DateTime();
            string strDay = p.EventDate;
            dt = DateTime.Parse(strDay);
            var eventDate = dt.ToLongDateString();

            using (StreamWriter sw = new StreamWriter(makeDirFilePath))
            {
                foreach (var item in listdatas)
                {
                    var lines = "";
                    lines = eventDate + "_" + p.Title + "," +
                           item.Place + "," +
                           item.Session + "," +
                           item.SpeakerId + "_" + item.Speaker;
                    sw.WriteLine(lines);
                }
            }
        }
        //csvファイルからフォルダ作成する
        private void Csv2MakeFoldr(string savePathMain, string savePathSub, string makeDirFilePath)
        {
            string[] files = File.ReadAllLines(makeDirFilePath);
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i];
                StreamReader sr = new StreamReader(makeDirFilePath);
                var lines = sr.ReadToEnd();
                string sConma = lines;
                string[] Paths = sConma.Split('\n');

                for (int j = 0; j < Paths.Length - 1; j++)
                {
                    Paths[j] = Paths[j].Trim();
                    while (Paths[j][Paths[j].Length - 1] == ',')
                    {
                        Paths[j] = Paths[j].Remove(Paths[j].Length - 1, 1);
                    }
                    Paths[j] = Paths[j].Replace(",", "/");
                    var selectPath1 = savePathMain;
                    var selectPath2 = savePathSub;
                    var filePath1 = selectPath1 + '/' + Paths[j];
                    var filePath2 = selectPath2 + '/' + Paths[j];
                    Directory.CreateDirectory(filePath1);
                    Directory.CreateDirectory(filePath2);
                }
                sr.Close();
            }
        }

        //フォルダ作成ボタン
        private void makeFolderBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("しばらくお待ちください。",
                "フォルダ作成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
               );
            //rd = new ReadDatas("import3.csv");
            rd = new ReadDatas(@"./temp/temp.csv");
            var p = rd.GetListData;

            //MakeFolderCsv("import3.csv", "./temp/makeDir.csv");
            MakeFolderCsv(@"./temp/temp.csv", "./temp/makeDir.csv");
            Csv2MakeFoldr(p.SavePathMain, p.SavePathSub, "./temp/makeDir.csv");

            MessageBox.Show("  " + p.SavePathMain + "  " + "と" + "  " + p.SavePathSub + "  " + "にファルダが作成されました。",
                            "フォルダ作成",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk
                           );
        }
        //閉じる
        private void cancellBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ファルダ作成時のcsvファイルからopenの配列を作成 
        private string[] GetOpenArray(string makeDirFilePath, string savePath)
        {
            string[] files = File.ReadAllLines(makeDirFilePath);
            var openArray = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                StreamReader sr = new StreamReader(makeDirFilePath);
                var lines = sr.ReadToEnd();
                //最後の一文字 ”,” を削除
                lines = lines.TrimEnd();
                string sConma = lines;
                sConma = sConma.Replace("\r", null);
                sConma = sConma.Replace(',', '/');
                string[] Paths = sConma.Split('\n');
                openArray[i] = savePath + '/' + Paths[i];
            }
            return openArray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //csvOverwriteSave("import3.csv", "./temp/makeDir.csv");
            csvOverwriteSave(@"./temp/temp.csv", "./temp/makeDir.csv");
        }

        //作成した演者の保存先フォルダ（open1　と open2）のパスをcsvファイルに上書き保存する。
        private void csvOverwriteSave(string filePath, string makeDirFilePath)
        {
            rd = new ReadDatas(filePath);
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;
            //ファルダ作成ファイルをＣＳＶ形式から配列化
            var open1Array = GetOpenArray(makeDirFilePath, p.SavePathMain);
            var open2Array = GetOpenArray(makeDirFilePath, p.SavePathSub);

            //ファイルを読み込みで開く
            StreamReader sr = new StreamReader(filePath);
            //一時ファイルを書き込みで開く
            //StreamWriter sw = new StreamWriter("import4.csv", false, Encoding.UTF8);
            StreamWriter sw = new StreamWriter(@"./temp/temp.csv", true, Encoding.UTF8);
            var r = 0;
            //内容を一行ずつ読み込む
            for (var i = 0; i < listdatas.Count + 100; i++)
            {
                //一行読み込む
                string line = sr.ReadLine();
                if (line.Contains("open1"))
                {
                    line = line.Replace("open1", open1Array[r]);
                }
                if (line.Contains("open2"))
                {
                    line = line.Replace("open2", open2Array[r]);
                    r++;
                }
                //ファイルに書き込む
                sw.WriteLine(line);
            }
            //閉じる
            sr.Close();
            sw.Close();
        }
    }
}
