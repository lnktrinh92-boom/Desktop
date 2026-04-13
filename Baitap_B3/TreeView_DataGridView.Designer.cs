namespace Baitap_B3
{
    partial class TreeView_DataGridView
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
            this.labelSP = new System.Windows.Forms.Label();
            this.labelLoaiSP = new System.Windows.Forms.Label();
            this.treeViewLoai = new System.Windows.Forms.TreeView();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSP.Location = new System.Drawing.Point(337, 46);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(129, 29);
            this.labelSP.TabIndex = 8;
            this.labelSP.Text = "Sản phẩm";
            // 
            // labelLoaiSP
            // 
            this.labelLoaiSP.AutoSize = true;
            this.labelLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiSP.Location = new System.Drawing.Point(16, 46);
            this.labelLoaiSP.Name = "labelLoaiSP";
            this.labelLoaiSP.Size = new System.Drawing.Size(180, 29);
            this.labelLoaiSP.TabIndex = 7;
            this.labelLoaiSP.Text = "Loại sản phẩm";
            // 
            // treeViewLoai
            // 
            this.treeViewLoai.Location = new System.Drawing.Point(21, 100);
            this.treeViewLoai.Name = "treeViewLoai";
            this.treeViewLoai.Size = new System.Drawing.Size(300, 309);
            this.treeViewLoai.TabIndex = 9;
            this.treeViewLoai.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLoai_AfterSelect);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(342, 100);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(446, 309);
            this.dataGridViewSP.TabIndex = 10;
            // 
            // TreeView_DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.treeViewLoai);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelLoaiSP);
            this.Name = "TreeView_DataGridView";
            this.Text = "TreeView và DataGridView";
            this.Load += new System.EventHandler(this.TreeView_DataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelLoaiSP;
        private System.Windows.Forms.TreeView treeViewLoai;
        private System.Windows.Forms.DataGridView dataGridViewSP;
    }
}