using FREDI_TRESORIER.Classe;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FREDI_TRESORIER
{
    
    public partial class Form_consulter : Form
    {
        public Form_consulter()
        {
            InitializeComponent();
            Connexion.init();
            RechercheList();
            initListDeroulante();
        }
        private void initListDeroulante()
        {
            List<string> lesMails = Connexion.GetlesMails();
            foreach(string unMail in lesMails)
            {
                comboBox1.Items.Add(unMail);
            }
        }

        private void RechercheList()
        {
            dataGridView1.Rows.Clear();
            if (comboBox1.Text != "")
            {
                
                List<lignes_frais> lesFrais = Connexion.Recherche(comboBox1.SelectedItem.ToString());
                foreach (lignes_frais unFrais in lesFrais)
                {
                    dataGridView1.Rows.Add(unFrais.Date_frais.ToShortDateString(), Connexion.GetMotifsLibelle(unFrais.Id_motif), unFrais.Trajet.ToString(), unFrais.Km.ToString(), unFrais.Cout_peage.ToString(), unFrais.Cout_repas.ToString(), unFrais.Cout_hebergement.ToString());
                    
                }

            }
            

        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RechercheList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Form_consulter_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string adresse = comboBox1.SelectedItem.ToString();
            string date = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string motif = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string trajet = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string km = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string cout_p = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string cout_r = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string cout_h = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            Form_valider fmv = new Form_valider(adresse,date, motif, trajet, km, cout_p, cout_r, cout_h);
            fmv.ShowDialog();



        }
    }

}
