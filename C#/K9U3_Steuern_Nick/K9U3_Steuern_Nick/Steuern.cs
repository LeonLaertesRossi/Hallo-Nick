using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9U3_Steuern_Nick
{
    internal class Steuern
    {
        private static double Mehrwertsteuer;

        public static double MWST { get => Mehrwertsteuer; set => Mehrwertsteuer = value; }

        public double IncelMWST(double arg)
        {
            return arg * MWST + arg;
        }
    }
}
