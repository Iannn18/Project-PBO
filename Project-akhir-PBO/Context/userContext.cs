using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project_akhir_PBO.DB;
using System.Data;

namespace Project_akhir_PBO.Context
{
    public static class userContext
    {
        public static Staff? akun;

        public static bool loginQuery(string username, string password)
        {
            bool status = false;

            // Query Database
            string query = @$"SELECT * FROM staff WHERE left(nuptk, 1)||right(nuptk,1)||right(left(nuptk,6), 4) = '{username}'AND left(nuptk, 1)||right(left(nuptk,3),1)||right(nuptk, 4) = '{password}';";
            // result = query
            DataTable result = Database.queryExecutor(query);

            // Dummy
            if (result.Rows.Count.ToString() != "0") // -> ubah berdasarkan result dari query
            {
                // Inisiasi properti dalam bentuk objek Staff berdasarkan hasil query
                //this.akun = new Staff(namaStaff: "Edo", tanggalLahir: new DateOnly(2015, 10, 21), tempatLahir: "Jember", alamat: "Rambi", nomorTelepon: 089342326231, nuptk: 3087, idJabatan: 1);
                userContext.akun = new Staff(
                namaStaff: result.Rows[0]["nama_staff"].ToString()!,
                tanggalLahir: DateTime.Parse(result.Rows[0]["tanggal_lahir"].ToString()!),
                tempatLahir: result.Rows[0]["tempat_lahir"].ToString()!,
                alamat: result.Rows[0]["alamat"].ToString()!,
                nomorTelepon: result.Rows[0]["nomor_telepon_staff"].ToString()!,
                nuptk: result.Rows[0]["nuptk"].ToString()!,
                idJabatan: int.Parse(result.Rows[0]["Id_jabatan"].ToString()!)
);

                status = true;
            }

            return status;
        }
    }
}
