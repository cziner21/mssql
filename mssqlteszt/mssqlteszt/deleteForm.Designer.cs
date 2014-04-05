namespace mssqlteszt
{
    partial class deleteForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.deleteDiak = new System.Windows.Forms.TabPage();
            this.deleteVaros = new System.Windows.Forms.TabPage();
            this.deleteNyelvvizsga = new System.Windows.Forms.TabPage();
            this.deleteSzak = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.deleteDiak);
            this.tabControl1.Controls.Add(this.deleteVaros);
            this.tabControl1.Controls.Add(this.deleteNyelvvizsga);
            this.tabControl1.Controls.Add(this.deleteSzak);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // deleteDiak
            // 
            this.deleteDiak.Location = new System.Drawing.Point(4, 22);
            this.deleteDiak.Name = "deleteDiak";
            this.deleteDiak.Padding = new System.Windows.Forms.Padding(3);
            this.deleteDiak.Size = new System.Drawing.Size(459, 257);
            this.deleteDiak.TabIndex = 0;
            this.deleteDiak.Text = "Diákok törlése";
            this.deleteDiak.UseVisualStyleBackColor = true;
            // 
            // deleteVaros
            // 
            this.deleteVaros.Location = new System.Drawing.Point(4, 22);
            this.deleteVaros.Name = "deleteVaros";
            this.deleteVaros.Padding = new System.Windows.Forms.Padding(3);
            this.deleteVaros.Size = new System.Drawing.Size(459, 257);
            this.deleteVaros.TabIndex = 1;
            this.deleteVaros.Text = "Városok törlése";
            this.deleteVaros.UseVisualStyleBackColor = true;
            // 
            // deleteNyelvvizsga
            // 
            this.deleteNyelvvizsga.Location = new System.Drawing.Point(4, 22);
            this.deleteNyelvvizsga.Name = "deleteNyelvvizsga";
            this.deleteNyelvvizsga.Padding = new System.Windows.Forms.Padding(3);
            this.deleteNyelvvizsga.Size = new System.Drawing.Size(459, 257);
            this.deleteNyelvvizsga.TabIndex = 2;
            this.deleteNyelvvizsga.Text = "Nyelvizsgák törlése";
            this.deleteNyelvvizsga.UseVisualStyleBackColor = true;
            // 
            // deleteSzak
            // 
            this.deleteSzak.Location = new System.Drawing.Point(4, 22);
            this.deleteSzak.Name = "deleteSzak";
            this.deleteSzak.Padding = new System.Windows.Forms.Padding(3);
            this.deleteSzak.Size = new System.Drawing.Size(459, 257);
            this.deleteSzak.TabIndex = 3;
            this.deleteSzak.Text = "Szakok törlése";
            this.deleteSzak.UseVisualStyleBackColor = true;
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 307);
            this.Controls.Add(this.tabControl1);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage deleteDiak;
        private System.Windows.Forms.TabPage deleteVaros;
        private System.Windows.Forms.TabPage deleteNyelvvizsga;
        private System.Windows.Forms.TabPage deleteSzak;
    }
}