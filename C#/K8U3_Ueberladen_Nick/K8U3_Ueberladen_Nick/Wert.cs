using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8U3_Ueberladen_Nick
{
    internal class Wert
    {
        public void Ausgabe(int ganzeZahl)
        {
            Console.WriteLine($"Die Ganzzahl lautet: {ganzeZahl}");
        }
        public void Ausgabe(double dezimalzahl)
        {
            Console.WriteLine($"Die Dezimalzahl lautet: {dezimalzahl}");
        }
        public void Ausgabe(string Text)
        {
            Console.WriteLine($"Der Text lautet: {Text.Trim()}");
        }
    }
}
