using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    class prints
    {
        public static void Export(string filePath, string sql)  //filePath为保存到本地磁盘的位置
        {

            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);


                string col_txt = "";
                string row_txt = "";
                DataTable dt = DataDBInfo.QueryDBInfo(sql);
                foreach (DataColumn item in dt.Columns)  // dt  为DataTable  循环写入列标题
                {
                    col_txt += item.ToString() + ",";
                }
                col_txt = col_txt.Substring(0, col_txt.Length - 1);  //去掉最后多于的逗号
                sw.WriteLine(col_txt);//写入更改

                foreach (DataRow item in dt.Rows)//循环写入行数据
                {
                    row_txt = "";//容易漏写，造成数据的重复写入
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        row_txt += item[i].ToString() + ",";
                    }
                    row_txt = row_txt.Substring(0, row_txt.Length - 1); //去掉最后多于的逗号

                    sw.WriteLine(row_txt);//写入更改
                }
                sw.Flush();   //此处必须有此操作
            }



        }


    }
}
