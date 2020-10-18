using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    /// <summary>
    /// イベントインフォメーション CSVファイルインポート用
    /// </summary>
    [Serializable]
    public class EventInfo : EventInfoBase
    {
        
        public EventInfo()
        {

        }

        public List<string> GetPlaceList(List<string> edgvlist)
        {
            var list = new List<string>();
            EventInfo ei = new EventInfo();
            for (int i = 0; i < 10; i++)
            {
                var item = ei.EDgvList[i].Place;
                if (!list.Contains(item)) list.Add(item);
            }
            return list;
        }
    }
}





