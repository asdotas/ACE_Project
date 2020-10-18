using Microsoft.VisualBasic.FileIO;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    


    public partial class LogDgvForm : Form
    {
        public LogDgvForm()
        {
            InitializeComponent();
        }
        private void LogDgvForm_Load(object sender, EventArgs e)
        {
        }

        public void ShowDgv(string logPathMain, string logPathSub)
        {
            logDgvMain.Rows.Clear();
            // フォントを変更する
            logDgvMain.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 8, FontStyle.Regular);
            logDgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 8, FontStyle.Regular);
            try
            {
                // 読み込みたいCSVファイルのパスを指定して開く
                using(var sr1 = new StreamReader(logPathMain))
                {
                    {
                        var r = 0;
                        // 末尾まで繰り返す
                        while (sr1.Peek() > -1)
                        {
                            logDgvMain.Rows.Add();
                            {
                                // CSVファイルの一行を読み込む
                                string line = sr1.ReadLine();
                                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                                string[] values = line.Split(',');


                                logDgvMain.Rows[r].Cells[0].Value = values[0];
                                logDgvMain.Rows[r].Cells[1].Value = values[1];
                                logDgvMain.Rows[r].Cells[2].Value = values[2];
                            }
                            r++;
                        }
                    }
                }

                logDgvSub.Rows.Clear();
                // フォントを変更する
                logDgvSub.DefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 8, FontStyle.Regular);
                logDgvSub.ColumnHeadersDefaultCellStyle.Font = new Font("UD デジタル 教科書体 NK-R", 8, FontStyle.Regular);
                // 読み込みたいCSVファイルのパスを指定して開く
                using (var sr2 = new StreamReader(logPathSub))
                {
                    {
                        var r = 0;
                        // 末尾まで繰り返す
                        while (sr2.Peek() > -1)
                        {
                            logDgvSub.Rows.Add();
                            {
                                // CSVファイルの一行を読み込む
                                string line = sr2.ReadLine();
                                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                                string[] values = line.Split(',');
                                logDgvSub.Rows[r].Cells[0].Value = values[0];
                                logDgvSub.Rows[r].Cells[1].Value = values[1];
                                logDgvSub.Rows[r].Cells[2].Value = values[2];
                            }
                            r++;
                        }
                    }
                }
                    

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}


