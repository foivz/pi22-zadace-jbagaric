using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignalLocalization.Models;

namespace SignalLocalization
{
    public partial class FrmUpdate : Form
    {
        private Prostorija _selectedProstorija;

        public FrmUpdate(Prostorija selectedProstorija)
        {
            InitializeComponent();
            _selectedProstorija = selectedProstorija;
            this.LoadValues();

        }

        private void LoadValues()
        {
            txtID.Enabled = false;
            txtID.Text = _selectedProstorija.Id.ToString();
            txtKat.Text = _selectedProstorija.Kat.ToString();
            //frmDodaj.txtVrsta.Text = this.dgvOpisniPodaci.CurrentRow.Cells[2].Value.ToString();
            txtBroj.Text = _selectedProstorija.Broj.ToString();
            txtVelicina.Text = _selectedProstorija.Velicina.ToString();
            txtKrevet.Text = _selectedProstorija.BrojKreveta.ToString();
            txtZatvorenik.Text = _selectedProstorija.IdZatvorenika.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            FrmOpisniPodaci form = new FrmOpisniPodaci();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }
    }
}
