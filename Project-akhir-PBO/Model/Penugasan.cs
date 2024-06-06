using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Penugasan
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
}
