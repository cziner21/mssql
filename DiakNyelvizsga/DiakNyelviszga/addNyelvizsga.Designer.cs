namespace DiakNyelvizsga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNyelvizsga));
            this.addNyelvizsgaBtn = new System.Windows.Forms.Button();
            this.iskolaTbx = new System.Windows.Forms.TextBox();
            this.szintTbx = new System.Windows.Forms.TextBox();
            this.tipusTbx = new System.Windows.Forms.TextBox();
            this.nyelvTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNyelvizsgaBtn
            // 
            this.addNyelvizsgaBtn.Location = new System.Drawing.Point(185, 110);
            this.addNyelvizsgaBtn.Name = "addNyelvizsgaBtn";
            this.addNyelvizsgaBtn.Size = new System.Drawing.Size(75, 23);
            this.addNyelvizsgaBtn.TabIndex = 26;
            this.addNyelvizsgaBtn.Text = "Hozzáad";
            this.addNyelvizsgaBtn.UseVisualStyleBackColor = true;
            this.addNyelvizsgaBtn.Click += new System.EventHandler(this.addNyelvizsgaBtn_Click);
            // 
            // iskolaTbx
            // 
            this.iskolaTbx.Location = new System.Drawing.Point(90, 84);
            this.iskolaTbx.Name = "iskolaTbx";
            this.iskolaTbx.Size = new System.Drawing.Size(170, 20);
            this.iskolaTbx.TabIndex = 25;
            // 
            // szintTbx
            // 
            this.szintTbx.Location = new System.Drawing.Point(90, 58);
            this.szintTbx.Name = "szintTbx";
            this.szintTbx.Size = new System.Drawing.Size(170, 20);
            this.szintTbx.TabIndex = 24;
            // 
            // tipusTbx
            // 
            this.tipusTbx.Location = new System.Drawing.Point(90, 32);
            this.tipusTbx.Name = "tipusTbx";
            this.tipusTbx.Size = new System.Drawing.Size(170, 20);
            this.tipusTbx.TabIndex = 23;
            // 
            // nyelvTbx
            // 
            this.nyelvTbx.Location = new System.Drawing.Point(90, 6);
            this.nyelvTbx.Name = "nyelvTbx";
            this.nyelvTbx.Size = new System.Drawing.Size(170, 20);
            this.nyelvTbx.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Iskola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Szint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Típus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nyelv";
            // 
            // addNyelvizsga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(272, 151);
            this.Controls.Add(this.addNyelvizsgaBtn);
            this.Controls.Add(this.iskolaTbx);
            this.Controls.Add(this.szintTbx);
            this.Controls.Add(this.tipusTbx);
            this.Controls.Add(this.nyelvTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addNyelvizsga";
            this.Text = "Nyelvizsga hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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