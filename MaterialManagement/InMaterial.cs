using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    public partial class InMaterial : Form
    {

        public InMaterial()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string txt = txtQuery.Text;
            if (txt == string.Empty)
            {
                return;
            }

            //query string
            string queryString = "select * from material where barcode = '" + txt + "'";
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set txt(s) 对textBox赋值
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtBarCode.Text = dr[0].ToString();
                    txtCategoryOne.Text = dr[1].ToString();
                    txtCategoryTwo.Text = dr[2].ToString();
                    txtCategoryThree.Text = dr[3].ToString();
                    txtMaterialName.Text = dr[4].ToString();
                    txtSpecification.Text = dr[5].ToString();
                    txtSpecificationModle.Text = dr[10].ToString();
                    txtNote.Text = dr[8].ToString();
                    txtPrice.Text = dr[9].ToString();
                    if (txtPrice.Text == "")
                    {
                        txtPrice.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("数据库中没有此编码，请添加！");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //检查编码的有效性
            string barcode = txtBarCode.Text;
            //if (barcode.Length <= 5)
            //{
            //    return;
            //}

            //判断编码是否已经存在
            if (frmMain.CheckBarCodeExist(barcode, dgvInList))
            {
                foreach (DataGridViewRow row in dgvInList.Rows)
                {
                    if (row.Cells["barcode"].Value.ToString() == barcode)
                        row.Cells["InNum"].Value = txtAddNum.Text;
                }
                return;
            }

            int index = dgvInList.Rows.Add();
            dgvInList.Rows[index].Cells["barcode"].Value = barcode;
            dgvInList.Rows[index].Cells["categoryone"].Value = txtCategoryOne.Text;
            dgvInList.Rows[index].Cells["categorytwo"].Value = txtCategoryTwo.Text;
            dgvInList.Rows[index].Cells["categorythree"].Value = txtCategoryThree.Text;
            dgvInList.Rows[index].Cells["materialname"].Value = txtMaterialName.Text;
            dgvInList.Rows[index].Cells["specification"].Value = txtSpecification.Text;
            //dgvInList.Rows[index].Cells["specificationModle"].Value = txtSpecificationModle.Text;
            dgvInList.Rows[index].Cells["remainnum"].Value = DataDBInfo.GetRemainNumByBarCode(barcode);
            dgvInList.Rows[index].Cells["InNum"].Value = txtAddNum.Text;
            dgvInList.Rows[index].Cells["note"].Value = txtNote.Text;
            dgvInList.Rows[index].Cells["price"].Value = txtPrice.Text;
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnQuery.Focus();
                btnQuery_Click(sender, e);
            }
        }

        private void btnAddInMaterial_Click(object sender, EventArgs e)
        {
            //遍历循环要添加的列
            foreach (DataGridViewRow row in dgvInList.Rows)
            {
                int addNum = 0;
                string addNums = row.Cells["InNum"].Value.ToString();
                if (addNums != string.Empty)
                {
                    addNum = int.Parse(addNums);
                }
                string queryString = "update material set remainnum = remainnum  + " + addNum + " where barcode = '" + row.Cells[0].Value.ToString() + "'";
                int rowAffect = DataDBInfo.ExecuteSQLQuery(queryString);

                if (rowAffect == 0)
                {
                    queryString = "insert into material (barcode,categoryone,categorytwo,categorythree,materialname,specification,specificationmodle,remainnum,note) values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["categoryone"].Value.ToString() + "','"
                        + row.Cells["categorytwo"].Value.ToString() + "','"
                        + row.Cells["categorythree"].Value.ToString() + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"
                        + row.Cells["specificationModle"].Value.ToString() + "','"
                        + row.Cells["InNum"].Value.ToString() + "','"
                        + row.Cells["note"].Value.ToString() + "')";
                    DataDBInfo.ExecuteSQLQuery(queryString);
                }

                string historyString = "insert into history Values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"
                        + row.Cells["specificationmodle"].Value.ToString() + "','"  
                        + "入库','"
                        + row.Cells["InNum"].Value.ToString() + "','"
                        + DateTime.Now.ToString() + "','"
                        + LoginDataInfo.LoginData.UserName + "')";
                DataDBInfo.ExecuteSQLQuery(historyString);
            }

            //提示入库成功
            if (DialogResult.Yes == MessageBox.Show("物料入库成功，是否要导出入库记录！", "Exprot", MessageBoxButtons.YesNo))
            {
                ExportToFiles();
            }

            //入库后清空列表
            dgvInList.Rows.Clear();
        }

        private void ExportToFiles()
        {
            ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dgvInList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvInList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvInList.ClearSelection();
                        dgvInList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    //if (dgvMaterialList.SelectedRows.Count == 1)
                    {
                        dgvInList.CurrentCell = dgvInList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                }
            }
        }

        private void dgvInList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
