using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using GestioneViaggi.Model;

namespace GestioneViaggi.Controller
{
    static class ManageDB
    {
        const string FileNameAutisti = "autisti.json";
        const string FileNameMezzi = "mezzi.json";

        #region "Autisti"
        public static void StoreAutisti(Autisti myAutisti)
        {

            FileStream fs = new FileStream(FileNameAutisti, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string jsonData = JsonConvert.SerializeObject(myAutisti);
            sw.WriteLine(jsonData);

            sw.Close();
            fs.Close();


        }
        public static List<Autista> GetAutisti()
        {
            Autisti ret = new Autisti();

            try
            {
                FileStream fs = new FileStream(FileNameAutisti, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string jsonData = sr.ReadToEnd();
                ret = JsonConvert.DeserializeObject<Autisti>(jsonData);

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return ret.listAutisti;

        }
        public static int GetLastIDAutista()
        {
            Autisti ret = new Autisti();

            try
            {
                FileStream fs = new FileStream(FileNameAutisti, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string jsonData = sr.ReadToEnd();
                ret = JsonConvert.DeserializeObject<Autisti>(jsonData);

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return ret.idAutista;

        }
        #endregion

        #region "Mezzi"
        public static void StoreMezzi(Mezzi myMezzi)
        {

            FileStream fs = new FileStream(FileNameMezzi, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string jsonData = JsonConvert.SerializeObject(myMezzi);
            sw.WriteLine(jsonData);

            sw.Close();
            fs.Close();


        }
        public static List<Mezzo> GetMezzi()
        {
            Mezzi ret = new Mezzi();

            try
            {
                FileStream fs = new FileStream(FileNameMezzi, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string jsonData = sr.ReadToEnd();
                ret = JsonConvert.DeserializeObject<Mezzi>(jsonData);

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return ret.listMezzi;

        }
        public static int GetLastIDMezzo()
        {
            Mezzi ret = new Mezzi();

            try
            {
                FileStream fs = new FileStream(FileNameMezzi, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string jsonData = sr.ReadToEnd();
                ret = JsonConvert.DeserializeObject<Mezzi>(jsonData);

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return ret.idMezzo;

        }
        #endregion
    }
}
