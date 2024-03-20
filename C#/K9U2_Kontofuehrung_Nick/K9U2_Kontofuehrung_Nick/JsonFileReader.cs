using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;



namespace K9U2_Kontofuehrung_Nick
{
    internal class JsonFileReader
    {
       
        public static int fileNumber { get;set;}   
        public static bool register { get;set;}    
        
        public static void KontoauszugSpeichern(List<Konto> arg)
        {
            string path = Directory.GetCurrentDirectory() + @"\Kontoauszug";
            string fileName = path + @"\Kontoauszug-" + JsonFileReader.fileNumber + ".json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(fileName, JsonSerializer.Serialize(arg, options));
        }
        public static List<Nutzer> NutzerDatenLaden()
        {
            string path = Directory.GetCurrentDirectory() + @"\NutzerDaten\NutzerDaten.json";
            string NutzerFile = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Nutzer>>(NutzerFile);
        }
        public static List<Konto> KontenLadenKontostand()
        {
            string fileName = Directory.GetCurrentDirectory() + @"\Kontoauszug" + @"\Kontoauszug-" + JsonFileReader.fileNumber + ".json";
            string Kontofile = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<Konto>>(Kontofile);
        }
        public static List<Konto> KontoauszugLaden() 
        {
            List<Konto> kontolist = new List<Konto>();
            if (JsonFileReader.register)
            {
                string path = Directory.GetCurrentDirectory() + @"\Kontoauszug\Kontoauszug-" + JsonFileReader.fileNumber + ".json";
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(path, JsonSerializer.Serialize(kontolist, options));
                string Kontofile = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Konto>>(Kontofile);
            }
            else
            {
                string path = Directory.GetCurrentDirectory() + @"\Kontoauszug\Kontoauszug-" + JsonFileReader.fileNumber + ".json";
                string Kontofile = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Konto>>(Kontofile);
            }
        }
    }
}
