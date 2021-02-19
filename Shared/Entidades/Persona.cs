 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
   public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public DateTime? FechaNacimiento { get; set; }

        public string Descripcion { get; set; }
        public string Foto { get; set; }

        // si quiero una propiedad que no vaya a salir en la tabla 
        [NotMapped]
        public string Personaje { get; set; }
        #region PROPIEDADES DE NAVEGACION (ESTABLECEN LAS RELACIONES ENTRE LAS TABLAS)
        public List<PeliculaActor> PeliculasActor { get; set; }

        #endregion
        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   Id == persona.Id &&
                   Nombre == persona.Nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre);
        }
    }
}
