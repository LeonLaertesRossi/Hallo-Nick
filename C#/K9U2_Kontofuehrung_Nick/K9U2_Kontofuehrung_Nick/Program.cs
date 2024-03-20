using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Text.Json;
using System.IO;
using System.Web;
using System.Diagnostics;
using System.Net;
using System.ComponentModel;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Net.Http.Headers;

namespace K9U2_Kontofuehrung_Nick
{
    class Program
    {

        static Konto konto = new Konto();
        static List<Nutzer> nutzerDatenList = new List<Nutzer>();   

        static void Main(string[] args)
        {
            Nutzer nutzer = new Nutzer();
            JsonFileReader jsonFileNumberTranfer = new JsonFileReader();
            string path0 = Directory.GetCurrentDirectory() + @"\NutzerDaten";
            string[] files0 = Directory.GetFiles(path0);
            if (!files0.Contains(path0 + @"\NutzerDaten.json"))
            {
                string path = Directory.GetCurrentDirectory();
                string fileName = path + @"\NutzerDaten\NutzerDaten.json";
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(fileName, JsonSerializer.Serialize(nutzerDatenList, options));
            }
            string patternForNutzerName = @"[^(A-za-z0-9)]";
            string patternForPasswort = @"^\w{2,20}$";
            bool running1 = true;
            bool next = false;
            bool register = false;
            while (running1)
            {
                Console.WriteLine("Anmelden(1), Registrieren(2), beenden(3):");
                string nutzerEingabe1 = Console.ReadLine();
                switch (nutzerEingabe1)
                {
                    case "1":
                        Console.Write("Nutzername: ");
                        string nutzername = Console.ReadLine();
                        if(nutzer.NutzerNamePrüfen(nutzername) & !Regex.IsMatch(nutzername, patternForNutzerName))
                        {
                            Console.Write("passwort: ");
                            string passwort = Console.ReadLine();
                            if (nutzer.PasswortPrüfen(passwort) & Regex.IsMatch(nutzername, patternForPasswort))
                            {
                                
                                JsonFileReader.fileNumber = nutzer.Anmelden(nutzername, passwort);
                                Console.WriteLine(JsonFileReader.fileNumber + "oder so");
                                next = true;
                                running1 = false;
                                JsonFileReader.register = false;
                            }
                            else
                            {
                                Console.WriteLine("Denn Passwort gibt es schon oder es sind nicht erlaubte zeichen enthalten\nEin Passwort muss mindestens 2 und maximal 20 zeichen groß sein und darf nur Alphanumerische zeichen enthalen");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Denn Nutzer Namen gibt es schon oder es sind nicht erlaubte zeichen enthalten");
                        }
                        break;
                    case "2":
                        Console.Write("Geben sie ein Nutzername ein: ");
                        string nutzerNameEingabe = Console.ReadLine();

                        if (!nutzer.NutzerNamePrüfen(nutzerNameEingabe) & !Regex.IsMatch(nutzerNameEingabe, patternForNutzerName))
                        {
                            Console.Write("Geben sie ein passwort ein : ");
                            string passwortEingabe = Console.ReadLine();
                            if (!nutzer.PasswortPrüfen(passwortEingabe) & Regex.IsMatch(nutzerNameEingabe, patternForPasswort))
                            {
                                List<Nutzer> nutzer1 = new List<Nutzer>();
                                GrößteZahl größteZahlsuche = new GrößteZahl();
                                string path = Directory.GetCurrentDirectory() + @"\Kontoauszug";
                                string[] files = Directory.GetFiles(path);
                                int biggestIndex = größteZahlsuche.größteZahl(files);
                                JsonFileReader.fileNumber = biggestIndex+1;
                                foreach (var data in JsonFileReader.NutzerDatenLaden())
                                {
                                    nutzer1.Add(new Nutzer { NutzerName = data.NutzerName, Passwort = data.Passwort , JsonDatei = data.JsonDatei});
                                }
                                nutzer1.Add(new Nutzer { NutzerName = nutzerNameEingabe, Passwort = passwortEingabe , JsonDatei = JsonFileReader.fileNumber});
                                nutzer.NutzerDatenHinzufügen(nutzer1);
                                Console.WriteLine("Ihr Account wurde Erfolgreich erstellt.");
                                next = true;
                                running1 = false;
                                register = true;
                                JsonFileReader.register = true;
                            }
                            else
                            {
                                Console.WriteLine("Denn Passwort gibt es schon oder es sind nicht erlaubte zeichen enthalten\nEin Passwort muss mindestens 2 und maximal 20 zeichen groß sein und darf nur Alphanumerische zeichen enthalen");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Denn Nutzer Namen gibt es schon oder es sind nicht erlaubte zeichen enthalten");
                        }
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
                if (next)
                {
                    if(register)
                    {
                        konto.Einzahlen(Convert.ToDouble("0"));
                    }

                    string patternForInt = @"^\d*\d$";
                    string patternFordouble = @"^\d*[(.{1}|,{1})]\d{1,2}$";
                    string patternFordoubleKommar = @"^\d*[(,{1})]\d+$";

                    bool running = true;
                    while (running)
                    {
                        konto.AnzeigenKontostand();
                        Console.WriteLine("Einzahlen(1), Auszahlen(2), Kontoauszug(3), Nutzerauswahl(4), Beenden(5):");
                        string nutzerEingabe = Console.ReadLine();
                        switch (nutzerEingabe)
                        {
                            case "1":
                                Console.Write("Betrag: ");
                                string einzahlungEingabe = Console.ReadLine();
                                if (Regex.IsMatch(einzahlungEingabe, patternFordouble) || Regex.IsMatch(einzahlungEingabe, patternForInt))
                                {
                                    if (Regex.IsMatch(einzahlungEingabe, patternFordoubleKommar))
                                    {
                                        konto.Einzahlen(Convert.ToDouble(einzahlungEingabe));
                                        
                                    }
                                    else
                                    {
                                        konto.Einzahlen(double.Parse(einzahlungEingabe, CultureInfo.InvariantCulture));
                                    }
                                } 
                                else
                                {
                                    Console.WriteLine("Ungültige Eingabe");
                                }
                                break;
                            case "2":

                                Console.Write("Betrag: ");
                                string auszahlungEingabe = Console.ReadLine();
                                if (Regex.IsMatch(auszahlungEingabe, patternFordouble) || Regex.IsMatch(auszahlungEingabe, patternForInt))
                                {
                                    if (Regex.IsMatch(auszahlungEingabe, patternFordoubleKommar))
                                    {
                                        konto.Auszahlen(Convert.ToDouble(auszahlungEingabe));
                                    }
                                    else
                                    {
                                        konto.Auszahlen(double.Parse(auszahlungEingabe, CultureInfo.InvariantCulture));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ungültige Eingabe");
                                }
                                break;
                            case "3":
                                konto.Anzeigen();
                                break;
                            case "4":
                                running = false;
                                running1 = true;
                                next = false;
                                konto.ClearKontoList();
                                break;
                            case "5":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Ungültige Eingabe");
                                break;
                        }
                    }
                }
            }
        }
    }
}
