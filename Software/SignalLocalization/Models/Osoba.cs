using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalLocalization.Models
{
    public abstract class Osoba : Object
    {
        public int Id { get; set; }
        public string Ime { get; set; } 
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
