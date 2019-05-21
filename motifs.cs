using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    class motifs
    {
        private int id_motif;
        private string libelle;

        public motifs(int id_motif, string libelle)
        {
            this.id_motif = id_motif;
            this.libelle = libelle;
        }

        public motifs()
        {

        }

        public int Id_motif { get => id_motif; set => id_motif = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
