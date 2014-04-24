namespace DiakNyelvizsga
{
    partial class varosSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orszagCbx = new System.Windows.Forms.CheckBox();
            this.megyeCbx = new System.Windows.Forms.CheckBox();
            this.nevCbx = new System.Windows.Forms.CheckBox();
            this.idCbx = new System.Windows.Forms.CheckBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.nevTbx = new System.Windows.Forms.TextBox();
            this.nevLbl = new System.Windows.Forms.Label();
            this.megyeTbx = new System.Windows.Forms.TextBox();
            this.megyeLbl = new System.Windows.Forms.Label();
            this.orszagTbx = new System.Windows.Forms.TextBox();
            this.orszagLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 159);
            this.groupBox1.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orszagCbx);
            this.groupBox2.Controls.Add(this.megyeCbx);
            this.groupBox2.Controls.Add(this.nevCbx);
            this.groupBox2.Controls.Add(this.idCbx);
            this.groupBox2.Location = new System.Drawing.Point(15, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés";
            // 
            // orszagCbx
            // 
            this.orszagCbx.AutoSize = true;
            this.orszagCbx.Location = new System.Drawing.Point(7, 89);
            this.orszagCbx.Name = "orszagCbx";
            this.orszagCbx.Size = new System.Drawing.Size(71, 17);
            this.orszagCbx.TabIndex = 3;
            this.orszagCbx.Text = "ORSZÁG";
            this.orszagCbx.UseVisualStyleBackColor = true;
            this.orszagCbx.CheckedChanged += new System.EventHandler(this.orszagCbx_CheckedChanged);
            // 
            // megyeCbx
            // 
            this.megyeCbx.AutoSize = true;
            this.megyeCbx.Location = new System.Drawing.Point(7, 66);
            this.megyeCbx.Name = "megyeCbx";
            this.megyeCbx.Size = new System.Drawing.Size(64, 17);
            this.megyeCbx.TabIndex = 2;
            this.megyeCbx.Text = "MEGYE";
            this.megyeCbx.UseVisualStyleBackColor = true;
            this.megyeCbx.CheckedChanged += new System.EventHandler(this.megyeCbx_CheckedChanged);
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
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(120, 49);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(191, 49);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(100, 20);
            this.idTbx.TabIndex = 3;
            this.idTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTbx_KeyPress);
            // 
            // nevTbx
            // 
            this.nevTbx.Location = new System.Drawing.Point(191, 75);
            this.nevTbx.Name = "nevTbx";
            this.nevTbx.Size = new System.Drawing.Size(100, 20);
            this.nevTbx.TabIndex = 5;
            // 
            // nevLbl
            // 
            this.nevLbl.AutoSize = true;
            this.nevLbl.Location = new System.Drawing.Point(120, 75);
            this.nevLbl.Name = "nevLbl";
            this.nevLbl.Size = new System.Drawing.Size(29, 13);
            this.nevLbl.TabIndex = 4;
            this.nevLbl.Text = "NÉV";
            // 
            // megyeTbx
            // 
            this.megyeTbx.Location = new System.Drawing.Point(191, 101);
            this.megyeTbx.Name = "megyeTbx";
            this.megyeTbx.Size = new System.Drawing.Size(100, 20);
            this.megyeTbx.TabIndex = 7;
            // 
            // megyeLbl
            // 
            this.megyeLbl.AutoSize = true;
            this.megyeLbl.Location = new System.Drawing.Point(120, 101);
            this.megyeLbl.Name = "megyeLbl";
            this.megyeLbl.Size = new System.Drawing.Size(45, 13);
            this.megyeLbl.TabIndex = 6;
            this.megyeLbl.Text = "MEGYE";
            // 
            // orszagTbx
            // 
            this.orszagTbx.Location = new System.Drawing.Point(191, 127);
            this.orszagTbx.Name = "orszagTbx";
            this.orszagTbx.Size = new System.Drawing.Size(100, 20);
            this.orszagTbx.TabIndex = 9;
            // 
            // orszagLbl
            // 
            this.orszagLbl.AutoSize = true;
            this.orszagLbl.Location = new System.Drawing.Point(120, 127);
            this.orszagLbl.Name = "orszagLbl";
            this.orszagLbl.Size = new System.Drawing.Size(52, 13);
            this.orszagLbl.TabIndex = 8;
            this.orszagLbl.Text = "ORSZÁG";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(313, 49);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 63);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Keres";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // varosSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 321);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.orszagTbx);
            this.Controls.Add(this.orszagLbl);
            this.Controls.Add(this.megyeTbx);
            this.Controls.Add(this.megyeLbl);
            this.Controls.Add(this.nevTbx);
            this.Controls.Add(this.nevLbl);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "varosSearch";
            this.Text = "Városok keresése";
            this.Load += new System.EventHandler(this.searchVaros_Load);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox orszagCbx;
        private System.Windows.Forms.CheckBox megyeCbx;
        private System.Windows.Forms.CheckBox nevCbx;
        private System.Windows.Forms.CheckBox idCbx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.TextBox nevTbx;
        private System.Windows.Forms.Label nevLbl;
        private System.Windows.Forms.TextBox megyeTbx;
        private System.Windows.Forms.Label megyeLbl;
        private System.Windows.Forms.TextBox orszagTbx;
        private System.Windows.Forms.Label orszagLbl;
        private System.Windows.Forms.Button searchBtn;
    }
}