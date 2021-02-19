// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUdemy.Client.Shared
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
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\PeliculaIndividual.razor"
       
    private string urlPelicula = string.Empty;
    protected override void OnInitialized()
    {
        urlPelicula = $"pelicula/";
    }
    [Parameter] public Pelicula peli { get; set; }

    //EVENT CALLBACKS... los uso para pasar metodos como parametros
    //  [Parameter] public EventCallback EliminarPelicula { get; set; }
    // para saber cual pelicula estoy borrando requiero que tenga un parametro... en evntCallback
    [Parameter] public EventCallback<Pelicula> EliminarPelicula { get; set; }
    // estos callbacks disponen de un metodo InvokeAsync que permite que se le pasen parametros a trave de una lambda
    // pasaria de estar asi ==> <button @onclick="EliminarPelicula">Eliminar</button>

    // el boton quedaria asi ==>   <button @onclick="@(()=>EliminarPelicula.InvokeAsync(peli))">Eliminar</button>
    // ahora ELiminarPelicula seria un EventCallback
    // despues en el metodo de eliminar pelicula de ListadoPeliculas tengo que indicarle que recibe un parametro de tipo
    // pelicula

    // USAMOS CALLBACKS PARA
    // para ejecutar un metodo del compoennte padre en respuesta de un evento ocurrido en el compoennte hijo


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
