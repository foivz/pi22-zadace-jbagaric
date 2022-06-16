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
    public partial class FrmOpisniPodaci : Form
    {
        public FrmOpisniPodaci()
        {
            InitializeComponent();
        }

        

        private void FrmOpisniPodaci_Load(object sender, EventArgs e)
        {
            this.OsvjeziPrikaz();
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.TestProstorija' table. You can move, or remove it, as needed.
            //this.testProstorijaTableAdapter.Fill(this.jbagaric20_DBDataSet.TestProstorija);

        }

        private void OsvjeziPrikaz()
        {
            List<Prostorija> prostorije = ProstorijaRepository.GetProstorije();
            dgvOpisniPodaci.DataSource = prostorije;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Prostorija selectedProstorija = dgvOpisniPodaci.CurrentRow.DataBoundItem as Prostorija;
            ProstorijaRepository repository = new ProstorijaRepository();
            repository.Delete(selectedProstorija.Id);
            this.OsvjeziPrikaz();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodaj form2 = new FrmDodaj();
            form2.ShowDialog();
            this.Close();
        }

        private void dgvOpisniPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Prostorija selectedProstorija = dgvOpisniPodaci.CurrentRow.DataBoundItem as Prostorija;
            
            this.Hide();

            FrmUpdate frmUpdate = new FrmUpdate(selectedProstorija);
            frmUpdate.ShowDialog();

            this.Close();

        }
    }
}
