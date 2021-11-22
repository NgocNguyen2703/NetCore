using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETCORE.Models;
//using NETCORE.Data;
namespace NETCORE.Data {
public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NETCORE.Models.Movie> Movie { get; set; }

        public DbSet<NETCORE.Models.Person> Person { get; set; }

        public DbSet<NETCORE.Models.Student> Student { get; set; }

        public DbSet<NETCORE.Models.Employee> Employee { get; set; }

        public DbSet<NETCORE.Models.Product> Product { get; set; }

        public DbSet<NETCORE.Models.DonHang> DonHang { get; set; }

        public DbSet<NETCORE.Models.KetQua> KetQua { get; set; }

        public DbSet<NETCORE.Models.PhieuXuat> PhieuXuat { get; set; }

        public DbSet<NETCORE.Models.HoaDon> HoaDon { get; set; }
    }
}

    
