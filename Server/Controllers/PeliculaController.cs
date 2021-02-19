using BlazorUdemy.Server.Helpers;
using BlazorUdemy.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUdemy.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PeliculaController:ControllerBase
    {
        private ApplicationDbContext contexto;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        public PeliculaController(ApplicationDbContext contexto, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.contexto = contexto;
            this.almacenadorArchivos =  almacenadorArchivos;
            //asi cargo la clase que tiene la referencia de como es la bbdd creada a partir de las clases
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Pelicula pelicula)
        {
            if (!string.IsNullOrEmpty(pelicula.Imagen))
            {
                //string imagensrc = pelicula.Imagen.Substring(pelicula.Imagen.IndexOf("base64,"), pelicula.Imagen.Length);
                //imagensrc = imagensrc.Split(",")[1];

                var fotoPersona = Convert.FromBase64String(pelicula.Imagen);
                pelicula.Imagen = await almacenadorArchivos.GuardarArchivo(fotoPersona, ".jpg", "peliculas");

                //byte[] bytes = Encoding.UTF8.GetBytes(pelicula.Imagen);
                //var posterPeli = Convert.ToBase64String(bytes);//sin el wwwroot directamente lo almacena ahi en imagenes/personas
                //pelicula.Imagen = await almacenadorArchivos.GuardarArchivo(bytes, ".jpg", "imagenes/peliculas");
            }

            contexto.Add(pelicula);
            await contexto.SaveChangesAsync();
            return pelicula.Id;
        }


    

    }
}
