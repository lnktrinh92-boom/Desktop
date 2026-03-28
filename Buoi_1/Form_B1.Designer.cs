namespace Buoi_1
{
    partial class Form_B1
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbListHoTen = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(28, 59);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(365, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // lbListHoTen
            // 
            this.lbListHoTen.FormattingEnabled = true;
            this.lbListHoTen.ItemHeight = 16;
            this.lbListHoTen.Location = new System.Drawing.Point(28, 107);
            this.lbListHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbListHoTen.Name = "lbListHoTen";
            this.lbListHoTen.Size = new System.Drawing.Size(491, 276);
            this.lbListHoTen.TabIndex = 1;
            this.lbListHoTen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(420, 59);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseClick);
            // 
            // Form_B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbListHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_B1";
            this.Text = "Buoi 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_B1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ListBox lbListHoTen;
        private System.Windows.Forms.Button btnAdd;
    }
}

