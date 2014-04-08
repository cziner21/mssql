namespace mssqlteszt
{
    partial class addDiak
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
            this.hozzaadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.zsebpenzTbx = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.anyjaTbx = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.telefonTbx = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cimTbx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keresztnev1Tbx = new System.Windows.Forms.TextBox();
            this.keresztnev2Tbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vezeteknevTbx = new System.Windows.Forms.TextBox();
            this.varosIdCbx = new System.Windows.Forms.ComboBox();
            this.beadandoDataSet = new mssqlteszt.beadandoDataSet();
            this.isk_diak2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isk_diak2TableAdapter = new mssqlteszt.beadandoDataSetTableAdapters.isk_diak2TableAdapter();
            this.tableAdapterManager = new mssqlteszt.beadandoDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beadandoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isk_diak2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hozzaadBtn
            // 
            this.hozzaadBtn.Location = new System.Drawing.Point(180, 464);
            this.hozzaadBtn.Name = "hozzaadBtn";
            this.hozzaadBtn.Size = new System.Drawing.Size(75, 24);
            this.hozzaadBtn.TabIndex = 1;
            this.hozzaadBtn.Text = "Hozzáad";
            this.hozzaadBtn.UseVisualStyleBackColor = true;
            this.hozzaadBtn.Click += new System.EventHandler(this.hozzaadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.hozzaadBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.varosIdCbx);
            this.groupBox8.Location = new System.Drawing.Point(9, 400);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(107, 52);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Irányítószám";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.zsebpenzTbx);
            this.groupBox7.Location = new System.Drawing.Point(9, 342);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(246, 52);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Zsebpénz";
            // 
            // zsebpenzTbx
            // 
            this.zsebpenzTbx.Location = new System.Drawing.Point(7, 23);
            this.zsebpenzTbx.Name = "zsebpenzTbx";
            this.zsebpenzTbx.Size = new System.Drawing.Size(233, 20);
            this.zsebpenzTbx.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.anyjaTbx);
            this.groupBox6.Location = new System.Drawing.Point(9, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 52);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Anyja neve";
            // 
            // anyjaTbx
            // 
            this.anyjaTbx.Location = new System.Drawing.Point(7, 23);
            this.anyjaTbx.Name = "anyjaTbx";
            this.anyjaTbx.Size = new System.Drawing.Size(233, 20);
            this.anyjaTbx.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.telefonTbx);
            this.groupBox5.Location = new System.Drawing.Point(9, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 52);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Telefonszám";
            // 
            // telefonTbx
            // 
            this.telefonTbx.Location = new System.Drawing.Point(7, 23);
            this.telefonTbx.Name = "telefonTbx";
            this.telefonTbx.Size = new System.Drawing.Size(233, 20);
            this.telefonTbx.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cimTbx);
            this.groupBox4.Location = new System.Drawing.Point(9, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 52);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cím";
            // 
            // cimTbx
            // 
            this.cimTbx.Location = new System.Drawing.Point(7, 23);
            this.cimTbx.Name = "cimTbx";
            this.cimTbx.Size = new System.Drawing.Size(233, 20);
            this.cimTbx.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.keresztnev1Tbx);
            this.groupBox3.Controls.Add(this.keresztnev2Tbx);
            this.groupBox3.Location = new System.Drawing.Point(9, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 75);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keresztnév";
            // 
            // keresztnev1Tbx
            // 
            this.keresztnev1Tbx.Location = new System.Drawing.Point(6, 19);
            this.keresztnev1Tbx.Name = "keresztnev1Tbx";
            this.keresztnev1Tbx.Size = new System.Drawing.Size(233, 20);
            this.keresztnev1Tbx.TabIndex = 15;
            // 
            // keresztnev2Tbx
            // 
            this.keresztnev2Tbx.Location = new System.Drawing.Point(6, 45);
            this.keresztnev2Tbx.Name = "keresztnev2Tbx";
            this.keresztnev2Tbx.Size = new System.Drawing.Size(233, 20);
            this.keresztnev2Tbx.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vezeteknevTbx);
            this.groupBox2.Location = new System.Drawing.Point(9, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 52);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vezetéknév";
            // 
            // vezeteknevTbx
            // 
            this.vezeteknevTbx.Location = new System.Drawing.Point(7, 23);
            this.vezeteknevTbx.Name = "vezeteknevTbx";
            this.vezeteknevTbx.Size = new System.Drawing.Size(233, 20);
            this.vezeteknevTbx.TabIndex = 8;
            // 
            // varosIdCbx
            // 
            this.varosIdCbx.FormattingEnabled = true;
            this.varosIdCbx.Location = new System.Drawing.Point(7, 25);
            this.varosIdCbx.Name = "varosIdCbx";
            this.varosIdCbx.Size = new System.Drawing.Size(92, 21);
            this.varosIdCbx.TabIndex = 0;
            // 
            // beadandoDataSet
            // 
            this.beadandoDataSet.DataSetName = "beadandoDataSet";
            this.beadandoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isk_diak2BindingSource
            // 
            this.isk_diak2BindingSource.DataMember = "isk_diak2";
            this.isk_diak2BindingSource.DataSource = this.beadandoDataSet;
            // 
            // isk_diak2TableAdapter
            // 
            this.isk_diak2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.isk_diak_nyelvizsgaTableAdapter = null;
            this.tableAdapterManager.isk_diak_szakTableAdapter = null;
            this.tableAdapterManager.isk_diak2TableAdapter = this.isk_diak2TableAdapter;
            this.tableAdapterManager.isk_nyelvizsgaTableAdapter = null;
            this.tableAdapterManager.isk_szakTableAdapter = null;
            this.tableAdapterManager.isk_varosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mssqlteszt.beadandoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addDiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 498);
            this.Controls.Add(this.groupBox1);
            this.Name = "addDiak";
            this.Text = "Új diák hozzáadása";
            this.Load += new System.EventHandler(this.addDiak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beadandoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isk_diak2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hozzaadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keresztnev2Tbx;
        private System.Windows.Forms.TextBox keresztnev1Tbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vezeteknevTbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox cimTbx;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox zsebpenzTbx;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox anyjaTbx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox telefonTbx;
        private System.Windows.Forms.ComboBox varosIdCbx;
        private beadandoDataSet beadandoDataSet;
        private System.Windows.Forms.BindingSource isk_diak2BindingSource;
        private beadandoDataSetTableAdapters.isk_diak2TableAdapter isk_diak2TableAdapter;
        private beadandoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}