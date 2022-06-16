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
    public partial class FrmOpisniPodaci : Form
    {
        public FrmOpisniPodaci()
        {
            InitializeComponent();
        }

        

        private void FrmOpisniPodaci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.TestProstorija' table. You can move, or remove it, as needed.
            this.testProstorijaTableAdapter.Fill(this.jbagaric20_DBDataSet.TestProstorija);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvOpisniPodaci.CurrentCell.RowIndex;
            dgvOpisniPodaci.Rows.RemoveAt(rowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmDodaj form2 = new FrmDodaj();
            form2.ShowDialog();
        }

        private void dgvOpisniPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Prostorija selectedProstorija = dgvOpisniPodaci.CurrentRow.DataBoundItem as Prostorija;
                //if (selectedProstorija != null)
                //{

                FrmDodaj frmDodaj = new FrmDodaj(selectedProstorija);

                //}
                frmDodaj.txtID.Text = this.dgvOpisniPodaci.CurrentRow.Cells[0].Value.ToString();
                frmDodaj.txtKat.Text = this.dgvOpisniPodaci.CurrentRow.Cells[1].Value.ToString();
                //frmDodaj.txtVrsta.Text = this.dgvOpisniPodaci.CurrentRow.Cells[2].Value.ToString();
                frmDodaj.txtBroj.Text = this.dgvOpisniPodaci.CurrentRow.Cells[2].Value.ToString();
                frmDodaj.txtVelicina.Text = this.dgvOpisniPodaci.CurrentRow.Cells[3].Value.ToString();
                frmDodaj.txtKrevet.Text = this.dgvOpisniPodaci.CurrentRow.Cells[4].Value.ToString();
                frmDodaj.txtZatvorenik.Text = dgvOpisniPodaci.CurrentRow.Cells[5].Value.ToString();
                frmDodaj.ShowDialog();
            
        }
    }
}
