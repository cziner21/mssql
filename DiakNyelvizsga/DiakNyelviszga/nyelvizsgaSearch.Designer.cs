namespace DiakNyelvizsga
{
    partial class nyelvizsgaSearch
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.nyelvTbx = new System.Windows.Forms.TextBox();
            this.nyelvLbl = new System.Windows.Forms.Label();
            this.tipusTbx = new System.Windows.Forms.TextBox();
            this.tipusLbl = new System.Windows.Forms.Label();
            this.szintTbx = new System.Windows.Forms.TextBox();
            this.szintLbl = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nyelvCbx = new System.Windows.Forms.CheckBox();
            this.tipusCbx = new System.Windows.Forms.CheckBox();
            this.szintCbx = new System.Windows.Forms.CheckBox();
            this.idCbx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iskolaCbx = new System.Windows.Forms.CheckBox();
            this.iskolaTbx = new System.Windows.Forms.TextBox();
            this.iskolaLbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(310, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 63);
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Keres";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nyelvTbx
            // 
            this.nyelvTbx.Location = new System.Drawing.Point(188, 109);
            this.nyelvTbx.Name = "nyelvTbx";
            this.nyelvTbx.Size = new System.Drawing.Size(100, 20);
            this.nyelvTbx.TabIndex = 20;
            // 
            // nyelvLbl
            // 
            this.nyelvLbl.AutoSize = true;
            this.nyelvLbl.Location = new System.Drawing.Point(117, 109);
            this.nyelvLbl.Name = "nyelvLbl";
            this.nyelvLbl.Size = new System.Drawing.Size(42, 13);
            this.nyelvLbl.TabIndex = 19;
            this.nyelvLbl.Text = "NYELV";
            // 
            // tipusTbx
            // 
            this.tipusTbx.Location = new System.Drawing.Point(188, 83);
            this.tipusTbx.Name = "tipusTbx";
            this.tipusTbx.Size = new System.Drawing.Size(100, 20);
            this.tipusTbx.TabIndex = 18;
            // 
            // tipusLbl
            // 
            this.tipusLbl.AutoSize = true;
            this.tipusLbl.Location = new System.Drawing.Point(117, 83);
            this.tipusLbl.Name = "tipusLbl";
            this.tipusLbl.Size = new System.Drawing.Size(39, 13);
            this.tipusLbl.TabIndex = 17;
            this.tipusLbl.Text = "TÍPUS";
            // 
            // szintTbx
            // 
            this.szintTbx.Location = new System.Drawing.Point(188, 57);
            this.szintTbx.Name = "szintTbx";
            this.szintTbx.Size = new System.Drawing.Size(100, 20);
            this.szintTbx.TabIndex = 16;
            // 
            // szintLbl
            // 
            this.szintLbl.AutoSize = true;
            this.szintLbl.Location = new System.Drawing.Point(117, 57);
            this.szintLbl.Name = "szintLbl";
            this.szintLbl.Size = new System.Drawing.Size(39, 13);
            this.szintLbl.TabIndex = 15;
            this.szintLbl.Text = "SZINT";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(188, 31);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(100, 20);
            this.idTbx.TabIndex = 14;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(117, 31);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 13;
            this.idLbl.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iskolaCbx);
            this.groupBox2.Controls.Add(this.nyelvCbx);
            this.groupBox2.Controls.Add(this.tipusCbx);
            this.groupBox2.Controls.Add(this.szintCbx);
            this.groupBox2.Controls.Add(this.idCbx);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 137);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés";
            // 
            // nyelvCbx
            // 
            this.nyelvCbx.AutoSize = true;
            this.nyelvCbx.Location = new System.Drawing.Point(7, 89);
            this.nyelvCbx.Name = "nyelvCbx";
            this.nyelvCbx.Size = new System.Drawing.Size(61, 17);
            this.nyelvCbx.TabIndex = 3;
            this.nyelvCbx.Text = "NYELV";
            this.nyelvCbx.UseVisualStyleBackColor = true;
            // 
            // tipusCbx
            // 
            this.tipusCbx.AutoSize = true;
            this.tipusCbx.Location = new System.Drawing.Point(7, 66);
            this.tipusCbx.Name = "tipusCbx";
            this.tipusCbx.Size = new System.Drawing.Size(58, 17);
            this.tipusCbx.TabIndex = 2;
            this.tipusCbx.Text = "TÍPUS";
            this.tipusCbx.UseVisualStyleBackColor = true;
            // 
            // szintCbx
            // 
            this.szintCbx.AutoSize = true;
            this.szintCbx.Location = new System.Drawing.Point(7, 43);
            this.szintCbx.Name = "szintCbx";
            this.szintCbx.Size = new System.Drawing.Size(58, 17);
            this.szintCbx.TabIndex = 1;
            this.szintCbx.Text = "SZINT";
            this.szintCbx.UseVisualStyleBackColor = true;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eredmény";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // iskolaCbx
            // 
            this.iskolaCbx.AutoSize = true;
            this.iskolaCbx.Location = new System.Drawing.Point(7, 112);
            this.iskolaCbx.Name = "iskolaCbx";
            this.iskolaCbx.Size = new System.Drawing.Size(64, 17);
            this.iskolaCbx.TabIndex = 4;
            this.iskolaCbx.Text = "ISKOLA";
            this.iskolaCbx.UseVisualStyleBackColor = true;
            // 
            // iskolaTbx
            // 
            this.iskolaTbx.Location = new System.Drawing.Point(188, 136);
            this.iskolaTbx.Name = "iskolaTbx";
            this.iskolaTbx.Size = new System.Drawing.Size(100, 20);
            this.iskolaTbx.TabIndex = 23;
            // 
            // iskolaLbl
            // 
            this.iskolaLbl.AutoSize = true;
            this.iskolaLbl.Location = new System.Drawing.Point(117, 136);
            this.iskolaLbl.Name = "iskolaLbl";
            this.iskolaLbl.Size = new System.Drawing.Size(45, 13);
            this.iskolaLbl.TabIndex = 22;
            this.iskolaLbl.Text = "ISKOLA";
            // 
            // nyelvizsgaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 339);
            this.Controls.Add(this.iskolaTbx);
            this.Controls.Add(this.iskolaLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nyelvTbx);
            this.Controls.Add(this.nyelvLbl);
            this.Controls.Add(this.tipusTbx);
            this.Controls.Add(this.tipusLbl);
            this.Controls.Add(this.szintTbx);
            this.Controls.Add(this.szintLbl);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "nyelvizsgaSearch";
            this.Text = "Nyelvizsga keresése";
            this.Load += new System.EventHandler(this.nyelvizsgaSearch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nyelvTbx;
        private System.Windows.Forms.Label nyelvLbl;
        private System.Windows.Forms.TextBox tipusTbx;
        private System.Windows.Forms.Label tipusLbl;
        private System.Windows.Forms.TextBox szintTbx;
        private System.Windows.Forms.Label szintLbl;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox iskolaCbx;
        private System.Windows.Forms.CheckBox nyelvCbx;
        private System.Windows.Forms.CheckBox tipusCbx;
        private System.Windows.Forms.CheckBox szintCbx;
        private System.Windows.Forms.CheckBox idCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox iskolaTbx;
        private System.Windows.Forms.Label iskolaLbl;
    }
}