namespace Baitap_B2
{
    partial class UC_va_UCLN
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
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.radioButtonUC = new System.Windows.Forms.RadioButton();
            this.radioButtonUCLN = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(125, 12);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(334, 45);
            this.textBoxNum1.TabIndex = 0;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(125, 86);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(334, 45);
            this.textBoxNum2.TabIndex = 1;
            this.textBoxNum2.TextChanged += new System.EventHandler(this.textBoxNum2_TextChanged);
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum1.Location = new System.Drawing.Point(2, 15);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(117, 39);
            this.labelNum1.TabIndex = 2;
            this.labelNum1.Text = "Num1:";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum2.Location = new System.Drawing.Point(2, 89);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(117, 39);
            this.labelNum2.TabIndex = 3;
            this.labelNum2.Text = "Num2:";
            // 
            // radioButtonUC
            // 
            this.radioButtonUC.AutoSize = true;
            this.radioButtonUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUC.Location = new System.Drawing.Point(9, 163);
            this.radioButtonUC.Name = "radioButtonUC";
            this.radioButtonUC.Size = new System.Drawing.Size(261, 43);
            this.radioButtonUC.TabIndex = 4;
            this.radioButtonUC.TabStop = true;
            this.radioButtonUC.Text = "Tìm ước chung";
            this.radioButtonUC.UseVisualStyleBackColor = true;
            this.radioButtonUC.CheckedChanged += new System.EventHandler(this.radioButtonUC_CheckedChanged);
            // 
            // radioButtonUCLN
            // 
            this.radioButtonUCLN.AutoSize = true;
            this.radioButtonUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUCLN.Location = new System.Drawing.Point(9, 221);
            this.radioButtonUCLN.Name = "radioButtonUCLN";
            this.radioButtonUCLN.Size = new System.Drawing.Size(391, 43);
            this.radioButtonUCLN.TabIndex = 5;
            this.radioButtonUCLN.TabStop = true;
            this.radioButtonUCLN.Text = "Tìm ước chung lớn nhất";
            this.radioButtonUCLN.UseVisualStyleBackColor = true;
            this.radioButtonUCLN.CheckedChanged += new System.EventHandler(this.radioButtonUCLN_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(12, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 232);
            this.listBox1.TabIndex = 6;
            // 
            // UC_va_UCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 533);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButtonUCLN);
            this.Controls.Add(this.radioButtonUC);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "UC_va_UCLN";
            this.Text = "UC_va_UCLN";
            this.Load += new System.EventHandler(this.UC_va_UCLN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.RadioButton radioButtonUC;
        private System.Windows.Forms.RadioButton radioButtonUCLN;
        private System.Windows.Forms.ListBox listBox1;
    }
}