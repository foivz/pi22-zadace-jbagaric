﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using SignalLocalization.Models;

namespace SignalLocalization.Repositories
{
    public class ZatvorenikRepository
    {
        public static Zatvorenik GetZatvorenik(int id)
        {
            Zatvorenik zatvorenik = null;
            string sql = $"SELECT * FROM Zatvorenici WHERE Id = {id}";
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
            DB.SetConfiguration("jbagaric20_DB", "jbagaric20", "#A{v+t8H");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zatvorenik zatvorenik = CreateObject(reader);
                zatvorenici.Add(zatvorenik);
            }
            reader.Close();
            DB.CloseConnection();
            return zatvorenici;
        }

        private static Zatvorenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string ime = reader["ime"].ToString();
            string prezime = reader["prezime"].ToString();
            DateTime datumPritvora = DateTime.Parse(reader["datumPritvora"].ToString());
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
