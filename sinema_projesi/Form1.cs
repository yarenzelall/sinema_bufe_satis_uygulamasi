using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            misir = misir * 4;
            su = su * 1;
            cay = cay * 2;
            bilet = bilet * 8;

            toplam = (misir + su + cay + bilet);
            lbltoplam.Text = toplam.ToString();
            kasatutar = toplam + kasatutar;
            lblkasa.Text = kasatutar.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmisir.Text = "";
            txtsu.Text = "";
            txtcay.Text = "";
            txtbilet.Text = "";
            txtmisir.Focus();
            lbltoplam.Text = "00 TL";
        }
    }
}
