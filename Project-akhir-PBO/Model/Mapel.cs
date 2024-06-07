using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Mapel
    {
        [Key]
        public int Kode_Mapel { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nama_Mapel { get; set; }

        public string Deskripsi_Mapel { get; set; }

        public int Id_Kelas { get; set; }

        [ForeignKey("Id_Kelas")]
        public virtual Kelas Kelas { get; set; }

        [Required]
        [MaxLength(255)]
        public string NUPTK { get; set; }

        [ForeignKey("NUPTK")]
        public virtual Staff Staff { get; set; }

        public virtual ICollection<Penugasan> Penugasans { get; set; }
        public virtual ICollection<DetailRaport> DetailRaports { get; set; }
    }
}
