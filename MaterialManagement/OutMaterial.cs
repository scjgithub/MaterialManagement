using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDataInfo;

namespace MaterialManagement
{
    public partial class OutMaterial : Form
    {
        public OutMaterial()
        {
            InitializeComponent();
        }
        //public static MaterialTreeView mTree = new MaterialTreeView();
        //MaterialTreeView treeFrm;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        


        

        //定义查询数据库字段名称
        //string[] dbFields = { "materialname", "barcode", "categoryone", "categorytwo", "categorythree", "materialname", "specification", "supplier", "total", "remainnum", "price" };
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string txt = txtQuery.Text;
            //int itemIndex = cmbQuery.SelectedIndex;
            //if (itemIndex < 0)
            //{
            //    return;
            //}
            //query string
            string queryString = "select * from material where barcode like '%" + txt + "%'";
            if (txt == string.Empty)
            {
                queryString = "select * from material";
            }
            
       

            //先清空列表
            dgvMaterialList.Rows.Clear();

            //query string
            
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);
                int dtt = dt.Rows.Count;
                //Set txt(s) 对textBox赋值
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)   ///遍历所有的行
                    {
                        string barcode = dr[0].ToString();

                        //int num = Convert.ToInt32(dr["remainnum"].ToString());
                        //double numPrice = Convert.ToInt32(dr["price"].ToString());
                        //double numTotal = num * numPrice;
                        //if (CheckBarCodeExist(barcode, dgvMaterialList))
                        //{
                        //    continue;
                        //}
                        int index = dgvMaterialList.Rows.Add();
                        dgvMaterialList.Rows[index].Cells["barcode1"].Value = barcode;                       
                        dgvMaterialList.Rows[index].Cells["materialname1"].Value = dr["materialname"].ToString();
                        dgvMaterialList.Rows[index].Cells["specification1"].Value = dr["specification"].ToString();
                        dgvMaterialList.Rows[index].Cells["specification1Modle"].Value = dr["specificationmodle"].ToString();
                        dgvMaterialList.Rows[index].Cells["remainnum1"].Value = dr["remainnum"].ToString();
                        dgvMaterialList.Rows[index].Cells["categoryone1"].Value = dr["categoryone"].ToString();
                        dgvMaterialList.Rows[index].Cells["categorytwo1"].Value = dr["categorytwo"].ToString();
                        dgvMaterialList.Rows[index].Cells["categorythree1"].Value = dr["categorythree"].ToString();
                        dgvMaterialList.Rows[index].Cells["note1"].Value = dr["note"].ToString();
                        dgvMaterialList.Rows[index].Cells["total1"].Value = dr["total"].ToString();
                        dgvMaterialList.Rows[index].Cells["price1"].Value = dr["price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("数据库中没有此编码！");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string whereabouts=txtWhereabouts.Text;
            if (whereabouts == null || whereabouts.Equals(""))
            {
                MessageBox.Show("客户名称未填写");
                return;
            }
            //检查编码的有效性


            string barcode = txtQuery.Text;

            //判断编码是否已经存在
            if (frmMain.CheckBarCodeExist(barcode, dgvOutList))
            {
                foreach (DataGridViewRow row in dgvOutList.Rows)
                {
                    if (row.Cells["barcode"].Value.ToString() == barcode)
                    {
                        row.Cells["InNum"].Value = txtAddCount.Text;
                        row.Cells["whereabouts"].Value = txtWhereabouts.Text;
                    }
                }
                return;
            }

            DataTable dt = DataDBInfo.GetMaterialInfoByBarCode(barcode);
            if (dt == null || dt.Rows.Count == 0)
            {
                Console.WriteLine("查询BarCode对应物料信息错误！");
                return;
            }

            //判读库存数量和出库数量
            int nRemain = int.Parse(dt.Rows[0]["remainnum"].ToString());
            int outNum = int.Parse(txtAddCount.Text);
            if (outNum > nRemain)
            {
                MessageBox.Show(barcode+" 库存数量不足！");
                outNum = nRemain;
            }
            //int num = Convert.ToInt32(dt.Rows[0]["remainnum"].ToString());
            //double numPrice = Convert.ToInt32(dt.Rows[0]["price"].ToString());
            //double numTotal = num * numPrice;

            int index = dgvOutList.Rows.Add();
            dgvOutList.Rows[index].Cells["barcode"].Value = barcode;
            dgvOutList.Rows[index].Cells["materialname"].Value = dt.Rows[0]["materialname"].ToString();
            dgvOutList.Rows[index].Cells["specification"].Value = dt.Rows[0]["specification"].ToString();
            dgvOutList.Rows[index].Cells["specificationModle"].Value = dt.Rows[0]["specificationmodle"].ToString();
            dgvOutList.Rows[index].Cells["remainnum"].Value = dt.Rows[0]["remainnum"].ToString();
            dgvOutList.Rows[index].Cells["whereabouts"].Value = txtWhereabouts.Text;
            dgvOutList.Rows[index].Cells["categoryone"].Value = dt.Rows[0]["categoryone"].ToString();
            dgvOutList.Rows[index].Cells["categorytwo"].Value = dt.Rows[0]["categorytwo"].ToString();
            dgvOutList.Rows[index].Cells["categorythree"].Value = dt.Rows[0]["categorythree"].ToString();
            dgvOutList.Rows[index].Cells["InNum"].Value = outNum.ToString();
            dgvOutList.Rows[index].Cells["note"].Value = dt.Rows[0]["note"].ToString();
            dgvOutList.Rows[index].Cells["price"].Value = dt.Rows[0]["price"].ToString();
            dgvOutList.Rows[index].Cells["total"].Value = dt.Rows[0]["total"].ToString();
        }

        private void btnOutMaterial_Click(object sender, EventArgs e)
        {
            //遍历循环要添加的列
            foreach (DataGridViewRow row in dgvOutList.Rows)
            {
                int addNum = 0;
                string addNums = row.Cells["InNum"].Value.ToString();
                double numprice = Convert.ToDouble(row.Cells["price"].Value.ToString());
                

                if (addNums != string.Empty)
                {
                    addNum = int.Parse(addNums);
                    
                }
                double sumnum = addNum * numprice;
                double total = Convert.ToDouble(row.Cells["total"].Value.ToString());
                double totalnum = total - sumnum;
                string strTotal = Convert.ToString(totalnum);
                string queryString = "update material set remainnum = remainnum  - " + addNum + ",total=" + strTotal + " where barcode = '" + row.Cells["barcode"].Value.ToString() + "'";
                int rowAffect = DataDBInfo.ExecuteSQLQuery(queryString);

                if (rowAffect == 0)
                {
                    queryString = "insert into material (barcode,materialname,specification,specificationmodle,remainnum,categoryone,categorytwo,categorythree,whereabouts,price,total,note) values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"
                        + row.Cells["specificationmodle"].Value.ToString() + "','"
                        + row.Cells["remainnum"].Value.ToString() + "','"
                        + row.Cells["categoryone"].Value.ToString() + "','"
                        + row.Cells["categorytwo"].Value.ToString() + "','"
                        + row.Cells["categorythree"].Value.ToString() + "','"
                        + row.Cells["whereabouts"].Value.ToString() + "','"
                        + row.Cells["price"].Value.ToString() + "','"
                        + row.Cells["total"].Value.ToString() + "','"
                        + row.Cells["note"].Value.ToString() + "')";
                    DataDBInfo.ExecuteSQLQuery(queryString);
                }

                string historyString = "insert into history(barcode,note,materialname,price,specification,specificationmodle,inouttype,inoutnum,operatetime,operater,whereabouts) Values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["note"].Value.ToString() + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["price"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"
                        + row.Cells["specificationmodle"].Value.ToString() + "','"
                        + "出库','"
                        + row.Cells["InNum"].Value.ToString() + "','"
                        + DateTime.Now.ToString() + "','"
                        + LoginDataInfo.LoginData.UserName + "','"
                        + row.Cells["whereabouts"].Value.ToString() + "')";
                DataDBInfo.ExecuteSQLQuery(historyString);
            }
            MessageBox.Show("出库成功");
            //清空列表
            dgvOutList.Rows.Clear();
        }

        private void dgvMaterialList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex  < 0)
            {
                return;
            }

            txtQuery.Text = dgvMaterialList.Rows[e.RowIndex].Cells["barcode1"].Value.ToString();
        }

        private void clearAlltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
            if (contextMenuStrip != null)
            {
                //获取目标控件
                DataGridView dataGridView = contextMenuStrip.SourceControl as DataGridView;
                dataGridView.Rows.Clear();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
            if (contextMenuStrip != null)
            {
                //获取目标控件
                DataGridView dataGridView = contextMenuStrip.SourceControl as DataGridView;
                foreach (DataGridViewRow dr in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(dr);
                }
            }
        }

        private void btnMaterialList_Click(object sender, EventArgs e)
        {
            //MaterialTreeView mTree = new MaterialTreeView();
            frmMain.mTree.ShowDialog();

            txtQuery.Text = frmMain.mTree.barCode;
        }

        private void dgvOutList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvOutList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvOutList.ClearSelection();
                        dgvOutList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    //if (dgvMaterialList.SelectedRows.Count == 1)
                    {
                        dgvOutList.CurrentCell = dgvOutList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                }
            }
        }



        private void OutMaterial_Load(object sender, EventArgs e)
        {
            //设置combox
            //this.cmbQuery.SelectedIndex = 0;
            //设置txtQuery
            this.txtQuery.AutoSize = false;
        }

        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvOutList.Rows.Count == 0)
                return;
            try
            {
                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.Description = "请选择表格所在文件夹";
                string selectPCPath = "";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectPCPath = dialog.SelectedPath;
                }
                selectPCPath += "\\出库记录.xls";
                prints.ToExcel(dgvOutList, selectPCPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


        }

    }
}
