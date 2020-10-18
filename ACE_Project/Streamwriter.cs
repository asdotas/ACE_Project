using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    static public class TextStream
    {
        //public static object TextReader(string fileName)
        //{
        //        using (StreamReader sr = new StreamReader(fileName))
        //        {
        //            string line;
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                return line;
        //            }
        //        }
            
        //}

        /// <summary>
        /// オブジェクトの内容をファイルに保存する
        /// </summary>
        /// <param name="obj">保存するオブジェクト</param>
        /// <param name="fileName">保存先のファイル名</param>
        public static void TextWriter(object obj, string fileName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(obj);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }
    }
}
