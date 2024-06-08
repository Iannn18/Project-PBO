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
        [MaxLength(255)]
        public string Nama_Tugas { get; set; }

        public string Deskripsi_Tugas { get; set; }

        [Required]
        public int Kode_Mapel { get; set; }
        [Required]
        public int Id_Status { get; set; }


        [ForeignKey("Kode_Mapel")]
        public virtual Mapel Mapel { get; set; }

        [ForeignKey("Id_Status")]
        public virtual StatusTugas StatusTugas { get; set; }

    }
}
