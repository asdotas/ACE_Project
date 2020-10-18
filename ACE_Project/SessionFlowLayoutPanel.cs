using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public partial class SessionFlowLayoutPanel : CheckDeskForm
    {
        //ReadDatas speakers;
        public SessionFlowLayoutPanel()
        {
            this.Dock = DockStyle.Top;
            this.AutoScroll = true;

        }
        private BtnFlat[] btnFlats;

        ////セッションボタンを作成
        //public void AddSessionBtn2(FlowLayoutPanel flowLayoutPanel1, int num, List<string> _list)
        //{
        //    List<string> list = _list;
        //    //各会場のリスト（place）大ホール　小ホール等・・・
        //    var placelist = GetPlaceList(_list);

        //    //各会場（place）の個々の個数のリスト 大ホール　20個　小ホール　20個　・・・
        //    var placeCountList = GetPlaceCountList(placelist, _list);

        //    //sessionの種類の配列 (index, item)出力　大ホール　（午前１　午前　午後２　午後）・・・
        //    var sessionBtnArray = new string[placelist.Count];
        //    var str = "";
        //    int _j = 0;
        //    var sCount = 0;
        //    for (int i = 0; i < placelist.Count; i++)
        //    {
        //        sCount += 31 * placeCountList[i];
        //        for (int j = _j; j < sCount; j += 31)
        //        {
        //            if (str != list[9 + j]) { sessionBtnArray[i] += list[9 + j] + ","; }
        //            str = list[9 + j];
        //            _j += 31;
        //        }
        //    }
        //    //ボタン作成
        //    var sArray = sessionBtnArray[num].Split(','); //0 - 5
        //    this.btnFlats = new BtnFlat[sArray.Length - 1];
        //    this.SuspendLayout();
        //    for (int i = 0; i < btnFlats.Length; i++)
        //    {
        //        this.btnFlats[i] = new BtnFlat();
        //        this.btnFlats[i].Name = "btnFlat" + i.ToString();
        //        this.btnFlats[i].Text = sArray[i];
        //        this.btnFlats[i].Click += new EventHandler(this.BtnFlat_Clik);
        //    }
        //    flowLayoutPanel1.Controls.AddRange(this.btnFlats);
        //    this.ResumeLayout(false);
        //}

        //各会場のリスト（place）大ホール　小ホール等・・・
        public List<string> GetPlaceList(List<string> _list)
        {
            var placelist = new List<string>();
            var placeStr = "";
            for (int i = 0; i < _list.Count; i += 31)
            {
                if (placeStr != _list[8 + i]) placelist.Add(_list[8 + i]);
                placeStr = _list[8 + i];
            }
            return placelist;
        }
        //各会場（place）の個々の個数のリスト 大ホール　20個　小ホール　20個　・・・
        public List<int> GetPlaceCountList(List<string> placelist, List<string> _list)
        {
            var placeCountList = new List<int>();
            for (int i = 0; i < placelist.Count; i++)
            {
                var pCount = _list.Count(x => x == placelist[i]);
                placeCountList.Add(pCount);
            }
            return placeCountList;
        }

        //各会場の講演者数
        public int GetPlaceCount(List<string> _list, int num)
        {
            List<string> list = _list;
            var placelist = GetPlaceList(list);
            var count = list.Count(x => x == placelist[num]);
            return count;
        }
        //sessionAllボタンの表示
        public void SetsessionAllBtn(FlowLayoutPanel flowLayoutPanel1, string place)
        {
            BtnFlat btnf0 = new BtnFlat();
            flowLayoutPanel1.Controls.Add(btnf0);

            btnf0.Width = 129;

            //セッションボタンの先頭を会場名にする
            btnf0.Text = place;


            // btnf0.Name = "AllSessionBtn0";
        }

        public void ClearSessyonBtn(FlowLayoutPanel flowLayoutPanel)
        {
            for (int i = flowLayoutPanel.Controls.Count - 1; 0 <= i; i--)
            {
                flowLayoutPanel.Controls[i].Dispose();
            }
        }

        ////セッションボタン作成ボタン flowLayoutPanel1に第2引数の名前のボタンを追加(flowLayoutPanel1, placeBtnの番号, list)
        //public void SetSessyonBtn(int num, FlowLayoutPanel flowLayoutPanel)
        //{
        //    Dgv dgv = new Dgv();
        //    var sflp = new SessionFlowLayoutPanel();
        //    List<string> list = dgv.GetEventList();
        //    sflp.AddSessionBtn2(flowLayoutPanel, num, list);
        //}

    }
}
