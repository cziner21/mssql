namespace DiakNyelvizsga
{
    partial class addVaros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addVaros));
            this.addVarosBtn = new System.Windows.Forms.Button();
            this.orszagTbx = new System.Windows.Forms.TextBox();
            this.megyeTbx = new System.Windows.Forms.TextBox();
            this.telepulesTbx = new System.Windows.Forms.TextBox();
            this.iszTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addVarosBtn
            // 
            this.addVarosBtn.Location = new System.Drawing.Point(133, 146);
            this.addVarosBtn.Name = "addVarosBtn";
            this.addVarosBtn.Size = new System.Drawing.Size(75, 23);
            this.addVarosBtn.TabIndex = 17;
            this.addVarosBtn.Text = "Hozzáad";
            this.addVarosBtn.UseVisualStyleBackColor = true;
            this.addVarosBtn.Click += new System.EventHandler(this.addVarosBtn_Click);
            // 
            // orszagTbx
            // 
            this.orszagTbx.Location = new System.Drawing.Point(84, 105);
            this.orszagTbx.Name = "orszagTbx";
            this.orszagTbx.Size = new System.Drawing.Size(124, 20);
            this.orszagTbx.TabIndex = 16;
            // 
            // megyeTbx
            // 
            this.megyeTbx.Location = new System.Drawing.Point(84, 72);
            this.megyeTbx.Name = "megyeTbx";
            this.megyeTbx.Size = new System.Drawing.Size(124, 20);
            this.megyeTbx.TabIndex = 15;
            // 
            // telepulesTbx
            // 
            this.telepulesTbx.Location = new System.Drawing.Point(84, 40);
            this.telepulesTbx.Name = "telepulesTbx";
            this.telepulesTbx.Size = new System.Drawing.Size(124, 20);
            this.telepulesTbx.TabIndex = 14;
            // 
            // iszTbx
            // 
            this.iszTbx.Location = new System.Drawing.Point(84, 8);
            this.iszTbx.Name = "iszTbx";
            this.iszTbx.Size = new System.Drawing.Size(124, 20);
            this.iszTbx.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ország";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Megye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Település";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Irányítószám";
            // 
            // addVaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 181);
            this.Controls.Add(this.addVarosBtn);
            this.Controls.Add(this.orszagTbx);
            this.Controls.Add(this.megyeTbx);
            this.Controls.Add(this.telepulesTbx);
            this.Controls.Add(this.iszTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addVaros";
            this.Text = "Város hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVarosBtn;
        private System.Windows.Forms.TextBox orszagTbx;
        private System.Windows.Forms.TextBox megyeTbx;
        private System.Windows.Forms.TextBox telepulesTbx;
        private System.Windows.Forms.TextBox iszTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}