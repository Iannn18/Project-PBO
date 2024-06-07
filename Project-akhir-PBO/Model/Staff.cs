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
        private DateOnly tanggal_lahir;
        private string nomor_telepon;
        private int nUPTK;
        private string jabatan;

        public Staff(string Nama_Staff, DateOnly tanggal_lahir, string tempat_lahir, string alamat, string nomor_telepon, int NUPTK, string jabatan)
        {
            this.Nama_Staff = Nama_Staff;
            this.tanggal_lahir = tanggal_lahir;
            Tempat_Lahir = tempat_lahir;
            Alamat = alamat;
            this.nomor_telepon = nomor_telepon;
            nUPTK = NUPTK;
            this.jabatan = jabatan;
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
