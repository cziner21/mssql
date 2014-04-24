namespace DiakNyelvizsga
{
    partial class editVaros
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
            this.varosOrszagTbx = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.varosMegyeTbx = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.varosNevTbx = new System.Windows.Forms.TextBox();
            this.varosModifyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iszTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // varosOrszagTbx
            // 
            this.varosOrszagTbx.Location = new System.Drawing.Point(12, 182);
            this.varosOrszagTbx.Name = "varosOrszagTbx";
            this.varosOrszagTbx.Size = new System.Drawing.Size(300, 20);
            this.varosOrszagTbx.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(12, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "Ország:";
            // 
            // varosMegyeTbx
            // 
            this.varosMegyeTbx.Location = new System.Drawing.Point(12, 135);
            this.varosMegyeTbx.Name = "varosMegyeTbx";
            this.varosMegyeTbx.Size = new System.Drawing.Size(300, 20);
            this.varosMegyeTbx.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(12, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 17);
            this.label26.TabIndex = 24;
            this.label26.Text = "Megye:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(12, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 17);
            this.label27.TabIndex = 23;
            this.label27.Text = "Név:";
            // 
            // varosNevTbx
            // 
            this.varosNevTbx.Location = new System.Drawing.Point(12, 84);
            this.varosNevTbx.Name = "varosNevTbx";
            this.varosNevTbx.Size = new System.Drawing.Size(300, 20);
            this.varosNevTbx.TabIndex = 20;
            // 
            // varosModifyBtn
            // 
            this.varosModifyBtn.Location = new System.Drawing.Point(235, 219);
            this.varosModifyBtn.Name = "varosModifyBtn";
            this.varosModifyBtn.Size = new System.Drawing.Size(77, 39);
            this.varosModifyBtn.TabIndex = 22;
            this.varosModifyBtn.Text = "Módosít";
            this.varosModifyBtn.UseVisualStyleBackColor = true;
            this.varosModifyBtn.Click += new System.EventHandler(this.varosModifyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Irányítószám:";
            // 
            // iszTbx
            // 
            this.iszTbx.Location = new System.Drawing.Point(12, 39);
            this.iszTbx.Name = "iszTbx";
            this.iszTbx.Size = new System.Drawing.Size(300, 20);
            this.iszTbx.TabIndex = 26;
            // 
            // editVaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iszTbx);
            this.Controls.Add(this.varosOrszagTbx);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.varosMegyeTbx);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.varosNevTbx);
            this.Controls.Add(this.varosModifyBtn);
            this.Name = "editVaros";
            this.Text = "Város szerkesztése";
            this.Load += new System.EventHandler(this.editVaros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox varosOrszagTbx;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox varosMegyeTbx;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox varosNevTbx;
        private System.Windows.Forms.Button varosModifyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iszTbx;
    }
}