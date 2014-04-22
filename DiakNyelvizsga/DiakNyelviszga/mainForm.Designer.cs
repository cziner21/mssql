namespace DiakNyelviszga
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.városToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyelvizsgaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.szakPbx = new System.Windows.Forms.PictureBox();
            this.nyelvizsgaPbx = new System.Windows.Forms.PictureBox();
            this.varosPbx = new System.Windows.Forms.PictureBox();
            this.diakPbx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyelvizsgaPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varosPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diákToolStripMenuItem,
            this.városToolStripMenuItem,
            this.nyelvizsgaToolStripMenuItem,
            this.szakToolStripMenuItem});
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // diákToolStripMenuItem
            // 
            this.diákToolStripMenuItem.Name = "diákToolStripMenuItem";
            this.diákToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.diákToolStripMenuItem.Text = "Diák...";
            // 
            // városToolStripMenuItem
            // 
            this.városToolStripMenuItem.Name = "városToolStripMenuItem";
            this.városToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.városToolStripMenuItem.Text = "Város...";
            // 
            // nyelvizsgaToolStripMenuItem
            // 
            this.nyelvizsgaToolStripMenuItem.Name = "nyelvizsgaToolStripMenuItem";
            this.nyelvizsgaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.nyelvizsgaToolStripMenuItem.Text = "Nyelvizsga...";
            // 
            // szakToolStripMenuItem
            // 
            this.szakToolStripMenuItem.Name = "szakToolStripMenuItem";
            this.szakToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.szakToolStripMenuItem.Text = "Szak...";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.szakPbx);
            this.panel1.Controls.Add(this.nyelvizsgaPbx);
            this.panel1.Controls.Add(this.varosPbx);
            this.panel1.Controls.Add(this.diakPbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 213);
            this.panel1.TabIndex = 1;
            // 
            // szakPbx
            // 
            this.szakPbx.Location = new System.Drawing.Point(166, 114);
            this.szakPbx.Name = "szakPbx";
            this.szakPbx.Size = new System.Drawing.Size(60, 60);
            this.szakPbx.TabIndex = 11;
            this.szakPbx.TabStop = false;
            this.szakPbx.Click += new System.EventHandler(this.szakPbx_Click);
            // 
            // nyelvizsgaPbx
            // 
            this.nyelvizsgaPbx.Location = new System.Drawing.Point(38, 114);
            this.nyelvizsgaPbx.Name = "nyelvizsgaPbx";
            this.nyelvizsgaPbx.Size = new System.Drawing.Size(60, 60);
            this.nyelvizsgaPbx.TabIndex = 10;
            this.nyelvizsgaPbx.TabStop = false;
            this.nyelvizsgaPbx.Click += new System.EventHandler(this.nyelvizsgaPbx_Click);
            // 
            // varosPbx
            // 
            this.varosPbx.Location = new System.Drawing.Point(166, 20);
            this.varosPbx.Name = "varosPbx";
            this.varosPbx.Size = new System.Drawing.Size(60, 60);
            this.varosPbx.TabIndex = 9;
            this.varosPbx.TabStop = false;
            this.varosPbx.Click += new System.EventHandler(this.varosPbx_Click);
            // 
            // diakPbx
            // 
            this.diakPbx.Location = new System.Drawing.Point(38, 20);
            this.diakPbx.Name = "diakPbx";
            this.diakPbx.Size = new System.Drawing.Size(60, 60);
            this.diakPbx.TabIndex = 8;
            this.diakPbx.TabStop = false;
            this.diakPbx.Click += new System.EventHandler(this.diakPbx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Szakok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nyelvizsgák";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Városok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diákok";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Főablak";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyelvizsgaPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varosPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem városToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyelvizsgaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox szakPbx;
        private System.Windows.Forms.PictureBox nyelvizsgaPbx;
        private System.Windows.Forms.PictureBox varosPbx;
        private System.Windows.Forms.PictureBox diakPbx;
    }
}

