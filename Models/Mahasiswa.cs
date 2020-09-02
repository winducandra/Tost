using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{ 
    [Table("Mahasiswa")]
    public class Mahasiswa
    {
        [Key]
        public Nullable<int> MahasiswaID { get; set; }
        public string Nama { get; set; }
    }
}