namespace SignalLocalization
{
    partial class FrmOpisniPodaci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvOpisniPodaci = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.jbagaric20_DBDataSet = new SignalLocalization.jbagaric20_DBDataSet();
            this.testProstorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testProstorijaTableAdapter = new SignalLocalization.jbagaric20_DBDataSetTableAdapters.TestProstorijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpisniPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testProstorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOpisniPodaci
            // 
            this.dgvOpisniPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpisniPodaci.Location = new System.Drawing.Point(67, 68);
            this.dgvOpisniPodaci.Name = "dgvOpisniPodaci";
            this.dgvOpisniPodaci.RowHeadersWidth = 51;
            this.dgvOpisniPodaci.RowTemplate.Height = 24;
            this.dgvOpisniPodaci.Size = new System.Drawing.Size(663, 233);
            this.dgvOpisniPodaci.TabIndex = 0;
            this.dgvOpisniPodaci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpisniPodaci_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(519, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(629, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // jbagaric20_DBDataSet
            // 
            this.jbagaric20_DBDataSet.DataSetName = "jbagaric20_DBDataSet";
            this.jbagaric20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testProstorijaBindingSource
            // 
            this.testProstorijaBindingSource.DataMember = "TestProstorija";
            this.testProstorijaBindingSource.DataSource = this.jbagaric20_DBDataSet;
            // 
            // testProstorijaTableAdapter
            // 
            this.testProstorijaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOpisniPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOpisniPodaci);
            this.Name = "FrmOpisniPodaci";
            this.Text = "FrmOpisniPodaci";
            this.Load += new System.EventHandler(this.FrmOpisniPodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpisniPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testProstorijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOpisniPodaci;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private jbagaric20_DBDataSet jbagaric20_DBDataSet;
        private System.Windows.Forms.BindingSource testProstorijaBindingSource;
        private jbagaric20_DBDataSetTableAdapters.TestProstorijaTableAdapter testProstorijaTableAdapter;
    }
}

