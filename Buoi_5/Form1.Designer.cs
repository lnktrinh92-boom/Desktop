namespace Buoi_5
{
    partial class Form1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnCase1 = new System.Windows.Forms.Button();
            this.rtxKQ = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCase2 = new System.Windows.Forms.Button();
            this.btnCallback = new System.Windows.Forms.Button();
            this.btnLinQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(33, 22);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(153, 36);
            this.txtA.TabIndex = 0;
            // 
            // btnCase1
            // 
            this.btnCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCase1.Location = new System.Drawing.Point(397, 22);
            this.btnCase1.Name = "btnCase1";
            this.btnCase1.Size = new System.Drawing.Size(131, 36);
            this.btnCase1.TabIndex = 2;
            this.btnCase1.Text = "Case 1";
            this.btnCase1.UseVisualStyleBackColor = true;
            this.btnCase1.Click += new System.EventHandler(this.btnCase1_Click);
            // 
            // rtxKQ
            // 
            this.rtxKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxKQ.Location = new System.Drawing.Point(33, 80);
            this.rtxKQ.Name = "rtxKQ";
            this.rtxKQ.Size = new System.Drawing.Size(809, 358);
            this.rtxKQ.TabIndex = 4;
            this.rtxKQ.Text = "";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(215, 22);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(153, 36);
            this.txtB.TabIndex = 6;
            // 
            // btnCase2
            // 
            this.btnCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCase2.Location = new System.Drawing.Point(559, 22);
            this.btnCase2.Name = "btnCase2";
            this.btnCase2.Size = new System.Drawing.Size(131, 36);
            this.btnCase2.TabIndex = 7;
            this.btnCase2.Text = "Case 2";
            this.btnCase2.UseVisualStyleBackColor = true;
            this.btnCase2.Click += new System.EventHandler(this.btnCase2_Click);
            // 
            // btnCallback
            // 
            this.btnCallback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallback.Location = new System.Drawing.Point(708, 22);
            this.btnCallback.Name = "btnCallback";
            this.btnCallback.Size = new System.Drawing.Size(131, 36);
            this.btnCallback.TabIndex = 8;
            this.btnCallback.Text = "Callback";
            this.btnCallback.UseVisualStyleBackColor = true;
            this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
            // 
            // btnLinQ
            // 
            this.btnLinQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinQ.Location = new System.Drawing.Point(320, 456);
            this.btnLinQ.Name = "btnLinQ";
            this.btnLinQ.Size = new System.Drawing.Size(229, 36);
            this.btnLinQ.TabIndex = 9;
            this.btnLinQ.Text = "Test LinQ";
            this.btnLinQ.UseVisualStyleBackColor = true;
            this.btnLinQ.Click += new System.EventHandler(this.btnLinQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 518);
            this.Controls.Add(this.btnLinQ);
            this.Controls.Add(this.btnCallback);
            this.Controls.Add(this.btnCase2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.rtxKQ);
            this.Controls.Add(this.btnCase1);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnCase1;
        private System.Windows.Forms.RichTextBox rtxKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCase2;
        private System.Windows.Forms.Button btnCallback;
        private System.Windows.Forms.Button btnLinQ;
    }
}

