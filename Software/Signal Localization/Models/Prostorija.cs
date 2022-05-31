using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Localization.Models
{
    public class Prostorija
    {
        public int Id { get; set; }
        public int Kat { get; set; }
        public string Vrsta { get; set; }
        public int BrojKreveta { get; set; }
        public int Velicina { get; set; }   
    }
}
