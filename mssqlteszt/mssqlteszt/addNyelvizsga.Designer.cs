namespace mssqlteszt
{
    partial class addNyelvizsga
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNyelvizsgaBtn = new System.Windows.Forms.Button();
            this.iskolaTbx = new System.Windows.Forms.TextBox();
            this.szintTbx = new System.Windows.Forms.TextBox();
            this.tipusTbx = new System.Windows.Forms.TextBox();
            this.nyelvTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addNyelvizsgaBtn);
            this.panel1.Controls.Add(this.iskolaTbx);
            this.panel1.Controls.Add(this.szintTbx);
            this.panel1.Controls.Add(this.tipusTbx);
            this.panel1.Controls.Add(this.nyelvTbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 266);
            this.panel1.TabIndex = 0;
            // 
            // addNyelvizsgaBtn
            // 
            this.addNyelvizsgaBtn.Location = new System.Drawing.Point(276, 185);
            this.addNyelvizsgaBtn.Name = "addNyelvizsgaBtn";
            this.addNyelvizsgaBtn.Size = new System.Drawing.Size(75, 23);
            this.addNyelvizsgaBtn.TabIndex = 17;
            this.addNyelvizsgaBtn.Text = "Hozzáad";
            this.addNyelvizsgaBtn.UseVisualStyleBackColor = true;
            this.addNyelvizsgaBtn.Click += new System.EventHandler(this.addNyelvizsgaBtn_Click);
            // 
            // iskolaTbx
            // 
            this.iskolaTbx.Location = new System.Drawing.Point(103, 192);
            this.iskolaTbx.Name = "iskolaTbx";
            this.iskolaTbx.Size = new System.Drawing.Size(100, 20);
            this.iskolaTbx.TabIndex = 16;
            // 
            // szintTbx
            // 
            this.szintTbx.Location = new System.Drawing.Point(103, 160);
            this.szintTbx.Name = "szintTbx";
            this.szintTbx.Size = new System.Drawing.Size(100, 20);
            this.szintTbx.TabIndex = 15;
            // 
            // tipusTbx
            // 
            this.tipusTbx.Location = new System.Drawing.Point(103, 105);
            this.tipusTbx.Name = "tipusTbx";
            this.tipusTbx.Size = new System.Drawing.Size(100, 20);
            this.tipusTbx.TabIndex = 14;
            // 
            // nyelvTbx
            // 
            this.nyelvTbx.Location = new System.Drawing.Point(103, 52);
            this.nyelvTbx.Name = "nyelvTbx";
            this.nyelvTbx.Size = new System.Drawing.Size(100, 20);
            this.nyelvTbx.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Iskola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Szint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Típus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nyelv";
            // 
            // addNyelvizsga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 313);
            this.Controls.Add(this.panel1);
            this.Name = "addNyelvizsga";
            this.Text = "addNyelvizsga";
            this.Load += new System.EventHandler(this.addNyelvizsga_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNyelvizsgaBtn;
        private System.Windows.Forms.TextBox iskolaTbx;
        private System.Windows.Forms.TextBox szintTbx;
        private System.Windows.Forms.TextBox tipusTbx;
        private System.Windows.Forms.TextBox nyelvTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}