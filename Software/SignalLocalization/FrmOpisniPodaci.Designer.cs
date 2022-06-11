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
            this.dgvOpisniPodaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpisniPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOpisniPodaci
            // 
            this.dgvOpisniPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOpisniPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpisniPodaci.Location = new System.Drawing.Point(77, 59);
            this.dgvOpisniPodaci.Name = "dgvOpisniPodaci";
            this.dgvOpisniPodaci.RowHeadersWidth = 51;
            this.dgvOpisniPodaci.RowTemplate.Height = 24;
            this.dgvOpisniPodaci.Size = new System.Drawing.Size(638, 234);
            this.dgvOpisniPodaci.TabIndex = 0;
            // 
            // FrmOpisniPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOpisniPodaci);
            this.Name = "FrmOpisniPodaci";
            this.Text = "FrmOpisniPodaci";
            this.Load += new System.EventHandler(this.FrmOpisniPodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpisniPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOpisniPodaci;
    }
}

