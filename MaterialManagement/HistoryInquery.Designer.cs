namespace MaterialManagement
{
    partial class HistoryInquery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryInquery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOutList = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationModle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inouttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inoutnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whereabouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbQuery);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 86);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbQuery
            // 
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Items.AddRange(new object[] {
            "编码",
            "物料名称",
            "物料规格",
            "出入库类型",
            "操作人"});
            this.cmbQuery.Location = new System.Drawing.Point(137, 12);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(127, 20);
            this.cmbQuery.TabIndex = 15;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(273, 12);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(149, 21);
            this.txtQuery.TabIndex = 14;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(294, 48);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(128, 21);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(760, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 53);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(472, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 49);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查  询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(136, 48);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(128, 21);
            this.dateTimeStart.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出入库查询类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出入库查询日期";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOutList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 385);
            this.panel2.TabIndex = 1;
            // 
            // dgvOutList
            // 
            this.dgvOutList.AllowUserToAddRows = false;
            this.dgvOutList.AllowUserToDeleteRows = false;
            this.dgvOutList.AllowUserToOrderColumns = true;
            this.dgvOutList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.materialname,
            this.specification,
            this.specificationModle,
            this.inouttype,
            this.inoutnum,
            this.operatetime,
            this.operater,
            this.whereabouts});
            this.dgvOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutList.Location = new System.Drawing.Point(0, 0);
            this.dgvOutList.Name = "dgvOutList";
            this.dgvOutList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvOutList.RowTemplate.Height = 30;
            this.dgvOutList.Size = new System.Drawing.Size(1194, 385);
            this.dgvOutList.TabIndex = 3;
            this.dgvOutList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutList_CellContentClick);
            // 
            // barcode
            // 
            this.barcode.HeaderText = "编码";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // materialname
            // 
            this.materialname.HeaderText = "名称";
            this.materialname.Name = "materialname";
            this.materialname.ReadOnly = true;
            this.materialname.Width = 150;
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
            // inouttype
            // 
            this.inouttype.HeaderText = "出入库类型";
            this.inouttype.Name = "inouttype";
            this.inouttype.Width = 90;
            // 
            // inoutnum
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.inoutnum.DefaultCellStyle = dataGridViewCellStyle1;
            this.inoutnum.HeaderText = "数量";
            this.inoutnum.Name = "inoutnum";
            this.inoutnum.ReadOnly = true;
            this.inoutnum.Width = 80;
            // 
            // operatetime
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.operatetime.DefaultCellStyle = dataGridViewCellStyle2;
            this.operatetime.HeaderText = "时间";
            this.operatetime.Name = "operatetime";
            this.operatetime.Width = 120;
            // 
            // operater
            // 
            this.operater.HeaderText = "操作人";
            this.operater.Name = "operater";
            this.operater.ReadOnly = true;
            // 
            // whereabouts
            // 
            this.whereabouts.HeaderText = "出库去向";
            this.whereabouts.Name = "whereabouts";
            this.whereabouts.Width = 110;
            // 
            // HistoryInquery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryInquery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出入库历史查询";
            this.Load += new System.EventHandler(this.HistoryInquery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOutList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationModle;
        private System.Windows.Forms.DataGridViewTextBoxColumn inouttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn inoutnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn operater;
        private System.Windows.Forms.DataGridViewTextBoxColumn whereabouts;
    }
}