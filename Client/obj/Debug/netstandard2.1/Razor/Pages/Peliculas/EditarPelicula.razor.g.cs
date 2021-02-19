#pragma checksum "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84a1e1bad2cac10d701fc0f6218299149333b4ef"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Editar Pelicula</h3>\r\n");
            __builder.OpenComponent<BlazorUdemy.Client.Pages.Peliculas.FormularIoPeliculas>(1);
            __builder.AddAttribute(2, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorUdemy.Shared.Entidades.Pelicula>(
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
                                Pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
                                                         Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "GenerosNoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorUdemy.Shared.Entidades.Genero>>(
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
                                                                                         GenerosNoSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "GenerosSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorUdemy.Shared.Entidades.Genero>>(
#nullable restore
#line 6 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
                                           GenerosSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
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
