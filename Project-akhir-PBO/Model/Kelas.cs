using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Kelas
	{
		[Key]
		public int Id_Kelas { get; set; }

		[Required]
		public string Nama_Kelas { get; set; } 
		public int Jumlah_Siswa {  get; set; }

		[ForeignKey("NUPTK")]
		public virtual Staff Staff { get; set; }

		public virtual ICollection<Siswa> Siswas { get; set; }
	}
}
