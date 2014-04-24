namespace DiakNyelvizsga
{
    partial class editSzak
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
            this.szakFelevTbx = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.szakNevTbx = new System.Windows.Forms.TextBox();
            this.szakModifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // szakFelevTbx
            // 
            this.szakFelevTbx.Location = new System.Drawing.Point(12, 80);
            this.szakFelevTbx.Name = "szakFelevTbx";
            this.szakFelevTbx.Size = new System.Drawing.Size(300, 20);
            this.szakFelevTbx.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(12, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Félévek száma:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 21;
            this.label20.Text = "Név:";
            // 
            // szakNevTbx
            // 
            this.szakNevTbx.Location = new System.Drawing.Point(12, 29);
            this.szakNevTbx.Name = "szakNevTbx";
            this.szakNevTbx.Size = new System.Drawing.Size(300, 20);
            this.szakNevTbx.TabIndex = 18;
            // 
            // szakModifyBtn
            // 
            this.szakModifyBtn.Location = new System.Drawing.Point(235, 130);
            this.szakModifyBtn.Name = "szakModifyBtn";
            this.szakModifyBtn.Size = new System.Drawing.Size(77, 39);
            this.szakModifyBtn.TabIndex = 20;
            this.szakModifyBtn.Text = "Módosít";
            this.szakModifyBtn.UseVisualStyleBackColor = true;
            this.szakModifyBtn.Click += new System.EventHandler(this.szakModifyBtn_Click);
            // 
            // editSzak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 184);
            this.Controls.Add(this.szakFelevTbx);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.szakNevTbx);
            this.Controls.Add(this.szakModifyBtn);
            this.Name = "editSzak";
            this.Text = "Szak módosítása";
            this.Load += new System.EventHandler(this.editSzak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox szakFelevTbx;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox szakNevTbx;
        private System.Windows.Forms.Button szakModifyBtn;
    }
}