using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8U2_Primzahlen_Nick
{
    internal class Zahl
    {
        public string isPrime(int n)
        {
            int zahl = n;
            for (int i = 2; i <= Convert.ToInt32(Math.Pow(zahl, 0.5)); i += 2)
            {
                if (zahl % i == 0)
                {
                    return $"{n}: Ist keine Primzahl";
                }
                else if (i == 2)
                {
                    i--;
                }
            }
            return $"{n} Ist eine Primzahl";
        }
        public bool isPrimeRange(int n)
        {
            int zahl = n;
            for (int i = 2; i <= Convert.ToInt32(Math.Pow(zahl, 0.5)); i += 2)
            {
                if (zahl % i == 0)
                {
                    return false;
                }
                else if (i == 2)
                {
                    i--;
                }
            }
            return true;
        }
    }
}
