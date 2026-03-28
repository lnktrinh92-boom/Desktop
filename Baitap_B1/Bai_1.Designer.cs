namespace Baitap_B1
{
    partial class Bai_1
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
            this.panel_num = new System.Windows.Forms.Panel();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.radioButton_Nhân = new System.Windows.Forms.RadioButton();
            this.radioButton_Chia = new System.Windows.Forms.RadioButton();
            this.radioButton_Trừ = new System.Windows.Forms.RadioButton();
            this.radioButton_Cộng = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_num.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_num
            // 
            this.panel_num.BackColor = System.Drawing.Color.Gray;
            this.panel_num.Controls.Add(this.textNum2);
            this.panel_num.Controls.Add(this.textNum1);
            this.panel_num.Controls.Add(this.Num2);
            this.panel_num.Controls.Add(this.Num1);
            this.panel_num.Location = new System.Drawing.Point(12, 12);
            this.panel_num.Name = "panel_num";
            this.panel_num.Size = new System.Drawing.Size(331, 107);
            this.panel_num.TabIndex = 0;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(150, 66);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(163, 22);
            this.textNum2.TabIndex = 3;
            this.textNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum2_KeyPress);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(150, 20);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(163, 22);
            this.textNum1.TabIndex = 2;
            this.textNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum1_KeyPress);
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(15, 59);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(81, 29);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "Num2";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(15, 13);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(81, 29);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Num1";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Snow;
            this.Result.Location = new System.Drawing.Point(27, 327);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(115, 29);
            this.Result.TabIndex = 11;
            this.Result.Text = "Kết quả:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.IndianRed;
            this.labelResult.Location = new System.Drawing.Point(157, 327);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(83, 29);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "..........";
            // 
            // radioButton_Nhân
            // 
            this.radioButton_Nhân.AutoSize = true;
            this.radioButton_Nhân.Location = new System.Drawing.Point(180, 39);
            this.radioButton_Nhân.Name = "radioButton_Nhân";
            this.radioButton_Nhân.Size = new System.Drawing.Size(94, 33);
            this.radioButton_Nhân.TabIndex = 9;
            this.radioButton_Nhân.TabStop = true;
            this.radioButton_Nhân.Text = "Nhân";
            this.radioButton_Nhân.UseVisualStyleBackColor = true;
            this.radioButton_Nhân.CheckedChanged += new System.EventHandler(this.radioButton_Nhân_CheckedChanged);
            // 
            // radioButton_Chia
            // 
            this.radioButton_Chia.AutoSize = true;
            this.radioButton_Chia.Location = new System.Drawing.Point(180, 88);
            this.radioButton_Chia.Name = "radioButton_Chia";
            this.radioButton_Chia.Size = new System.Drawing.Size(86, 33);
            this.radioButton_Chia.TabIndex = 10;
            this.radioButton_Chia.TabStop = true;
            this.radioButton_Chia.Text = "Chia";
            this.radioButton_Chia.UseVisualStyleBackColor = true;
            this.radioButton_Chia.CheckedChanged += new System.EventHandler(this.radioButton_Chia_CheckedChanged);
            // 
            // radioButton_Trừ
            // 
            this.radioButton_Trừ.AutoSize = true;
            this.radioButton_Trừ.Location = new System.Drawing.Point(25, 88);
            this.radioButton_Trừ.Name = "radioButton_Trừ";
            this.radioButton_Trừ.Size = new System.Drawing.Size(71, 33);
            this.radioButton_Trừ.TabIndex = 8;
            this.radioButton_Trừ.TabStop = true;
            this.radioButton_Trừ.Text = "Trừ";
            this.radioButton_Trừ.UseVisualStyleBackColor = true;
            this.radioButton_Trừ.CheckedChanged += new System.EventHandler(this.radioButton_Trừ_CheckedChanged);
            // 
            // radioButton_Cộng
            // 
            this.radioButton_Cộng.AutoSize = true;
            this.radioButton_Cộng.Location = new System.Drawing.Point(23, 39);
            this.radioButton_Cộng.Name = "radioButton_Cộng";
            this.radioButton_Cộng.Size = new System.Drawing.Size(94, 33);
            this.radioButton_Cộng.TabIndex = 7;
            this.radioButton_Cộng.TabStop = true;
            this.radioButton_Cộng.Text = "Cộng";
            this.radioButton_Cộng.UseVisualStyleBackColor = true;
            this.radioButton_Cộng.CheckedChanged += new System.EventHandler(this.radioButton_Cộng_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.radioButton_Cộng);
            this.groupBox1.Controls.Add(this.radioButton_Trừ);
            this.groupBox1.Controls.Add(this.radioButton_Chia);
            this.groupBox1.Controls.Add(this.radioButton_Nhân);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép Toán";
            // 
            // Bai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(355, 393);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_num);
            this.Name = "Bai_1";
            this.Text = "Bài 1";
            this.panel_num.ResumeLayout(false);
            this.panel_num.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_num;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RadioButton radioButton_Nhân;
        private System.Windows.Forms.RadioButton radioButton_Chia;
        private System.Windows.Forms.RadioButton radioButton_Trừ;
        private System.Windows.Forms.RadioButton radioButton_Cộng;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

