using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public abstract class TabRadioBtnBase :RadioButton 
    {
        public TabRadioBtnBase()
        {
            Appearance = System.Windows.Forms.Appearance.Button; //形状をラジオボタンから普通のボタンにする
            FlatAppearance.BorderSize = 0; //ボーダーの太さ
            FlatStyle = System.Windows.Forms.FlatStyle.Flat; //平面のボタン
            BackColor = System.Drawing.Color.Transparent;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Font = new Font("UD デジタル 教科書体 NK-R", 10, FontStyle.Regular);
        }
    }
}
