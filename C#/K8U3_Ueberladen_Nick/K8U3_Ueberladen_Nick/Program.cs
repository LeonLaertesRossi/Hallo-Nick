using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace K8U3_Ueberladen_Nick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Wert wert = new Wert();

            string patternForInt = $"^\\d*\\d$";
            string patternFordouble = $"^\\d*[(.{1}|,{1})]\\d+$";
            string patternFordoubleKommar = $"^\\d*[(,{1})]\\d+$";

            string x = "1";
            while (x != "0")
            {
                Console.WriteLine("Geben sie eine Ganzezahl, dezimalzahl oder Text ein:");
                string search = (Console.ReadLine()).Trim();
                if (Regex.IsMatch(search, patternForInt) == true)
                {
                    try
                    {
                        wert.Ausgabe(Convert.ToInt32(search));
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
                else if (Regex.IsMatch(search, patternFordouble) == true)
                {
                    try
                    {
                        if (Regex.IsMatch(search, patternFordoubleKommar) == true)
                        {
                            wert.Ausgabe(Convert.ToDouble(search));
                        }
                        else
                        {
                            wert.Ausgabe(double.Parse(search, CultureInfo.InvariantCulture));
                        }
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (search == "")
                {
                    Console.WriteLine("Sie haben nichts eingegeben");
                    Console.WriteLine(search);
                }
                else
                {
                    wert.Ausgabe(search);
                }

                Console.WriteLine("Drücken sie 0 um das Programm zu beenden und 1 um es weiter auszuführen");
                x = Console.ReadLine();
                if (x != "1") 
                {
                    Console.WriteLine("Keine Erlaubte Eingabe.");
                }
            }
        }
    }
}
