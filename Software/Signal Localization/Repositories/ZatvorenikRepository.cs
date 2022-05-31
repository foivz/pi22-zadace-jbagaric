using DBLayer;
using Signal_Localization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Signal_Localization.Repositories
{
    public class ZatvorenikRepository
    {
        public static Zatvorenik GetZatvorenik(int id)
        {
            Zatvorenik zatvorenik = null;

            string sql = $"SELECT * FROM Zatvorenici WHERE idZatvorenika = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zatvorenik = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return zatvorenik;
        }

        public static List<Zatvorenik> GetZatvorenike()
        {
            var zatvorenici = new List<Zatvorenik>();

            string sql = "SELECT * FROM Zatvorenici";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zatvorenik zatvorenik= CreateObject(reader);
                zatvorenici.Add(zatvorenik);
            }

            reader.Close();
            DB.CloseConnection();

            return zatvorenici;
        }

        private static Zatvorenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idZatvorenika"].ToString());
            string ime = reader["imeZatvorenika"].ToString();
            string prezime = reader["prezimeZatvorenika"].ToString();
            string datumPritvora = reader["datumPritvora"].ToString();

            var zatvorenik = new Zatvorenik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                DatumPritvora = datumPritvora
            };

            return zatvorenik;
        }

    }
}
