using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneViaggi
{
    class Autista
    {
        public int id { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }

        public Autista (string Cognome,string Nome)
        {
            this.id = -1;
            this.Cognome = Cognome;
            this.Nome = Nome;
        }

        public Autista()
        {
            this.id = -1;
        }
    }
}
