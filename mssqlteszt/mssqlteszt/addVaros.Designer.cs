namespace mssqlteszt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iszTbx = new System.Windows.Forms.TextBox();
            this.telepulesTbx = new System.Windows.Forms.TextBox();
            this.megyeTbx = new System.Windows.Forms.TextBox();
            this.orszagTbx = new System.Windows.Forms.TextBox();
            this.addVarosBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addVarosBtn);
            this.groupBox1.Controls.Add(this.orszagTbx);
            this.groupBox1.Controls.Add(this.megyeTbx);
            this.groupBox1.Controls.Add(this.telepulesTbx);
            this.groupBox1.Controls.Add(this.iszTbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Irányítószám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Település";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Megye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország";
            // 
            // iszTbx
            // 
            this.iszTbx.Location = new System.Drawing.Point(107, 44);
            this.iszTbx.Name = "iszTbx";
            this.iszTbx.Size = new System.Drawing.Size(100, 20);
            this.iszTbx.TabIndex = 4;
            // 
            // telepulesTbx
            // 
            this.telepulesTbx.Location = new System.Drawing.Point(107, 97);
            this.telepulesTbx.Name = "telepulesTbx";
            this.telepulesTbx.Size = new System.Drawing.Size(100, 20);
            this.telepulesTbx.TabIndex = 5;
            // 
            // megyeTbx
            // 
            this.megyeTbx.Location = new System.Drawing.Point(107, 152);
            this.megyeTbx.Name = "megyeTbx";
            this.megyeTbx.Size = new System.Drawing.Size(100, 20);
            this.megyeTbx.TabIndex = 6;
            // 
            // orszagTbx
            // 
            this.orszagTbx.Location = new System.Drawing.Point(107, 184);
            this.orszagTbx.Name = "orszagTbx";
            this.orszagTbx.Size = new System.Drawing.Size(100, 20);
            this.orszagTbx.TabIndex = 7;
            // 
            // addVarosBtn
            // 
            this.addVarosBtn.Location = new System.Drawing.Point(280, 177);
            this.addVarosBtn.Name = "addVarosBtn";
            this.addVarosBtn.Size = new System.Drawing.Size(75, 23);
            this.addVarosBtn.TabIndex = 8;
            this.addVarosBtn.Text = "Hozzáad";
            this.addVarosBtn.UseVisualStyleBackColor = true;
            this.addVarosBtn.Click += new System.EventHandler(this.addVarosBtn_Click);
            // 
            // addVaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "addVaros";
            this.Text = "Város hozzáadása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox orszagTbx;
        private System.Windows.Forms.TextBox megyeTbx;
        private System.Windows.Forms.TextBox telepulesTbx;
        private System.Windows.Forms.TextBox iszTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addVarosBtn;
    }
}