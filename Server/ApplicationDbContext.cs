using BlazorUdemy.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Server
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
             : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // aqui creamos la clave primaria compuesta ( o lo configuramos)
            modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId });
            modelBuilder.Entity<PeliculaActor>().HasKey(x => new { x.PeliculaId, x.PersonaId });
            base.OnModelCreating(modelBuilder);
        
        
        }
        // para cada tabla que queramos generar (las claves especiales las definimos arriba OnModelCreating)
        // lo tenemos que definir aqui mediante dbSet
        public DbSet <PeliculaActor> PeliculasActores { get; set; }
        public DbSet<Pelicula>Peliculas { get; set; }
        public DbSet<Persona>Personas { get; set; }
        public DbSet<Genero>Generos { get; set; }
        public DbSet<GeneroPelicula> GenerosPeliculas { get; set; }
    }
}
