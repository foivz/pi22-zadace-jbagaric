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
using SignalLocalization.Repositories;

namespace SignalLocalization
{
    public partial class FrmDodaj : Form
    {
        public FrmDodaj()
        {
            InitializeComponent();
        }

        public FrmDodaj(Prostorija selectedProstorija)
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmOpisniPodaci form = new FrmOpisniPodaci();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Prostorija novaProstorija = new Prostorija
            {
                Id = int.Parse(txtID.Text),
                Kat = int.Parse(txtKat.Text),
                //Vrsta = txtVrsta.Text,
                Broj = int.Parse(txtBroj.Text),
                Velicina = int.Parse(txtVelicina.Text),
                BrojKreveta = int.Parse(txtKrevet.Text),
                IdZatvorenika = int.Parse(txtZatvorenik.Text)

            };


            ProstorijaRepository repository = new ProstorijaRepository();
            repository.Insert(novaProstorija);

            FrmOpisniPodaci form1 = new FrmOpisniPodaci();
            this.Visible = false;
            form1.ShowDialog();
            this.Close();
        }
    }
}
