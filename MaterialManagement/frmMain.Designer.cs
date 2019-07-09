namespace MaterialManagement
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnHistory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvMaterialList = new System.Windows.Forms.DataGridView();
            this.dgvContentMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInfoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnOutMaterial = new System.Windows.Forms.Button();
            this.btnInMaterial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMaterialList = new System.Windows.Forms.Button();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationmodle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorythree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).BeginInit();
            this.dgvContentMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHistory.Location = new System.Drawing.Point(994, 16);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(116, 53);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "出入库记录查询";
            btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1480, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 562);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 83);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMaterialList);
            this.splitContainer1.Size = new System.Drawing.Size(1480, 479);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvMaterialList
            // 
            this.dgvMaterialList.AllowUserToAddRows = false;
            this.dgvMaterialList.AllowUserToDeleteRows = false;
            this.dgvMaterialList.AllowUserToOrderColumns = true;
            this.dgvMaterialList.AllowUserToResizeRows = false;
            this.dgvMaterialList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.materialname,
            this.supplier,
            this.specification,
            this.specificationmodle,
            this.remainnum,
            this.categoryone,
            this.categorytwo,
            this.categorythree,
            this.price,
            this.total,
            this.note,
            this.warn});
            this.dgvMaterialList.ContextMenuStrip = this.dgvContentMenuStrip;
            this.dgvMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialList.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.ReadOnly = true;
            this.dgvMaterialList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvMaterialList.RowTemplate.Height = 30;
            this.dgvMaterialList.Size = new System.Drawing.Size(1250, 479);
            this.dgvMaterialList.TabIndex = 2;
            this.dgvMaterialList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterialList_CellMouseDoubleClick);
            this.dgvMaterialList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterialList_CellMouseUp);
            // 
            // dgvContentMenuStrip
            // 
            this.dgvContentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllMenuItem,
            this.deleteMenuItem,
            this.modifyInfoStripMenuItem1});
            this.dgvContentMenuStrip.Name = "dgvContentMenuStrip";
            this.dgvContentMenuStrip.Size = new System.Drawing.Size(125, 70);
            this.dgvContentMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.dgvContentMenuStrip_Opening);
            // 
            // clearAllMenuItem
            // 
            this.clearAllMenuItem.Name = "clearAllMenuItem";
            this.clearAllMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearAllMenuItem.Text = "清空";
            this.clearAllMenuItem.Click += new System.EventHandler(this.clearAllMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteMenuItem.Text = "删除";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // modifyInfoStripMenuItem1
            // 
            this.modifyInfoStripMenuItem1.Enabled = false;
            this.modifyInfoStripMenuItem1.Name = "modifyInfoStripMenuItem1";
            this.modifyInfoStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.modifyInfoStripMenuItem1.Text = "修改信息";
            this.modifyInfoStripMenuItem1.Click += new System.EventHandler(this.modifyInfoStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbQuery);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.txtQuery);
            this.panel2.Controls.Add(btnHistory);
            this.panel2.Controls.Add(this.btnOutMaterial);
            this.panel2.Controls.Add(this.btnInMaterial);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1480, 83);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(107, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "库存查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbQuery
            // 
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Items.AddRange(new object[] {
            "快速查询",
            "编码",
            "类别一",
            "类别二",
            "类别三",
            "物料名称",
            "物料规格",
            "供应商",
            "总价",
            "数量",
            "单价"});
            this.cmbQuery.Location = new System.Drawing.Point(189, 38);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(121, 20);
            this.cmbQuery.TabIndex = 12;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(514, 27);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 37);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(322, 37);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(169, 21);
            this.txtQuery.TabIndex = 10;
            // 
            // btnOutMaterial
            // 
            this.btnOutMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnOutMaterial.Image")));
            this.btnOutMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutMaterial.Location = new System.Drawing.Point(837, 16);
            this.btnOutMaterial.Name = "btnOutMaterial";
            this.btnOutMaterial.Size = new System.Drawing.Size(116, 53);
            this.btnOutMaterial.TabIndex = 8;
            this.btnOutMaterial.Text = "出库";
            this.btnOutMaterial.UseVisualStyleBackColor = true;
            this.btnOutMaterial.Click += new System.EventHandler(this.btnOutMaterial_Click);
            // 
            // btnInMaterial
            // 
            this.btnInMaterial.Font = new System.Drawing.Font("宋体", 9F);
            this.btnInMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnInMaterial.Image")));
            this.btnInMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInMaterial.Location = new System.Drawing.Point(667, 16);
            this.btnInMaterial.Name = "btnInMaterial";
            this.btnInMaterial.Size = new System.Drawing.Size(129, 53);
            this.btnInMaterial.TabIndex = 9;
            this.btnInMaterial.Text = "入库";
            this.btnInMaterial.UseVisualStyleBackColor = true;
            this.btnInMaterial.Click += new System.EventHandler(this.btnInMaterial_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnMaterialList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1480, 83);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1116, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 53);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "导出";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMaterialList
            // 
            this.btnMaterialList.Location = new System.Drawing.Point(6, 12);
            this.btnMaterialList.Name = "btnMaterialList";
            this.btnMaterialList.Size = new System.Drawing.Size(75, 59);
            this.btnMaterialList.TabIndex = 0;
            this.btnMaterialList.Text = "物料列表";
            this.btnMaterialList.UseVisualStyleBackColor = true;
            this.btnMaterialList.Visible = false;
            this.btnMaterialList.Click += new System.EventHandler(this.btnMaterialList_Click);
            // 
            // barcode
            // 
            this.barcode.HeaderText = "编码";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 60;
            // 
            // materialname
            // 
            this.materialname.HeaderText = "名称";
            this.materialname.Name = "materialname";
            this.materialname.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "供应商";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // specification
            // 
            this.specification.HeaderText = "规格类型";
            this.specification.Name = "specification";
            this.specification.ReadOnly = true;
            // 
            // specificationmodle
            // 
            this.specificationmodle.HeaderText = "规格名称";
            this.specificationmodle.Name = "specificationmodle";
            this.specificationmodle.ReadOnly = true;
            // 
            // remainnum
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.remainnum.DefaultCellStyle = dataGridViewCellStyle1;
            this.remainnum.HeaderText = "库存数量";
            this.remainnum.Name = "remainnum";
            this.remainnum.ReadOnly = true;
            this.remainnum.Width = 90;
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
            this.price.ReadOnly = true;
            this.price.Width = 40;
            // 
            // total
            // 
            this.total.HeaderText = "总价";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 40;
            // 
            // note
            // 
            this.note.HeaderText = "备注";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 90;
            // 
            // warn
            // 
            this.warn.HeaderText = "阈警";
            this.warn.Name = "warn";
            this.warn.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料管理";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).EndInit();
            this.dgvContentMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip dgvContentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyInfoStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnOutMaterial;
        private System.Windows.Forms.Button btnInMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMaterialList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationmodle;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryone;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorytwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorythree;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn warn;
    }
}

