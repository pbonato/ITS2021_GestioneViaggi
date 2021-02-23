using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneViaggi.Controller;

namespace GestioneViaggi
{
    class Autisti
    {
        List<Autista> listAutisti = new List<Autista>();

        public int count { get => listAutisti.Count; }

        public void Add(Autista myAutista)
        {
            listAutisti.Add(myAutista);
            ManageDB.StoreAutisti(listAutisti);
        }
        public void Delete(int id)
        {
            listAutisti.RemoveAt(id);
            ManageDB.StoreAutisti(listAutisti);
        }

        public List<Autista> GetAutisti()
        {
            listAutisti = ManageDB.GetAutisti();
            return listAutisti;
        }
        public Autista GetAutista(int id)
        {
            Autista tmp = new Autista();
            tmp.id = listAutisti[id].id;
            tmp.Cognome = listAutisti[id].Cognome;
            tmp.Nome = listAutisti[id].Nome;

            return tmp;
        } 
    }
}
