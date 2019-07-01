namespace MaterialManagement
{
    partial class InMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InMaterial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaterialList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddInMaterial = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategoryTwo = new System.Windows.Forms.TextBox();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtCategoryThree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoryOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInList = new System.Windows.Forms.DataGridView();
            this.dgvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationModle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorythree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInList)).BeginInit();
            this.dgvContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaterialList);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAddInMaterial);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 183);
            this.panel1.TabIndex = 0;
            // 
            // btnMaterialList
            // 
            this.btnMaterialList.Location = new System.Drawing.Point(1037, 30);
            this.btnMaterialList.Name = "btnMaterialList";
            this.btnMaterialList.Size = new System.Drawing.Size(75, 59);
            this.btnMaterialList.TabIndex = 0;
            this.btnMaterialList.Text = "物料列表";
            this.btnMaterialList.UseVisualStyleBackColor = true;
            this.btnMaterialList.Click += new System.EventHandler(this.btnMaterialList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1037, 128);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 39);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "关闭窗口 ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInMaterial
            // 
            this.btnAddInMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInMaterial.Image")));
            this.btnAddInMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInMaterial.Location = new System.Drawing.Point(867, 132);
            this.btnAddInMaterial.Name = "btnAddInMaterial";
            this.btnAddInMaterial.Size = new System.Drawing.Size(88, 39);
            this.btnAddInMaterial.TabIndex = 18;
            this.btnAddInMaterial.Text = "物料入库";
            this.btnAddInMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddInMaterial.UseVisualStyleBackColor = true;
            this.btnAddInMaterial.Click += new System.EventHandler(this.btnAddInMaterial_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(756, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 39);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "添  加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(929, 72);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 37);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(742, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "库存编码查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoryTwo);
            this.groupBox1.Controls.Add(this.txtAddNum);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtCategoryThree);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSpecification);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaterialName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCategoryOne);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBarCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 174);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物品信息";
            // 
            // txtCategoryTwo
            // 
            this.txtCategoryTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryTwo.Location = new System.Drawing.Point(327, 80);
            this.txtCategoryTwo.Name = "txtCategoryTwo";
            this.txtCategoryTwo.Size = new System.Drawing.Size(142, 21);
            this.txtCategoryTwo.TabIndex = 18;
            // 
            // txtAddNum
            // 
            this.txtAddNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddNum.Location = new System.Drawing.Point(564, 77);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(142, 21);
            this.txtAddNum.TabIndex = 19;
            this.txtAddNum.Text = "0";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(564, 127);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 21);
            this.txtPrice.TabIndex = 19;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(564, 29);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(142, 21);
            this.txtNote.TabIndex = 19;
            // 
            // txtCategoryThree
            // 
            this.txtCategoryThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryThree.Location = new System.Drawing.Point(327, 127);
            this.txtCategoryThree.Name = "txtCategoryThree";
            this.txtCategoryThree.Size = new System.Drawing.Size(142, 21);
            this.txtCategoryThree.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "添加数量：";
            // 
            // txtSpecification
            // 
            this.txtSpecification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecification.Location = new System.Drawing.Point(87, 127);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(142, 21);
            this.txtSpecification.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "物料类别3：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "物料类别2：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "物料规格：";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaterialName.Location = new System.Drawing.Point(87, 81);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(142, 21);
            this.txtMaterialName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "物料名称：";
            // 
            // txtCategoryOne
            // 
            this.txtCategoryOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryOne.Location = new System.Drawing.Point(327, 32);
            this.txtCategoryOne.Name = "txtCategoryOne";
            this.txtCategoryOne.Size = new System.Drawing.Size(142, 21);
            this.txtCategoryOne.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "物料类别1：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Location = new System.Drawing.Point(86, 33);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(143, 21);
            this.txtBarCode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "编码：";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(754, 80);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(169, 21);
            this.txtQuery.TabIndex = 14;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 397);
            this.panel2.TabIndex = 1;
            // 
            // dgvInList
            // 
            this.dgvInList.AllowUserToAddRows = false;
            this.dgvInList.AllowUserToDeleteRows = false;
            this.dgvInList.AllowUserToOrderColumns = true;
            this.dgvInList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.materialname,
            this.specification,
            this.specificationModle,
            this.remainnum,
            this.InNum,
            this.categoryone,
            this.categorytwo,
            this.categorythree,
            this.price,
            this.note});
            this.dgvInList.ContextMenuStrip = this.dgvContextMenuStrip;
            this.dgvInList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInList.Location = new System.Drawing.Point(0, 0);
            this.dgvInList.MultiSelect = false;
            this.dgvInList.Name = "dgvInList";
            this.dgvInList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvInList.RowTemplate.Height = 30;
            this.dgvInList.Size = new System.Drawing.Size(1153, 397);
            this.dgvInList.TabIndex = 0;
            this.dgvInList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInList_CellContentClick);
            this.dgvInList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInList_CellMouseUp);
            // 
            // dgvContextMenuStrip
            // 
            this.dgvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dgvContextMenuStrip.Name = "contextMenuStrip1";
            this.dgvContextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.clearAllToolStripMenuItem.Text = "清空";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // barcode
            // 
            this.barcode.HeaderText = "编码";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 90;
            // 
            // materialname
            // 
            this.materialname.HeaderText = "名称";
            this.materialname.Name = "materialname";
            this.materialname.ReadOnly = true;
            // 
            // specification
            // 
            this.specification.HeaderText = "规格类型";
            this.specification.Name = "specification";
            this.specification.ReadOnly = true;
            // 
            // specificationModle
            // 
            this.specificationModle.HeaderText = "规格名称";
            this.specificationModle.Name = "specificationModle";
            this.specificationModle.ReadOnly = true;
            // 
            // remainnum
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.remainnum.DefaultCellStyle = dataGridViewCellStyle1;
            this.remainnum.HeaderText = "库存数量";
            this.remainnum.Name = "remainnum";
            this.remainnum.ReadOnly = true;
            this.remainnum.Width = 80;
            // 
            // InNum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.InNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.InNum.HeaderText = "入库数量";
            this.InNum.Name = "InNum";
            this.InNum.Width = 80;
            // 
            // categoryone
            // 
            this.categoryone.HeaderText = "物料类别一";
            this.categoryone.Name = "categoryone";
            this.categoryone.ReadOnly = true;
            this.categoryone.Width = 90;
            // 
            // categorytwo
            // 
            this.categorytwo.HeaderText = "物料类别二";
            this.categorytwo.Name = "categorytwo";
            this.categorytwo.ReadOnly = true;
            this.categorytwo.Width = 90;
            // 
            // categorythree
            // 
            this.categorythree.HeaderText = "物料类别三";
            this.categorythree.Name = "categorythree";
            this.categorythree.ReadOnly = true;
            this.categorythree.Width = 90;
            // 
            // price
            // 
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // note
            // 
            this.note.HeaderText = "备注";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 80;
            // 
            // InMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInList)).EndInit();
            this.dgvContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCategoryTwo;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtCategoryThree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoryOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInList;
        private System.Windows.Forms.Button btnAddInMaterial;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip dgvContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnMaterialList;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationModle;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryone;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorytwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorythree;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}