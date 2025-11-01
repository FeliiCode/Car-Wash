using System;
using Npgsql;

namespace Car_Wash.Koneksi
{
    public class DBConnection
    {
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "db_vb2_car_wash";
        private static string Password = ""; // ubah sesuai password PostgreSQL kamu
        private static string Port = "5432";

        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={Host};Username={User};Password={Password};Database={DBname};Port={Port}";
            return new NpgsqlConnection(connString);
        }
    }
}
