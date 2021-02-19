using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
  public  class VotoPelicula
    {
        public int Id { get; set; }
        public int Voto { get; set; }

        public DateTime FechaVoto { get; set; }
        public int PeliculaId { get; set; }
        #region PROPIEDAD DE NAVEGACION
        // SI COLOCAMOS UNA PROPIEDAD DE NAVEGACION Y ADEMAS TENEMOS UNA PROPIEDAD DE LA ENTIDAD CON EL  MISMO NOMBRE, SEGUIDO DE ID
        // HACE QUE ESTA PROPIEDAD (ID) SEA UNA CLAVE FORANEA QUE APUNTE A LA TABLA DE LA PROPIEDAD DE NAVEGACION, IMPIDIENDO QUE HAYA
        // UNA PELICULAID DE UNA PELICULA QUE NO EXISTE EN LA TABLA PELICULAS ( NO PUEDE HABER UNA PELICULA CON ID = 700) SI NO EXISTE EN LA TABLA PELICULAS

        public Pelicula Pelicula { get; set; }

        #endregion
    }
}
