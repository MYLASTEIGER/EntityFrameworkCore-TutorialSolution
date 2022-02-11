using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Tutorial.Models {
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }

        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        //important for projects above
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured) {
                builder.UseSqlServer("server=localhost\\sqlexpress;database=SalesDb1;trusted_connection=true;");
                //connection string to access the database above in quotes
            }
        }
        protected override void OnModelCreating(ModelBuilder builder) {

        }
    }
}
