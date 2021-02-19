using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorUdemy.Client.Repositorios;

using Microsoft.AspNetCore.Components.WebAssembly;
using Microsoft.AspNetCore.Components.WebAssembly.Infrastructure;
using BlazorUdemy.Client.Helpers;
using Tewr.Blazor.FileReader;

namespace BlazorUdemy.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices (IServiceCollection services)
        {
            
            // al ser una clase que lleva interfaz hay que hacer un extra
            services.AddScoped<IRepositorio, Repositorio>();
            services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            // para leer imagenes 
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}
