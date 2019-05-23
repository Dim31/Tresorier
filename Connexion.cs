using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FREDI_TRESORIER.Classe;
using MySql.Data.MySqlClient;

namespace FREDI_TRESORIER
{
    public static class Connexion
    {
        private static MySqlConnection connect;

        public static void init()
        {
            connect = new MySqlConnection();
            //connect.ConnectionString = "SERVER = 127.0.0.1; DATABASE=fredi; UID=root; PASSWORD= ";
            connect.ConnectionString = "SERVER=172.16.106.4; DATABASE=slam_19; UID=slam_19; PASSWORD=Btsslam";
        }
        public static void GetLesDemandeur()
        {
            //ouverture de la connexion
            connect.Open();

            //commande
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from demandeurs";

            //execution
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                MessageBox.Show("ok");
            }

            connect.Close();
        }
        public static List<lignes_frais> GetLesFrais()
        {
            connect.Open();
            List<lignes_frais> Leslignes = new List<lignes_frais>(); 
            

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select ADRESSE_MAIL, DATE_FRAIS, ID_MOTIF, TRAJET, KM, COUT_PEAGE, COUT_REPAS, COUT_HEBERGEMENT from lignes_frais";

            MySqlDataReader reader = cmd.ExecuteReader();

            //int i = 0;
            while (reader.Read())
            {
                lignes_frais uneLigne = new lignes_frais();

                 uneLigne.Adresse_mail = (string)reader["ADRESSE_MAIL"];
                 uneLigne.Date_frais = (DateTime)reader["DATE_FRAIS"];
                 uneLigne.Id_motif = (Int64)reader["ID_MOTIF"];
                 uneLigne.Trajet = (string)reader["TRAJET"];
                 uneLigne.Km = (Int64)reader["KM"];
                 uneLigne.Cout_peage = (Decimal)reader["COUT_PEAGE"];
                 uneLigne.Cout_repas = (Decimal)reader["COUT_REPAS"];
                 uneLigne.Cout_hebergement = (Decimal)reader["COUT_HEBERGEMENT"];

                Leslignes.Add(uneLigne);
                /*MessageBox.Show(reader[i].GetType().ToString());
                i++;*/
            }

            connect.Close();

            return Leslignes;

        }
        public static string GetMotifsLibelle(Int64 id)
        {
            string LeMotifs="";
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select LIBELLE from motifs where ID_MOTIF = "+id;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                LeMotifs = (string)reader["LIBELLE"];

            }
            connect.Close();
            return LeMotifs;
        }

        public static List<string> GetlesMails()
        {
            List<string> lesMails = new List<string>();
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select ADRESSE_MAIL from demandeurs";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lesMails.Add((string)reader["ADRESSE_MAIL"]);
            }
            connect.Close();
            return lesMails;
        }
    }
}
