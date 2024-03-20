using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Text.RegularExpressions.Regex;


namespace K8U2_Primzahlen_Nick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternforInt = @"[^\d]";
            string loop1 = "0";
            while (loop1 == "0")
            {
                Console.WriteLine("Drücke:\n1 ein um eine Zahl zu prüfen.\n2 um eine Bereich von zahlen zu prüfen.\n0 um das Programm zu beenden.");
                string wahl = Console.ReadLine();
                if (wahl == "1")
                {
                    Zahl zahl = new Zahl();
                    string loop2 = "1";
                    while (loop2 == "1")
                    {
                        Console.WriteLine("Geben sie eine ganze Zahl ein:");
                        string searchText = Console.ReadLine();
                        if (false == Regex.IsMatch(searchText, patternforInt))
                        {
                            try
                            {
                                int n = Convert.ToInt32(searchText);
                                if (n < 2)
                                {
                                    Console.WriteLine($"{n}: Ist keine Primzahl");
                                }
                                Console.WriteLine(zahl.isPrime(n));
                            }
                            catch (OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sie haben keine ganzezahl eingegeben.");
                        }
                        Console.WriteLine("\nDrücke:\n0 um das Programm zu beenden.\n1 um weiter zu machen.\n2 um zum zürck zum anfang zukommen.");
                        loop2 = Console.ReadLine();
                        if (loop2 == "2") { break; }
                        else if (loop2 == "0")
                        {
                            loop1 = "";
                        }
                        else if (loop2 == "1") { }
                        else
                        {
                            Console.WriteLine("Keine erlaubte Eingabe.");
                        }
                    }
                }
                else if (wahl == "2")
                {
                    string loop3 = "1";
                    while (loop3 == "1")
                    {
                        Zahl zahl = new Zahl();
                        Console.WriteLine("Geben sie ein Zahlen Bereich ein.");
                        Console.WriteLine("minimum:");
                        string searchText1 = Console.ReadLine();
                        Console.WriteLine("maximum:");
                        string searchText2 = Console.ReadLine();
                        if (false == Regex.IsMatch(searchText1, patternforInt) & false == Regex.IsMatch(searchText2, patternforInt))
                        {
                            try
                            {
                                int min = Convert.ToInt32(searchText1);
                                int max = Convert.ToInt32(searchText2);
                                string list = ",";
                                int primanzahl = 0;
                                if (min < max & min >= 2)
                                {
                                    DateTime StartZeit = DateTime.Now;
                                    for (int i = min; i <= max; i++)
                                    {
                                        bool wert = zahl.isPrimeRange(i);
                                        if (wert)
                                        {
                                            if (wert & primanzahl != 0)
                                            {
                                                Console.Write(",");
                                            }
                                            if (wert & primanzahl == 0)
                                            {
                                                list = "[";
                                            }
                                            else
                                            { list = ""; }
                                            Console.Write(list + i.ToString());
                                            primanzahl++;
                                        }

                                        if (i == max & primanzahl != 0)
                                        {
                                            Console.Write("]");
                                        }
                                    }
                                    TimeSpan EndZeit = DateTime.Now - StartZeit;

                                    Console.WriteLine("\n");
                                    Console.WriteLine((EndZeit.TotalSeconds).ToString() + "s");
                                }
                                else
                                {
                                    Console.WriteLine("Nicht erlaubte eingabe.");
                                }
                            }
                            catch (OverflowException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eine oder beide der beiden eingaben war keine Erlaubte Eingabe.");
                        }
                        Console.WriteLine("\nDrücke:\n0 um das Programm zu beenden.\n1 um weiter zu machen.\n2 um zurück zum anfang zukommen.");
                        loop3 = Console.ReadLine();
                        if (loop3 == "2") { break; }
                        else if (loop3 == "0")
                        {
                            loop1 = "";
                        }
                        else if (loop3 == "1") { }
                        else
                        {
                            Console.WriteLine("Keine Erlaubte Eingabe.");
                            break;
                        }
                    }
                }
                else if (wahl == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Keine Erlaubte Eingabe.");
                    loop1 = "0";
                }
            }
        }
    }
}
