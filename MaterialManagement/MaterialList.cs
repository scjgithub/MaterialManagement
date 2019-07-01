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
    public partial class MaterialList : Form
    {
        public MaterialList()
        {
            InitializeComponent();
        }

        //定义选中的listBox的字段
        private string categoryOne = "";
        private string categoryTwo = "";
        private string categoryThree = "";

        public string barCode = "";

        private void MaterialList_Load(object sender, EventArgs e)
        {
            InitListBoxOne();
        }

        /// <summary>
        /// 初始化类别1 ListBox
        /// </summary>
        private void InitListBoxOne()
        {
            listBoxCateOne.Items.Clear();
            try
            {
                string queryString = "select distinct categoryone from material order by categoryone";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBoxCateOne.Items.Add(dr[0].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到CategoryOne的物料");
                }

                categoryOne = listBoxCateOne.Items[0].ToString();
                listBoxCateOne.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 初始化类别2 ListBox
        /// </summary>
        private void InitListBoxTwo()
        {
            listBoxCateTwo.Items.Clear();
            if (categoryOne.Length <= 0)
            {
                return;
            }

            try
            {
                string queryString = "select distinct categorytwo from material where categoryone = '" + categoryOne + "' order by categorytwo";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBoxCateTwo.Items.Add(dr[0].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }

                categoryTwo = listBoxCateTwo.Items[0].ToString();
                listBoxCateTwo.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 初始化类别3 ListBox
        /// </summary>
        private void InitListBoxThree()
        {
            listBoxCateThree.Items.Clear();
            if (categoryTwo.Length <= 0)
            {
                return;
            }

            try
            {
                string queryString = "select distinct categorythree from material where categoryone = '" + categoryOne + "' and categorytwo = '" + categoryTwo + "' order by categorythree";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBoxCateThree.Items.Add(dr[0].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }

                categoryThree = listBoxCateThree.Items[0].ToString();
                listBoxCateThree.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 初始化类别4 ListBox
        /// </summary>
        private void InitListBoxFour()
        {
            listBoxCateFour.Items.Clear();
            if (categoryTwo.Length <= 0)
            {
                return;
            }

            try
            {
                string queryString = "select barcode, materialname, specification from material where categoryone = '" + categoryOne + "' and categorytwo = '" + categoryTwo + "' and categoryThree = '" + categoryThree + "' order by materialname";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        MaterialItem item = new MaterialItem();
                        item.itemString = dr["materialname"].ToString();
                        item.barcode = dr["barcode"].ToString();
                        item.specification = dr["specification"].ToString();
                        int index = listBoxCateFour.Items.Add(item);
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }
                listBoxCateFour.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBoxCateOne_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxCateOne.SelectedIndex;
            categoryOne = listBoxCateOne.Items[index].ToString();

            InitListBoxTwo();
        }

        private void listBoxCateTwo_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxCateTwo.SelectedIndex;
            categoryTwo = listBoxCateTwo.Items[index].ToString();

            InitListBoxThree();
        }

        private void listBoxCateThree_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxCateThree.SelectedIndex;
            categoryThree = listBoxCateThree.Items[index].ToString();

            InitListBoxFour();
        }

        private void listBoxCateFour_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxCateFour.SelectedIndex;
            barCode = ((MaterialItem)listBoxCateFour.Items[index]).barcode;

            this.Close();
        }

        ToolTip toolTip1 = new ToolTip();
        private void listBoxCateFour_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBoxCateFour.IndexFromPoint(e.Location);
            // Check if the index is valid.
            if (index != -1 && index < listBoxCateFour.Items.Count)
            {
                // Check if the ToolTip's text isn't already the one we are now processing.
                if (toolTip1.GetToolTip(listBoxCateFour) != ((MaterialItem)listBoxCateFour.Items[index]).itemString)
                {
                    // If it isn't, then a new item needs to be
                    // displayed on the toolTip. Update it.
                    toolTip1.SetToolTip(listBoxCateFour, ((MaterialItem)listBoxCateFour.Items[index]).itemString);
                }
            }
        }
    }
}
