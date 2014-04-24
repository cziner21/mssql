namespace DiakNyelvizsga
{
    partial class tarsitNyelvizsga
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
            this.hozzaadBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // hozzaadBtn
            // 
            this.hozzaadBtn.Location = new System.Drawing.Point(197, 227);
            this.hozzaadBtn.Name = "hozzaadBtn";
            this.hozzaadBtn.Size = new System.Drawing.Size(75, 23);
            this.hozzaadBtn.TabIndex = 0;
            this.hozzaadBtn.Text = "Hozzáad";
            this.hozzaadBtn.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(215, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // tarsitNyelvizsga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.hozzaadBtn);
            this.Name = "tarsitNyelvizsga";
            this.Text = "tarsitNyelvizsga";
            this.Load += new System.EventHandler(this.tarsitNyelvizsga_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hozzaadBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}