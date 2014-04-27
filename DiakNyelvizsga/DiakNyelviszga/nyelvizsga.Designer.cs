namespace DiakNyelviszga
{
    partial class nyelvizsga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nyelvizsga));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // updateBtn
            // 
            this.updateBtn.Image = global::DiakNyelvizsga.Properties.Resources.book_edit;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(554, 9);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(80, 24);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Módosít";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::DiakNyelvizsga.Properties.Resources.arrow_refresh;
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Location = new System.Drawing.Point(554, 69);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(80, 24);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Frissít";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Image = global::DiakNyelvizsga.Properties.Resources.book_delete;
            this.delBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delBtn.Location = new System.Drawing.Point(554, 39);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(80, 24);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Töröl";
            this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Image = global::DiakNyelvizsga.Properties.Resources.add;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(554, 99);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Hozzáad";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nyelvizsga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nyelvizsga";
            this.Text = "Nyelvizsgák";
            this.Load += new System.EventHandler(this.nyelvizsga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
    }
}