using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Raport
    {
        [Key]
        public int Id_Raport { get; set; }

        [Required]
        [MaxLength(255)]
        public string Semester { get; set; }

        [Required]
        [MaxLength(255)]
        public string NISN { get; set; }

        [ForeignKey("NISN")]
        public virtual Siswa Siswa { get; set; }

        public long Id_Detail_Raport { get; set; }

        [ForeignKey("Id_Detail_Raport")]
        public virtual DetailRaport DetailRaport { get; set; }
    }
}
