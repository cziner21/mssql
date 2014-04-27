namespace DiakNyelvizsga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSzak));
            this.addSzakBtn = new System.Windows.Forms.Button();
            this.felevekTbx = new System.Windows.Forms.TextBox();
            this.szakNevTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSzakBtn
            // 
            this.addSzakBtn.Location = new System.Drawing.Point(151, 95);
            this.addSzakBtn.Name = "addSzakBtn";
            this.addSzakBtn.Size = new System.Drawing.Size(75, 23);
            this.addSzakBtn.TabIndex = 22;
            this.addSzakBtn.Text = "Hozzáad";
            this.addSzakBtn.UseVisualStyleBackColor = true;
            this.addSzakBtn.Click += new System.EventHandler(this.addSzakBtn_Click);
            // 
            // felevekTbx
            // 
            this.felevekTbx.Location = new System.Drawing.Point(91, 57);
            this.felevekTbx.Name = "felevekTbx";
            this.felevekTbx.Size = new System.Drawing.Size(135, 20);
            this.felevekTbx.TabIndex = 21;
            // 
            // szakNevTbx
            // 
            this.szakNevTbx.Location = new System.Drawing.Point(91, 23);
            this.szakNevTbx.Name = "szakNevTbx";
            this.szakNevTbx.Size = new System.Drawing.Size(135, 20);
            this.szakNevTbx.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Félévek száma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Név";
            // 
            // addSzak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 121);
            this.Controls.Add(this.addSzakBtn);
            this.Controls.Add(this.felevekTbx);
            this.Controls.Add(this.szakNevTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSzak";
            this.Text = "Szak hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSzakBtn;
        private System.Windows.Forms.TextBox felevekTbx;
        private System.Windows.Forms.TextBox szakNevTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}