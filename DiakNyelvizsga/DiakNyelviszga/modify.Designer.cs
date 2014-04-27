namespace DiakNyelvizsga
{
    partial class modify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify));
            this.label1 = new System.Windows.Forms.Label();
            this.nevTbx = new System.Windows.Forms.TextBox();
            this.cimTbx = new System.Windows.Forms.TextBox();
            this.telTbx = new System.Windows.Forms.TextBox();
            this.anyjaTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zsebpenzTbx = new System.Windows.Forms.TextBox();
            this.varosCbx = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // nevTbx
            // 
            this.nevTbx.Location = new System.Drawing.Point(100, 36);
            this.nevTbx.Name = "nevTbx";
            this.nevTbx.Size = new System.Drawing.Size(235, 20);
            this.nevTbx.TabIndex = 1;
            // 
            // cimTbx
            // 
            this.cimTbx.Location = new System.Drawing.Point(100, 62);
            this.cimTbx.Name = "cimTbx";
            this.cimTbx.Size = new System.Drawing.Size(235, 20);
            this.cimTbx.TabIndex = 2;
            // 
            // telTbx
            // 
            this.telTbx.Location = new System.Drawing.Point(100, 88);
            this.telTbx.Name = "telTbx";
            this.telTbx.Size = new System.Drawing.Size(235, 20);
            this.telTbx.TabIndex = 3;
            // 
            // anyjaTbx
            // 
            this.anyjaTbx.Location = new System.Drawing.Point(100, 114);
            this.anyjaTbx.Name = "anyjaTbx";
            this.anyjaTbx.Size = new System.Drawing.Size(235, 20);
            this.anyjaTbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anyja neve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "zsebpénz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Város";
            // 
            // zsebpenzTbx
            // 
            this.zsebpenzTbx.Location = new System.Drawing.Point(100, 144);
            this.zsebpenzTbx.Name = "zsebpenzTbx";
            this.zsebpenzTbx.Size = new System.Drawing.Size(235, 20);
            this.zsebpenzTbx.TabIndex = 10;
            // 
            // varosCbx
            // 
            this.varosCbx.FormattingEnabled = true;
            this.varosCbx.Location = new System.Drawing.Point(100, 170);
            this.varosCbx.Name = "varosCbx";
            this.varosCbx.Size = new System.Drawing.Size(109, 21);
            this.varosCbx.TabIndex = 11;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(260, 212);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 38);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Módosít";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 262);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.varosCbx);
            this.Controls.Add(this.zsebpenzTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anyjaTbx);
            this.Controls.Add(this.telTbx);
            this.Controls.Add(this.cimTbx);
            this.Controls.Add(this.nevTbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modify";
            this.Text = "Diákok szerkesztése";
            this.Load += new System.EventHandler(this.modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevTbx;
        private System.Windows.Forms.TextBox cimTbx;
        private System.Windows.Forms.TextBox telTbx;
        private System.Windows.Forms.TextBox anyjaTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zsebpenzTbx;
        private System.Windows.Forms.ComboBox varosCbx;
        private System.Windows.Forms.Button updateBtn;


    }
}