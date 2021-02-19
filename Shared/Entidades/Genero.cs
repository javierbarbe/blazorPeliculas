using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorUdemy.Shared.Entidades
{
  public  class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Nombre { get; set; }
        // para modelar la relacion entre Genero y GeneroPeliculas (entre estas dos entidades usaremos una lista)
        //la idea es que a partir de un genero poder buscar todos los registros de ese generoPwliculas par los cuales dicho genero
        //esta participando

        public List<GeneroPelicula> GeneroPeliculas { get; set; }
    }
}
