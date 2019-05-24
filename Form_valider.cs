using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FREDI_TRESORIER
{
    public partial class Form_valider : Form
    {
        string adresse;
        string date;
        string motif;
        string trajet;
        string km;
        string cout_p;
        string cout_r;
        string cout_h;
        public Form_valider(string adresseRecup, string dateRecup, string motifRecup, string trajetRecup, string kmRecup, string cout_pRecup, string cout_rRecup, string cout_hRecup)
        {
            this.adresse = adresseRecup;
            this.date = dateRecup;
            this.motif = motifRecup;
            this.trajet = trajetRecup;
            this.km = kmRecup;
            this.cout_p = cout_pRecup;
            this.cout_r = cout_rRecup;
            this.cout_h = cout_hRecup;
            InitializeComponent();
            load();



        }
        public void load()
        {
            label1.Text = adresse;
            textBox1.Text = date;
            textBox2.Text = motif;
            textBox3.Text = trajet;
            textBox4.Text = km;
            textBox5.Text = cout_p;
            textBox6.Text = cout_h;
            textBox7.Text = cout_r;

        }

        private void Form_valider_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
