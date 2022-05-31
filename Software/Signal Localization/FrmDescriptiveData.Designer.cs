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
            this.dgvDescriptiveData = new System.Windows.Forms.DataGridView();
            this.zatvoreniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jbagaric20_DBDataSet = new Signal_Localization.jbagaric20_DBDataSet();
            this.zatvoreniciTableAdapter = new Signal_Localization.jbagaric20_DBDataSetTableAdapters.ZatvoreniciTableAdapter();
            this.tableAdapterManager = new Signal_Localization.jbagaric20_DBDataSetTableAdapters.TableAdapterManager();
            this.idZatvorenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeZatvorenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeZatvorenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPritvoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptiveData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatvoreniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).BeginInit();
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
            // dgvDescriptiveData
            // 
            this.dgvDescriptiveData.AutoGenerateColumns = false;
            this.dgvDescriptiveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescriptiveData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZatvorenikaDataGridViewTextBoxColumn,
            this.imeZatvorenikaDataGridViewTextBoxColumn,
            this.prezimeZatvorenikaDataGridViewTextBoxColumn,
            this.datumPritvoraDataGridViewTextBoxColumn});
            this.dgvDescriptiveData.DataSource = this.zatvoreniciBindingSource;
            this.dgvDescriptiveData.Location = new System.Drawing.Point(94, 74);
            this.dgvDescriptiveData.Name = "dgvDescriptiveData";
            this.dgvDescriptiveData.RowHeadersWidth = 51;
            this.dgvDescriptiveData.RowTemplate.Height = 24;
            this.dgvDescriptiveData.Size = new System.Drawing.Size(657, 231);
            this.dgvDescriptiveData.TabIndex = 3;
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
            // idZatvorenikaDataGridViewTextBoxColumn
            // 
            this.idZatvorenikaDataGridViewTextBoxColumn.DataPropertyName = "idZatvorenika";
            this.idZatvorenikaDataGridViewTextBoxColumn.HeaderText = "idZatvorenika";
            this.idZatvorenikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idZatvorenikaDataGridViewTextBoxColumn.Name = "idZatvorenikaDataGridViewTextBoxColumn";
            this.idZatvorenikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeZatvorenikaDataGridViewTextBoxColumn
            // 
            this.imeZatvorenikaDataGridViewTextBoxColumn.DataPropertyName = "imeZatvorenika";
            this.imeZatvorenikaDataGridViewTextBoxColumn.HeaderText = "imeZatvorenika";
            this.imeZatvorenikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeZatvorenikaDataGridViewTextBoxColumn.Name = "imeZatvorenikaDataGridViewTextBoxColumn";
            this.imeZatvorenikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeZatvorenikaDataGridViewTextBoxColumn
            // 
            this.prezimeZatvorenikaDataGridViewTextBoxColumn.DataPropertyName = "prezimeZatvorenika";
            this.prezimeZatvorenikaDataGridViewTextBoxColumn.HeaderText = "prezimeZatvorenika";
            this.prezimeZatvorenikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeZatvorenikaDataGridViewTextBoxColumn.Name = "prezimeZatvorenikaDataGridViewTextBoxColumn";
            this.prezimeZatvorenikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumPritvoraDataGridViewTextBoxColumn
            // 
            this.datumPritvoraDataGridViewTextBoxColumn.DataPropertyName = "datumPritvora";
            this.datumPritvoraDataGridViewTextBoxColumn.HeaderText = "datumPritvora";
            this.datumPritvoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumPritvoraDataGridViewTextBoxColumn.Name = "datumPritvoraDataGridViewTextBoxColumn";
            this.datumPritvoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmDescriptiveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.dgvDescriptiveData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmDescriptiveData";
            this.Text = "FrmDescriptiveData";
            this.Load += new System.EventHandler(this.FrmDescriptiveData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptiveData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatvoreniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbagaric20_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDescriptiveData;
        private jbagaric20_DBDataSet jbagaric20_DBDataSet;
        private System.Windows.Forms.BindingSource zatvoreniciBindingSource;
        private jbagaric20_DBDataSetTableAdapters.ZatvoreniciTableAdapter zatvoreniciTableAdapter;
        private jbagaric20_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZatvorenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeZatvorenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeZatvorenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPritvoraDataGridViewTextBoxColumn;
    }
}

