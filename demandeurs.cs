using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    class demandeurs
    {
        private string adresse_mail;
        private string nom;
        private string prenom;
        private string rue;
        private int cp;
        private string ville;
        private string password;

        public demandeurs(string adresse_mail, string nom, string prenom, string rue, int cp, string ville, string password)
        {
            this.adresse_mail = adresse_mail;
            this.nom = nom;
            this.prenom = prenom;
            this.rue = rue;
            this.cp = cp;
            this.ville = ville;
            this.password = password;
        }
        public demandeurs() { }

        public string Adresse_mail { get => adresse_mail; set => adresse_mail = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue { get => rue; set => rue = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Password { get => password; set => password = value; }
    }
}
