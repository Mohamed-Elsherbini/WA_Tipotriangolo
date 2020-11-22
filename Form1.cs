using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Tipotriangolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {
            //dati
            float lato=Convert.ToInt32(txt_primo.Text), b= Convert.ToInt32(txt_secondo.Text), c= Convert.ToInt32(txt_terzo.Text);
            //scelta tipo triangolo
            if (lato == b && b == c)
            {
               txt_risultato.Text="Equilatero";
            }
            else if (lato == b && b != c || lato == c && c != b || b == c && lato != b)
            {
                txt_risultato.Text = "Isoscele";
            }
            else
            {
                
                txt_risultato.Text = "Scaleno";
            }
        }
    }
}
