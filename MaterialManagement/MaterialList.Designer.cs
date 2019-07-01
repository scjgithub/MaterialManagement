namespace MaterialManagement
{
    partial class MaterialList
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
            this.listBoxCateOne = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxCateTwo = new System.Windows.Forms.ListBox();
            this.listBoxCateThree = new System.Windows.Forms.ListBox();
            this.listBoxCateFour = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCateOne
            // 
            this.listBoxCateOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxCateOne.FormattingEnabled = true;
            this.listBoxCateOne.ItemHeight = 12;
            this.listBoxCateOne.Location = new System.Drawing.Point(0, 0);
            this.listBoxCateOne.Name = "listBoxCateOne";
            this.listBoxCateOne.Size = new System.Drawing.Size(154, 446);
            this.listBoxCateOne.TabIndex = 0;
            this.listBoxCateOne.DoubleClick += new System.EventHandler(this.listBoxCateOne_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxCateFour);
            this.panel1.Controls.Add(this.listBoxCateThree);
            this.panel1.Controls.Add(this.listBoxCateTwo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 446);
            this.panel1.TabIndex = 1;
            // 
            // listBoxCateTwo
            // 
            this.listBoxCateTwo.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxCateTwo.FormattingEnabled = true;
            this.listBoxCateTwo.ItemHeight = 12;
            this.listBoxCateTwo.Location = new System.Drawing.Point(0, 0);
            this.listBoxCateTwo.Name = "listBoxCateTwo";
            this.listBoxCateTwo.Size = new System.Drawing.Size(161, 446);
            this.listBoxCateTwo.TabIndex = 0;
            this.listBoxCateTwo.DoubleClick += new System.EventHandler(this.listBoxCateTwo_DoubleClick);
            // 
            // listBoxCateThree
            // 
            this.listBoxCateThree.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxCateThree.FormattingEnabled = true;
            this.listBoxCateThree.ItemHeight = 12;
            this.listBoxCateThree.Location = new System.Drawing.Point(161, 0);
            this.listBoxCateThree.Name = "listBoxCateThree";
            this.listBoxCateThree.Size = new System.Drawing.Size(172, 446);
            this.listBoxCateThree.TabIndex = 1;
            this.listBoxCateThree.DoubleClick += new System.EventHandler(this.listBoxCateThree_DoubleClick);
            // 
            // listBoxCateFour
            // 
            this.listBoxCateFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCateFour.FormattingEnabled = true;
            this.listBoxCateFour.ItemHeight = 12;
            this.listBoxCateFour.Location = new System.Drawing.Point(333, 0);
            this.listBoxCateFour.Name = "listBoxCateFour";
            this.listBoxCateFour.Size = new System.Drawing.Size(264, 446);
            this.listBoxCateFour.TabIndex = 2;
            this.listBoxCateFour.DoubleClick += new System.EventHandler(this.listBoxCateFour_DoubleClick);
            this.listBoxCateFour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxCateFour_MouseMove);
            // 
            // MaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxCateOne);
            this.Name = "MaterialList";
            this.Text = "MaterialList";
            this.Load += new System.EventHandler(this.MaterialList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCateOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxCateTwo;
        private System.Windows.Forms.ListBox listBoxCateFour;
        private System.Windows.Forms.ListBox listBoxCateThree;
    }
}