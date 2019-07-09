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
    public partial class MaterialTreeView : Form
    {
        public MaterialTreeView()
        {
            InitializeComponent();
        }

        public string barCode = "";
        public int queryIndex = 0;

        private void MaterialTreeView_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        public delegate void MaterialSelectNodify();
        public MaterialSelectNodify materialSelectNodify;

        /// <summary>
        /// 初始化
        /// </summary>
        private void InitTreeView()
        {
            if (materiaTreeView.Nodes.Count > 0)
            {
                return;
            }
            materiaTreeView.Nodes.Clear();

            TreeNode node = new TreeNode("物料列表");
            materiaTreeView.Nodes.Add(node);
            CreateTreeNode(node);

            node.Expand();
        }

        private void CreateTreeNode(TreeNode tNode)
        {
            try
            {
                string queryString = "select distinct categoryone from material order by categoryone";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string categoryOne = dr[0].ToString();
                        TreeNode node = new TreeNode(categoryOne);
                        tNode.Nodes.Add(node);
                        node.Tag = "1";

                        CreateNodeTwo(node, categoryOne);
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到CategoryOne的物料");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateNodeTwo(TreeNode node, string categoryOne)
        {
            try
            {
                string queryString = "select distinct categorytwo from material where categoryone = '" + categoryOne + "' order by categorytwo";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string categoryTwo = dr[0].ToString();
                        TreeNode subNode = new TreeNode(categoryTwo);
                        node.Nodes.Add(subNode);
                        subNode.Tag = "2";

                        CreateNodeThree(subNode, categoryOne, categoryTwo);
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateNodeThree(TreeNode node, string categoryOne, string categoryTwo)
        {
            try
            {
                string queryString = "select distinct categorythree from material where categoryone = '" + categoryOne + "' and categorytwo = '" + categoryTwo + "' order by categorythree";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string categoryThree = dr[0].ToString();
                        TreeNode subNode = new TreeNode(categoryThree);
                        node.Nodes.Add(subNode);
                        subNode.Tag = "3";

                        CreateNodeFour(subNode, categoryOne, categoryTwo, categoryThree);
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateNodeFour(TreeNode node, string categoryOne, string categoryTwo, string categoryThree)
        {
            try
            {
                string queryString = "select barcode, materialname, specification from material where categoryone = '" + categoryOne + "' and categorytwo = '" + categoryTwo + "' and categoryThree = '" + categoryThree + "' order by barcode";
                DataTable dt = DataDBInfo.QueryDBInfo(queryString);

                //Set listBox
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string barCode = dr["barcode"].ToString();
                        string materialName = dr["materialname"].ToString();
                        TreeNode subNode = new TreeNode(barCode + " " + materialName);
                        subNode.Tag = barCode;
                        subNode.ToolTipText = dr["specification"].ToString();
                        node.Nodes.Add(subNode);
                    }
                }
                else
                {
                    Console.WriteLine("没有查找到Categorytwo的物料");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void materiaTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Nodes.Count == 0)
                {
                    barCode = e.Node.Tag.ToString();
                    queryIndex = 1;
                } 
                else
                {
                    barCode = e.Node.Text;
                    queryIndex = int.Parse(e.Node.Tag.ToString()) +1;
                }
                SelectNotify();
            }
        }

        public void SelectNotify()
        {
            if (materialSelectNodify != null)
            {
                materialSelectNodify();
            }
            else
            {
                if (queryIndex == 1)
                {
                    this.Hide();
                }
                //this.Close();
            }
        }

        private void materiaTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
