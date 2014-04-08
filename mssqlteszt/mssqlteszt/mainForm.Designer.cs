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
            this.components = new System.ComponentModel.Container();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectGbx = new System.Windows.Forms.GroupBox();
            this.nyelvizsgaClick = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szakClick = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.varosClick = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diakPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.selectGbx.SuspendLayout();
            this.nyelvizsgaClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.szakClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.varosClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.diakPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lekérdezésToolStripMenuItem.Text = "Szűrés";
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
            this.egyediLekérdezésToolStripMenuItem.Click += new System.EventHandler(this.egyediLekérdezésToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 302);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selectGbx);
            this.panel3.Location = new System.Drawing.Point(12, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 268);
            this.panel3.TabIndex = 0;
            // 
            // selectGbx
            // 
            this.selectGbx.Controls.Add(this.nyelvizsgaClick);
            this.selectGbx.Controls.Add(this.szakClick);
            this.selectGbx.Controls.Add(this.varosClick);
            this.selectGbx.Controls.Add(this.diakPanel);
            this.selectGbx.Location = new System.Drawing.Point(14, 12);
            this.selectGbx.Name = "selectGbx";
            this.selectGbx.Size = new System.Drawing.Size(216, 172);
            this.selectGbx.TabIndex = 1;
            this.selectGbx.TabStop = false;
            this.selectGbx.Text = "Lekérdezések";
            // 
            // nyelvizsgaClick
            // 
            this.nyelvizsgaClick.Controls.Add(this.pictureBox3);
            this.nyelvizsgaClick.Controls.Add(this.label3);
            this.nyelvizsgaClick.Location = new System.Drawing.Point(25, 96);
            this.nyelvizsgaClick.Name = "nyelvizsgaClick";
            this.nyelvizsgaClick.Size = new System.Drawing.Size(56, 71);
            this.nyelvizsgaClick.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::mssqlteszt.Properties.Resources.language1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nyelvizsgák";
            // 
            // szakClick
            // 
            this.szakClick.Controls.Add(this.pictureBox4);
            this.szakClick.Controls.Add(this.label4);
            this.szakClick.Location = new System.Drawing.Point(127, 96);
            this.szakClick.Name = "szakClick";
            this.szakClick.Size = new System.Drawing.Size(57, 70);
            this.szakClick.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::mssqlteszt.Properties.Resources.szakok;
            this.pictureBox4.Location = new System.Drawing.Point(3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Szakok";
            // 
            // varosClick
            // 
            this.varosClick.Controls.Add(this.pictureBox2);
            this.varosClick.Controls.Add(this.label2);
            this.varosClick.Location = new System.Drawing.Point(127, 15);
            this.varosClick.Name = "varosClick";
            this.varosClick.Size = new System.Drawing.Size(58, 73);
            this.varosClick.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mssqlteszt.Properties.Resources.city2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Városok";
            // 
            // diakPanel
            // 
            this.diakPanel.Controls.Add(this.pictureBox1);
            this.diakPanel.Controls.Add(this.label1);
            this.diakPanel.Location = new System.Drawing.Point(25, 18);
            this.diakPanel.Name = "diakPanel";
            this.diakPanel.Size = new System.Drawing.Size(57, 70);
            this.diakPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mssqlteszt.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Kattintson a képre a lekérdezéshez.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Diákok";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(266, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 277);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Kezdő form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.selectGbx.ResumeLayout(false);
            this.nyelvizsgaClick.ResumeLayout(false);
            this.nyelvizsgaClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.szakClick.ResumeLayout(false);
            this.szakClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.varosClick.ResumeLayout(false);
            this.varosClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.diakPanel.ResumeLayout(false);
            this.diakPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox selectGbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel diakPanel;
        private System.Windows.Forms.Panel varosClick;
        private System.Windows.Forms.Panel szakClick;
        private System.Windows.Forms.Panel nyelvizsgaClick;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

