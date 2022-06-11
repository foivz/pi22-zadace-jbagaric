using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using SignalLocalization.Models;
using System.Data.SqlClient;

namespace SignalLocalization.Repositories
{
    public class ProstorijaRepository
    {
        public static Prostorija GetProstorija(int id)
        {
            Prostorija prostorija = null;
            string sql = $"SELECT * FROM Prostorije WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                prostorija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return prostorija;
        }

        public static List<Prostorija> GetProstorije()
        {
            var prostorije = new List<Prostorija>();

            string sql = "SELECT * FROM Zatvorenici";
            DB.SetConfiguration("jbagaric20_DB", "jbagaric20", "#A{v+t8H");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
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
            int id = int.Parse(reader["id"].ToString());
            string vrsta = reader["vrsta"].ToString();
            int broj = int.Parse(reader["broj"].ToString());
            int velicina = int.Parse(reader["velicina"].ToString());
            int krevet = int.Parse(reader["kreveti"].ToString());
            int kat = int.Parse(reader["kat"].ToString());
            var prostorija = new Prostorija
            {
                Id = id,
                Vrsta = vrsta,
                Broj = broj,
                Velicina = velicina,
                BrojKreveta = krevet,
                Kat = kat
            };
            return prostorija;
        }
    }
}
