using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Materi")]
    public class Materi
    {
        [Key]
        public Nullable<int> Materi_ID { get; set; }
        public string Deskripsi { get; set; }
        public Nullable<int> SKS { get; set; }
        public Nullable<int> Parent_MateriID { get; set; }
    }
}