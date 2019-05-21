using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            connect.ConnectionString = "SERVER=172.16.0.16; DATABASE=slam_22a; UID=slam_22; PASSWORD=Btsslam";
        }
        public static void GetLesDemandeur()
        {
            //ouverture de la connexion
            connect.Open();

            //commande
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from DEMANDEURS";

            //execution
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                MessageBox.Show("ok");
            }

            connect.Close();
        }
    }
}
