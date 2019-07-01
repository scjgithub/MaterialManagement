using LoginDataInfo;
//using PostgreDBUtility;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static MaterialTreeView mTree = new MaterialTreeView();
        
        //用户名
        public static string user_Name = "Admin";
        MaterialTreeView treeFrm;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //导入数据库
            //ImprotMaterial.ImportToDB();

            //初始化权限
            if (Authority.Guest == LoginData.Authority)
            {
                modifyInfoStripMenuItem1.Enabled = false;
                this.price.Visible = false;
            }
            else
                modifyInfoStripMenuItem1.Enabled = true;


            //dgvMaterialList.RowHeightChanged


            //设置combox
            this.cmbQuery.SelectedIndex = 0;
            //设置txtQuery
            this.txtQuery.AutoSize = false;

            //Set  MaterialTreeView
            LoadMaterialTreeView();
        }

        private void LoadMaterialTreeView()
        {
            treeFrm = new MaterialTreeView();
            treeFrm.TopLevel = false;
            treeFrm.Visible = true;
            treeFrm.FormBorderStyle = FormBorderStyle.None;

            treeFrm.Parent = this.splitContainer1.Panel1;
            treeFrm.Width = this.splitContainer1.Panel2.Width;
            treeFrm.Height = this.splitContainer1.Panel2.Height;
            //treeFrm.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(treeFrm);
            treeFrm.Dock = DockStyle.Fill;
            treeFrm.materialSelectNodify = SelectNodify;
            
        }

        public void SelectNodify()
        {
            txtQuery.Text = treeFrm.barCode;
            cmbQuery.SelectedIndex = treeFrm.queryIndex;

            btnQuery_Click(null, null);
        }

        //定义查询数据库字段名称
        string[] dbFields = { "materialname", "barcode", "categoryone", "categorytwo", "categorythree", "materialname", "specification" };
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string txt = txtQuery.Text;
            int itemIndex = cmbQuery.SelectedIndex;
            if (itemIndex < 0)
            {
                return;
            }
            //query string
            string queryString = "select * from material where lower(" + dbFields[itemIndex] + ") like '%" + txt.ToLower() + "%'";
            if (txt == string.Empty)
            {
                queryString = "select * from material";
            }
            queryDBInfoAndAddtoDgv(queryString);
        }

        private void queryDBInfoAndAddtoDgv(string queryString)
        {
            //query DB data
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set dgvList
                if (dt.Rows.Count > 0)
                {
                    dgvMaterialList.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)   ///遍历所有的行
                    {
                        string barcode = dr[0].ToString();
                        //if (CheckBarCodeExist(barcode, dgvMaterialList))
                        //{
                        //    continue;
                        //}
                        int index = dgvMaterialList.Rows.Add();
                        dgvMaterialList.Rows[index].Cells["barcode"].Value = barcode;
                        dgvMaterialList.Rows[index].Cells["materialname"].Value = dr["materialname"].ToString();
                        dgvMaterialList.Rows[index].Cells["specification"].Value = dr["specification"].ToString();
                        dgvMaterialList.Rows[index].Cells["specificationModle"].Value = dr["specification"].ToString();
                        dgvMaterialList.Rows[index].Cells["remainnum"].Value = dr["remainnum"].ToString();
                        dgvMaterialList.Rows[index].Cells["categoryone"].Value = dr["categoryone"].ToString();
                        dgvMaterialList.Rows[index].Cells["categorytwo"].Value = dr["categorytwo"].ToString();
                        dgvMaterialList.Rows[index].Cells["categorythree"].Value = dr["categorythree"].ToString();
                        dgvMaterialList.Rows[index].Cells["price"].Value = dr["price"].ToString();
                        dgvMaterialList.Rows[index].Cells["note"].Value = dr["note"].ToString();

                        int nThreshold = int.Parse(dr["threshold"].ToString());
                        int nRemain = int.Parse(dr["remainnum"].ToString());
                        if (nRemain < nThreshold)
                        {
                            dgvMaterialList.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("没有此物料或者查询类别不对！");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool CheckBarCodeExist(string barcode, DataGridView dgvMaterialList)
        {
            foreach (DataGridViewRow row in dgvMaterialList.Rows)
            {
                if (row.Cells["barcode"].Value.ToString() == barcode)
                {
                    int nIndex = row.Index;
                    return true;
                }
            }
            return false;
        }

        private void btnInMaterial_Click(object sender, EventArgs e)
        {
            if (LoginData.Authority == Authority.Guest)
            {
                MessageBox.Show("你还没有权限进行操作！. \n 请联系管理员. \n ", "Authority!", MessageBoxButtons.OK);
                return;
            }
            InMaterial fm = new InMaterial();
            fm.Show();

            UpdateMaterialList();
        }

        private void UpdateMaterialList()
        {
            return;

            //foreach (DataGridViewRow row in dgvMaterialList.Rows)
            //{
            //    try
            //    {
            //        string queryString = "select * from material  where barcode = '" + row.Cells[0].Value.ToString() + "'";
            //        DataTable dt = DataDBInfo.QueryDBInfo(queryString);

            //        //Set dgvList
            //        if (dt.Rows.Count > 0)
            //        {
            //            if (dt.Rows.Count > 0)
            //            {
            //                row.Cells[6].Value = dt.Rows[0][6].ToString();
            //            }
            //        }
            //    }
            //    catch (System.Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }

        private void btnOutMaterial_Click(object sender, EventArgs e)
        {
            if (LoginDataInfo.LoginData.Authority == Authority.Guest)
            {
                MessageBox.Show("你还没有权限进行操作！. \n 请联系管理员. \n ", "Authority!", MessageBoxButtons.OK);
                return;
            }
            OutMaterial fm = new OutMaterial();
            fm.ShowDialog();

            UpdateMaterialList();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryInquery fm = new HistoryInquery();
            fm.ShowDialog();

            UpdateMaterialList();
        }

        private void dgvMaterialList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtQuery.Text = dgvMaterialList.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbQuery.SelectedIndex = 1;
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
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
                    Console.WriteLine(dr.Cells[0].Value.ToString());
                }
            }
        }

        private void clearAllMenuItem_Click(object sender, EventArgs e)
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

        private void btnMaterialList_Click(object sender, EventArgs e)
        {
            MaterialTreeView mTree = new MaterialTreeView();
            mTree.ShowDialog();

            txtQuery.Text = mTree.barCode;
            cmbQuery.SelectedIndex = 1;
        }

        private void dgvContentMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            //int rowIndex = dgvMaterialList.CurrentCell.RowIndex;
            //int colIndex = dgvMaterialList.CurrentCell.ColumnIndex;

            if (Authority.Guest == LoginData.Authority)
            {
                modifyInfoStripMenuItem1.Enabled = false;
            }
            else
                modifyInfoStripMenuItem1.Enabled = true;
        }

        private void dgvMaterialList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvMaterialList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvMaterialList.ClearSelection();
                        dgvMaterialList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    //if (dgvMaterialList.SelectedRows.Count == 1)
                    {
                        dgvMaterialList.CurrentCell = dgvMaterialList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                }
            }
        }

        private void modifyInfoStripMenuItem1_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMaterialList.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            ModifyMaterialInfo fmModify = new ModifyMaterialInfo(dgvMaterialList.Rows[rowIndex]);
            fmModify.ShowDialog();
        }

        private void dgvMaterialList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}