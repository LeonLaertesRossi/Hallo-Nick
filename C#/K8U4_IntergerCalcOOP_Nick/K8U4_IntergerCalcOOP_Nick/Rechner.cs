using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8U4_IntergerCalcOOP_Nick
{
    internal class Rechner
    {
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public int Addition()
        {
            int Ergebnis = Zahl1 + Zahl2;
            return Ergebnis;
        }
        public int Subtraktion()
        {
            return Zahl1 - Zahl2;
        }
        public int Multiplikation()
        {
            return Zahl1 * Zahl2;
        }
        public int Division()
        {
            return Zahl1 / Zahl2;
        }
        public int Modulo()
        {
            return Zahl1 % Zahl2;
        }
    }
}
