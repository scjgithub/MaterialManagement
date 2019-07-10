using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MaterialManagement
{
    class prints
    {
        public static void ToExcel(DataGridView dataGridView1, string path)
        {
            try
            {
                //没有数据的话就不往下执行  
                if (dataGridView1.Rows.Count == 0)
                    return;
                //实例化一个Excel.Application对象  
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                //让后台执行设置为不可见，为true的话会看到打开一个Excel，然后数据在往里写  


                //新增加一个工作簿，Workbook是直接保存，不会弹出保存对话框，加上Application会弹出保存对话框，值为false会报错  
                Workbook wkbook = excel.Application.Workbooks.Add(true);
                //生成Excel中列头名称  
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible == true)
                    {
                        excel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }

                }
                //把DataGridView当前页的数据保存在Excel中  
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    System.Windows.Forms.Application.DoEvents();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Columns[j].Visible == true)
                        {
                            if (dataGridView1[j, i].ValueType == typeof(string))
                            {
                                excel.Cells[i + 2, j + 1] = "'" + dataGridView1[j, i].Value.ToString();
                            }
                            else
                            {
                                excel.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                            }
                        }

                    }
                }

                //设置禁止弹出保存和覆盖的询问提示框  
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;

                //保存工作簿  
                //excel.Application.Workbooks.Add(true).Save();
                //保存excel文件  
                //excel.SaveWorkspace("C:\\img\\11.xls");
                wkbook.SaveAs(path);



                //确保Excel进程关闭  
                excel.Quit();
                excel = null;
                GC.Collect();//如果不使用这条语句会导致excel进程无法正常退出，使用后正常退出
                MessageBox.Show("文件已经成功导出！");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
            }

        }



#region 从数据库
        //public static void Export(string filePath, string sql)  //filePath为保存到本地磁盘的位置
        //{

        //    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        //    {
        //        StreamWriter sw = new StreamWriter(fs);


        //        string col_txt = "";
        //        string row_txt = "";
        //        DataTable dt = DataDBInfo.QueryDBInfo(sql);
        //        foreach (DataColumn item in dt.Columns)  // dt  为DataTable  循环写入列标题
        //        {
        //            col_txt += item.ToString() + ",";
        //        }
        //        col_txt = col_txt.Substring(0, col_txt.Length - 1);  //去掉最后多于的逗号
        //        sw.WriteLine(col_txt);//写入更改

        //        foreach (DataRow item in dt.Rows)//循环写入行数据
        //        {
        //            row_txt = "";//容易漏写，造成数据的重复写入
        //            for (int i = 0; i < dt.Columns.Count; i++)
        //            {
        //                row_txt += item[i].ToString() + ",";
        //            }
        //            row_txt = row_txt.Substring(0, row_txt.Length - 1); //去掉最后多于的逗号

        //            sw.WriteLine(row_txt);//写入更改
        //        }
        //        sw.Flush();   //此处必须有此操作
        //        sw.Close();
                
        //    }



        //}
        #endregion

    }
}
