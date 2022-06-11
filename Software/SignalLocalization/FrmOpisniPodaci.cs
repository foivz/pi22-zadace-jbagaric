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
            ShowZatvorenike();
        }

        private void ShowZatvorenike()
        {
            List<Zatvorenik> zatvorenici = ZatvorenikRepository.GetZatvorenike();
            dgvOpisniPodaci.DataSource = zatvorenici;

        }
    }
}
