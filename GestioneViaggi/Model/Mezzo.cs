using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneViaggi.Model
{
    class Mezzo
    {
        public int id { get; set; }
        public string Descrizione { get; set; }

        public Mezzo(string Descrizione)
        {
            this.id = -1;
            this.Descrizione = Descrizione;
        }

        public Mezzo()
        {
            this.id = -1;
        }
    }
}
