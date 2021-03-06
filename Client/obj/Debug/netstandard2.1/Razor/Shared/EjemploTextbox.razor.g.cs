#pragma checksum "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\EjemploTextbox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "464379ea57ef994d6cbe6254a8fc62a93031c4ac"
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
    public partial class EjemploTextbox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "placeholder", "placeholder por defecto");
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 1 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\EjemploTextbox.razor"
                                                                      ParametrosAdicionales

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\javiLenovo\source\repos\BlazorPeliculas\Client\Shared\EjemploTextbox.razor"
       
    // esto de Parameter(CaptureUnmatchedValues=true)] permite que blazor analice los parametros que le indicas a la etiqueta
    // y si no coincide con los que has creado tú explictamente, les  buscara en los propios de html css
    //  requiere que aqui, en el componente indiquemos esto : @attributes="ParametrosAdicionales" , 
    // si no está, no casca aunque no lo reconozca ... pero no va a funcionar como deberia en html y no va a dar error
    [Parameter(CaptureUnmatchedValues =true)]
    public Dictionary<string, object> ParametrosAdicionales { get; set; }


    // tambien podria deffinir yo a mano todos los atributos ... sin necesidad de @attribute... pero sería mas tedioso
    // puedo definir valores por defecto auqi en el componente directamente definiendo el parametro del tagg
    // EJEMPLO : 
    //<input type="text" placeholder="placeholder por defecto" @attributes="ParametrosAdicionales"/>

    // la prioridad  va de derecha a izuqierda en la deffinicion del componente... es decir... que si pusiera placeholder="..." en ultimo
    // lugar... sería ese el que utilizase y pisaria el que me intentaran mandar desde el componente padre
    // EJEMPLO 
    // AUNQUE EN EL COMPONENTE PADRE PUSIERA 
    // <EjemploTextbox placeholder="mi placeholderPadre"/>
    // al estar definido asi ==> <input type="text"  @attributes="ParametrosAdicionales" placeholder="placeholder por defecto"/>
    // la visualizacion en la pag web seria "placeholder por defecto"

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
