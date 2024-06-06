using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Penilaian
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
}
