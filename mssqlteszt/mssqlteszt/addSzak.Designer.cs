namespace mssqlteszt
{
    partial class addSzak
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
            this.addSzakBtn = new System.Windows.Forms.Button();
            this.felevekTbx = new System.Windows.Forms.TextBox();
            this.szakNevTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addSzakBtn);
            this.panel1.Controls.Add(this.felevekTbx);
            this.panel1.Controls.Add(this.szakNevTbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 266);
            this.panel1.TabIndex = 1;
            // 
            // addSzakBtn
            // 
            this.addSzakBtn.Location = new System.Drawing.Point(230, 182);
            this.addSzakBtn.Name = "addSzakBtn";
            this.addSzakBtn.Size = new System.Drawing.Size(75, 23);
            this.addSzakBtn.TabIndex = 17;
            this.addSzakBtn.Text = "Hozzáad";
            this.addSzakBtn.UseVisualStyleBackColor = true;
            this.addSzakBtn.Click += new System.EventHandler(this.addSzakBtn_Click);
            // 
            // felevekTbx
            // 
            this.felevekTbx.Location = new System.Drawing.Point(127, 105);
            this.felevekTbx.Name = "felevekTbx";
            this.felevekTbx.Size = new System.Drawing.Size(100, 20);
            this.felevekTbx.TabIndex = 14;
            // 
            // szakNevTbx
            // 
            this.szakNevTbx.Location = new System.Drawing.Point(127, 52);
            this.szakNevTbx.Name = "szakNevTbx";
            this.szakNevTbx.Size = new System.Drawing.Size(100, 20);
            this.szakNevTbx.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Félévek száma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Név";
            // 
            // addSzak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 328);
            this.Controls.Add(this.panel1);
            this.Name = "addSzak";
            this.Text = "Szak hozzáadása";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addSzakBtn;
        private System.Windows.Forms.TextBox felevekTbx;
        private System.Windows.Forms.TextBox szakNevTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}