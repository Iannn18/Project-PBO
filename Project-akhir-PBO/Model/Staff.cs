using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Staff : Person
	{
		[Key]
		public int NUPTK { get; set; }
		[Required]
		public string Nama_Staff { get; set; }
		[ForeignKey("Id_Jabatan")]
		public virtual Jabatan Jabatan { get; set; }
	}
}
