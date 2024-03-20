using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K7U3Fortschrittsanzeige
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++) 
            {
                buttonStart.Enabled = false;
                buttonZurücksetzen.Enabled = false;
                System.Threading.Thread.Sleep(50);
                
                progressBar1.Value = i;

                
                labelProzent.Text = i+" Prozent";
                
                Application.DoEvents();
            }
            buttonStart.Enabled = true;
            buttonZurücksetzen.Enabled = true;
        }

        private void labelProzent_Click(object sender, EventArgs e)
        {

        }

        private void buttonZurücksetzen_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            labelProzent.Text = "0 Prozent";
        }

        private void buttonSchließen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
