using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    public class ligue
    {
        private int num_ligue;
        private string nom;
        private string sigle;
        private string president;

        public ligue(int num_ligue, string nom, string sigle, string president)
        {
            this.Num_ligue = num_ligue;
            this.Nom = nom;
            this.Sigle = sigle;
            this.President = president;
        }

        public ligue() { }
        public int Num_ligue { get => num_ligue; set => num_ligue = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Sigle { get => sigle; set => sigle = value; }
        public string President { get => president; set => president = value; }
    }
}