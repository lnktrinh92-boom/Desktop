namespace Baitap_B1
{
    partial class Bai_2
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
            this.labelChooseTime = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.textContent = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listContent = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelChooseTime
            // 
            this.labelChooseTime.AutoSize = true;
            this.labelChooseTime.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseTime.ForeColor = System.Drawing.Color.White;
            this.labelChooseTime.Location = new System.Drawing.Point(24, 31);
            this.labelChooseTime.Name = "labelChooseTime";
            this.labelChooseTime.Size = new System.Drawing.Size(183, 29);
            this.labelChooseTime.TabIndex = 0;
            this.labelChooseTime.Text = "Chọn thời gian:";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.BackColor = System.Drawing.Color.Transparent;
            this.labelContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.ForeColor = System.Drawing.Color.White;
            this.labelContent.Location = new System.Drawing.Point(24, 90);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(184, 29);
            this.labelContent.TabIndex = 1;
            this.labelContent.Text = "Nội dung:         ";
            // 
            // textContent
            // 
            this.textContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContent.Location = new System.Drawing.Point(232, 97);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(297, 114);
            this.textContent.TabIndex = 3;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(312, 242);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(193, 53);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRemove_MouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(39, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(193, 53);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseClick);
            // 
            // listContent
            // 
            this.listContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContent.FormattingEnabled = true;
            this.listContent.ItemHeight = 20;
            this.listContent.Location = new System.Drawing.Point(29, 313);
            this.listContent.Name = "listContent";
            this.listContent.Size = new System.Drawing.Size(500, 164);
            this.listContent.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(232, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // Bai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 499);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listContent);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelChooseTime);
            this.Name = "Bai_2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Bai_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseTime;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listContent;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}