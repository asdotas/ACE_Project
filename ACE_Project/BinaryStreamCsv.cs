using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public class BinaryStreamCsv
    {
        /// <summary>
        /// 正規のフォーマットで現在DGV１で表示中のPlace別CSVファイルを保存する　sessionボタンのセッション別に表示させる為
        /// </summary>
        /// <param name="dgv1"></param>
        public void SaveNowDgvDefaultCsv(DataGridView dgv1)
        {
            var rd = new ReadDatas(@"./temp/temp.csv");
            var p = rd.GetListData;
            List<EventInfo_dgvs> listdatas = p.EDgvList;

            //File.Delete(@"./temp/nowdgv.csv");
            //１－９７行目にの通し番号を記入
            using (var sw = new StreamWriter(@"./temp/nowdgv.csv", false))
            {
                for (int i = 0; i < 97; i++)
                {
                    sw.WriteLine(i + 1 + ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
                }
            }
            //９８行目に　98 + 1～30までを記入
            using (var sw = new StreamWriter(@"./temp/nowdgv.csv", true))
            {
                var lines = "98";
                for (int i = 0; i < 30; i++)
                {
                    lines += "," + (i + 1);
                }
                sw.WriteLine(lines);
            }
            //９９行目に　項目名を記入
            using (var sw = new StreamWriter(@"./temp/nowdgv.csv", true))
            {
                var lines = "99";
                lines += "," + "日程" + "," + "開催会場" + "," + "会名" + "," + "テーマ" + "," + "保存先メイン" + "," + "保存先サブ" + "," + "予備" + "," + "会場名" + "," + "セッション" + "," + "演者ID" + "," + "演者名" + "," + "開始時間" + "," + "終了時間" + "," + "演    題    名" + "," + "備考・申し送り" + "," + "保存先メインパス" + "," + "保存先サブパス" + "," + "ＰＣ持込み" + "," + "音声あり" + "," + "映像あり" + "," + "申し送りあり" + "," + "修正" + "," + "発表者ツール" + "," + "演台上" + "," + "パワーポイント２００３" + "," + "パワーポイント２００７" + "," + "パワーポイント２０１０" + "," + "パワーポイント２０１３" + "," + "パワーポイント２０１６" + "," + "パワーポイント２０１９";
                sw.WriteLine(lines);
            }
            //１００行目に　データを記入
            using (var sw = new StreamWriter(@"./temp/nowdgv.csv", true))
            {
                var lines = "100";
                lines += "," + p.EventDate + "," + p.Venue + "," + p.Title + "," + p.Theme + "," + p.SavePathMain + "," + p.SavePathSub + "," + p.Reserve + ",,,,,,,,,,,,,,,,,,,,,,,";
                sw.WriteLine(lines);
            }
            //末尾加筆にならないよう、StreamWriter のコンストラクタの第二引数には false を指定
            using (var sw = new StreamWriter(@"./temp/nowdgv.csv", true))
            {
                for (int r = 0; r < dgv1.Rows.Count - 1; r++)
                {
                    var lines = "";

                    for (int c = 0; c < dgv1.Columns.Count -1; c++)
                    {
                        lines += dgv1.Rows[r].Cells[c].Value.ToString();
                        lines += ',';
                    }
                    sw.WriteLine(lines);
                }
            }
        }
    }
}
