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

	internal class Mapel
	{
		[Key]
        public string Kode_Mapel { get; set; }

		[Required]
        public string Nama_Mapel { get; set; }
		public string Deskripsi_Mapel { get; set; }

		[ForeignKey("Id_Kelas")]
        public int Id_Kelas { get; set; }

		public virtual Kelas Kelas { get; set; }

		public virtual ICollection<Penugasan> Penugasans { get; set; }

        public virtual ICollection<Detail_Raport> Detail_Raports { get; set; }
    }

	internal class Penugasan
	{
        [Key]
        public int Id_Tugas { get; set; }

        [Required]
        public string Nama_Tugas { get; set; }

        public string Deskripsi_Tugas { get; set; }

        [ForeignKey("Kode_Mapel")]
        public int Kode_Mapel { get; set; }

        public virtual Mapel Mapel { get; set; }

        [ForeignKey("Id_Status")]
        public int Id_Status { get; set; }

        public virtual Status_Tugas Status_Tugas { get; set; }

        public virtual ICollection<Penilaian> Penilaians { get; set; }
    }

	internal class Penilaian
	{
        [Key]
        public int Id_Penilaian { get; set; }

        [ForeignKey("NISN")]
        public int NISN { get; set; }

        public virtual Siswa Siswa { get; set; }

        [ForeignKey("Id_Tugas")]
        public int Id_Tugas { get; set; }

        public virtual Penugasan Penugasan { get; set; }

        public int Nilai { get; set; }
    }

    internal class Status_Tugas 
    {
        [Key]
        public int Id_Status { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Penugasan> Penugasans { get; set; }
    }
}
