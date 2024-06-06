using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	public class Siswa : Person
	{
		[Key]
		public string NISN { get; set; }
		// public string Nomor_Telepon_Siswa { get; set; }
		public string nama_kelas { get; set; }

		[Required]

		[ForeignKey("Id_Kelas")]
		public virtual Kelas Kelas { get; set; }

		public virtual ICollection<Raport> Raports { get; set; }
		public virtual ICollection<Absensi> Absensis { get; set; }

		public Siswa(string nama, DateOnly tanggal_lahir, string tempat_lahir, string alamat, string nomor_telepon, string NISN, string nama_kelas) : base(nama, tanggal_lahir, tempat_lahir, alamat, nomor_telepon)
		{
			this.NISN = NISN;
			// this.Nomor_Telepon_Siswa = Nomor_Telepon_Siswa;
			this.nama_kelas = nama_kelas;
		}
	}
}
