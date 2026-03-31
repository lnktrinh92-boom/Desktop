namespace Buoi_2
{
    partial class StackDelete
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.buttonDeleteLeft = new System.Windows.Forms.Button();
            this.buttonDeleteRight = new System.Windows.Forms.Button();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.buttonToRight = new System.Windows.Forms.Button();
            this.buttonToLeft = new System.Windows.Forms.Button();
            this.buttonAllToRight = new System.Windows.Forms.Button();
            this.buttonAllToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(22, 23);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(198, 30);
            this.textInput.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(260, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.ItemHeight = 25;
            this.listBoxLeft.Location = new System.Drawing.Point(22, 163);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(198, 254);
            this.listBoxLeft.TabIndex = 2;
            this.listBoxLeft.SelectedIndexChanged += new System.EventHandler(this.listBoxLeft_SelectedIndexChanged);
            // 
            // buttonDeleteLeft
            // 
            this.buttonDeleteLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteLeft.Location = new System.Drawing.Point(64, 93);
            this.buttonDeleteLeft.Name = "buttonDeleteLeft";
            this.buttonDeleteLeft.Size = new System.Drawing.Size(110, 35);
            this.buttonDeleteLeft.TabIndex = 3;
            this.buttonDeleteLeft.Text = "Delete";
            this.buttonDeleteLeft.UseVisualStyleBackColor = true;
            this.buttonDeleteLeft.Click += new System.EventHandler(this.buttonDeleteLeft_Click);
            // 
            // buttonDeleteRight
            // 
            this.buttonDeleteRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRight.Location = new System.Drawing.Point(361, 93);
            this.buttonDeleteRight.Name = "buttonDeleteRight";
            this.buttonDeleteRight.Size = new System.Drawing.Size(110, 35);
            this.buttonDeleteRight.TabIndex = 4;
            this.buttonDeleteRight.Text = "Delete";
            this.buttonDeleteRight.UseVisualStyleBackColor = true;
            this.buttonDeleteRight.Click += new System.EventHandler(this.buttonDeleteRight_Click);
            // 
            // listBoxRight
            // 
            this.listBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.ItemHeight = 25;
            this.listBoxRight.Location = new System.Drawing.Point(317, 163);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(198, 254);
            this.listBoxRight.TabIndex = 5;
            this.listBoxRight.SelectedIndexChanged += new System.EventHandler(this.listBoxRight_SelectedIndexChanged);
            // 
            // buttonToRight
            // 
            this.buttonToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToRight.Location = new System.Drawing.Point(244, 183);
            this.buttonToRight.Name = "buttonToRight";
            this.buttonToRight.Size = new System.Drawing.Size(51, 35);
            this.buttonToRight.TabIndex = 6;
            this.buttonToRight.Text = ">";
            this.buttonToRight.UseVisualStyleBackColor = true;
            this.buttonToRight.Click += new System.EventHandler(this.buttonToRight_Click);
            // 
            // buttonToLeft
            // 
            this.buttonToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToLeft.Location = new System.Drawing.Point(244, 242);
            this.buttonToLeft.Name = "buttonToLeft";
            this.buttonToLeft.Size = new System.Drawing.Size(51, 35);
            this.buttonToLeft.TabIndex = 7;
            this.buttonToLeft.Text = "<";
            this.buttonToLeft.UseVisualStyleBackColor = true;
            this.buttonToLeft.Click += new System.EventHandler(this.buttonToLeft_Click);
            // 
            // buttonAllToRight
            // 
            this.buttonAllToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllToRight.Location = new System.Drawing.Point(244, 304);
            this.buttonAllToRight.Name = "buttonAllToRight";
            this.buttonAllToRight.Size = new System.Drawing.Size(51, 35);
            this.buttonAllToRight.TabIndex = 8;
            this.buttonAllToRight.Text = ">>";
            this.buttonAllToRight.UseVisualStyleBackColor = true;
            this.buttonAllToRight.Click += new System.EventHandler(this.buttonAllToRight_Click);
            // 
            // buttonAllToLeft
            // 
            this.buttonAllToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllToLeft.Location = new System.Drawing.Point(244, 365);
            this.buttonAllToLeft.Name = "buttonAllToLeft";
            this.buttonAllToLeft.Size = new System.Drawing.Size(51, 35);
            this.buttonAllToLeft.TabIndex = 9;
            this.buttonAllToLeft.Text = "<<";
            this.buttonAllToLeft.UseVisualStyleBackColor = true;
            this.buttonAllToLeft.Click += new System.EventHandler(this.buttonAllToLeft_Click);
            // 
            // StackDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.buttonAllToLeft);
            this.Controls.Add(this.buttonAllToRight);
            this.Controls.Add(this.buttonToLeft);
            this.Controls.Add(this.buttonToRight);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.buttonDeleteRight);
            this.Controls.Add(this.buttonDeleteLeft);
            this.Controls.Add(this.listBoxLeft);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textInput);
            this.Name = "StackDelete";
            this.Text = "StackDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.Button buttonDeleteLeft;
        private System.Windows.Forms.Button buttonDeleteRight;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Button buttonToRight;
        private System.Windows.Forms.Button buttonToLeft;
        private System.Windows.Forms.Button buttonAllToRight;
        private System.Windows.Forms.Button buttonAllToLeft;
    }
}