using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE_Project
{
    public abstract class EventInfoBase
    {
        public EventInfoBase()
        {
            EDgvList = new List<EventInfo_dgvs>();
        }
        //各演者の現在の項目数
        private int Item31 {get;} = 31;
        public  int Get31() { return 31; }

        //1 日程
        public string EventDate { get; set; } = "---";
        //2 開催会場
        public string Venue { get; set; } = "---";
        //3 会名
        public string Title { get; set; } = "---";
        //4 テーマ
        public string Theme { get; set; } = "---";
        //5 保存先メイン
        public string SavePathMain { get; set; }
        //6 保存先サブ
        public string SavePathSub { get; set; }
        //7 予備
        public string Reserve { get; set; } = "---";

        public List<EventInfo_dgvs> EDgvList { get; set; }
    }
    /// <summary>
    /// 演者インフォメーション
    /// </summary>
    [Serializable]
    public class EventInfo_dgvs
    {
        //0 登録番号
        public string RegNum { get; set; } = "---";
        //8 会場（施設の部屋名）
        public string Place { get; set; } = "---";
        //9 セッション
        public string Session { get; set; } = "---";
        //10 演者ID
        public string SpeakerId { get; set; } = "---";
        //11 演者
        public string Speaker { get; set; } = "---";
        //12 開始時間
        public string Start { get; set; } = "---";
        //13 終了時間
        public string End { get; set; } = "---";
        //14 演題名
        public string SpeakerTitle { get; set; } = "---";
        //15 備考
        public string Remarks { get; set; } = "---";

        /// <summary>
        /// 演者フォルダーのアイコン一覧
        /// </summary>
        //16 演者フォルダーパス１
        public string Open1 { get; set; } = "---";
        //17 演者フォルダーパス１
        public string Open2 { get; set; } = "---";
        //18 19 PC持込の有無
        public string Pc { get; set; } = "---";
        //20 音声の有無
        public string Audio { get; set; } = "---";
        //21 動画の有無
        public string Video { get; set; } = "---";
        //22 申送りの有無
        public string Request { get; set; } = "---";
        //23 修正の有無
        public string Fix { get; set; } = "---";
        //24 発表者ツールの有無
        public string PresenterTool { get; set; } = "---";
        //25 PCを演台上に設置
        public string PcPodium { get; set; } = "---";
        //26 パワーポイント2003
        public string PowerPoint { get; set; } = "---";
        //27 受付済
        public string Done { get; set; } = "---";
        //28 パワーポイント2010
        public string PowerPoint2010 { get; set; } = "---";
        //29 パワーポイント2013
        public string PowerPoint2013 { get; set; } = "---";
        //30 パワーポイント2016
        public string PowerPoint2016 { get; set; } = "---";
        ////30 パワーポイント2019
        public string PowerPoint2019 { get; set; } = "---";
    }
}
