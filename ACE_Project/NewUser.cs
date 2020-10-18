using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE_Project
{
    [Serializable]
    public class NewUser
    {
        //1 新規ユーザー名
        public string NewUserName { get; set; } = "---";
        //2 新規パスワード
        public string NewPassword { get; set; } = "---";
    }
}
