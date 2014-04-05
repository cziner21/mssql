namespace mssqlteszt
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
            this.lekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összesDiákLekéréseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyediLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adatmódosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákokModosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.városokMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyelviszgákMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szakokMódosításaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákokTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.városokTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyelvizsgákTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szakokTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.lekérdezésToolStripMenuItem,
            this.adatmódosításToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.újToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.add;
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // diákToolStripMenuItem
            // 
            this.diákToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.user_add;
            this.diákToolStripMenuItem.Name = "diákToolStripMenuItem";
            this.diákToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.diákToolStripMenuItem.Text = "Diák";
            this.diákToolStripMenuItem.Click += new System.EventHandler(this.diákToolStripMenuItem_Click);
            // 
            // városToolStripMenuItem
            // 
            this.városToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.map_add;
            this.városToolStripMenuItem.Name = "városToolStripMenuItem";
            this.városToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.városToolStripMenuItem.Text = "Város";
            this.városToolStripMenuItem.Click += new System.EventHandler(this.városToolStripMenuItem_Click);
            // 
            // nyelvizsgaToolStripMenuItem
            // 
            this.nyelvizsgaToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.book_add;
            this.nyelvizsgaToolStripMenuItem.Name = "nyelvizsgaToolStripMenuItem";
            this.nyelvizsgaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.nyelvizsgaToolStripMenuItem.Text = "Nyelvizsga";
            this.nyelvizsgaToolStripMenuItem.Click += new System.EventHandler(this.nyelvizsgaToolStripMenuItem_Click);
            // 
            // szakToolStripMenuItem
            // 
            this.szakToolStripMenuItem.Name = "szakToolStripMenuItem";
            this.szakToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.szakToolStripMenuItem.Text = "Szak";
            this.szakToolStripMenuItem.Click += new System.EventHandler(this.szakToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.cross;
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // lekérdezésToolStripMenuItem
            // 
            this.lekérdezésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összesDiákLekéréseToolStripMenuItem,
            this.egyediLekérdezésToolStripMenuItem});
            this.lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.lekérdezésToolStripMenuItem.Text = "Lekérdezés";
            // 
            // összesDiákLekéréseToolStripMenuItem
            // 
            this.összesDiákLekéréseToolStripMenuItem.Name = "összesDiákLekéréseToolStripMenuItem";
            this.összesDiákLekéréseToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.összesDiákLekéréseToolStripMenuItem.Text = "Összes diák lekérése";
            this.összesDiákLekéréseToolStripMenuItem.Click += new System.EventHandler(this.összesDiákLekéréseToolStripMenuItem_Click);
            // 
            // egyediLekérdezésToolStripMenuItem
            // 
            this.egyediLekérdezésToolStripMenuItem.Name = "egyediLekérdezésToolStripMenuItem";
            this.egyediLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.egyediLekérdezésToolStripMenuItem.Text = "Egyéni...";
            // 
            // adatmódosításToolStripMenuItem
            // 
            this.adatmódosításToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diákokModosításaToolStripMenuItem,
            this.városokMódosításaToolStripMenuItem,
            this.nyelviszgákMódosításaToolStripMenuItem,
            this.szakokMódosításaToolStripMenuItem1});
            this.adatmódosításToolStripMenuItem.Name = "adatmódosításToolStripMenuItem";
            this.adatmódosításToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.adatmódosításToolStripMenuItem.Text = "Adatmódosítás";
            // 
            // diákokModosításaToolStripMenuItem
            // 
            this.diákokModosításaToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.user_edit;
            this.diákokModosításaToolStripMenuItem.Name = "diákokModosításaToolStripMenuItem";
            this.diákokModosításaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.diákokModosításaToolStripMenuItem.Text = "Diákok modosítása";
            this.diákokModosításaToolStripMenuItem.Click += new System.EventHandler(this.diákokModosításaToolStripMenuItem_Click);
            // 
            // városokMódosításaToolStripMenuItem
            // 
            this.városokMódosításaToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.map_edit;
            this.városokMódosításaToolStripMenuItem.Name = "városokMódosításaToolStripMenuItem";
            this.városokMódosításaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.városokMódosításaToolStripMenuItem.Text = "Városok módosítása";
            this.városokMódosításaToolStripMenuItem.Click += new System.EventHandler(this.városokMódosításaToolStripMenuItem_Click);
            // 
            // nyelviszgákMódosításaToolStripMenuItem
            // 
            this.nyelviszgákMódosításaToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.book_edit;
            this.nyelviszgákMódosításaToolStripMenuItem.Name = "nyelviszgákMódosításaToolStripMenuItem";
            this.nyelviszgákMódosításaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.nyelviszgákMódosításaToolStripMenuItem.Text = "Nyelvizsgák módosítása";
            this.nyelviszgákMódosításaToolStripMenuItem.Click += new System.EventHandler(this.nyelviszgákMódosításaToolStripMenuItem_Click);
            // 
            // szakokMódosításaToolStripMenuItem1
            // 
            this.szakokMódosításaToolStripMenuItem1.Name = "szakokMódosításaToolStripMenuItem1";
            this.szakokMódosításaToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.szakokMódosításaToolStripMenuItem1.Text = "Szakok módosítása";
            this.szakokMódosításaToolStripMenuItem1.Click += new System.EventHandler(this.szakokMódosításaToolStripMenuItem1_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diákokTörléseToolStripMenuItem,
            this.városokTörléseToolStripMenuItem,
            this.nyelvizsgákTörléseToolStripMenuItem,
            this.szakokTörléseToolStripMenuItem});
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // diákokTörléseToolStripMenuItem
            // 
            this.diákokTörléseToolStripMenuItem.Name = "diákokTörléseToolStripMenuItem";
            this.diákokTörléseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.diákokTörléseToolStripMenuItem.Text = "Diákok törlése";
            this.diákokTörléseToolStripMenuItem.Click += new System.EventHandler(this.diákokTörléseToolStripMenuItem_Click);
            // 
            // városokTörléseToolStripMenuItem
            // 
            this.városokTörléseToolStripMenuItem.Name = "városokTörléseToolStripMenuItem";
            this.városokTörléseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.városokTörléseToolStripMenuItem.Text = "Városok törlése";
            this.városokTörléseToolStripMenuItem.Click += new System.EventHandler(this.városokTörléseToolStripMenuItem_Click);
            // 
            // nyelvizsgákTörléseToolStripMenuItem
            // 
            this.nyelvizsgákTörléseToolStripMenuItem.Name = "nyelvizsgákTörléseToolStripMenuItem";
            this.nyelvizsgákTörléseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nyelvizsgákTörléseToolStripMenuItem.Text = "Nyelvizsgák törlése";
            this.nyelvizsgákTörléseToolStripMenuItem.Click += new System.EventHandler(this.nyelvizsgákTörléseToolStripMenuItem_Click);
            // 
            // szakokTörléseToolStripMenuItem
            // 
            this.szakokTörléseToolStripMenuItem.Name = "szakokTörléseToolStripMenuItem";
            this.szakokTörléseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.szakokTörléseToolStripMenuItem.Text = "Szakok törlése";
            this.szakokTörléseToolStripMenuItem.Click += new System.EventHandler(this.szakokTörléseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::mssqlteszt.Properties.Resources.information;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.helpToolStripMenuItem.Text = "Segítség";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 326);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Kezdő form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adatmódosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem városToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyelvizsgaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összesDiákLekéréseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyediLekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákokModosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem városokMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyelviszgákMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szakokMódosításaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diákokTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem városokTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyelvizsgákTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szakokTörléseToolStripMenuItem;

    }
}

