﻿using System;
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
    public partial class Form_accueil : Form
    {
        public Form_accueil()
        {
            Connexion.init();
            InitializeComponent();
            
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Valider fmv = new Form_Valider();
            fmv.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_modif fmm = new Form_modif();
            fmm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         //   Connexion.init();
         // Connexion.GetLesDemandeur();
        }

        private void Form_accueil_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
