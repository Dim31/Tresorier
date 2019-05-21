using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FREDI_TRESORIER.Classe
{
    class lignes_frais
    {
        private string adresse_mail;
        private DateTime date_frais;
        private int id_motif;
        private string trajet;
        private int km;
        private float cout_peage;
        private float cout_repas;
        private float cout_hebergement;
        private bool km_valide;
        private bool peage_valide;
        private bool repas_valide;
        private bool hebergement_valide;
        private float total;

        public lignes_frais(string adresse_mail, DateTime date_frais, int id_motif, string trajet, int km, float cout_peage, float cout_repas, float cout_hebergement, bool km_valide, bool peage_valide, bool repas_valide, bool hebergement_valide, float total)
        {
            this.adresse_mail = adresse_mail;
            this.date_frais = date_frais;
            this.id_motif = id_motif;
            this.trajet = trajet;
            this.km = km;
            this.cout_peage = cout_peage;
            this.cout_repas = cout_repas;
            this.cout_hebergement = cout_hebergement;
            this.km_valide = km_valide;
            this.peage_valide = peage_valide;
            this.repas_valide = repas_valide;
            this.hebergement_valide = hebergement_valide;
            this.total = total;
        }

        public lignes_frais()
        {

        }
        public string Adresse_mail { get => adresse_mail; set => adresse_mail = value; }
        public DateTime Date_frais { get => date_frais; set => date_frais = value; }
        public int Id_motif { get => id_motif; set => id_motif = value; }
        public string Trajet { get => trajet; set => trajet = value; }
        public int Km { get => km; set => km = value; }
        public float Cout_peage { get => cout_peage; set => cout_peage = value; }
        public float Cout_repas { get => cout_repas; set => cout_repas = value; }
        public float Cout_hebergement { get => cout_hebergement; set => cout_hebergement = value; }
        public bool Km_valide { get => km_valide; set => km_valide = value; }
        public bool Peage_valide { get => peage_valide; set => peage_valide = value; }
        public bool Repas_valide { get => repas_valide; set => repas_valide = value; }
        public bool Hebergement_valide { get => hebergement_valide; set => hebergement_valide = value; }
        public float Total { get => total; set => total = value; }
    }
}
