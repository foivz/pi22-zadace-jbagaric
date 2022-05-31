namespace Signal_Localization
{
    partial class FrmDescriptiveData
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.zatvoreniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jbagaric20_DBDataSet = new Signal_Localization.jbagaric20_DBDataSet();
            this.zatvoreniciTableAdapter = new Signal_Localization.jbagaric20_DBDataSetTableAdapters.ZatvoreniciTableAdapter();
            this.tableAdapterManager = new Signal_Localization.jbagaric20_DBDataSetTableAdapters.TableAdapterManager();
            this.prostorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prostorijeTableAdapter = new Signal_Localization.jbagaric20_DBDataSetTableAdapters.ProstorijeTableAdapter();
            this.dgvDescriptiveData2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zatvoreniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptiveData2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(524, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(620, 326);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 35);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Promijeni";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // zatvoreniciBindingSource
            // 
            this.zatvoreniciBindingSource.DataMember = "Zatvorenici";
            this.zatvoreniciBindingSource.DataSource = this.jbagaric20_DBDataSet;
            // 
            // jbagaric20_DBDataSet
            // 
            this.jbagaric20_DBDataSet.DataSetName = "jbagaric20_DBDataSet";
            this.jbagaric20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zatvoreniciTableAdapter
            // 
            this.zatvoreniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProstorijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Signal_Localization.jbagaric20_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Voditelj_objektaTableAdapter = null;
            this.tableAdapterManager.ZatvoreniciTableAdapter = this.zatvoreniciTableAdapter;
            // 
            // prostorijeBindingSource
            // 
            this.prostorijeBindingSource.DataMember = "Prostorije";
            this.prostorijeBindingSource.DataSource = this.jbagaric20_DBDataSet;
            // 
            // prostorijeTableAdapter
            // 
            this.prostorijeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDescriptiveData2
            // 
            this.dgvDescriptiveData2.AutoGenerateColumns = false;
            this.dgvDescriptiveData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescriptiveData2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvDescriptiveData2.DataSource = this.prostorijeBindingSource;
            this.dgvDescriptiveData2.Location = new System.Drawing.Point(44, 74);
            this.dgvDescriptiveData2.Name = "dgvDescriptiveData2";
            this.dgvDescriptiveData2.RowHeadersWidth = 51;
            this.dgvDescriptiveData2.RowTemplate.Height = 24;
            this.dgvDescriptiveData2.Size = new System.Drawing.Size(783, 233);
            this.dgvDescriptiveData2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProstorije";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProstorije";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kat";
            this.dataGridViewTextBoxColumn2.HeaderText = "kat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vrsta";
            this.dataGridViewTextBoxColumn3.HeaderText = "vrsta";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "brojKreveta";
            this.dataGridViewTextBoxColumn4.HeaderText = "brojKreveta";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "veličina";
            this.dataGridViewTextBoxColumn5.HeaderText = "veličina";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // FrmDescriptiveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.dgvDescriptiveData2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmDescriptiveData";
            this.Text = "FrmDescriptiveData";
            this.Load += new System.EventHandler(this.FrmDescriptiveData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zatvoreniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prostorijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptiveData2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private jbagaric20_DBDataSet jbagaric20_DBDataSet;
        private System.Windows.Forms.BindingSource zatvoreniciBindingSource;
        private jbagaric20_DBDataSetTableAdapters.ZatvoreniciTableAdapter zatvoreniciTableAdapter;
        private jbagaric20_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource prostorijeBindingSource;
        private jbagaric20_DBDataSetTableAdapters.ProstorijeTableAdapter prostorijeTableAdapter;
        private System.Windows.Forms.DataGridView dgvDescriptiveData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

