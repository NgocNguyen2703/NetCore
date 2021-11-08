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
    }
}

    
