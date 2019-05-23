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
    public partial class Form_log : Form
    {
        public Form_log()
        {
            Connexion.init();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = numlicence.Text;
            string mdp = password.Text;

            bool estConnecte = Connexion.connectTresorier(login, mdp);

            if(estConnecte)
            {
                Form_accueil fma = new Form_accueil();
                fma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erreur de connexion !");
                numlicence.Clear();
                password.Clear();
            }

        }

        private void Form_log_Load(object sender, EventArgs e)
        {

        }

        private void numlicence_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
