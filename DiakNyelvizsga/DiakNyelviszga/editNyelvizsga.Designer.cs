namespace DiakNyelvizsga
{
    partial class editNyelvizsga
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
            this.nyvIskolaTbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nyvNyelvTbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nyvTipusTbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nyvSzintTbx = new System.Windows.Forms.TextBox();
            this.nyvModifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nyvIskolaTbx
            // 
            this.nyvIskolaTbx.Location = new System.Drawing.Point(20, 176);
            this.nyvIskolaTbx.Name = "nyvIskolaTbx";
            this.nyvIskolaTbx.Size = new System.Drawing.Size(300, 20);
            this.nyvIskolaTbx.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(20, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Iskola:";
            // 
            // nyvNyelvTbx
            // 
            this.nyvNyelvTbx.Location = new System.Drawing.Point(20, 129);
            this.nyvNyelvTbx.Name = "nyvNyelvTbx";
            this.nyvNyelvTbx.Size = new System.Drawing.Size(300, 20);
            this.nyvNyelvTbx.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(20, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nyelv:";
            // 
            // nyvTipusTbx
            // 
            this.nyvTipusTbx.Location = new System.Drawing.Point(20, 82);
            this.nyvTipusTbx.Name = "nyvTipusTbx";
            this.nyvTipusTbx.Size = new System.Drawing.Size(300, 20);
            this.nyvTipusTbx.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(20, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Típus:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(20, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Szint:";
            // 
            // nyvSzintTbx
            // 
            this.nyvSzintTbx.Location = new System.Drawing.Point(20, 31);
            this.nyvSzintTbx.Name = "nyvSzintTbx";
            this.nyvSzintTbx.Size = new System.Drawing.Size(300, 20);
            this.nyvSzintTbx.TabIndex = 21;
            // 
            // nyvModifyBtn
            // 
            this.nyvModifyBtn.Location = new System.Drawing.Point(243, 212);
            this.nyvModifyBtn.Name = "nyvModifyBtn";
            this.nyvModifyBtn.Size = new System.Drawing.Size(77, 39);
            this.nyvModifyBtn.TabIndex = 24;
            this.nyvModifyBtn.Text = "Módosít";
            this.nyvModifyBtn.UseVisualStyleBackColor = true;
            this.nyvModifyBtn.Click += new System.EventHandler(this.nyvModifyBtn_Click);
            // 
            // editNyelvizsga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.nyvIskolaTbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nyvNyelvTbx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nyvTipusTbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nyvSzintTbx);
            this.Controls.Add(this.nyvModifyBtn);
            this.Name = "editNyelvizsga";
            this.Text = "Nyelvvizsga szerkesztése";
            this.Load += new System.EventHandler(this.editNyelvizsga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nyvIskolaTbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nyvNyelvTbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nyvTipusTbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nyvSzintTbx;
        private System.Windows.Forms.Button nyvModifyBtn;
    }
}