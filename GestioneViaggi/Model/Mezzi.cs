using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneViaggi.Controller;

namespace GestioneViaggi.Model
{
    class Mezzi
    {
        public List<Mezzo> listMezzi = new List<Mezzo>();

        public int idMezzo = 0;

        public void Add(Mezzo myMezzo)
        {
            idMezzo++;
            myMezzo.id = idMezzo;
            listMezzi.Add(myMezzo);
            ManageDB.StoreMezzi(this);
        }
        public void Delete(int id)
        {
            int tmp = listMezzi.FindIndex(item => item.id == id);
            listMezzi.RemoveAt(tmp);
            ManageDB.StoreMezzi(this);
        }
        public void Edit(int id, Mezzo myMezzo)
        {
            int tmp = listMezzi.FindIndex(item => item.id == id);
            listMezzi[tmp].Descrizione = myMezzo.Descrizione;
            ManageDB.StoreMezzi(this);
        }
        public List<Mezzo> GetMezzi()
        {
            listMezzi = ManageDB.GetMezzi();
            idMezzo = ManageDB.GetLastIDMezzo();
            return listMezzi;
        }
        public Mezzo GetMezzo(int id)
        {
            Mezzo tmp = new Mezzo();
            tmp.id = listMezzi[id].id;
            tmp.Descrizione = listMezzi[id].Descrizione;

            return tmp;
        }
    }
}
