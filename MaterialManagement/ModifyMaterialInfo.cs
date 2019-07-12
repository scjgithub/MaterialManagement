using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManagement
{
    public partial class ModifyMaterialInfo : Form
    {
#region Fields
        public DataGridViewRow dtRow;
#endregion
        public ModifyMaterialInfo()
        {
            InitializeComponent();
        }

        public ModifyMaterialInfo(DataGridViewRow dtRow)
        {
            this.dtRow = dtRow;
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //set dtRow
            string num1 = txtRemainNum.Text;
            string price = txtPrice.Text;
            if (!Regex.IsMatch(num1, @"^[+-]?\d*[.]?\d*$") || !Regex.IsMatch(price, @"^[+-]?\d*[.]?\d*$"))
            {
                MessageBox.Show("单价或数量为非数字！！");
                return;
            }
            

            string barCode = dtRow.Cells["barcode"].Value.ToString();
            dtRow.Cells["barcode"].Value        = txtBarCode.Text;
            dtRow.Cells["materialname"].Value   = txtMaterialName.Text;
            dtRow.Cells["specification"].Value  = txtSpecification.Text;
            dtRow.Cells["specificationmodle"].Value = txtSpecificationModle.Text;
            dtRow.Cells["remainnum"].Value      = txtRemainNum.Text;
            dtRow.Cells["categoryone"].Value    = txtCategoryOne.Text;
            dtRow.Cells["categorytwo"].Value    = txtCategoryTwo.Text;
            dtRow.Cells["categorythree"].Value  = txtCategoryThree.Text;
            dtRow.Cells["note"].Value           = txtNote.Text;
            dtRow.Cells["price"].Value          = txtPrice.Text;
            dtRow.Cells["warn"].Value = txtThresHold.Text;
            dtRow.Cells["supplier"].Value = txtSupplier.Text;
            dtRow.Cells["brand"].Value = txtBrand.Text;
            //dtRow.Cells["threshold"].Value = txtThresHold.Text;

            try
            {
                //SetDB modify
                double num = Convert.ToDouble(dtRow.Cells["remainnum"].Value);
                double numPrice = Convert.ToInt32(dtRow.Cells["price"].Value);
                double numTotal = num * numPrice;
                string queryString = "update material set barcode = '" + dtRow.Cells["barcode"].Value.ToString() +
                                    "',materialname = '" + dtRow.Cells["materialname"].Value.ToString() +
                                    "',specification = '" + dtRow.Cells["specification"].Value.ToString() +
                                    "',brand = '" + dtRow.Cells["brand"].Value.ToString() +
                                    "',supplier = '" + dtRow.Cells["supplier"].Value.ToString() +
                                    "',specificationmodle = '" + dtRow.Cells["specificationmodle"].Value.ToString() +
                                    "',remainnum = " + dtRow.Cells["remainnum"].Value.ToString() +
                                    ",categoryone = '" + dtRow.Cells["categoryone"].Value.ToString() +
                                    "',categorytwo = '" + dtRow.Cells["categorytwo"].Value.ToString() +
                                    "',categorythree = '" + dtRow.Cells["categorythree"].Value.ToString() +
                                    "',threshold = " + txtThresHold.Text +
                                    ",price = '" + dtRow.Cells["price"].Value.ToString() +                                    
                                    "',note = '" + dtRow.Cells["note"].Value.ToString() +
                                    "',total = '" + numTotal +
                                    "' where barcode = '" + barCode + "'";
                DataDBInfo.ExecuteSQLQuery(queryString);

                //modify History
                string historyString = "insert into history(barcode,brand,supplier,materialname,inoutnum,supplier,total,price,note,specification,specificationmodle,inouttype,operatetime,operater) Values('"
                        + dtRow.Cells["barcode"].Value.ToString() + "','"
                        + dtRow.Cells["brand"].Value.ToString() + "','"
                        + dtRow.Cells["supplier"].Value.ToString() + "','"
                        + dtRow.Cells["materialname"].Value.ToString() + "','"
                        + dtRow.Cells["remainnum"].Value.ToString() + "','"
                        + dtRow.Cells["supplier"].Value.ToString() + "','"
                        + numTotal + "','"
                        + dtRow.Cells["price"].Value.ToString() + "','"
                        + dtRow.Cells["note"].Value.ToString() + "','"
                        + dtRow.Cells["specification"].Value.ToString() + "','"
                        + dtRow.Cells["specificationmodle"].Value.ToString() + "','" 
                        + "修改','"                        
                        + DateTime.Now.ToString() + "','"
                        + LoginDataInfo.LoginData.UserName + "')";
                DataDBInfo.ExecuteSQLQuery(historyString);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //close window
            this.Close();
        }

        private void ModifyMaterialInfo_Load(object sender, EventArgs e)
        {//Cell 
            txtBarCode.Text         = dtRow.Cells["barcode"].Value.ToString();
            txtMaterialName.Text    = dtRow.Cells["materialname"].Value.ToString();
            txtSpecification.Text   = dtRow.Cells["specification"].Value.ToString();
            txtSpecificationModle.Text = dtRow.Cells["specificationmodle"].Value.ToString();
            txtRemainNum.Text       = dtRow.Cells["remainnum"].Value.ToString();
            txtCategoryOne.Text     = dtRow.Cells["categoryone"].Value.ToString();
            txtCategoryTwo.Text     = dtRow.Cells["categorytwo"].Value.ToString();
            txtCategoryThree.Text   = dtRow.Cells["categorythree"].Value.ToString();
            txtNote.Text            = dtRow.Cells["note"].Value.ToString();
            txtPrice.Text           = dtRow.Cells["price"].Value.ToString();
            txtThresHold.Text = dtRow.Cells["warn"].Value.ToString();
            txtSupplier.Text = dtRow.Cells["supplier"].Value.ToString();
            txtBrand.Text = dtRow.Cells["brand"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       
    }
}
