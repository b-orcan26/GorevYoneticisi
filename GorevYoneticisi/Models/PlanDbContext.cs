using LinqToDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GorevYoneticisi.Models
{
    public class PlanDbContext : DbContext
    {
        public virtual DbSet<Plan> Planlars { get; set; }

        public PlanDbContext(DbContextOptions<PlanDbContext> options)
           : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DRANA\\SQLEXPRESS; database=PlanDb ; integrated security=true;");
        //}

    }
}
