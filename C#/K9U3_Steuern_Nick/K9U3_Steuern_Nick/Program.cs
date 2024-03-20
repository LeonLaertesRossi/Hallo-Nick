using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace K9U3_Steuern_Nick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Steuern steuern = new Steuern();
            Steuern.MWST = 0.19;
            string patternForInt = @"^\d*\d$";
            string patternForDouble = @"^\d*[(.{1}|,{1})]\d{1,2}$";
            string patternFordoubleKommar = @"^\d*[(,{1})]\d+$";

            bool running = true;
            while (running)
            {
                Console.WriteLine("Geben sie ein Netto betrag von der sie denn Brutto und den Mehrwertsteuersatz wissen wollen");
                Console.WriteLine("Netto Betrag: ");
                string nettoBetragPrüfen = Console.ReadLine();

                if (Regex.IsMatch(nettoBetragPrüfen, patternForDouble) | Regex.IsMatch(nettoBetragPrüfen, patternForInt))
                {
                    if (Regex.IsMatch(nettoBetragPrüfen, patternFordoubleKommar)| Regex.IsMatch(nettoBetragPrüfen, patternForInt))
                    {
                        double nettoBetrag = Convert.ToDouble(nettoBetragPrüfen);
                        Console.WriteLine("Brutto Betrag: " + Math.Round(steuern.IncelMWST(nettoBetrag), 2, MidpointRounding.AwayFromZero));
                        Console.WriteLine("Mehrwertsteuersatz:" + Math.Round(Steuern.MWST * nettoBetrag, 2, MidpointRounding.AwayFromZero));
                    }
                    else
                    {
                        double nettoBetrag = double.Parse(nettoBetragPrüfen, CultureInfo.InvariantCulture);
                        Console.WriteLine("Brutto Betrag: " + Math.Round(steuern.IncelMWST(nettoBetrag), 2, MidpointRounding.AwayFromZero));
                        Console.WriteLine("Mehrwertsteuersatz:" + Math.Round(Steuern.MWST * nettoBetrag, 2, MidpointRounding.AwayFromZero));
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }
    }
}
