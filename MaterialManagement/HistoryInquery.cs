using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
                System.Data.DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set dgvList
                if (dt.Rows.Count > 0)
                {
                    dgvOutList.Rows.Clear();

                    foreach (DataRow dr in dt.Rows)   ///遍历所有的行
                    {
                        int index = dgvOutList.Rows.Add();
                        //dgvOutList.Rows[index].Cells[0].Value = dr[0].ToString();
                        //dgvOutList.Rows[index].Cells[1].Value = dr[1].ToString();
                        //dgvOutList.Rows[index].Cells[2].Value = dr[2].ToString();
                        //dgvOutList.Rows[index].Cells[3].Value = dr[8].ToString();
                        //dgvOutList.Rows[index].Cells[4].Value = dr[3].ToString();
                        //dgvOutList.Rows[index].Cells[5].Value = dr[5].ToString();
                        //dgvOutList.Rows[index].Cells[6].Value = dr[6].ToString();
                        //dgvOutList.Rows[index].Cells[7].Value = dr[7].ToString();
                        //dgvOutList.Rows[index].Cells[8].Value = dr[4].ToString();
                        //dgvOutList.Rows[index].Cells[9].Value = dr[13].ToString();
                        //dgvOutList.Rows[index].Cells[10].Value = dr[11].ToString();
                        //dgvOutList.Rows[index].Cells[11].Value = dr[10].ToString();
                        //dgvOutList.Rows[index].Cells[12].Value = dr[9].ToString();
                        //dgvOutList.Rows[index].Cells[13].Value = dr[12].ToString();



                        dgvOutList.Rows[index].Cells["barcode"].Value = dr["barcode"].ToString();
                        dgvOutList.Rows[index].Cells["materialname"].Value = dr["materialname"].ToString();
                        dgvOutList.Rows[index].Cells["specification"].Value = dr["specification"].ToString();
                        dgvOutList.Rows[index].Cells["specificationmodle"].Value = dr["specificationmodle"].ToString();
                        dgvOutList.Rows[index].Cells["inouttype"].Value = dr["inouttype"].ToString();
                        dgvOutList.Rows[index].Cells["inoutnum"].Value = dr["inoutnum"].ToString();
                        dgvOutList.Rows[index].Cells["total"].Value = dr["total"].ToString();
                        dgvOutList.Rows[index].Cells["operatetime"].Value = dr["operatetime"].ToString();
                        dgvOutList.Rows[index].Cells["operater"].Value = dr["operater"].ToString();
                        dgvOutList.Rows[index].Cells["whereabouts"].Value = dr["whereabouts"].ToString();
                        dgvOutList.Rows[index].Cells["price"].Value = dr["price"].ToString();
                        dgvOutList.Rows[index].Cells["note"].Value = dr["note"].ToString();
                        dgvOutList.Rows[index].Cells["supplier"].Value = dr["supplier"].ToString();
                        dgvOutList.Rows[index].Cells["brand"].Value = dr["brand"].ToString();




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

            

           // DataGridView dt=new DataGridView();
            
                //ExportDataGridview(dgvOutList,true);

            //DataTable dt = new DataTable();   //需要转换的数据表

            //ExportToExcel(dt, "出入库历史记录");

            try
            {
                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.Description = "请选择表格所在文件夹";
                string selectPCPath = "";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectPCPath = dialog.SelectedPath;
                }
                selectPCPath += "\\出入库历史记录.xls";
                prints.ToExcel(dgvOutList, selectPCPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            

        }









       





        #region

        //public bool ExportDataGridview(DataGridView gridView, bool isShowExcle)
        //{
        //    if (gridView.Rows.Count == 0)
        //    {
        //        return false;
        //    }
        //    //创建Excel对象
        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //    excel.Application.Workbooks.Add(true);
        //    //生成字段名称
        //    for (int i = 0; i < gridView.ColumnCount; i++)
        //    {
        //        excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
        //    }
        //    //填充数据
        //    for (int i = 0; i < gridView.RowCount - 1; i++) //循环行
        //    {
        //        for (int j = 0; j < gridView.ColumnCount; j++) //循环列
        //        {
        //            if (gridView[j, i].ValueType == typeof(string))
        //            {
        //                excel.Cells[i + 2, j + 1] = "'" + gridView.Rows[i].Cells[j].Value.ToString();
        //            }
        //            else
        //            {
        //                excel.Cells[i + 2, j + 1] = gridView.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //    }
        //    //设置禁止弹出保存和覆盖的询问提示框
        //    excel.Visible = false;
        //    excel.DisplayAlerts = false;
        //    excel.AlertBeforeOverwriting = false;
        //    //保存到临时工作簿
        //    //excel.Application.Workbooks.Add(true).Save();
        //    //保存文件
        //    excel.Save(@"C:\img\123.xlsx");
        //    excel.Quit();
        //    return true;
        //}

        #endregion


        #region

        //public void ExportToExcel(DataTable dt, string saveFileName)
        //{
        //    if (dt == null) return;

        //    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        //    if (xlApp == null)
        //    {
        //        // lblMsg.Text = "无法创建Excel对象，可能您的机子未安装Excel";
        //        MessageBox.Show("请确保您的电脑已经安装Excel", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
        //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1]; //取得sheet1
        //    Microsoft.Office.Interop.Excel.Range range = null;
        //    long totalCount = dt.Rows.Count;
        //    long rowRead = 0;
        //    float percent = 0;

        //    //写入标题
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {
        //        worksheet.Cells[0, i + 1] = dt.Columns[i].ColumnName;
        //        range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[0, i + 1];
        //        range.Interior.ColorIndex = 15;//背景颜色
        //        range.Font.Bold = true; //粗体
        //        range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中
        //        //加边框
        //        range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin,
        //                          Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //        //range.ColumnWidth = 4.63;//设置列宽
        //        //range.EntireColumn.AutoFit();//自动调整列宽
        //        //r1.EntireRow.AutoFit();//自动调整行高
        //    }
        //    //写入内容
        //    for (int r = 0; r < dt.Rows.Count; r++)
        //    {
        //        for (int i = 0; i < dt.Columns.Count; i++)
        //        {
        //            try
        //            {
        //                worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i];

        //                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[r + 2, i + 1];
        //                range.Font.Size = 9; //字体大小
        //                //加边框
        //                range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin,
        //                                  Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //                range.EntireColumn.AutoFit(); //自动调整列宽
        //            }
        //            catch (Exception)
        //            {
        //            }
        //        }
        //        rowRead++;
        //        percent = ((float)(100 * rowRead)) / totalCount;
        //        Application.DoEvents();
        //    }


        //    range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        //    if (dt.Columns.Count > 1)
        //    {
        //        range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        //    }

        //    try
        //    {
        //        workbook.Saved = true;

        //        SaveFileDialog SaveFile = new SaveFileDialog();
        //        SaveFile.FileName = saveFileName;
        //        //SaveFile.Filter = "Miscrosoft Office Excel 97-2003 工作表|*.xls|所有文件(*.*)|*.*";
        //        SaveFile.Filter = "Miscrosoft Office Excel 97-2003 工作表|*.xls|Excel 工作簿|*.xlsx|所有文件(*.*)|*.*";
        //        SaveFile.RestoreDirectory = true;
        //        if (SaveFile.ShowDialog() == DialogResult.OK)
        //        {
        //            workbook.SaveCopyAs(SaveFile.FileName);

        //            MessageBox.Show("导出数据成功!", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show("导出文件时出错,文件可能正被打开!", "系统信息");
        //        MessageBox.Show(ex.Message.ToString());
        //    }
            #endregion

            #region
            //private void Export(string filePath)  //filePath为保存到本地磁盘的位置
            //{
            //    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            //    {
            //        StreamWriter sw = new StreamWriter(fs);
            //        string timeStart = this.dateTimeStart.Value.ToString("yyyy/MM/dd") + " 00:00:00";
            //        string timeEnd = this.dateTimeEnd.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            //        string queryString = "select * from history where operatetime>='" + timeStart + "' AND operatetime<='" + timeEnd + "'";
            //        AddHistoryToList(queryString);


            //        string col_txt = "";
            //        string row_txt = "";
            //        string[] i = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" };
            //        DataTable dt = DataDBInfo.QueryDBInfo(queryString);
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
            //    }
            //}
            #endregion



        }
    }
