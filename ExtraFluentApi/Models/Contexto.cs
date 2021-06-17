using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExtraFluentApi.Models
{
    class Contexto: DbContext
    {
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<AccesoPremier> AccesoPremiers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasOne<Rol>(p => p.Rol)
                .WithMany(r => r.Personas)
                .HasForeignKey(p => p.RolId);

            modelBuilder.Entity<AccesoPremier>()
                .HasOne<Persona>(a => a.Persona)
                .WithMany(p => p.AccesoPremiers)
                .HasForeignKey(a => a.PersonaId);

            modelBuilder.Entity<AccesoPremier>()
                .HasOne<Pelicula>(a => a.Pelicula)
                .WithMany(p => p.AccesoPremiers)
                .HasForeignKey(a => a.PeliculaId);

            modelBuilder.Entity<AccesoPremierB>().HasKey(ap => new { ap.PeliculaId, ap.PersonaId});

            modelBuilder.Entity<AccesoPremierB>()
                .HasOne<Persona>(a => a.Persona)
                .WithMany(p => p.AccesoPremierBs)
                .HasForeignKey(a => a.PersonaId);

            modelBuilder.Entity<AccesoPremierB>()
                .HasOne<Pelicula>(a => a.Pelicula)
                .WithMany(p => p.AccesoPremierBs)
                .HasForeignKey(a => a.PeliculaId);

            modelBuilder.Entity<Persona>()
                .Property(p => p.Telefono)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            modelBuilder.Entity<Persona>()
                .Property(p => p.Nombre)
                .HasColumnName("Name");

            //Ejemplo relacion one-one
            /*
             * modelBuilder.Entity<Pelicula>()
                .HasOne<AccesoPremier>(p => p.accesoPremier)
                .WithOne(a => a.Pelicula)
                .HasForeignKey<AccesoPremier>(p => p.PeliculaId);
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.168.138.128;Database=ExtraFluentApi;Trusted_Connection=False;user=marleny;password=marlenyl");
        }
    }
}
