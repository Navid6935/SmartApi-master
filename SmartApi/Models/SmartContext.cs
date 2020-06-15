using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartApi.Models;

namespace SmartApi.Models
{

    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=192.168.0.58;Initial Catalog=SmartApi;user = sa;password=69655.6935.;MultipleActiveResultSets=true;");
        }

        public DbSet<SmartApi.Models.Users> Users { get; set; }
    }
}
