using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalLocalization.Models
{
    public class Prostorija
    {
        public int Id { get; set; }
        //public string Vrsta { get; set; }
        public int Broj { get; set; }
        public int Velicina { get; set; }
        public int BrojKreveta { get; set; }
        public int Kat { get; set; }
        public int IdZatvorenika { get; set; }
    }
}
