using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace K9U2_Kontofuehrung_Nick
{
    internal class Konto
    {
        List<Konto> kontoList = new List<Konto>();

        public string KontoauszugID {get; set;}
        public string VorherigerKontostand { get; set; }
        public string Kontostand { get; set; }
        public string Einzahlung { get; set; }
        public string Auszahlung { get; set; }
        public string Date { get; set; }


        public void Einzahlen(double wert)
        {
            if(JsonFileReader.register)
            {
                this.KontoauszugID = Convert.ToString(Convert.ToInt32(this.KontoauszugID) + 1);
                this.Auszahlung = "0";
                this.Einzahlung = wert.ToString();
                this.Kontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) + wert, 2, MidpointRounding.AwayFromZero));
                this.VorherigerKontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) - wert, 2, MidpointRounding.AwayFromZero));
                Speichern();
            }
            else
            {
                foreach (var kontoDaten in JsonFileReader.KontoauszugLaden())
                {
                    this.KontoauszugID = kontoDaten.KontoauszugID;
                    this.Auszahlung = kontoDaten.Auszahlung;
                    this.Einzahlung = kontoDaten.Einzahlung;
                    this.Kontostand = kontoDaten.Kontostand;
                    this.VorherigerKontostand = kontoDaten.VorherigerKontostand;
                    this.Date = kontoDaten.Date;
                }
                this.KontoauszugID = Convert.ToString(Convert.ToInt32(this.KontoauszugID) + 1);
                this.Auszahlung = "0";
                this.Einzahlung = wert.ToString();
                this.Kontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) + wert, 2, MidpointRounding.AwayFromZero));
                this.VorherigerKontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) - wert, 2, MidpointRounding.AwayFromZero));
                Speichern();
            }
        }
        public void Auszahlen(double wert)
        {
            if (JsonFileReader.register)
            {
                this.KontoauszugID = Convert.ToString(Convert.ToInt32(this.KontoauszugID) + 1);
                this.Auszahlung = wert.ToString();
                this.Einzahlung = "0";
                this.Kontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) - wert, 2, MidpointRounding.AwayFromZero));
                this.VorherigerKontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) + wert, 2, MidpointRounding.AwayFromZero));
            }
            else
            {
                foreach (var kontoDaten in JsonFileReader.KontoauszugLaden())
                {
                    this.KontoauszugID = kontoDaten.KontoauszugID;
                    this.Auszahlung = kontoDaten.Auszahlung;
                    this.Einzahlung = kontoDaten.Einzahlung;
                    this.Kontostand = kontoDaten.Kontostand;
                    this.VorherigerKontostand = kontoDaten.VorherigerKontostand;
                    this.Date = kontoDaten.Date;
                }
                this.KontoauszugID = Convert.ToString(Convert.ToInt32(this.KontoauszugID) + 1);
                this.Auszahlung = wert.ToString();
                this.Einzahlung = "0";
                this.Kontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) - wert, 2, MidpointRounding.AwayFromZero));
                this.VorherigerKontostand = Convert.ToString(Math.Round(Convert.ToDouble(this.Kontostand) + wert, 2, MidpointRounding.AwayFromZero));
            }
            Speichern();
        }
        public void Speichern()
        {
            if (JsonFileReader.register)
            {
                kontoList.Add(new Konto
                {
                    KontoauszugID = this.KontoauszugID,
                    VorherigerKontostand = this.VorherigerKontostand,
                    Auszahlung = this.Auszahlung,
                    Einzahlung = this.Einzahlung,
                    Kontostand = this.Kontostand,
                    Date = DateTime.Now.ToString("G")
                });
                JsonFileReader.KontoauszugSpeichern(kontoList);
            }
            else
            {
                foreach(var kdata in JsonFileReader.KontoauszugLaden())
                {
                    kontoList.Add(new Konto
                    {
                        KontoauszugID = kdata.KontoauszugID,
                        VorherigerKontostand = kdata.VorherigerKontostand,
                        Auszahlung = kdata.Auszahlung,
                        Einzahlung = kdata.Einzahlung,
                        Kontostand = kdata.Kontostand,
                        Date = DateTime.Now.ToString("G")
                    });
                }
                kontoList.Add(new Konto
                {
                    KontoauszugID = this.KontoauszugID,
                    VorherigerKontostand = this.VorherigerKontostand,
                    Auszahlung = this.Auszahlung,
                    Einzahlung = this.Einzahlung,
                    Kontostand = this.Kontostand,
                    Date = this.Date
                });
                JsonFileReader.KontoauszugSpeichern(kontoList);
            }
        }
        public void Anzeigen()
        {
            if (JsonFileReader.register)
            {
                foreach (var item in kontoList)
                {
                    Console.WriteLine("\n" + "KontoauszugID: " + item.KontoauszugID);
                    Console.WriteLine("verheriger Kontostand: " + item.VorherigerKontostand);
                    Console.WriteLine("Kontostand: " + item.Kontostand);
                    Console.WriteLine("Einzahlung: " + item.Einzahlung);
                    Console.WriteLine("Auszahlung: " + item.Auszahlung);
                    Console.WriteLine("Date: " + item.Date);
                }
            }
            else
            {
                foreach (var item in JsonFileReader.KontoauszugLaden())
                {
                    Console.WriteLine("\n" + "KontoauszugID: " + item.KontoauszugID);
                    Console.WriteLine("verheriger Kontostand: " + item.VorherigerKontostand);
                    Console.WriteLine("Kontostand: " + item.Kontostand);
                    Console.WriteLine("Einzahlung: " + item.Einzahlung);
                    Console.WriteLine("Auszahlung: " + item.Auszahlung);
                    Console.WriteLine("Date: " + item.Date);
                }
            }

        }
        public void AnzeigenKontostand()
        {
            string temp = this.Kontostand;
            foreach (var item in JsonFileReader.KontenLadenKontostand())
            {
                this.Kontostand = item.Kontostand;
            }
            Console.WriteLine($"\nBetrag: " + this.Kontostand);
            this.Kontostand = temp;
        }

        public void ClearKontoList()
        {
            this.KontoauszugID = null;
            this.VorherigerKontostand = null;
            this.Kontostand = null;
            this.Einzahlung = null;
            this.Auszahlung = null;
            this.Date = null;
            kontoList.Clear();
        }
    }
}
