using FREDI_TRESORIER.Classe;
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
    
    public partial class Form_Valider : Form
    {
        public Form_Valider()
        {
            InitializeComponent();
            Connexion.init();
            initListview();
        }
        private void initListview()
        {
            initListDeroulante();
            List<lignes_frais> lesFrais = Connexion.GetLesFrais();
            foreach(lignes_frais unFrais in lesFrais)
            {
                dataGridView1.Rows.Add(unFrais.Date_frais.ToShortDateString(), Connexion.GetMotifsLibelle(unFrais.Id_motif),unFrais.Trajet.ToString(), unFrais.Km.ToString(), unFrais.Cout_peage.ToString(), unFrais.Cout_repas.ToString(), unFrais.Cout_hebergement.ToString());
            }
        }
        private void initListDeroulante()
        {
            List<string> lesMails = Connexion.GetlesMails();
            foreach(string unMail in lesMails)
            {
                comboBox1.Items.Add(unMail);
            }
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
