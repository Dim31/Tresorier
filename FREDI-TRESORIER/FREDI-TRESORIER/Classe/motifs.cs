using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    public class motifs
    {
        private Int64 id_motif;
        private string libelle;

        public motifs(Int64 id_motif, string libelle)
        {
            this.id_motif = id_motif;
            this.libelle = libelle;
        }

        public motifs()
        {

        }

        public Int64 Id_motif { get => id_motif; set => id_motif = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}