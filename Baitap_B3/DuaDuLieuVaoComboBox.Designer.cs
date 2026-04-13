namespace Baitap_B3
{
    partial class DuaDuLieuVaoComboBox
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
            this.comboBoxSP = new System.Windows.Forms.ComboBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSP.Location = new System.Drawing.Point(50, 56);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(390, 39);
            this.labelSP.TabIndex = 0;
            this.labelSP.Text = "DANH MỤC SẢN PHẨM";
            // 
            // comboBoxSP
            // 
            this.comboBoxSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSP.FormattingEnabled = true;
            this.comboBoxSP.Location = new System.Drawing.Point(57, 136);
            this.comboBoxSP.Name = "comboBoxSP";
            this.comboBoxSP.Size = new System.Drawing.Size(469, 37);
            this.comboBoxSP.TabIndex = 1;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(580, 122);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(160, 58);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // DuaDuLieuVaoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.comboBoxSP);
            this.Controls.Add(this.labelSP);
            this.Name = "DuaDuLieuVaoComboBox";
            this.Text = "Đưa dữ liệu vào ComboBox";
            this.Load += new System.EventHandler(this.DuaDuLieuVaoComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.ComboBox comboBoxSP;
        private System.Windows.Forms.Button buttonThoat;
    }
}