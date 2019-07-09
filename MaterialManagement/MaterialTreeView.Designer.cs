namespace MaterialManagement
{
    partial class MaterialTreeView
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
            this.materiaTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // materiaTreeView
            // 
            this.materiaTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materiaTreeView.Location = new System.Drawing.Point(0, 0);
            this.materiaTreeView.Name = "materiaTreeView";
            this.materiaTreeView.ShowNodeToolTips = true;
            this.materiaTreeView.Size = new System.Drawing.Size(310, 524);
            this.materiaTreeView.TabIndex = 0;
            this.materiaTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.materiaTreeView_AfterSelect);
            this.materiaTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.materiaTreeView_NodeMouseDoubleClick);
            // 
            // MaterialTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 524);
            this.Controls.Add(this.materiaTreeView);
            this.Name = "MaterialTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaterialTreeView";
            this.Load += new System.EventHandler(this.MaterialTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView materiaTreeView;
    }
}