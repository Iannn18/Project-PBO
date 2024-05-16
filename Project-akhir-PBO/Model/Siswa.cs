using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Siswa : Person
	{
		[Key]
		public int NISN { get; set; }
		[Required]
		public string Nama_Siswa{ get; set; }
		[ForeignKey("Id_Kelas")]
		public virtual Kelas Kelas { get; set; }

	}
}
