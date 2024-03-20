using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace K10U3_Autofahren_nick_v1
{
    internal class Auto : Button
    {
        public int Geschwindigkeit { get; set; } = 0;

        public void Fahren()
        {
            int panelWidth = 432;
            int autoWidth = 75;
            int panelEnd = panelWidth - autoWidth;
            int geschwindigkeit = this.Geschwindigkeit;
            this.Left = geschwindigkeit;


            while (this.Left + geschwindigkeit <= panelEnd)
            {
                System.Threading.Thread.Sleep(200);
                this.Left += geschwindigkeit;
                Application.DoEvents();
            }
            if (this.Left + geschwindigkeit > panelEnd)
            {
                System.Threading.Thread.Sleep(100);
                this.Left += (panelEnd - this.Left);
            }
            
            
        }
    }
}