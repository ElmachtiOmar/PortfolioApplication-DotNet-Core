using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        { 
        }
        public DbSet<Owner> Owner { get; set; }

        public DbSet<Adress> Adress {  get; set; }
        
        public DbSet<PortfolioItem> PortfolioItems { get; set; }

    }
}
