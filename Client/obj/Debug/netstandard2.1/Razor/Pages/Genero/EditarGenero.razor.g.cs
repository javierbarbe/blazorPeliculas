#pragma checksum "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\EditarGenero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04baf1617a1bbad770ffe9bc37b09a4b7576f58f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUdemy.Client.Pages.Genero
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/generos/editar/{GeneroId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/generos/editar/{GeneroId:int}/{NombreGenero}")]
    public partial class EditarGenero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Genero</h3>\r\n");
            __builder.OpenComponent<BlazorUdemy.Client.Pages.Genero.FormularioGenero>(1);
            __builder.AddAttribute(2, "nuevoGenero", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorUdemy.Shared.Entidades.Genero>(
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\EditarGenero.razor"
                               Genero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\EditarGenero.razor"
                                                      Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\EditarGenero.razor"
       
    [Parameter] public int GeneroId { get; set; }
    [Parameter] public string NombreGenero { get; set; }

    private Genero Genero;

    protected override void OnInitialized()
    {
        Genero = new Genero() { Nombre = "Comedia", Id = GeneroId };
    }

    private void Editar()
    {
        Console.WriteLine("Editando el genero");
        Console.WriteLine($"ID:{GeneroId}");

        Console.WriteLine($"NombreNuevo:{Genero.Nombre}");
        

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
