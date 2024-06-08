using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Absensi
    {
        [Key]
        public int Id_Absensi { get; set; }

        [Required]
        public DateTime Waktu_Hadir { get; set; }

        [Required]
        [MaxLength(255)]
        public string NISN { get; set; }

        [ForeignKey("NISN")]
        public virtual Siswa Siswa { get; set; }

        public long Id_Status_Absen { get; set; }

        [ForeignKey("Id_Status_Absen")]
        public virtual StatusAbsensi StatusAbsensi { get; set; }
    }
}
