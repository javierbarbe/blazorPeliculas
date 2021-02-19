using BlazorUdemy.Server.Helpers;
using BlazorUdemy.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorUdemy.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonaController : ControllerBase
    {
        private ApplicationDbContext contexto;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        public PersonaController(ApplicationDbContext contexto, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.contexto = contexto;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        [HttpGet("{textoBusqueda}")]
        public async Task <ActionResult<List<Persona>>> Buscar(string textoBusqueda)
        {
            if (String.IsNullOrEmpty(textoBusqueda)) { return new List<Persona>(); }
            textoBusqueda = textoBusqueda.ToLower();
            return await contexto.Personas
                        .Where(x => x.Nombre.ToLower().Contains(textoBusqueda)).ToListAsync();
        }


        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            List<Persona> milista = await contexto.Personas.ToListAsync();

            return milista;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Persona persona)
        {
            if (!string.IsNullOrEmpty(persona.Foto))
            {
                var fotoPersona = Convert.FromBase64String(persona.Foto);//sin el wwwroot directamente lo almacena ahi en imagenes/personas
                persona.Foto = await almacenadorArchivos.GuardarArchivo(fotoPersona, ".jpg", "imagenes/personas");
            }

            contexto.Add(persona);
            await contexto.SaveChangesAsync();
            return Ok();
        }
    }
}
