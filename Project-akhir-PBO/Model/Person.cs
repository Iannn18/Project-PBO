using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
	internal class Person
	{
		[Required]
		public DateOnly Tanggal_Lahir { get; set; }
		public string Tempat_Lahir { get; set; }
		public string Alamat {  get; set; }
	}
}
