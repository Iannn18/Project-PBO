using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Context
{
    public class userContext
    {
        public Staff? akun;

        public bool loginQuery(string username, string password)
        {
            bool status = false;

            // Query Database
            // result = query
            // Dummy
            if (username == "admin" && password == "admin") // -> ubah berdasarkan result dari query
            {
                // Inisiasi properti dalam bentuk objek Staff berdasarkan hasil query
                //this.akun = new Staff(namaStaff: "Edo", tanggalLahir: new DateOnly(2015, 10, 21), tempatLahir: "Jember", alamat: "Rambi", nomorTelepon: 089342326231, nuptk: 3087, idJabatan: 1);
                this.akun = new Staff(
                namaStaff: "Edo",
                tanggalLahir: new DateTime(2015, 10, 21),
                tempatLahir: "Jember",
                alamat: "Rambi",
                nomorTelepon: "089342326231",
                nuptk: "3087",
                idJabatan: 1
);

                status = true;
            }

            return status;
        }
    }
}
