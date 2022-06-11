using SignalLocalization.Models;
using SignalLocalization.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet4.Zatvorenici' table. You can move, or remove it, as needed.
            this.zatvoreniciTableAdapter1.Fill(this.jbagaric20_DBDataSet4.Zatvorenici);
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet4.Prostorije' table. You can move, or remove it, as needed.
           // this.prostorijeTableAdapter2.Fill(this.jbagaric20_DBDataSet4.Prostorije);

            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.Zatvorenici' table. You can move, or remove it, as needed.
            //this.zatvoreniciTableAdapter.Fill(this.jbagaric20_DBDataSet.Zatvorenici);
            //ShowZatvorenike();
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.Prostorije' table. You can move, or remove it, as needed.
            //this.prostorijeTableAdapter.Fill(this.jbagaric20_DBDataSet.Prostorije);
            //ShowProstorije();
            ShowZatvorenike();
        }

        private void ShowZatvorenike()
        {
            var zatvorenici = ZatvorenikRepository.GetZatvorenike();
            dgvOpisniPodaci.DataSource = zatvorenici;

        }
        private void ShowProstorije()
        {
            var prostorije = ProstorijaRepository.GetProstorije();
            //dgvOpisniPodaci2.DataSource = prostorije;

        }
    }
}
