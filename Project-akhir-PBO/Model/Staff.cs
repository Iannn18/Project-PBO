using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	public class Staff : Person
	{
		[Key]
		public int NUPTK { get; set; }

		[Required]

		[ForeignKey("Id_Jabatan")]
		// public int Id_Jabatan { get; set; }
		public string jabatan { get; set; }


        public Staff(string nama, DateOnly tanggal_lahir, string tempat_lahir, string alamat, string nomor_telepon, int NUPTK, string jabatan) : base(nama, tanggal_lahir, tempat_lahir, alamat, nomor_telepon) 
        {
            this.NUPTK = NUPTK;
            this.jabatan = jabatan;
        }
	}

}
