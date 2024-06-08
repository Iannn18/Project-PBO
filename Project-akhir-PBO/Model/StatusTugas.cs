using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class StatusTugas
    {
        [Key]
        public int Id_Status { get; set; }

        [Required]
        [MaxLength(255)]
        public string Status_Tugas { get; set; }

        public virtual ICollection<Penugasan> Penugasans { get; set; }
    }
}
