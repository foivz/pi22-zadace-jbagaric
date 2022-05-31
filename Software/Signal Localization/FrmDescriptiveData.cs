using Signal_Localization.Models;
using Signal_Localization.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Signal_Localization
{
    public partial class FrmDescriptiveData : Form
    {
        public FrmDescriptiveData()
        {
            InitializeComponent();
        }

        private void FrmDescriptiveData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.Prostorije' table. You can move, or remove it, as needed.
            this.prostorijeTableAdapter.Fill(this.jbagaric20_DBDataSet.Prostorije);
            ShowProstorije();
            // TODO: This line of code loads data into the 'jbagaric20_DBDataSet.Zatvorenici' table. You can move, or remove it, as needed.
            this.zatvoreniciTableAdapter.Fill(this.jbagaric20_DBDataSet.Zatvorenici);
            //ShowZatvorenike();
            
        }

        /*private void ShowZatvorenike()
        {
            
            BindingList<Zatvorenik> zatvorenici = ZatvorenikRepository.GetZatvorenici();
            dgvDescriptiveData.DataSource = zatvorenici;
            

        }*/
        private void ShowProstorije()
        {

            List<Prostorija> prostorije = ProstorijaRepository.GetProstorije();
            dgvDescriptiveData2.DataSource = prostorije;


        }
    }
}
