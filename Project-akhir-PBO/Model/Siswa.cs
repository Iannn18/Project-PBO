using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Siswa : Person
	{
		[Key]
		public int NISN { get; set; }

		[Required]

		[ForeignKey("Id_Kelas")]
		public virtual Kelas Kelas { get; set; }


		public virtual ICollection<Raport> Raports { get; set; }
		public virtual ICollection<Absensi> Absensis { get; set; }
		public virtual ICollection<Nomor_Telepon_Siswa> Nomor_Telepon_Siswas { get; set; }

		public Siswa(string nama, DateOnly tanggal_lahir, string tempat_lahir, string alamat, string nomor_telepon, int NISN) : base(nama, tanggal_lahir, tempat_lahir, alamat, nomor_telepon)
		{
			this.NISN = NISN;
		}
	}

	internal class Raport
	{
		[Key]
        public int Id_Raport { get; set; }

		[Required]
        public string Semester { get; set; }

		[ForeignKey("NISN")]
		public int NISN { get; set; }
        public virtual Siswa Siswa { get; set; }


        public virtual ICollection<Detail_Raport> Detail_Raports { get; set; }
    }	

	internal class Detail_Raport
	{
		[Key]
        public int Id_Detail_Raport { get; set; }

		[ForeignKey("Kode_Mapel")]
        public string Kode_Mapel { get; set; }

		public virtual Mapel Mapel { get; set; }
    }	

	internal class Absensi
	{
		[Key]
        public int Id_Absensi { get; set; }

		[ForeignKey("NISN")]
        public int NISN { get; set; }

        public virtual Siswa Siswa { get; set; }

		public DateTime Waktu_Hadir { get; set; }
    }	

	internal class Nomor_Telepon_Siswa
	{
		[Key]
        public int Id_Nomor_Telepon_Siswa { get; set; }

		public long Nomor_Telepon_siswa { get; set; }

		[ForeignKey("NISN")]
        public int NISN { get; set; }

        public virtual Siswa Siswa { get; set; }
    }
}
