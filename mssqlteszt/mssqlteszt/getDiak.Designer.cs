namespace mssqlteszt
{
    partial class getDiak
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.beadandoDataSet = new mssqlteszt.beadandoDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anyjaneveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsebpenzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varosidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskgetalldiakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isk_getalldiakTableAdapter = new mssqlteszt.beadandoDataSetTableAdapters.isk_getalldiakTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beadandoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iskgetalldiakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.cimDataGridViewTextBoxColumn,
            this.telszamDataGridViewTextBoxColumn,
            this.anyjaneveDataGridViewTextBoxColumn,
            this.zsebpenzDataGridViewTextBoxColumn,
            this.varosidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iskgetalldiakBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // beadandoDataSet
            // 
            this.beadandoDataSet.DataSetName = "beadandoDataSet";
            this.beadandoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // cimDataGridViewTextBoxColumn
            // 
            this.cimDataGridViewTextBoxColumn.DataPropertyName = "cim";
            this.cimDataGridViewTextBoxColumn.HeaderText = "cim";
            this.cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            // 
            // telszamDataGridViewTextBoxColumn
            // 
            this.telszamDataGridViewTextBoxColumn.DataPropertyName = "tel_szam";
            this.telszamDataGridViewTextBoxColumn.HeaderText = "tel_szam";
            this.telszamDataGridViewTextBoxColumn.Name = "telszamDataGridViewTextBoxColumn";
            // 
            // anyjaneveDataGridViewTextBoxColumn
            // 
            this.anyjaneveDataGridViewTextBoxColumn.DataPropertyName = "anyja_neve";
            this.anyjaneveDataGridViewTextBoxColumn.HeaderText = "anyja_neve";
            this.anyjaneveDataGridViewTextBoxColumn.Name = "anyjaneveDataGridViewTextBoxColumn";
            // 
            // zsebpenzDataGridViewTextBoxColumn
            // 
            this.zsebpenzDataGridViewTextBoxColumn.DataPropertyName = "zsebpenz";
            this.zsebpenzDataGridViewTextBoxColumn.HeaderText = "zsebpenz";
            this.zsebpenzDataGridViewTextBoxColumn.Name = "zsebpenzDataGridViewTextBoxColumn";
            // 
            // varosidDataGridViewTextBoxColumn
            // 
            this.varosidDataGridViewTextBoxColumn.DataPropertyName = "varos_id";
            this.varosidDataGridViewTextBoxColumn.HeaderText = "varos_id";
            this.varosidDataGridViewTextBoxColumn.Name = "varosidDataGridViewTextBoxColumn";
            // 
            // iskgetalldiakBindingSource
            // 
            this.iskgetalldiakBindingSource.DataMember = "isk_getalldiak";
            this.iskgetalldiakBindingSource.DataSource = this.beadandoDataSet;
            // 
            // isk_getalldiakTableAdapter
            // 
            this.isk_getalldiakTableAdapter.ClearBeforeFill = true;
            // 
            // getDiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 277);
            this.Controls.Add(this.dataGridView1);
            this.Name = "getDiak";
            this.Text = "Diákok lekérdezése";
            this.Load += new System.EventHandler(this.getDiak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beadandoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iskgetalldiakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private beadandoDataSet beadandoDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anyjaneveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsebpenzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varosidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iskgetalldiakBindingSource;
        private beadandoDataSetTableAdapters.isk_getalldiakTableAdapter isk_getalldiakTableAdapter;
    }
}