﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Model
{
    public class Siswa
    {
        public Siswa(string? NISN, string? nama, string? nama_kelas, DateOnly tanggal_lahir, string? tempat_lahir, string? alamat, string? nomor_telepon)
        {
            this.NISN = NISN;
            Tempat_Lahir = tempat_lahir;
            Alamat = alamat;
        }

        [Key]
        [MaxLength(255)]
        public string NISN { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nama_Siswa { get; set; }

        [Required]
        public DateTime Tanggal_Lahir { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nomor_Telepon_Siswa { get; set; }

        [Required]
        [MaxLength(255)]
        public string Tempat_Lahir { get; set; }

        [Required]
        [MaxLength(255)]
        public string Alamat { get; set; }

        public int Id_Kelas { get; set; }

        [ForeignKey("Id_Kelas")]
        public virtual Kelas Kelas { get; set; }

        public virtual ICollection<Absensi> Absensis { get; set; }
        public virtual ICollection<Raport> Raports { get; set; }

    }
}
