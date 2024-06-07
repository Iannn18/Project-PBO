using Npgsql;
using NpgsqlTypes;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Context
{
    internal class DetailRaportContext
    {
        private static string table = "detail_raport";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataDetailRaport = Database.queryExecutor(query);
            return dataDetailRaport;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_detail_raport = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataDetailRaport = Database.queryExecutor(query, parameters);
            return dataDetailRaport;
        }

        public static void store(DetailRaport detailRaportBaru)
        {
            string query = $"INSERT INTO {table}(kode_mapel, score) VALUES(@kode_mapel, @score)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = detailRaportBaru.Kode_Mapel},
            new NpgsqlParameter("@score", NpgsqlDbType.Integer){Value = detailRaportBaru.Score},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_detail_raport = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(DetailRaport detailRaportEdit)
        {
            string query = $"UPDATE {table} SET kode_mapel = @kode_mapel, score = @score WHERE id_detail_raport = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = detailRaportEdit.Kode_Mapel},
            new NpgsqlParameter("@score", NpgsqlDbType.Integer){Value = detailRaportEdit.Score},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = detailRaportEdit.Id_Detail_Raport},
        };
            Database.commandExecutor(query, parameters);
        }
    }

}
