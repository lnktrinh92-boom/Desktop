namespace Baitap_B3
{
    partial class DuaDuLieuVaoDataGridView
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
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSP.Location = new System.Drawing.Point(53, 55);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(390, 39);
            this.labelSP.TabIndex = 1;
            this.labelSP.Text = "DANH MỤC SẢN PHẨM";
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(60, 123);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(696, 265);
            this.dataGridViewSP.TabIndex = 2;
            // 
            // DuaDuLieuVaoDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.labelSP);
            this.Name = "DuaDuLieuVaoDataGridView";
            this.Text = "Đưa dữ liệu vào DataGridView";
            this.Load += new System.EventHandler(this.DuaDuLieuVaoDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.DataGridView dataGridViewSP;
    }
}