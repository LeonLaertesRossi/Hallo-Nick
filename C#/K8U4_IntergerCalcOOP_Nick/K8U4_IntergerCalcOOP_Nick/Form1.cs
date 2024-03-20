using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K8U4_IntergerCalcOOP_Nick
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
        Rechner rechenoperationen = new Rechner();

        public void init()
        {
                textBoxErgebnis.Text = "";
                rechenoperationen.Zahl1 = Convert.ToInt32(textBoxZahl1.Text);
                rechenoperationen.Zahl2 = Convert.ToInt32(textBoxZahl2.Text);
        }

        public void anzeigen(int Ergebnis)
        {
            textBoxErgebnis.Text = Ergebnis.ToString();
        }

        private void button_click_Addition(object sender, EventArgs e)
        {
            try
            {
                if (textBoxZahl1.Text != "" & textBoxZahl2.Text != "")
                {
                    init();
                    int Ergebnis = rechenoperationen.Addition();
                    anzeigen(Ergebnis);
                }
                else
                {
                    MessageBox.Show("Eine oder beide Textboxen sind leer.");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_click_Subtraktion(object sender, EventArgs e)
        {
            try
            {
                if (textBoxZahl1.Text != "" & textBoxZahl2.Text != "")
                {
                    init();
                    int Ergebnis = rechenoperationen.Subtraktion();
                    anzeigen(Ergebnis);
                }
                else
                {
                    MessageBox.Show("Eine oder beide Textboxen sind leer.");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_click_Multiplikation(object sender, EventArgs e)
        {
            try
            {
                if (textBoxZahl1.Text != "" & textBoxZahl2.Text != "")
                {
                    init();
                    int Ergebnis = rechenoperationen.Multiplikation();
                    anzeigen(Ergebnis);
                }
                else
                {
                    MessageBox.Show("Eine oder beide Textboxen sind leer.");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_click_Division(object sender, EventArgs e)
        {
            try
            {
                if (textBoxZahl1.Text != "" & textBoxZahl2.Text != "")
                {
                    init();
                    if(rechenoperationen.Zahl1 != 0 & rechenoperationen.Zahl2 != 0)
                    {
                        if (rechenoperationen.Modulo() == 0)
                        {
                            int Ergebnis = rechenoperationen.Division();
                            anzeigen(Ergebnis);
                        }
                        else
                        {
                            MessageBox.Show(rechenoperationen.Zahl1 + " dividiert durch " + rechenoperationen.Zahl2 + " hat keine Ganzezahl als quotient");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Man keine division mit einer Null durschführen");
                    }
                }
                else
                {
                    MessageBox.Show("Eine oder beide Textboxen sind leer.");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           
        private void button_click_Modulo(object sender, EventArgs e)
        {
            try
            {
                if (textBoxZahl1.Text != "" & textBoxZahl2.Text != "")
                {
                    init();
                    if (rechenoperationen.Zahl1 >= rechenoperationen.Zahl2)
                    {
                        if (rechenoperationen.Zahl1 != 0 & rechenoperationen.Zahl2 != 0)
                        {
                            int Ergebnis = rechenoperationen.Modulo();
                            anzeigen(Ergebnis);
                        }
                        else
                        {
                            MessageBox.Show("Man keine Modulo division mit einer Null durschführen");
                        }
                    }
                    else
                    {
                        if(rechenoperationen.Zahl1 != 0 & rechenoperationen.Zahl2 != 0)
                        {
                            MessageBox.Show("Der Dividend " + rechenoperationen.Zahl1 + " ist Größer als der divisor " + rechenoperationen.Zahl2 + "\nDer Quotient dieser Modulo operation hat kein sinvolles Ergebnis");
                        }
                        else
                        {
                            MessageBox.Show("Man keine Modulo division mit einer Null durschführen");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Eine oder beide Textboxen sind leer.");
                }
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContentTestZahl1(object sender, KeyPressEventArgs e)
        {
            string patternForInt = @".*[^\d\b]";
            string patternForMoreThanOneZeros = @"^0{1}[^\b]";
            string searchValue = (e.KeyChar).ToString();
            if (Regex.IsMatch(searchValue, patternForInt) == true | Regex.IsMatch(textBoxZahl1.Text + e.KeyChar.ToString(), patternForMoreThanOneZeros))
            {
                e.Handled = true;
            }
        }

        private void ContentTestZahl2(object sender, KeyPressEventArgs e)
        {
            string patternForInt = @".*[^\d\b]";
            string patternForMoreThanOneZeros = @"^0{1}[^\b]";
            string searchValue = (e.KeyChar).ToString();
            if (Regex.IsMatch(searchValue, patternForInt) == true | Regex.IsMatch(textBoxZahl2.Text + e.KeyChar.ToString(), patternForMoreThanOneZeros))
            {
                e.Handled = true;
            }
        }
    }
}
