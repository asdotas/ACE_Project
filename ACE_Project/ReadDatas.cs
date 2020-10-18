using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE_Project
{
    class ReadDatas
    {
        private readonly EventInfo _names;

        //コンストラクタ
        public ReadDatas(string filePath)
        {
            _names = ReadSpeakerLists(filePath);
        }
        public EventInfo GetListData => _names;

        //CSVをListに変換(tb)
        private static EventInfo ReadSpeakerLists(string filePath)
        {
            EventInfo p = new EventInfo();
            using (var sr = new StreamReader(filePath))
            {
                //データは100行目からなので飛ばす
                for (int i = 0; i < 99; i++) _ = sr.ReadLine();
                //行で読み込みカンマで区切る
                var lines = sr.ReadLine().Trim(null).Split(',');
                //１、登録番号　２、日程　３、開催会場　４、会名　５、テーマ　６、保存先メイン　７、保存先サブ　８、予備
                //p.RegNum = lines[0].ToString();
                p.EventDate = lines[1].ToString();
                p.Venue = lines[2].ToString();
                p.Title = lines[3].ToString();
                p.Theme = lines[4].ToString();
                p.SavePathMain = lines[5].ToString();
                p.SavePathSub = lines[6].ToString();
                p.Reserve = lines[7].ToString();
                while (sr.Peek() > -1)
                {
                    string[] s = sr.ReadLine().Trim(null).Split(',');
                    EventInfo_dgvs pd = new EventInfo_dgvs
                    {
                        RegNum = s[0],
                        Place = s[8],
                        Session = s[9],
                        SpeakerId = s[10],
                        Speaker = s[11],
                        Start = s[12],
                        End = s[13],
                        SpeakerTitle = s[14],
                        Remarks = s[15],
                        Open1 = s[16],
                        Open2 = s[17],
                        Pc = s[18],
                        Audio = s[19],
                        Video = s[20],
                        Request = s[21],
                        Fix = s[22],
                        PresenterTool = s[23],
                        PcPodium = s[24],
                        PowerPoint = s[25],
                        Done = s[26],
                        PowerPoint2010 = s[27],
                        PowerPoint2013 = s[28],
                        PowerPoint2016 = s[29],
                        PowerPoint2019 = s[30]
                    };
                    p.EDgvList.Add(pd);
                }
                return p;
            }
        }
    }
}
