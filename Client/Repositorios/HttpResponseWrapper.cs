using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUdemy.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        public bool Error { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpResponseWrapper(T response,bool error, HttpResponseMessage httpResponseMessage)
        {
            this.Error = error;
            this.Response = response;
            this.HttpResponseMessage = httpResponseMessage;
        }
        // metodo para los mensajes de error
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
