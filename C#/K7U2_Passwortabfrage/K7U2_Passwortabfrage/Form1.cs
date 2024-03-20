using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K7U2_Passwortabfrage
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

        private void textBoxPasswort_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwort = textBoxPasswort.Text;

            switch (passwort)
            {
                case "ad2013min":
                    textBoxAusgabe.Text = "Sie sind als Aministrator angemeldet";
                    break;

                case "einUser":
                    textBoxAusgabe.Text = "Sie haben sich als Use angemeldet";
                    break;
                default:
                    textBoxAusgabe.Text = "Siw isnd nur als Gast angemeldet";
                    break;
            }

        }
    }
}
