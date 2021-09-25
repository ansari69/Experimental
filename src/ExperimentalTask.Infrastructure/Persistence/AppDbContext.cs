using ExperimentalTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExperimentalTask.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }



        public DbSet<Experimental> Experimentals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

             optionsBuilder.UseSqlServer("server=.;database=Experimental-DB;trusted_connection=true;");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //getting configuratons for entities that are being executed
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var rel in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                rel.DeleteBehavior = DeleteBehavior.NoAction;
            }

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
