using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Jabatan
	{
		[Key]
		public int Id_Jabatan { get; set; }
		[Required]
		public string Nama_Jabatan { get; set; }

		public string Deskripsi { get; set; }
		
		public virtual ICollection<Staff> Staffs { get; set;}
	}
}
