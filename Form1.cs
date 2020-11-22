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
            float lato=Convert.ToInt32(txt_primo.Text), lato2= Convert.ToInt32(txt_secondo.Text), c= Convert.ToInt32(txt_terzo.Text);
            //scelta tipo triangolo
            if (lato == lato2 && lato2 == c)
            {
               txt_risultato.Text="Equilatero";
            }
            else if (lato == lato2 && lato2 != c || lato == c && c != lato2 || lato2 == c && lato != lato2)
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
