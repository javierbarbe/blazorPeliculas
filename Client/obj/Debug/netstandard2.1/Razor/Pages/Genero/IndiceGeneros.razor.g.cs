#pragma checksum "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc80913a6d41ea41efb32074fb2bb7370fc8b9a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/generos")]
    public partial class IndiceGeneros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>IndiceGeneros</h3>\r\n");
            __Blazor.BlazorUdemy.Client.Pages.Genero.IndiceGeneros.TypeInference.CreateListadoGenerico_0(__builder, 1, 2, 
#nullable restore
#line 4 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
                          Generos

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 4 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
                                             null

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Nombre</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
                 foreach(var item in Generos)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.AddMarkupContent(15, "<td>\r\n                        <a class=\"btn btn-success\">Editar</a>\r\n                        <button class=\"btn btn-danger\">Borrar</button>\r\n                    </td>\r\n                    ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 21 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
                         item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 24 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(23, "\r\n");
            __builder.AddMarkupContent(24, "<a class=\"btn btn-info\" href=\"generos/crear\">Crear Genero</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Pages\Genero\IndiceGeneros.razor"
              
    private List<Genero> Generos;
    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<List<Genero>>("api/Genero");
        Generos = httpResponse.Response;

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
namespace __Blazor.BlazorUdemy.Client.Pages.Genero.IndiceGeneros
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::BlazorUdemy.Client.Shared.ListadoGenerico<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "Cargando", __arg1);
        __builder.AddAttribute(__seq2, "HayRegistrosCompleto", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
