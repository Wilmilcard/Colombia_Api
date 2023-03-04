using Colombia_Api.Domain.Models;
using Colombia_Api.Domain.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombia_Api.Domain.DB
{
    public class ColombiaApiDbContext : DbContext
    {
        public ColombiaApiDbContext(DbContextOptions<ColombiaApiDbContext> options) : base(options)
        {

        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Session> Session { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
