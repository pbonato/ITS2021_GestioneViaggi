using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GestioneViaggi.Controller
{
    static class ManageDB
    {
        const string FileNameAutisti = "autisti.json";

        public static void StoreDBAutisti(List<Autista> myList)
        {
            FileStream fs = new FileStream(FileNameAutisti, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            string jsonData = JsonConvert.SerializeObject(myList);
            sw.WriteLine(jsonData);

            sw.Close();
            fs.Close();

            
        }
    }
}
