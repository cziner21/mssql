namespace DiakNyelvizsga
{
    partial class szakSeacrh
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
            this.felevTbx = new System.Windows.Forms.TextBox();
            this.felevLbl = new System.Windows.Forms.Label();
            this.nevTbx = new System.Windows.Forms.TextBox();
            this.nevLbl = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.felevCbx = new System.Windows.Forms.CheckBox();
            this.nevCbx = new System.Windows.Forms.CheckBox();
            this.idCbx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(376, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 63);
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Keres";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // felevTbx
            // 
            this.felevTbx.Location = new System.Drawing.Point(212, 84);
            this.felevTbx.Name = "felevTbx";
            this.felevTbx.Size = new System.Drawing.Size(148, 20);
            this.felevTbx.TabIndex = 18;
            // 
            // felevLbl
            // 
            this.felevLbl.AutoSize = true;
            this.felevLbl.Location = new System.Drawing.Point(150, 84);
            this.felevLbl.Name = "felevLbl";
            this.felevLbl.Size = new System.Drawing.Size(54, 13);
            this.felevLbl.TabIndex = 17;
            this.felevLbl.Text = "FÉLÉVEK";
            // 
            // nevTbx
            // 
            this.nevTbx.Location = new System.Drawing.Point(212, 58);
            this.nevTbx.Name = "nevTbx";
            this.nevTbx.Size = new System.Drawing.Size(148, 20);
            this.nevTbx.TabIndex = 16;
            // 
            // nevLbl
            // 
            this.nevLbl.AutoSize = true;
            this.nevLbl.Location = new System.Drawing.Point(150, 58);
            this.nevLbl.Name = "nevLbl";
            this.nevLbl.Size = new System.Drawing.Size(29, 13);
            this.nevLbl.TabIndex = 15;
            this.nevLbl.Text = "NÉV";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(212, 32);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(148, 20);
            this.idTbx.TabIndex = 14;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(150, 32);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 13;
            this.idLbl.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.felevCbx);
            this.groupBox2.Controls.Add(this.nevCbx);
            this.groupBox2.Controls.Add(this.idCbx);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés";
            // 
            // felevCbx
            // 
            this.felevCbx.AutoSize = true;
            this.felevCbx.Location = new System.Drawing.Point(7, 66);
            this.felevCbx.Name = "felevCbx";
            this.felevCbx.Size = new System.Drawing.Size(73, 17);
            this.felevCbx.TabIndex = 2;
            this.felevCbx.Text = "FÉLÉVEK";
            this.felevCbx.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(9, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 159);
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
            this.dataGridView1.Size = new System.Drawing.Size(468, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // szakSeacrh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 302);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.felevTbx);
            this.Controls.Add(this.felevLbl);
            this.Controls.Add(this.nevTbx);
            this.Controls.Add(this.nevLbl);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "szakSeacrh";
            this.Text = "Szak keresése";
            this.Load += new System.EventHandler(this.szakSeacrh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox felevTbx;
        private System.Windows.Forms.Label felevLbl;
        private System.Windows.Forms.TextBox nevTbx;
        private System.Windows.Forms.Label nevLbl;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox felevCbx;
        private System.Windows.Forms.CheckBox nevCbx;
        private System.Windows.Forms.CheckBox idCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}