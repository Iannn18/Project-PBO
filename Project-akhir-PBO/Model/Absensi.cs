﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Absensi
    {
        [Key]
        public int Id_Absensi { get; set; }

        [ForeignKey("NISN")]
        public int NISN { get; set; }

        public virtual Siswa Siswa { get; set; }

        public DateTime Waktu_Hadir { get; set; }
    }
}