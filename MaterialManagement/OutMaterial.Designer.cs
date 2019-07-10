namespace MaterialManagement
{
    partial class OutMaterial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutMaterial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMaterialList = new System.Windows.Forms.DataGridView();
            this.barcode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification1Modle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainnum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytwo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorythree1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMaterialList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWhereabouts = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnOutMaterial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvOutList = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationModle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whereabouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorythree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAlltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutList)).BeginInit();
            this.dgvContextMenuStrip.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 222);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMaterialList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 149);
            this.panel3.TabIndex = 42;
            // 
            // dgvMaterialList
            // 
            this.dgvMaterialList.AllowUserToAddRows = false;
            this.dgvMaterialList.AllowUserToDeleteRows = false;
            this.dgvMaterialList.AllowUserToOrderColumns = true;
            this.dgvMaterialList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode1,
            this.materialname1,
            this.specification1,
            this.specification1Modle,
            this.remainnum1,
            this.categoryone1,
            this.categorytwo1,
            this.categorythree1,
            this.price1,
            this.total1,
            this.note1});
            this.dgvMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialList.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvMaterialList.RowTemplate.Height = 30;
            this.dgvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialList.Size = new System.Drawing.Size(1145, 149);
            this.dgvMaterialList.TabIndex = 1;
            this.dgvMaterialList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterialList_CellMouseDoubleClick);
            // 
            // barcode1
            // 
            this.barcode1.HeaderText = "编码";
            this.barcode1.Name = "barcode1";
            this.barcode1.ReadOnly = true;
            this.barcode1.Width = 80;
            // 
            // materialname1
            // 
            this.materialname1.HeaderText = "名称";
            this.materialname1.Name = "materialname1";
            this.materialname1.ReadOnly = true;
            // 
            // specification1
            // 
            this.specification1.HeaderText = "规格类型";
            this.specification1.Name = "specification1";
            this.specification1.ReadOnly = true;
            this.specification1.Width = 110;
            // 
            // specification1Modle
            // 
            this.specification1Modle.HeaderText = "规格名称";
            this.specification1Modle.Name = "specification1Modle";
            this.specification1Modle.ReadOnly = true;
            this.specification1Modle.Width = 110;
            // 
            // remainnum1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue;
            this.remainnum1.DefaultCellStyle = dataGridViewCellStyle7;
            this.remainnum1.HeaderText = "库存数量";
            this.remainnum1.Name = "remainnum1";
            this.remainnum1.ReadOnly = true;
            this.remainnum1.Width = 80;
            // 
            // categoryone1
            // 
            this.categoryone1.HeaderText = "物料类别一";
            this.categoryone1.Name = "categoryone1";
            this.categoryone1.ReadOnly = true;
            this.categoryone1.Width = 110;
            // 
            // categorytwo1
            // 
            this.categorytwo1.HeaderText = "物料类别二";
            this.categorytwo1.Name = "categorytwo1";
            this.categorytwo1.ReadOnly = true;
            this.categorytwo1.Width = 110;
            // 
            // categorythree1
            // 
            this.categorythree1.HeaderText = "物料类别三";
            this.categorythree1.Name = "categorythree1";
            this.categorythree1.ReadOnly = true;
            this.categorythree1.Width = 110;
            // 
            // price1
            // 
            this.price1.HeaderText = "单价";
            this.price1.Name = "price1";
            // 
            // total1
            // 
            this.total1.HeaderText = "总价";
            this.total1.Name = "total1";
            // 
            // note1
            // 
            this.note1.HeaderText = "备注";
            this.note1.Name = "note1";
            this.note1.ReadOnly = true;
            this.note1.Width = 70;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaterialList);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtAddCount);
            this.panel4.Controls.Add(this.btnQuery);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtWhereabouts);
            this.panel4.Controls.Add(this.txtQuery);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1145, 73);
            this.panel4.TabIndex = 41;
            // 
            // btnMaterialList
            // 
            this.btnMaterialList.Location = new System.Drawing.Point(12, 8);
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
            this.btnClose.Location = new System.Drawing.Point(1009, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 45);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "关闭窗口 ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(877, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 39);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "增加到出库列表";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(435, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 52;
            this.label4.Text = "[出库数量]：";
            // 
            // txtAddCount
            // 
            this.txtAddCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddCount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddCount.Location = new System.Drawing.Point(562, 27);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(70, 35);
            this.txtAddCount.TabIndex = 51;
            this.txtAddCount.Text = "0";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(349, 23);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 37);
            this.btnQuery.TabIndex = 49;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(640, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "客户名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "库存查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWhereabouts
            // 
            this.txtWhereabouts.Location = new System.Drawing.Point(703, 31);
            this.txtWhereabouts.Name = "txtWhereabouts";
            this.txtWhereabouts.Size = new System.Drawing.Size(157, 21);
            this.txtWhereabouts.TabIndex = 48;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(161, 31);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(157, 21);
            this.txtQuery.TabIndex = 48;
            // 
            // btnOutMaterial
            // 
            this.btnOutMaterial.ForeColor = System.Drawing.Color.Red;
            this.btnOutMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnOutMaterial.Image")));
            this.btnOutMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutMaterial.Location = new System.Drawing.Point(637, 5);
            this.btnOutMaterial.Name = "btnOutMaterial";
            this.btnOutMaterial.Size = new System.Drawing.Size(107, 39);
            this.btnOutMaterial.TabIndex = 53;
            this.btnOutMaterial.Text = "确认物料出库";
            this.btnOutMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutMaterial.UseVisualStyleBackColor = false;
            this.btnOutMaterial.Click += new System.EventHandler(this.btnOutMaterial_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 364);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvOutList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1145, 314);
            this.panel6.TabIndex = 3;
            // 
            // dgvOutList
            // 
            this.dgvOutList.AllowUserToAddRows = false;
            this.dgvOutList.AllowUserToDeleteRows = false;
            this.dgvOutList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.materialname,
            this.specification,
            this.specificationModle,
            this.remainnum,
            this.InNum,
            this.whereabouts,
            this.categoryone,
            this.categorytwo,
            this.categorythree,
            this.price,
            this.total,
            this.note});
            this.dgvOutList.ContextMenuStrip = this.dgvContextMenuStrip;
            this.dgvOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutList.Location = new System.Drawing.Point(0, 0);
            this.dgvOutList.Name = "dgvOutList";
            this.dgvOutList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvOutList.RowTemplate.Height = 30;
            this.dgvOutList.Size = new System.Drawing.Size(1145, 314);
            this.dgvOutList.TabIndex = 2;
            this.dgvOutList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOutList_CellMouseUp);
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
            this.materialname.Width = 70;
            // 
            // specification
            // 
            this.specification.HeaderText = "规格类型";
            this.specification.Name = "specification";
            this.specification.ReadOnly = true;
            this.specification.Width = 110;
            // 
            // specificationModle
            // 
            this.specificationModle.HeaderText = "规格名称";
            this.specificationModle.Name = "specificationModle";
            this.specificationModle.ReadOnly = true;
            this.specificationModle.Width = 110;
            // 
            // remainnum
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            this.remainnum.DefaultCellStyle = dataGridViewCellStyle8;
            this.remainnum.HeaderText = "库存数量";
            this.remainnum.Name = "remainnum";
            this.remainnum.ReadOnly = true;
            this.remainnum.Width = 80;
            // 
            // InNum
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            this.InNum.DefaultCellStyle = dataGridViewCellStyle9;
            this.InNum.HeaderText = "出库数量";
            this.InNum.Name = "InNum";
            this.InNum.ReadOnly = true;
            this.InNum.Width = 80;
            // 
            // whereabouts
            // 
            this.whereabouts.HeaderText = "客户名称";
            this.whereabouts.Name = "whereabouts";
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
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "总价";
            this.total.Name = "total";
            this.total.Width = 80;
            // 
            // note
            // 
            this.note.HeaderText = "备注";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 60;
            // 
            // dgvContextMenuStrip
            // 
            this.dgvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAlltoolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dgvContextMenuStrip.Name = "dgvContextMenuStrip";
            this.dgvContextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // clearAlltoolStripMenuItem
            // 
            this.clearAlltoolStripMenuItem.Name = "clearAlltoolStripMenuItem";
            this.clearAlltoolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.clearAlltoolStripMenuItem.Text = "清空";
            this.clearAlltoolStripMenuItem.Click += new System.EventHandler(this.clearAlltoolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnOutMaterial);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1145, 50);
            this.panel5.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(796, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 36);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "导出";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "物料出库信息：";
            // 
            // OutMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OutMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutMaterial";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutList)).EndInit();
            this.dgvContextMenuStrip.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOutMaterial;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvOutList;
        private System.Windows.Forms.ContextMenuStrip dgvContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearAlltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnMaterialList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWhereabouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification1Modle;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainnum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorytwo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorythree1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn note1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationModle;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn whereabouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryone;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorytwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorythree;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button btnPrint;
    }
}