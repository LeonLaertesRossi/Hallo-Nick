using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace K9U2_Kontofuehrung_Nick
{
    internal class Nutzer
    {
        public string NutzerName { get;set; }
        public string Passwort { get;set; }

        public int JsonDatei { get;set; }    


        public void NutzerDatenHinzufügen(List<Nutzer> arg)
        {
            string path = Directory.GetCurrentDirectory() + @"\NutzerDaten\NutzerDaten.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(arg, options));
        }
        public bool NutzerNamePrüfen(string argnutzerNameVar)
        {
            foreach (var nutzerNameInListe in JsonFileReader.NutzerDatenLaden())
            {
                if (nutzerNameInListe.NutzerName == argnutzerNameVar)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PasswortPrüfen(string argpasswortVar)
        {
            foreach (var passwortInListe in JsonFileReader.NutzerDatenLaden())
            {

                if (passwortInListe.Passwort == argpasswortVar)
                {
                    return true;
                }
            }
            return false;
        }
        public int Anmelden(string argNutzerName, string argPasswort)
        {
            foreach(var data in JsonFileReader.NutzerDatenLaden())
            {
                if(data.NutzerName == argNutzerName & data.Passwort == argPasswort)
                {
                    return data.JsonDatei;
                }
            }
            return 0;
        }
    }   
}
