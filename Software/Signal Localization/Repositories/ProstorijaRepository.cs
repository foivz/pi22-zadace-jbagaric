using DBLayer;
using Signal_Localization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Signal_Localization.Repositories
{
    public class ProstorijaRepository
    {
        public static List<Prostorija> GetProstorije()
        {
            var prostorije = new List<Prostorija>();

            string sql = "SELECT * FROM Prostorije";
            //DB.SetConfiguration("jbagaric20_DB", "jbagaric20", "#A{v+t8H");
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Prostorija prostorija = CreateObject(reader);
                prostorije.Add(prostorija);
            }

            reader.Close();
            DB.CloseConnection();

            return prostorije;
        }

        private static Prostorija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idProstorije"].ToString());
            int kat = int.Parse(reader["kat"].ToString());
            string vrsta = reader["vrsta"].ToString();
            //int brojKreveta = int.Parse(reader["brojKreveta"].ToString());
            int velicina = int.Parse(reader["veličina"].ToString());

            var prostorija = new Prostorija
            {
                Id = id,
                Kat = kat,
                Vrsta = vrsta,
               // BrojKreveta = brojKreveta,
                Velicina = velicina
            };

            return prostorija;
        }
    }
}
