using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    public class Club
    {
        private string num_club;
        private string num_ligue;
        private string numero_licence;
        private string mdptresorier;
        private string nom_club;
        private string ville;
        private string cp;
        private string rue;

        public Club(string num_club, string num_ligue, string numero_licence, string mdptresorier, string nom_club, string ville, string cp, string rue)
        {
            this.num_club = num_club;
            this.num_ligue = num_ligue;
            this.numero_licence = numero_licence;
            this.mdptresorier = mdptresorier;
            this.nom_club = nom_club;
            this.ville = ville;
            this.cp = cp;
            this.rue = rue;
        }

        public Club()
        {

        }

        public string Num_club { get => num_club; set => num_club = value; }
        public string Num_ligue { get => num_ligue; set => num_ligue = value; }
        public string Numero_licence { get => numero_licence; set => numero_licence = value; }
        public string Mdptresorier { get => mdptresorier; set => mdptresorier = value; }
        public string Nom_club { get => nom_club; set => nom_club = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Rue { get => rue; set => rue = value; }
    }
}
