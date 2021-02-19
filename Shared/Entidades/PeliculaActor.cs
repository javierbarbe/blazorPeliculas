using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
    public class PeliculaActor
    {

        /* ESTA ES UNA CLASE RELACIONAL*/ 
        public int PersonaId { get; set; }
        public int PeliculaId { get; set; }
        #region PROPIEDADES DE NAVEGACION
        public Persona Persona { get; set; }
        public Pelicula Pelicula { get; set; }
        #endregion

        public string Personaje { get; set; }
        public int Orden { get; set; }
    }
}
