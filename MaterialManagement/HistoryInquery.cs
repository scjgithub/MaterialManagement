﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    public partial class HistoryInquery : Form
    {
        public HistoryInquery()
        {
            InitializeComponent();
        }

        string[] dbFields = { "barcode", "materialname", "specification", "specificationmodle", "inouttype", "operater" };
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string timeStart = this.dateTimeStart.Value.ToString("yyyy/MM/dd") + " 00:00:00";
            string timeEnd = this.dateTimeEnd.Value.ToString("yyyy/MM/dd") + " 23:59:59";

            string txt = txtQuery.Text;
            int itemIndex = cmbQuery.SelectedIndex;
            if (itemIndex < 0)
            {
                return;
            }

            //query string
            //SELECT * FROM history WHERE operatetime>='2018/03/21 00:00:00' AND operatetime<='2018/03/21 23:59:59' ORDER BY operatetime
            string queryString = "select * from history where operatetime>='" + timeStart + "' AND operatetime<='" + timeEnd + "'";
            if (txt.Length > 0)
            {
                queryString += " AND " + dbFields[itemIndex] + " like '%" + txt + "%'";
            }

            queryString += " ORDER BY operatetime";
            AddHistoryToList(queryString);
        }

        private void AddHistoryToList(string queryString)
        {
            //query DB data
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set dgvList
                if (dt.Rows.Count > 0)
                {
                    dgvOutList.Rows.Clear();

                    foreach (DataRow dr in dt.Rows)   ///遍历所有的行
                    {
                        int index = dgvOutList.Rows.Add();
                        dgvOutList.Rows[index].Cells[0].Value = dr[0].ToString();
                        dgvOutList.Rows[index].Cells[1].Value = dr[1].ToString();
                        dgvOutList.Rows[index].Cells[2].Value = dr[2].ToString();
                        dgvOutList.Rows[index].Cells[3].Value = dr[8].ToString();
                        dgvOutList.Rows[index].Cells[4].Value = dr[3].ToString();
                        dgvOutList.Rows[index].Cells[5].Value = dr[4].ToString();
                        dgvOutList.Rows[index].Cells[6].Value = dr[5].ToString();
                        dgvOutList.Rows[index].Cells[7].Value = dr[6].ToString();
                        dgvOutList.Rows[index].Cells[8].Value = dr[7].ToString();
                        
                        
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnQuery.Focus();
                btnQuery_Click(sender, e);
            }
        }

        private void HistoryInquery_Load(object sender, EventArgs e)
        {
            //设置combox
            this.cmbQuery.SelectedIndex = 0;
            //设置txtQuery
            this.txtQuery.AutoSize = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOutList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("haode");

            Export(@"C:\img\1.csv");
            //Server=127.0.0.1;Port=5432;User Id=postgres;Password=hardman; Database=material;CommandTimeout=0;ConnectionLifeTime=0;"
            //string strCon = "Password=egdb;User ID=egdb;Data Source=egdb;Persist Security Info=True";

            //OracleConnection con = new OracleConnection(strCon);
            //con.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from menu_perm";
            //cmd.CommandType = CommandType.Text;

            //OracleDataAdapter ad = new OracleDataAdapter(cmd);
            //DataSet ds = new DataSet();

            //ad.Fill(ds);
            //con.Close();


            //using (StreamWriter streamWriter = new StreamWriter(@"d:\1.csv", false, Encoding.Default))
            //{

            //    if (ds.Tables[0].Rows.Count > 0)
            //    {

            //        foreach (DataRow row in ds.Tables[0].Rows)
            //        {
            //            StringBuilder str = new StringBuilder();
            //            foreach (DataColumn col in ds.Tables[0].Columns)
            //            {
            //                //插入“，”自动会分割成不同的行。
            //                str.Append(row[col.Caption.ToString()].ToString() + ",");
            //            }

            //            streamWriter.WriteLine(str.ToString());
            //        }



            //    }

            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
        }
         private void Export(string filePath)  //filePath为保存到本地磁盘的位置
        {
            using (FileStream fs=new FileStream(filePath,FileMode.Create,FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                string timeStart = this.dateTimeStart.Value.ToString("yyyy/MM/dd") + " 00:00:00";
                string timeEnd = this.dateTimeEnd.Value.ToString("yyyy/MM/dd") + " 23:59:59";
                string queryString = "select * from history where operatetime>='" + timeStart + "' AND operatetime<='" + timeEnd + "'";
                AddHistoryToList(queryString);
                
                
                string col_txt = "";
                string row_txt = "";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);
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
          
#region 

        //public static void ExportCSV(System.Data.DataTable table, string directory, string fileName)
        //{
        //    // 开始忙了

        //    string directoryName = directory;
        //    if (!Directory.Exists(directoryName))
        //    {
        //        Directory.CreateDirectory(directoryName);
        //    }
        //    string file = directory + fileName;
        //    // if (!this.FileExist(file))
        //    // {
        //    ExportCSV(table, file);
        //    //Process.Start(file);
        //    //  }
        //    // 已经忙完了

        //}



        //public static void ExportCSV(DataTable dataTable, string fileName)
        //{
        //    StreamWriter StreamWriter = new StreamWriter(fileName, false, System.Text.Encoding.GetEncoding("gb2312"));
        //    StreamWriter.WriteLine(GetCSVFormatData(dataTable).ToString());
        //    StreamWriter.Flush();
        //    StreamWriter.Close();
        //}



        //public static StringBuilder GetCSVFormatData(DataTable dataTable)
        //{
        //    StringBuilder StringBuilder = new StringBuilder();
        //    // 写出表头

        //    StringBuilder.Append("AAAA,VVVVV,CCCCC ");
        //    StringBuilder.Append("\n");
        //    // 写出数据
        //    int count = 0;
        //    foreach (DataRowView dataRowView in dataTable.DefaultView)
        //    {
        //        count++;
        //        foreach (DataColumn DataColumn in dataTable.Columns)
        //        {
        //            string field = dataRowView[DataColumn.ColumnName].ToString();

        //            if (field.IndexOf('"') >= 0)
        //            {
        //                field = field.Replace("\"", "\"\"");
        //            }
        //            field = field.Replace("  ", " ");
        //            if (field.IndexOf(',') >= 0 || field.IndexOf('"') >= 0 || field.IndexOf('<') >= 0 || field.IndexOf('>') >= 0 || field.IndexOf("'") >= 0)
        //            {
        //                field = "\"" + field + "\"";
        //            }
        //            StringBuilder.Append(field + ",");
        //            field = string.Empty;
        //        }
        //        if (count != dataTable.Rows.Count)
        //        {
        //            StringBuilder.Append("\n");
        //        }
        //    }
        //    return StringBuilder;
        //}
#endregion
    }
}
