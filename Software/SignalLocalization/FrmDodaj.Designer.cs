namespace SignalLocalization
{
    partial class FrmDodaj
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblBrojKreveta = new System.Windows.Forms.Label();
            this.lblZatvorenik = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtZatvorenik = new System.Windows.Forms.TextBox();
            this.txtVelicina = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(47, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID prostorije:";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Location = new System.Drawing.Point(47, 118);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(29, 16);
            this.lblKat.TabIndex = 1;
            this.lblKat.Text = "Kat:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(47, 174);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(90, 16);
            this.lblBroj.TabIndex = 2;
            this.lblBroj.Text = "Broj prostorije";
            // 
            // lblBrojKreveta
            // 
            this.lblBrojKreveta.AutoSize = true;
            this.lblBrojKreveta.Location = new System.Drawing.Point(47, 238);
            this.lblBrojKreveta.Name = "lblBrojKreveta";
            this.lblBrojKreveta.Size = new System.Drawing.Size(82, 16);
            this.lblBrojKreveta.TabIndex = 3;
            this.lblBrojKreveta.Text = "Broj kreveta:";
            // 
            // lblZatvorenik
            // 
            this.lblZatvorenik.AutoSize = true;
            this.lblZatvorenik.Location = new System.Drawing.Point(47, 308);
            this.lblZatvorenik.Name = "lblZatvorenik";
            this.lblZatvorenik.Size = new System.Drawing.Size(73, 16);
            this.lblZatvorenik.TabIndex = 4;
            this.lblZatvorenik.Text = "Zatvorenik:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 73);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtZatvorenik
            // 
            this.txtZatvorenik.Location = new System.Drawing.Point(50, 327);
            this.txtZatvorenik.Name = "txtZatvorenik";
            this.txtZatvorenik.Size = new System.Drawing.Size(100, 22);
            this.txtZatvorenik.TabIndex = 6;
            // 
            // txtVelicina
            // 
            this.txtVelicina.Location = new System.Drawing.Point(50, 257);
            this.txtVelicina.Name = "txtVelicina";
            this.txtVelicina.Size = new System.Drawing.Size(100, 22);
            this.txtVelicina.TabIndex = 7;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(50, 193);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 22);
            this.txtBroj.TabIndex = 8;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(50, 137);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 22);
            this.txtKat.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.Location = new System.Drawing.Point(76, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtVelicina);
            this.Controls.Add(this.txtZatvorenik);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblZatvorenik);
            this.Controls.Add(this.lblBrojKreveta);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.lblID);
            this.Name = "FrmDodaj";
            this.Text = "FrmDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblBrojKreveta;
        private System.Windows.Forms.Label lblZatvorenik;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtZatvorenik;
        public System.Windows.Forms.TextBox txtVelicina;
        public System.Windows.Forms.TextBox txtBroj;
        public System.Windows.Forms.TextBox txtKat;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
    }
}