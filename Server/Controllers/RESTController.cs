using BlazorUdemy.Shared.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RESTController :ControllerBase
    {
        private Pelicula _pelicula;
        [HttpPost]//[FromBody]
        public IActionResult subirMultimedia(IFormFile ficheroAvatar)
        {
            try
            {    //recojo del cuerpo del formulario la imagen que me manda el cliente (array de bites) qe me manda el cliente
                 // los copi a un fliestream para poder almacenarlos en un fihcero en el servidor
                 // en directorio images/Avatares
                FileStream _accesoFich = new FileStream("wwwroot/img/Avatares/" + ficheroAvatar.FileName, FileMode.Create);
                ficheroAvatar.CopyTo(_accesoFich);
                _accesoFich.Close();

                this._pelicula = this._pelicula.addFotoAPelicula(ficheroAvatar.FileName, this._pelicula);
                if (this._pelicula != null)
                {

                    //this._clienteLogueado.RegistrarCookie(this._clienteLogueado, HttpContext.Session);
                    return Ok("Imagen subida satisfactoriamente");
                }

                return BadRequest("FALLO AL GRABAR IMAGEN");
            }
            catch (Exception e)
            {
                return BadRequest("FALLO AL GRABAR IMAGEN");
                //   throw e;

            }

        }


        }
    }
