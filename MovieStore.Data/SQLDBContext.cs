using MovieStore.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    public class SQLDBContext : DbContext
    {
        public SQLDBContext(string connectionString)
            :base(connectionString)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
