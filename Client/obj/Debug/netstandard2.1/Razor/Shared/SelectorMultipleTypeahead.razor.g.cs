#pragma checksum "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46ffa1458c5f21bf4a955a1d30474eb9736ad1e"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class SelectorMultipleTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorUdemy.Client.Shared.SelectorMultipleTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                                 (string value)=> SearchMethod(value)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 4 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                         sampleItem

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                                 (T item)=> ElementoSeleccionado(item)

#line default
#line hidden
#nullable disable
            ), 4, (context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddContent(6, 
#nullable restore
#line 8 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
         MyResultTemplate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "list-group");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 12 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
     foreach (var item in ElementosSeleccionados)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "draggable", "true");
            __builder.AddAttribute(15, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                            ()=>HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                           ()=>HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "list-group-item list-group-item-action");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                              ()=>ElementosSeleccionados.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "badge badge-primary badge-pill ");
            __builder.AddAttribute(24, "style", "cursor:pointer");
            __builder.AddContent(25, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 23 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
       
    [Parameter] public List<T> ElementosSeleccionados { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }
    T sampleItem = default(T);
    T itemArrastrado;

    private void HandleDragStart(T item)
    {
        itemArrastrado = item;
    }

    private void HandleDragOver(T item)
    {
        if (!item.Equals(itemArrastrado))
        {
            var indiceElementoArrastrado = ElementosSeleccionados.IndexOf(itemArrastrado);
            var indiceElemento = ElementosSeleccionados.IndexOf(item);
            ElementosSeleccionados[indiceElemento] = itemArrastrado;
            ElementosSeleccionados[indiceElementoArrastrado] = item;
        }
    }

    private void ElementoSeleccionado(T item)
    {
        if (!ElementosSeleccionados.Any(x => x.Equals(item)))
        {
            ElementosSeleccionados.Add(item);
        }
        sampleItem = default(T);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorUdemy.Client.Shared.SelectorMultipleTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::BlazorUdemy.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
