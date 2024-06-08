using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Staff
    {
        public Staff() { }

        public Staff(string namaStaff, DateTime tanggalLahir, string tempatLahir, string alamat, string nomorTelepon, string nuptk, int idJabatan)
        {
            Nama_Staff = namaStaff;
            Tanggal_Lahir = tanggalLahir;
            Tempat_Lahir = tempatLahir;
            Alamat = alamat;
            Nomor_Telepon_Staff = nomorTelepon;
            NUPTK = nuptk;
            Id_Jabatan = idJabatan;
        }

        [Key]
        [MaxLength(255)]
        public string NUPTK { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nama_Staff { get; set; }

        [Required]
        public DateTime Tanggal_Lahir { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nomor_Telepon_Staff { get; set; }

        [Required]
        [MaxLength(255)]
        public string Tempat_Lahir { get; set; }

        [Required]
        [MaxLength(255)]
        public string Alamat { get; set; }

        public int Id_Jabatan { get; set; }

        [ForeignKey("Id_Jabatan")]
        public virtual Jabatan Jabatan { get; set; }

        public virtual ICollection<Kelas> Kelas { get; set; }
        public virtual ICollection<Mapel> Mapels { get; set; }
    }

}
