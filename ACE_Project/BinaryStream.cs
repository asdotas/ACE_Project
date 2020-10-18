using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Edit
{
    static public class BinaryStream
    {
        /// <summary>
        /// オブジェクトの内容をファイルから読み込み復元する
        /// </summary>
        /// <param name="path">読み込むファイル名</param>
        /// <returns>復元されたオブジェクト</returns>
        public static object LoadFromBinaryFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            object obj = f.Deserialize(fs);
            fs.Close();
            return obj;
        }

        /// <summary>
        /// オブジェクトの内容をファイルに保存する
        /// </summary>
        /// <param name="obj">保存するオブジェクト</param>
        /// <param name="path">保存先のファイル名</param>
        public static void SaveToBinaryFile(object obj, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj);
            fs.Close();
        }
    }
}
