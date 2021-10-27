using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entidades;

namespace WebApplication1.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }
        public DbSet<Roles> Roles {get;set;}
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Tarjetas> Tarjetas { get; set; }
        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Carritos> Carritos { get; set; }
        public DbSet<DetalleDeCompras> detalleDeCompras { get; set; }
        public DbSet<Imagenes> imagenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
