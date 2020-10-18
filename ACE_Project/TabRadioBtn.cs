using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public class TabRadioBtn :TabRadioBtnBase
    {
        /*
         * AutoSize はプロパティが設定できなかったので、ビルドしてから個々に設定する
         * ファームに設置してから”会場一覧”ボタンにchekedを設定しても起動時に選択されない
         * ので、これも”会場一覧”ボタンのイメージ画像だけchecked時の画像に設定しています。
         */
        public TabRadioBtn()
        {
            //AutoSize = false;
            Image = Properties.Resources.glayFlame; //初期の画像
            Height = 44;
            Width = 129;
        }
        public void TabRadioBtnAction(RadioButton rbtn)
        {
            if (rbtn.Checked)
                rbtn.Image = Properties.Resources.whiteFlame;
            else
                rbtn.Image = Properties.Resources.glayFlame;
        }
    }
}
