using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string barCode = dtRow.Cells["barcode"].Value.ToString();
            dtRow.Cells["barcode"].Value        = txtBarCode.Text;
            dtRow.Cells["materialname"].Value   = txtMaterialName.Text;
            dtRow.Cells["specification"].Value  = txtSpecification.Text;
            dtRow.Cells["specificationModle"].Value = txtSpecification.Text;
            dtRow.Cells["remainnum"].Value      = txtRemainNum.Text;
            dtRow.Cells["categoryone"].Value    = txtCategoryOne.Text;
            dtRow.Cells["categorytwo"].Value    = txtCategoryTwo.Text;
            dtRow.Cells["categorythree"].Value  = txtCategoryThree.Text;
            dtRow.Cells["note"].Value           = txtNote.Text;
            dtRow.Cells["price"].Value          = txtPrice.Text;

            try
            {
                //SetDB modify
                string queryString = "update material set barcode = '" + dtRow.Cells["barcode"].Value.ToString() +
                                    "',materialname = '" + dtRow.Cells["materialname"].Value.ToString() +
                                    "',specification = '" + dtRow.Cells["specification"].Value.ToString() +
                                    "',remainnum = " + dtRow.Cells["remainnum"].Value.ToString() +
                                    ",categoryone = '" + dtRow.Cells["categoryone"].Value.ToString() +
                                    "',categorytwo = '" + dtRow.Cells["categorytwo"].Value.ToString() +
                                    "',categorythree = '" + dtRow.Cells["categorythree"].Value.ToString() +
                                    "',price = '" + dtRow.Cells["price"].Value.ToString() +
                                    "',note = '" + dtRow.Cells["note"].Value.ToString() +
                                    "' where barcode = '" + barCode + "'";
                DataDBInfo.ExecuteSQLQuery(queryString);

                //modify History
                string historyString = "insert into history Values('"
                        + dtRow.Cells["barcode"].Value.ToString() + "','"
                        + dtRow.Cells["materialname"].Value.ToString() + "','"
                        + dtRow.Cells["specification"].Value.ToString() + "','"
                        + "修改','"
                        + dtRow.Cells["remainnum"].Value.ToString() + "','"
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
        {
            txtBarCode.Text         = dtRow.Cells["barcode"].Value.ToString();
            txtMaterialName.Text    = dtRow.Cells["materialname"].Value.ToString();
            txtSpecification.Text   = dtRow.Cells["specification"].Value.ToString();
            txtRemainNum.Text       = dtRow.Cells["remainnum"].Value.ToString();
            txtCategoryOne.Text     = dtRow.Cells["categoryone"].Value.ToString();
            txtCategoryTwo.Text     = dtRow.Cells["categorytwo"].Value.ToString();
            txtCategoryThree.Text   = dtRow.Cells["categorythree"].Value.ToString();
            txtNote.Text            = dtRow.Cells["note"].Value.ToString();
            txtPrice.Text           = dtRow.Cells["price"].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
