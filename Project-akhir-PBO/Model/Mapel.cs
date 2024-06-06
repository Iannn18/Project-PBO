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
}
