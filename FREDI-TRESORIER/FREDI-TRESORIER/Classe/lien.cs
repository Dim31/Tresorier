using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    public class lien
    {
        private string numero_licence;
        private string adresse_mail;

        public lien(string numero_licence, string adresse_mail)
        {
            this.numero_licence = numero_licence;
            this.adresse_mail = adresse_mail;
        }

        public lien()
        {

        }

        public string Numero_licence { get => numero_licence; set => numero_licence = value; }
        public string Adresse_mail { get => adresse_mail; set => adresse_mail = value; }
    }
}
