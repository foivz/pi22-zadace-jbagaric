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
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.TestProstorija' table. You can move, or remove it, as needed.
            this.testProstorijaTableAdapter.Fill(this.jbagaric20_DBDataSet.TestProstorija);

        }
    }
}
