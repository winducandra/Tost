using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("RegisterMateri")]
    public class RegisterMateri
    {
        [Key]
        public Nullable<int> RegMateri { get; set; }
        public Nullable<int> MahasiswaID { get; set; }
        public Nullable<int> MateriID { get; set; }
    }

    public class RegisterVw
    { 
        public string Deskripsi { get; set; }
        public Nullable<int> SKS { get; set; }
        public Nullable<int> Parent_MateriID { get; set; }
        public Nullable<int> JumlahRegister { get; set; }
        public Nullable<int> TotalSks { get; set; }
    }
}