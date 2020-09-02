using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using BackEnd.Models;   

namespace BackEnd.Models
{
    public class DB:DbContext
    {
        public DB()
        {
            Database.SetInitializer<DB>(null);
        }
        public DbSet<Mahasiswa> Mahasiswa { get; set; }
        public DbSet<Materi> Materi { get; set; }
        public DbSet<RegisterMateri> RegisterMateri { get; set; }

    }
}