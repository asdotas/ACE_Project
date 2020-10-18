using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE_Project
{
    public class DicSession :EventInfoBase
    {

        public Dictionary<string, string> GetDicSession(List<string> edgvlist)
        {
            var dic = new Dictionary<string, string>();
            EventInfo ei = new EventInfo();
            for (int i = 0; i < 10; i++)
            {

            }
            return dic;
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
