// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUdemy.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using BlazorUdemy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using BlazorUdemy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using BlazorUdemy.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using BlazorUdemy.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\_Imports.razor"
using BlazorUdemy.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/editar/{peliculaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/editar/{peliculaId:int}/{NombrePelicula}")]
    public partial class EditarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
       
    Pelicula Pelicula = new Pelicula();
    [Parameter] public int peliculaId { get; set; }
    [Parameter] public string NombrePelicula { get; set; }
    private List<Genero> GenerosSeleccionados { get; set; } = new List<Genero>();
    private List<Genero> GenerosNoSeleccionados { get; set; } = new List<Genero>();
    protected override void OnInitialized()
    {
        Pelicula = new Pelicula() { Id = peliculaId, Titulo= NombrePelicula };
        if (NombrePelicula == null)
        {
            Pelicula.Titulo = "Mi pelicula";
        }
        GenerosSeleccionados.Add(new Genero() { Id=1, Nombre="Drama"});
        GenerosSeleccionados.Add(new Genero() { Id = 2, Nombre = "Suspense" });
        GenerosSeleccionados.Add(new Genero() { Id = 3, Nombre = "Comedia" });
        GenerosNoSeleccionados.Add(new Genero() { Id = 4, Nombre = "Musical" });


    }
    private void Editar()
    {
        Console.WriteLine("editando pelicula");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591