namespace DiakNyelvizsga
{
    partial class diakSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diakSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.serachBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.varosCbx = new System.Windows.Forms.CheckBox();
            this.zsebpenzCbx = new System.Windows.Forms.CheckBox();
            this.anyjaCbx = new System.Windows.Forms.CheckBox();
            this.telefonCbx = new System.Windows.Forms.CheckBox();
            this.cimCbx = new System.Windows.Forms.CheckBox();
            this.nevCbx = new System.Windows.Forms.CheckBox();
            this.idCbx = new System.Windows.Forms.CheckBox();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.nevTbx = new System.Windows.Forms.TextBox();
            this.cimTbx = new System.Windows.Forms.TextBox();
            this.telTbx = new System.Windows.Forms.TextBox();
            this.anyjaTbx = new System.Windows.Forms.TextBox();
            this.zsebpenzTbx = new System.Windows.Forms.TextBox();
            this.searchVarosCbx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eredmény";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 102);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(219, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(26, 13);
            this.lbl3.TabIndex = 38;
            this.lbl3.Text = "Cím";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(494, 54);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(55, 13);
            this.lbl7.TabIndex = 37;
            this.lbl7.Text = "Város név";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(495, 28);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(54, 13);
            this.lbl6.TabIndex = 36;
            this.lbl6.Text = "Zsebpénz";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(219, 130);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(60, 13);
            this.lbl5.TabIndex = 35;
            this.lbl5.Text = "Anyja neve";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(219, 104);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(67, 13);
            this.lbl4.TabIndex = 34;
            this.lbl4.Text = "Telefonszám";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(219, 54);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 13);
            this.lbl2.TabIndex = 33;
            this.lbl2.Text = "Név";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(219, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(18, 13);
            this.lbl1.TabIndex = 32;
            this.lbl1.Text = "ID";
            // 
            // serachBtn
            // 
            this.serachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serachBtn.Image = global::DiakNyelvizsga.Properties.Resources.magnify;
            this.serachBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.serachBtn.Location = new System.Drawing.Point(651, 131);
            this.serachBtn.Name = "serachBtn";
            this.serachBtn.Size = new System.Drawing.Size(100, 63);
            this.serachBtn.TabIndex = 44;
            this.serachBtn.Text = "Keresés";
            this.serachBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.serachBtn.UseVisualStyleBackColor = true;
            this.serachBtn.Click += new System.EventHandler(this.serachBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.varosCbx);
            this.groupBox2.Controls.Add(this.zsebpenzCbx);
            this.groupBox2.Controls.Add(this.anyjaCbx);
            this.groupBox2.Controls.Add(this.telefonCbx);
            this.groupBox2.Controls.Add(this.cimCbx);
            this.groupBox2.Controls.Add(this.nevCbx);
            this.groupBox2.Controls.Add(this.idCbx);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 142);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés";
            // 
            // varosCbx
            // 
            this.varosCbx.AutoSize = true;
            this.varosCbx.Location = new System.Drawing.Point(102, 43);
            this.varosCbx.Name = "varosCbx";
            this.varosCbx.Size = new System.Drawing.Size(63, 17);
            this.varosCbx.TabIndex = 6;
            this.varosCbx.Text = "VÁROS";
            this.varosCbx.UseVisualStyleBackColor = true;
            this.varosCbx.CheckedChanged += new System.EventHandler(this.varosCbx_CheckedChanged);
            // 
            // zsebpenzCbx
            // 
            this.zsebpenzCbx.AutoSize = true;
            this.zsebpenzCbx.Location = new System.Drawing.Point(102, 20);
            this.zsebpenzCbx.Name = "zsebpenzCbx";
            this.zsebpenzCbx.Size = new System.Drawing.Size(83, 17);
            this.zsebpenzCbx.TabIndex = 5;
            this.zsebpenzCbx.Text = "ZSEBPÉNZ";
            this.zsebpenzCbx.UseVisualStyleBackColor = true;
            this.zsebpenzCbx.CheckedChanged += new System.EventHandler(this.zsebpenzCbx_CheckedChanged);
            // 
            // anyjaCbx
            // 
            this.anyjaCbx.AutoSize = true;
            this.anyjaCbx.Location = new System.Drawing.Point(7, 112);
            this.anyjaCbx.Name = "anyjaCbx";
            this.anyjaCbx.Size = new System.Drawing.Size(92, 17);
            this.anyjaCbx.TabIndex = 4;
            this.anyjaCbx.Text = "ANYJA NEVE";
            this.anyjaCbx.UseVisualStyleBackColor = true;
            this.anyjaCbx.CheckedChanged += new System.EventHandler(this.anyjaCbx_CheckedChanged);
            // 
            // telefonCbx
            // 
            this.telefonCbx.AutoSize = true;
            this.telefonCbx.Location = new System.Drawing.Point(7, 89);
            this.telefonCbx.Name = "telefonCbx";
            this.telefonCbx.Size = new System.Drawing.Size(75, 17);
            this.telefonCbx.TabIndex = 3;
            this.telefonCbx.Text = "TELEFON";
            this.telefonCbx.UseVisualStyleBackColor = true;
            this.telefonCbx.CheckedChanged += new System.EventHandler(this.telefonCbx_CheckedChanged);
            // 
            // cimCbx
            // 
            this.cimCbx.AutoSize = true;
            this.cimCbx.Location = new System.Drawing.Point(7, 66);
            this.cimCbx.Name = "cimCbx";
            this.cimCbx.Size = new System.Drawing.Size(45, 17);
            this.cimCbx.TabIndex = 2;
            this.cimCbx.Text = "CÍM";
            this.cimCbx.UseVisualStyleBackColor = true;
            this.cimCbx.CheckedChanged += new System.EventHandler(this.cimCbx_CheckedChanged);
            // 
            // nevCbx
            // 
            this.nevCbx.AutoSize = true;
            this.nevCbx.Location = new System.Drawing.Point(7, 43);
            this.nevCbx.Name = "nevCbx";
            this.nevCbx.Size = new System.Drawing.Size(48, 17);
            this.nevCbx.TabIndex = 1;
            this.nevCbx.Text = "NÉV";
            this.nevCbx.UseVisualStyleBackColor = true;
            this.nevCbx.CheckedChanged += new System.EventHandler(this.nevCbx_CheckedChanged);
            // 
            // idCbx
            // 
            this.idCbx.AutoSize = true;
            this.idCbx.Location = new System.Drawing.Point(7, 20);
            this.idCbx.Name = "idCbx";
            this.idCbx.Size = new System.Drawing.Size(37, 17);
            this.idCbx.TabIndex = 0;
            this.idCbx.Text = "ID";
            this.idCbx.UseVisualStyleBackColor = true;
            this.idCbx.CheckedChanged += new System.EventHandler(this.idCbx_CheckedChanged);
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(292, 25);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(196, 20);
            this.idTbx.TabIndex = 50;
            // 
            // nevTbx
            // 
            this.nevTbx.Location = new System.Drawing.Point(292, 51);
            this.nevTbx.Name = "nevTbx";
            this.nevTbx.Size = new System.Drawing.Size(196, 20);
            this.nevTbx.TabIndex = 51;
            // 
            // cimTbx
            // 
            this.cimTbx.Location = new System.Drawing.Point(292, 76);
            this.cimTbx.Name = "cimTbx";
            this.cimTbx.Size = new System.Drawing.Size(196, 20);
            this.cimTbx.TabIndex = 52;
            // 
            // telTbx
            // 
            this.telTbx.Location = new System.Drawing.Point(292, 101);
            this.telTbx.Name = "telTbx";
            this.telTbx.Size = new System.Drawing.Size(196, 20);
            this.telTbx.TabIndex = 53;
            // 
            // anyjaTbx
            // 
            this.anyjaTbx.Location = new System.Drawing.Point(292, 127);
            this.anyjaTbx.Name = "anyjaTbx";
            this.anyjaTbx.Size = new System.Drawing.Size(196, 20);
            this.anyjaTbx.TabIndex = 54;
            // 
            // zsebpenzTbx
            // 
            this.zsebpenzTbx.Location = new System.Drawing.Point(555, 25);
            this.zsebpenzTbx.Name = "zsebpenzTbx";
            this.zsebpenzTbx.Size = new System.Drawing.Size(118, 20);
            this.zsebpenzTbx.TabIndex = 55;
            // 
            // searchVarosCbx
            // 
            this.searchVarosCbx.FormattingEnabled = true;
            this.searchVarosCbx.Location = new System.Drawing.Point(555, 50);
            this.searchVarosCbx.Name = "searchVarosCbx";
            this.searchVarosCbx.Size = new System.Drawing.Size(118, 21);
            this.searchVarosCbx.TabIndex = 56;
            // 
            // diakSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 318);
            this.Controls.Add(this.searchVarosCbx);
            this.Controls.Add(this.zsebpenzTbx);
            this.Controls.Add(this.anyjaTbx);
            this.Controls.Add(this.telTbx);
            this.Controls.Add(this.cimTbx);
            this.Controls.Add(this.nevTbx);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.serachBtn);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diakSearch";
            this.Text = "Diákok keresése";
            this.Load += new System.EventHandler(this.diakSearch_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button serachBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox varosCbx;
        private System.Windows.Forms.CheckBox zsebpenzCbx;
        private System.Windows.Forms.CheckBox anyjaCbx;
        private System.Windows.Forms.CheckBox telefonCbx;
        private System.Windows.Forms.CheckBox cimCbx;
        private System.Windows.Forms.CheckBox nevCbx;
        private System.Windows.Forms.CheckBox idCbx;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.TextBox nevTbx;
        private System.Windows.Forms.TextBox cimTbx;
        private System.Windows.Forms.TextBox telTbx;
        private System.Windows.Forms.TextBox anyjaTbx;
        private System.Windows.Forms.TextBox zsebpenzTbx;
        private System.Windows.Forms.ComboBox searchVarosCbx;
    }
}