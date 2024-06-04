using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	public class Person
	{
		[Required]
		public string nama { get; set; }
		public DateOnly tanggal_lahir { get; set; }
		public string tempat_lahir { get; set; }
		public string alamat {  get; set; }
        public string nomor_telepon { get; set; }

		public Person(string nama, DateOnly tanggal_lahir, string tempat_lahir, string alamat, string nomor_telepon)
		{
			this.nama = nama;
			this.tanggal_lahir = tanggal_lahir;
			this.tempat_lahir = tempat_lahir;
			this.alamat = alamat;
			this.nomor_telepon = nomor_telepon;
		}
    }
}
