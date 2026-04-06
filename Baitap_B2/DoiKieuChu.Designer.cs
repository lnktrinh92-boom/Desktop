namespace Baitap_B2
{
    partial class DoiKieuChu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxFontStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonLower = new System.Windows.Forms.RadioButton();
            this.radioButtonUpper = new System.Windows.Forms.RadioButton();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxFontStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(311, 6);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(372, 45);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(271, 39);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Nhập họ và tên:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(580, 88);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 159);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(311, 265);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(372, 45);
            this.textBoxResult.TabIndex = 4;
            this.textBoxResult.Click += new System.EventHandler(this.textBoxResult_Click);
            // 
            // groupBoxFontStyle
            // 
            this.groupBoxFontStyle.Controls.Add(this.radioButtonUpper);
            this.groupBoxFontStyle.Controls.Add(this.radioButtonLower);
            this.groupBoxFontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFontStyle.Location = new System.Drawing.Point(19, 70);
            this.groupBoxFontStyle.Name = "groupBoxFontStyle";
            this.groupBoxFontStyle.Size = new System.Drawing.Size(555, 177);
            this.groupBoxFontStyle.TabIndex = 5;
            this.groupBoxFontStyle.TabStop = false;
            this.groupBoxFontStyle.Text = "Chọn kiểu chữ";
            // 
            // radioButtonLower
            // 
            this.radioButtonLower.AutoSize = true;
            this.radioButtonLower.Location = new System.Drawing.Point(6, 56);
            this.radioButtonLower.Name = "radioButtonLower";
            this.radioButtonLower.Size = new System.Drawing.Size(206, 43);
            this.radioButtonLower.TabIndex = 0;
            this.radioButtonLower.TabStop = true;
            this.radioButtonLower.Text = "chữ thường";
            this.radioButtonLower.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpper
            // 
            this.radioButtonUpper.AutoSize = true;
            this.radioButtonUpper.Location = new System.Drawing.Point(6, 115);
            this.radioButtonUpper.Name = "radioButtonUpper";
            this.radioButtonUpper.Size = new System.Drawing.Size(240, 43);
            this.radioButtonUpper.TabIndex = 1;
            this.radioButtonUpper.TabStop = true;
            this.radioButtonUpper.Text = "CHỮ IN HOA";
            this.radioButtonUpper.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(19, 265);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(246, 45);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Kết quả";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // DoiKieuChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 322);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxFontStyle);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "DoiKieuChu";
            this.Text = "Đổi kiểu chữ";
            this.groupBoxFontStyle.ResumeLayout(false);
            this.groupBoxFontStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxFontStyle;
        private System.Windows.Forms.RadioButton radioButtonUpper;
        private System.Windows.Forms.RadioButton radioButtonLower;
        private System.Windows.Forms.Button buttonResult;
    }
}