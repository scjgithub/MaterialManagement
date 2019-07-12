using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //double beforTotal = 0;
        //string[] dbFields = { "materialname", "barcode", "materialname", "specification", "supplier", "total", "remainnum", "price" };
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string txt = txtQuery.Text;
            //int itemIndex = cmbQuery.SelectedIndex;
            //if (itemIndex < 0)
            //{
            //    return;
            //}

            //query string
            string queryString = "select * from material where barcode = '" + txt+ "'";
            if (txt == string.Empty)
            {
                return;
            }
            try
            {
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set txt(s) 对textBox赋值
                if (dt.Rows.Count > 0)
                {
                   DataRow dr = dt.Rows[0];
                    txtBarCode.Text = dr["barcode"].ToString();
                    txtCategoryOne.Text = dr["categoryone"].ToString();
                    txtCategoryTwo.Text = dr["categorytwo"].ToString();
                    txtCategoryThree.Text = dr["categorythree"].ToString();
                    txtMaterialName.Text = dr["materialname"].ToString();
                    txtSpecification.Text = dr["specification"].ToString();
                    txtAddNum.Text = dr["remainnum"].ToString();
                    txtNote.Text = dr["note"].ToString();
                    txtPrice.Text = dr["price"].ToString();
                    txtSupplier.Text = dr["supplier"].ToString();
                    txtSpecificationModle1.Text = dr["specificationmodle"].ToString();
                    txtBrand.Text = dr["brand"].ToString();
                    //string num = txtAddNum.Text;
                    //string price = txtPrice.Text;
                    //int num1 = Convert.ToInt32(num);
                    //int price1 = Convert.ToInt32(price);
                   // beforTotal =Convert.ToInt32(dr["total"].ToString()) ;
                    if (txtPrice.Text == "")
                    {
                        txtPrice.Text = "0";
                    }
                    if (txtThresHodl.Text == "")
                    {
                        txtThresHodl.Text = "0";
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

            string supplier = txtSupplier.Text;
            string brand = txtBrand.Text;
            if ((supplier == null || supplier.Equals("")) && (brand == null || brand.Equals("")))
            {
                MessageBox.Show("供应商或品牌不能为空！！");
                return;
            }
            string num = txtAddNum.Text;
            string price = txtPrice.Text;
            
            if (num.Equals("") || price.Equals(""))
            {
                MessageBox.Show("数量或单价不能为空");
                return;
            }
            int num1=0;
            double price1=0.0;
            if (Regex.IsMatch(num, @"^[+-]?\d*[.]?\d*$") && Regex.IsMatch(price, @"^[+-]?\d*[.]?\d*$"))
            {
                num1 = Convert.ToInt32(num);
                price1 = Convert.ToInt32(price);
            }
            else {
                MessageBox.Show("单价或数量为非数字！！");
                return;
            }
            double total = 0.0;
            if (num1 == 0 || price1 == 0)
            {
                total = 0.0;
            }
            else
            {
                total = num1 * price1;
            }
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
                    row.Cells["categoryone"].Value = txtCategoryOne.Text;
                    row.Cells["categorytwo"].Value = txtCategoryTwo.Text;
                    row.Cells["categorythree"].Value = txtCategoryThree.Text;
                    row.Cells["materialname"].Value = txtMaterialName.Text;
                    row.Cells["specification"].Value = txtSpecification.Text;
                    row.Cells["specificationModle"].Value = txtSpecificationModle1.Text;
                    row.Cells["price"].Value = txtPrice.Text;
                    row.Cells["supplier"].Value = txtSupplier.Text;
                    row.Cells["brand"].Value = txtBrand.Text;
                    row.Cells["note"].Value = txtNote.Text;
                    row.Cells["total"].Value = total;
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
            dgvInList.Rows[index].Cells["specificationmodle"].Value = txtSpecificationModle1.Text;
            dgvInList.Rows[index].Cells["remainnum"].Value = DataDBInfo.GetRemainNumByBarCode(barcode);
            dgvInList.Rows[index].Cells["InNum"].Value = txtAddNum.Text;
            dgvInList.Rows[index].Cells["note"].Value = txtNote.Text;
            dgvInList.Rows[index].Cells["price"].Value = txtPrice.Text;
            dgvInList.Rows[index].Cells["supplier"].Value = txtSupplier.Text;
            dgvInList.Rows[index].Cells["brand"].Value = txtBrand.Text;
            dgvInList.Rows[index].Cells["total"].Value = total;
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

            if (dgvInList.Rows.Count == 0)
                return;
            //遍历循环要添加的列
            foreach (DataGridViewRow row in dgvInList.Rows)
            {   //获取第一行编码
                string txt = row.Cells["barcode"].Value.ToString();
                //query string
                string queryString1 = "select * from material where barcode = '" + txt + "'";
                
           
                DataTable dt = DataDBInfo.QueryDBInfo(queryString1);
                //之前的总价
                double beforTotal = 0.0;
                //
                if(dt.Rows.Count>0){
                DataRow dr = dt.Rows[0];
                if (Convert.ToInt32(dr["total"].ToString()) == 0)
                {
                    beforTotal = 0;
                }
                else
                {
                    beforTotal = Convert.ToInt32(dr["total"].ToString());
                }
                }
                int addNum = 0;
                
                int addNums1 =Convert.ToInt32( row.Cells["InNum"].Value.ToString());
                int remainnum =Convert.ToInt32( row.Cells["remainnum"].Value.ToString());                
                double numPrice1 = Convert.ToInt32(row.Cells["price"].Value.ToString());
                double numTotal1 = beforTotal + (addNums1 * numPrice1);
                numPrice1 = numTotal1 / (remainnum + addNums1);
                string numPrice =Convert.ToString(numPrice1) ;
                string numTotal = Convert.ToString(numTotal1);
                string addNums = row.Cells["InNum"].Value.ToString();

                string numSupplier = row.Cells["supplier"].Value.ToString();
                string numBrand = row.Cells["brand"].Value.ToString();
                if (addNums != string.Empty)
                {                   
                    addNum = int.Parse(addNums);               
                }
                string queryString = "update material set remainnum = remainnum  + " + addNum+",supplier='"+numSupplier+"', brand='" +numBrand+"',price= '"+numPrice+"',total='"+numTotal+"'  where barcode = '" + row.Cells[0].Value.ToString() + "'";
                int rowAffect = DataDBInfo.ExecuteSQLQuery(queryString);

                if (rowAffect == 0)
                {
                    queryString = "insert into material (barcode,categoryone,categorytwo,categorythree,threshold,materialname,specification,specificationmodle,supplier,brand,price,total,remainnum,note) values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["categoryone"].Value.ToString() + "','"
                        + row.Cells["categorytwo"].Value.ToString() + "','"
                        + row.Cells["categorythree"].Value.ToString() + "','"
                        + txtThresHodl.Text + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"
                        + row.Cells["specificationModle"].Value.ToString() + "','"
                        + row.Cells["supplier"].Value.ToString() + "','"
                        + row.Cells["brand"].Value.ToString() + "','"
                        + row.Cells["price"].Value.ToString() + "','"
                        + row.Cells["total"].Value.ToString() + "','"
                        + row.Cells["InNum"].Value.ToString() + "','"
                        + row.Cells["note"].Value.ToString() + "')";
                    DataDBInfo.ExecuteSQLQuery(queryString);
                }

                string historyString = "insert into history(barcode,specificationmodle,materialname,supplier,total,brand,price,note,specification,inouttype,Inoutnum,operatetime,operater) Values('"
                        + row.Cells["barcode"].Value.ToString() + "','"
                        + row.Cells["specificationmodle"].Value.ToString() + "','"
                        + row.Cells["materialname"].Value.ToString() + "','"
                        + row.Cells["supplier"].Value.ToString() + "','"
                        + row.Cells["total"].Value.ToString() + "','"
                        + row.Cells["brand"].Value.ToString() + "','"
                        + row.Cells["price"].Value.ToString() + "','"
                        + row.Cells["note"].Value.ToString() + "','"
                        + row.Cells["specification"].Value.ToString() + "','"                        
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

        private void InMaterial_Load(object sender, EventArgs e)
        {
            //设置combox
            //this.cmbQuery.SelectedIndex = 0;
            //设置txtQuery
            this.txtQuery.AutoSize = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInList.Rows.Count == 0)
                return;




            string fileName = typeTxt.local("入库记录");
            if (fileName == null)
            {
                return;
            }
            prints.ToExcel(dgvInList, fileName);
            //try
            //{
            //    System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            //    dialog.Description = "请选择表格所在文件夹";
            //    string selectPCPath = "";
            //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        selectPCPath = dialog.SelectedPath;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //    selectPCPath += "\\入库记录.xls";
            //    prints.ToExcel(dgvInList, selectPCPath);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}
            
            
            
            
        }

        

       

       

        



        

       

       
    }
}
