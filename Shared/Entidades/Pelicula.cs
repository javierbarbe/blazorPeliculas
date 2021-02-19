using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
   public class Pelicula
    {
        public int Id { get; set; }

        public string Imagen { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime? Lanzamiento { get; set; }
        public string Resumen { get; set; }
        public bool EnCartelera { get; set; }

        #region PROPIEDADES DE NAVEGACION (ESTABLECEN LAS RELACIONES ENTRE LAS TABLAS)
        public List<PeliculaActor> PeliculasActor { get; set; }
        public List<GeneroPelicula> GenerosPelicula { get; set; } = new List<GeneroPelicula>();

        #endregion
        public string Trailer { get; set; }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Pelicula pelicula &&
                   Titulo == pelicula.Titulo &&
                   Lanzamiento == pelicula.Lanzamiento;
        }

        public Pelicula addFotoAPelicula(string fileName, Pelicula pelicula)
        {
            this.Imagen = fileName;
            return this;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titulo, Lanzamiento);
        }
    }
}
