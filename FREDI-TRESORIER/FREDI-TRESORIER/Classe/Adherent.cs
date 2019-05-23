using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    public class Adhérents
    {
        private int num_licence;
        private int num_club;
        private char sexe;
        private string nom;
        private string prenom;
        private DateTime date_naiss;
        private string rue;
        private int cp;
        private string ville;
        private string email;

        public Adhérents(int num_licence, int num_club, char sexe, string nom, string prenom, DateTime date_naiss, string rue, int cp, string ville, string email)
        {
            this.Num_licence = num_licence;
            this.Num_club = num_club;
            this.Sexe = sexe;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_naiss = date_naiss;
            this.Rue = rue;
            this.Cp = cp;
            this.Ville = ville;
            this.Email = email;
        }
        public Adhérents() { }

        public int Num_licence { get => num_licence; set => num_licence = value; }
        public int Num_club { get => num_club; set => num_club = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime Date_naiss { get => date_naiss; set => date_naiss = value; }
        public string Rue { get => rue; set => rue = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Email { get => email; set => email = value; }
    }
}