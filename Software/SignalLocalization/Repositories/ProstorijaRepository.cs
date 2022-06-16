using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalLocalization.Models;
using DBLayer;
using System.Data.SqlClient;

namespace SignalLocalization.Repositories
{
    public class ProstorijaRepository
    {
        public static Prostorija GetProstorija(int id)
        {
            Prostorija prostorija = null;
            string sql = $"SELECT * FROM TestProstorija WHERE idTestProstorija = {id}";
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
            List<Prostorija> prostorije = new List<Prostorija>();

            string sql = "SELECT * FROM TestProstorija";
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
            int id = int.Parse(reader["idTestProstorija"].ToString());
            int kat = int.Parse(reader["kat"].ToString());
            //string vrsta = reader["vrsta"].ToString();
            int broj = int.Parse(reader["broj"].ToString());
            int velicina = int.Parse(reader["velicina"].ToString());
            int krevet = int.Parse(reader["krevet"].ToString());
            int id2 = int.Parse(reader["idTestZatvorenik"].ToString());

            var prostorija = new Prostorija
            {
                Id = id,
                Kat = kat,
                // Vrsta = vrsta,
                Broj = broj,
                Velicina = velicina,
                BrojKreveta = krevet,

                IdZatvorenika = id2
            };
            return prostorija;
        }

        public void Insert(Prostorija prostorija)
        {
            string sql = $"INSERT INTO TestProstorija (idTestProstorija, kat, broj, velicina, krevet, idTestZatvorenik) VALUES({ prostorija.Id},{ prostorija.Kat}, { prostorija.Broj},{ prostorija.Velicina},{ prostorija.BrojKreveta}, { prostorija.IdZatvorenika})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void Update(Prostorija prostorija)
        {

            string sql = $"UPDATE TestProstorija " +
                $"SET kat = {prostorija.Kat}, broj = '{prostorija.Broj}', velicina = '{prostorija.Velicina}', krevet = '{prostorija.BrojKreveta}', idTestZatvorenik = '{prostorija.IdZatvorenika}'   WHERE idTestProstorija={prostorija.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public void Delete(int idProstorija)
        {
            string sql = $"DELETE FROM TestProstorija WHERE idTestProstorija = {idProstorija}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
