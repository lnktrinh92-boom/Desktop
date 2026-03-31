namespace Buoi_2
{
    partial class FormDinhDang
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
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.labelNhapTen = new System.Windows.Forms.Label();
            this.labelLapTrinhBoi = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRealTime = new System.Windows.Forms.CheckBox();
            this.buttonApplyAll = new System.Windows.Forms.Button();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.Location = new System.Drawing.Point(29, 72);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(212, 224);
            this.groupBoxColor.TabIndex = 0;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(18, 41);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(65, 29);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioButtonGreen.Location = new System.Drawing.Point(18, 86);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(84, 29);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(18, 130);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(69, 29);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(18, 176);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(78, 29);
            this.radioButtonBlack.TabIndex = 3;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            this.radioButtonBlack.CheckedChanged += new System.EventHandler(this.radioButtonBlack_CheckedChanged);
            // 
            // labelNhapTen
            // 
            this.labelNhapTen.AutoSize = true;
            this.labelNhapTen.BackColor = System.Drawing.Color.Black;
            this.labelNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapTen.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelNhapTen.Location = new System.Drawing.Point(24, 18);
            this.labelNhapTen.Name = "labelNhapTen";
            this.labelNhapTen.Size = new System.Drawing.Size(99, 25);
            this.labelNhapTen.TabIndex = 4;
            this.labelNhapTen.Text = "Nhập Tên";
            // 
            // labelLapTrinhBoi
            // 
            this.labelLapTrinhBoi.AutoSize = true;
            this.labelLapTrinhBoi.BackColor = System.Drawing.Color.Transparent;
            this.labelLapTrinhBoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLapTrinhBoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLapTrinhBoi.Location = new System.Drawing.Point(24, 387);
            this.labelLapTrinhBoi.Name = "labelLapTrinhBoi";
            this.labelLapTrinhBoi.Size = new System.Drawing.Size(134, 25);
            this.labelLapTrinhBoi.TabIndex = 5;
            this.labelLapTrinhBoi.Text = "Lập Trình Bởi:";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTen.Location = new System.Drawing.Point(171, 15);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(190, 30);
            this.textBoxTen.TabIndex = 6;
            this.textBoxTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFont.Controls.Add(this.checkBoxUnderline);
            this.groupBoxFont.Controls.Add(this.checkBoxItalic);
            this.groupBoxFont.Controls.Add(this.checkBoxBold);
            this.groupBoxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFont.Location = new System.Drawing.Point(305, 72);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(212, 224);
            this.groupBoxFont.TabIndex = 4;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Font";
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnderline.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxUnderline.Location = new System.Drawing.Point(24, 130);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(126, 29);
            this.checkBoxUnderline.TabIndex = 2;
            this.checkBoxUnderline.Text = "Gạch chân";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            this.checkBoxUnderline.CheckStateChanged += new System.EventHandler(this.checkBoxUnderline_CheckStateChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItalic.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxItalic.Location = new System.Drawing.Point(24, 86);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(148, 29);
            this.checkBoxItalic.TabIndex = 1;
            this.checkBoxItalic.Text = "Nghiêng Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckStateChanged += new System.EventHandler(this.checkBoxItalic_CheckStateChanged_1);
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBold.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxBold.Location = new System.Drawing.Point(24, 41);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(124, 29);
            this.checkBoxBold.TabIndex = 0;
            this.checkBoxBold.Text = "Đậm Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckStateChanged += new System.EventHandler(this.checkBoxBold_CheckStateChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.Color.Red;
            this.textBoxResult.Location = new System.Drawing.Point(171, 382);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(190, 30);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.Click += new System.EventHandler(this.textBoxResult_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.White;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Blue;
            this.buttonThoat.Location = new System.Drawing.Point(420, 434);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(97, 31);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonThoat_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApplyAll);
            this.groupBox1.Controls.Add(this.checkBoxRealTime);
            this.groupBox1.Location = new System.Drawing.Point(29, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBoxRealTime
            // 
            this.checkBoxRealTime.AutoSize = true;
            this.checkBoxRealTime.Location = new System.Drawing.Point(28, 20);
            this.checkBoxRealTime.Name = "checkBoxRealTime";
            this.checkBoxRealTime.Size = new System.Drawing.Size(74, 17);
            this.checkBoxRealTime.TabIndex = 0;
            this.checkBoxRealTime.Text = "Real Time";
            this.checkBoxRealTime.UseVisualStyleBackColor = true;
            // 
            // buttonApplyAll
            // 
            this.buttonApplyAll.Location = new System.Drawing.Point(300, 16);
            this.buttonApplyAll.Name = "buttonApplyAll";
            this.buttonApplyAll.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyAll.TabIndex = 1;
            this.buttonApplyAll.Text = "Apply All";
            this.buttonApplyAll.UseVisualStyleBackColor = true;
            this.buttonApplyAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonApplyAll_MouseClick);
            // 
            // FormDinhDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(549, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.labelLapTrinhBoi);
            this.Controls.Add(this.labelNhapTen);
            this.Controls.Add(this.groupBoxColor);
            this.Name = "FormDinhDang";
            this.Text = "Định Dạng (Formater)";
            this.Load += new System.EventHandler(this.FormDinhDang_Load);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.Label labelNhapTen;
        private System.Windows.Forms.Label labelLapTrinhBoi;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.CheckBox checkBoxUnderline;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonApplyAll;
        private System.Windows.Forms.CheckBox checkBoxRealTime;
    }
}

