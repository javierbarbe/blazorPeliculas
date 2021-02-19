using BlazorUdemy.Client.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Server.Helpers
{
    public class AlmacenadorArchivosLocal : IAlmacenadorArchivos
    {

        /*
         PARA GUARDAR LOS ARCHIVOS EN LOCAL NECESITAMOS DOS SERVICIOS INYECTADOS QUE SON:
        IWEBHOSTENVIRONMENT PARA SACAR LA URI
        para saber la url en la cual se encuentra nuestra aplicacion
         */ 
        private readonly IWebHostEnvironment env;
        private readonly IHttpContextAccessor httpContextAccessor;
            public AlmacenadorArchivosLocal(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            this.env = env;
            this.httpContextAccessor = httpContextAccessor;
        }
        public async Task<string> EditarArchivo(byte[] contenido, string extension, string nombreContenedor, string ruta)
        {
            if (!string.IsNullOrEmpty(ruta))
            {
                await EliminarArchivo(ruta, nombreContenedor);
            }
            return await GuardarArchivo(contenido, extension, nombreContenedor);

        }

        public Task EliminarArchivo(string ruta, string nombreContenedor)
        {
            var nombreArchivo = Path.GetFileName(ruta);
            string directorioArchivo = Path.Combine(env.WebRootPath, nombreContenedor, nombreArchivo);
            if (File.Exists(directorioArchivo))
            {
                File.Delete(directorioArchivo);
            }
            return Task.FromResult(0);
        }

        public async Task<string> GuardarArchivo(byte[] contenido, string extension, string nombreContenedor)
        {
            var nombreArchivo = $"{Guid.NewGuid()}{extension}";
            string carpeta = Path.Combine("~",env.WebRootPath, nombreContenedor);
            // si no existe dicha carpeta donde intento guardar, creamela
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string rutaGuardado = Path.Combine(carpeta, nombreArchivo);

            await File.WriteAllBytesAsync(rutaGuardado, contenido);

            // obtener urlActual
            var urlActual = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var rutaParaBD = Path.Combine(urlActual, nombreContenedor, nombreArchivo);
            return rutaParaBD;
        }
    }
}
