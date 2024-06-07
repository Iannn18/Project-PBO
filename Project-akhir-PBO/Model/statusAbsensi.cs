using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class StatusAbsensi
    {
        [Key]
        public int Id_Status_Absen { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nama_Status { get; set; }

        public virtual ICollection<Absensi> Absensis { get; set; }
    }
}
