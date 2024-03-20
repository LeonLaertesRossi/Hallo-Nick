using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace K9U2_Kontofuehrung_Nick
{
    internal class GrößteZahl
    {
        public int größteZahl(string[] files)
        {
            
            List<string> allfileIndex = new List<string>();
            foreach (string file in files)
            {
                if (file.Contains("Kontoauszug"))
                {
                    string fileTemp = Path.GetFileName(file);
                    string fileIndexWithExtension = fileTemp.Substring("Kontoauszug".Length + 1, fileTemp.Length - "Kontoauszug".Length - 1);
                    string fileIndex = Path.ChangeExtension(fileIndexWithExtension, null);
                    allfileIndex.Add(fileIndex);
                }
                else
                {
                    return 0;
                }
            }
            
            int startValue = 0;

            foreach(string value in allfileIndex)
            {
                int valueCompare = Convert.ToInt32(value);
                if (valueCompare > startValue) 
                {
                    startValue = Convert.ToInt32(value);
                }
            }
            if(startValue > 1)
            {
                return startValue;
            }
            else if(startValue == 1)
            {
                startValue = 1;
                return startValue;
            }
            else
            {
                startValue = 0;
                return startValue;
            }
        }
    }
}
