using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    internal class DetailRaport
    {
        [Key]
        public int Id_Detail_Raport { get; set; }

        [ForeignKey("Kode_Mapel")]
        public string Kode_Mapel { get; set; }

        public virtual Mapel Mapel { get; set; }
    }
}
