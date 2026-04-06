namespace Baitap_B2
{
    partial class XuLyChuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuLyChuoi));
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKQ = new System.Windows.Forms.Label();
            this.buttonCompareLower = new System.Windows.Forms.Button();
            this.buttonConcat = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSubstring = new System.Windows.Forms.Button();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.buttonCOMPAREUpper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.Location = new System.Drawing.Point(22, 9);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(646, 39);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "        CHƯƠNG TRÌNH XỬ LÝ CHUỖI       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập vào chuỗi thứ nhất:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 36);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(87, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 36);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập vào chuỗi thứ hai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả:";
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.BackColor = System.Drawing.Color.LemonChiffon;
            this.labelKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQ.Location = new System.Drawing.Point(24, 310);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(661, 87);
            this.labelKQ.TabIndex = 7;
            this.labelKQ.Text = resources.GetString("labelKQ.Text");
            // 
            // buttonCompareLower
            // 
            this.buttonCompareLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompareLower.Location = new System.Drawing.Point(29, 413);
            this.buttonCompareLower.Name = "buttonCompareLower";
            this.buttonCompareLower.Size = new System.Drawing.Size(155, 43);
            this.buttonCompareLower.TabIndex = 8;
            this.buttonCompareLower.Text = "Compare";
            this.buttonCompareLower.UseVisualStyleBackColor = true;
            this.buttonCompareLower.Click += new System.EventHandler(this.buttonCompareLower_Click);
            // 
            // buttonConcat
            // 
            this.buttonConcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcat.Location = new System.Drawing.Point(190, 413);
            this.buttonConcat.Name = "buttonConcat";
            this.buttonConcat.Size = new System.Drawing.Size(155, 43);
            this.buttonConcat.TabIndex = 9;
            this.buttonConcat.Text = "Concat";
            this.buttonConcat.UseVisualStyleBackColor = true;
            this.buttonConcat.Click += new System.EventHandler(this.buttonConcat_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(351, 413);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(155, 43);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(512, 413);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 43);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(512, 462);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(155, 43);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Dừng";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSubstring
            // 
            this.buttonSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubstring.Location = new System.Drawing.Point(351, 462);
            this.buttonSubstring.Name = "buttonSubstring";
            this.buttonSubstring.Size = new System.Drawing.Size(155, 43);
            this.buttonSubstring.TabIndex = 14;
            this.buttonSubstring.Text = "Substring";
            this.buttonSubstring.UseVisualStyleBackColor = true;
            this.buttonSubstring.Click += new System.EventHandler(this.buttonSubstring_Click);
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexOf.Location = new System.Drawing.Point(190, 462);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.Size = new System.Drawing.Size(155, 43);
            this.buttonIndexOf.TabIndex = 13;
            this.buttonIndexOf.Text = "IndexOf";
            this.buttonIndexOf.UseVisualStyleBackColor = true;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // buttonCOMPAREUpper
            // 
            this.buttonCOMPAREUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCOMPAREUpper.Location = new System.Drawing.Point(29, 462);
            this.buttonCOMPAREUpper.Name = "buttonCOMPAREUpper";
            this.buttonCOMPAREUpper.Size = new System.Drawing.Size(155, 43);
            this.buttonCOMPAREUpper.TabIndex = 12;
            this.buttonCOMPAREUpper.Text = "COMPARE";
            this.buttonCOMPAREUpper.UseVisualStyleBackColor = true;
            this.buttonCOMPAREUpper.Click += new System.EventHandler(this.buttonCOMPAREUpper_Click);
            // 
            // XuLyChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 518);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSubstring);
            this.Controls.Add(this.buttonIndexOf);
            this.Controls.Add(this.buttonCOMPAREUpper);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonConcat);
            this.Controls.Add(this.buttonCompareLower);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTieuDe);
            this.Name = "XuLyChuoi";
            this.Text = "Xử lý chuỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKQ;
        private System.Windows.Forms.Button buttonCompareLower;
        private System.Windows.Forms.Button buttonConcat;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSubstring;
        private System.Windows.Forms.Button buttonIndexOf;
        private System.Windows.Forms.Button buttonCOMPAREUpper;
    }
}