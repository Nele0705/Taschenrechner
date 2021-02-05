using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerAusKopf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(buttonDelete.Enabled)
            {
                zahlOben.Text = "";
                zahlUnten.Text = "";
                zahlErgebnis.Text = "";
                rechenoperator.Text = "";
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            rechenoperator.Text = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            rechenoperator.Text = "-";
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            rechenoperator.Text = "*";
        }

        private void buttonGeteilt_Click(object sender, EventArgs e)
        {
            rechenoperator.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 1;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 2;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 3;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 4;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 5;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 6;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 7;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 8;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 9;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 9;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + 0;
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + 0;
            }
        }

        private void rechenoperator_Click(object sender, EventArgs e)
        {

        }

        private void buttonKomma_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "")
            {
                zahlOben.Text = zahlOben.Text + ",";
            }
            else
            {
                zahlUnten.Text = zahlUnten.Text + ",";
            }
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            if (rechenoperator.Text == "+")
            {
                zahlErgebnis.Text = (float.Parse(zahlOben.Text) + float.Parse(zahlUnten.Text)).ToString();
            }
            if (rechenoperator.Text == "-")
            {
                zahlErgebnis.Text = (float.Parse(zahlOben.Text) - float.Parse(zahlUnten.Text)).ToString();
            }
            if (rechenoperator.Text == "*")
            {
                zahlErgebnis.Text = (float.Parse(zahlOben.Text) * float.Parse(zahlUnten.Text)).ToString();
            }
            if (rechenoperator.Text == "/")
            {
                zahlErgebnis.Text = (float.Parse(zahlOben.Text) / float.Parse(zahlUnten.Text)).ToString();
            }
            
     
        }
    }
}
