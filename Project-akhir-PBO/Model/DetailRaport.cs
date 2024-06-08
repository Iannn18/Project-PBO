using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class DetailRaport
    {
        [Key]
        public int Id_Detail_Raport { get; set; }

        [Required]
        public int Kode_Mapel { get; set; }

        [ForeignKey("Kode_Mapel")]
        public virtual Mapel Mapel { get; set; }

        [Required]
        public int Score { get; set; }

        public virtual ICollection<Raport> Raports { get; set; }
    }
}
