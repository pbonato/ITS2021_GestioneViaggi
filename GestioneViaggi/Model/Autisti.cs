using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneViaggi.Controller;

namespace GestioneViaggi.Model
{
    class Autisti
    {
        public List<Autista> listAutisti = new List<Autista>();

        public int idAutista = 0;

        public void Add(Autista myAutista)
        {
            idAutista++;
            myAutista.id = idAutista;
            listAutisti.Add(myAutista);
            //ManageDB.StoreAutisti(listAutisti);
            ManageDB.StoreAutisti(this);
        }
        public void Delete(int id)
        {
            int tmp = listAutisti.FindIndex(item => item.id == id);
            listAutisti.RemoveAt(tmp);
            ManageDB.StoreAutisti(this);
        }
        public void Edit(int id,Autista myAutista)
        {
            int tmp = listAutisti.FindIndex(item => item.id == id);
            listAutisti[tmp].Cognome = myAutista.Cognome;
            listAutisti[tmp].Nome = myAutista.Nome;
            ManageDB.StoreAutisti(this);
        }
        public List<Autista> GetAutisti()
        {
            listAutisti = ManageDB.GetAutisti();
            idAutista = ManageDB.GetLastIDAutista();
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
