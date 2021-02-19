using BlazorUdemy.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorUdemy.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;
        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }
        public async Task <HttpResponseWrapper<object>>Post<T>(string url, T enviar)
        {
            // convierto a formato JSON el objeto comodin a enviar
            var enviarJSON = JsonSerializer.Serialize(enviar);
            // convierto a string el json del objeto comodin
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            // hago la peticion del objeto pasado a string con formato JSON a la url introducida
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            // devuelvo un objeto del tipo creado por mi
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
       

        public async Task<HttpResponseWrapper<T>> Get<T> (string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode) //aqui paso con generos
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        #region profesor  VA  METODO PARA DESERIALIZAR UNA RESPUESTA HTTP
        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }
      
        
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
        #endregion

        #region MI MANERA QUE NO FUNCIONA BIEN
        //public async Task<HttpResponseWrapper<object>> Post<T, TResponse>(string url, T enviar)
        //{                   // lo que devuelve              //                  // parametros Recibidos
        //    // convierto a formato JSON el objeto comodin a enviar
        //    var enviarJSON = JsonSerializer.Serialize(enviar);
        //    // convierto a string el json del objeto comodin
        //    var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
        //    // hago la peticion del objeto pasado a string con formato JSON a la url introducida
        //    var responseHttp = await httpClient.PostAsync(url, enviarContent);
        //    bool er = responseHttp.IsSuccessStatusCode;
        //    if (er)
        //    {
        //        var response = await DeserializarRespuesta<TResponse>(enviarContent, OpcionesPorDefectoJSON);
        //        return new HttpResponseWrapper<object>(response, false, responseHttp);
        //    }
        //    else
        //    {
        //        // devuelvo un objeto del tipo creado por mi
        //        return new HttpResponseWrapper<object>(default, true, responseHttp);
        //    }

        //}
        //private async Task<T> DeserializarRespuesta<T>(StringContent httpResponse, JsonSerializerOptions optionsJSON)
        //{

        //    // var responseString = await httpResponse.Content.ReadAsStringAsync();
        //    var responseString = await httpResponse.ReadAsStringAsync();
        //    //  return responseString;
        //    return JsonSerializer.Deserialize<T>(responseString, optionsJSON);//, optionsJSON);

        //}

        #endregion

        public List<Pelicula> ObtenerPeliculas()
        {
                return new List<Pelicula>()
                {
                    new Pelicula() {Lanzamiento = new DateTime(2014,10,14), 
                                Titulo = "Piratas del Caribe 3",
                                Imagen="/imagenes/piratas.jpg"},
                    new Pelicula() { Lanzamiento = new DateTime(2014, 1, 17),
                                    Titulo = "Iron Man 3" ,
                                Imagen="/imagenes/ironman.jpg"},
                    new Pelicula() { Lanzamiento = new DateTime(2019, 6, 10), 
                                    Titulo = "Vengadores EndGame",
                                    Imagen="/imagenes/vengadores.jpg"}
                 };
        }
    }
}
