using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
   public  class GeneroPelicula
    {
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }
        #region PROPIEDADES DE NAVEGACION
        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set; }
        #endregion

    }
}
