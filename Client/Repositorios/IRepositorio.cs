using BlazorUdemy.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Client.Repositorios
{
    interface IRepositorio
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        public  List<Pelicula> ObtenerPeliculas();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        //  Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
       // Task<HttpResponseWrapper<object>> Post<T, TResponse>(string url, T enviar);
    }
}
