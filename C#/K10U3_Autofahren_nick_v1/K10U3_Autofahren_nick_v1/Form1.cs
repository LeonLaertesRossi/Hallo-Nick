using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace K10U3_Autofahren_nick_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            auto1.Left = 0;
            buttonLangsamer.Enabled = true;
            buttonSchneller.Enabled = true;
        }

        private void buttonFahren_Click(object sender, EventArgs e)
        {
            buttonLangsamer.Enabled = false;
            buttonSchneller.Enabled = false;
            auto1.Fahren();
            
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLangsamer_Click(object sender, EventArgs e)
        {
            if(auto1.Geschwindigkeit - 10 >= 0)
            {
                auto1.Geschwindigkeit -= 10;
                label1.Text = "Geschwindigkeit: " + auto1.Geschwindigkeit + "km/h";
            }

        }

        private void buttonSchneller_Click(object sender, EventArgs e)
        {
            if(auto1.Geschwindigkeit + 10 <= 200)
            {
                auto1.Geschwindigkeit += 10;
                label1.Text = "Geschwindigkeit: " + auto1.Geschwindigkeit + "km/h";
            }
        }


    }
}
