namespace Baitap_B3
{
    partial class Filter
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
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(27, 131);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(100, 29);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Kết quả";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(27, 53);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(239, 29);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Chọn loại sản phẩm";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(272, 50);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(339, 37);
            this.comboBoxFilter.TabIndex = 7;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(635, 49);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(114, 37);
            this.buttonLoc.TabIndex = 8;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(32, 183);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(717, 238);
            this.dataGridViewSP.TabIndex = 9;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInput);
            this.Name = "Filter";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.DataGridView dataGridViewSP;
    }
}