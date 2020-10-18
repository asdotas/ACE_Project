using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE_Project
{
    public class Expression
    {
        //日付を2020/02/18 から2020年2月18日に変換
        public string GetLongDate(string date)
        {
            var dt = new DateTime();
            dt = DateTime.Parse(date);
            var eventDate = dt.ToLongDateString();

            return eventDate;
        }
        //フォルダ以下のファイルを配列化
        public String[] GetFilesArray(string filePath)
        {
            var filesArray = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
            return filesArray;
        }
        //フォルダ以下のファイルを配列内にドラッグされたファイルがあればFalse
        public bool isSaimFile(string filePath, string dragFilePath)
        {
            bool result = true;
            var filesArray = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
            foreach (var item in filesArray)
            {
                if (item == dragFilePath) result = false;
            }
            return result;
        }




        /// <summary>
        /// 未使用
        /// </summary>
        //モードレスフォーム　両方のformが生きてる
        public void ShowSpeakerInfoForm()
        {
            var f = new SpInfoForm();
            f.Show();
        }
        //モーダルフォーム　新しいformのみ生きてる
        public void ShowSpeakerInfoForm2()
        {
            var f = new SpInfoForm();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
