using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using static BlazorUdemy.Client.Shared.MainLayout;

namespace BlazorUdemy.Client.Pages
{
    public partial class Counter
    {
        #region "--------------------inyeccion de servicios personalizados----------------------------------"
        
        #endregion

        [Inject] IJSRuntime JS { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        #region "-----------------------parametros a heredar de componentes padre a nivel de app ------------"
        [CascadingParameter(Name = "Color")] protected string Color { get; set; }
        [CascadingParameter(Name = "Size")] protected string Size { get; set; }

        #region "-------------------------parametros heredados de una clase... solo 1 cascadingParameter------"
        #endregion

        #endregion


        // quiero leer esta current count desde javascript
        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
        
            currentCountStatic = currentCount;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");

        }

        protected async Task IncrementCountJavascript()
        {
            //tiene que hacer referencia al metodo del archivo js que hace referencia al metodo no estatico
            // reeuiere dos paramaetros... el nombre del metodo y luego dotnetobjectreference.create(clase que tiene el metodo)
            // en este caso... this
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia",
                        DotNetObjectReference.Create(this));
        }

        // para poder utilizar este metodo estatico desde una funcion de JS requiere que tenga un atributo
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
        // crearemos un archivo de js que utilice esta funcion ... este archivo js lo ponemos en wwwroot 
        // que es donde esta nuestro contenido estatico del proyecto
        // tras esto añadimos en el metodo IncrementCount la llamada al metodo js que hace llamada a este metodo xD
        // para eso hay que intyectar el IJSRuntime ... aqui qe es solamente c# se hace con [Injetct] {get;set;} xq es una 
        // propiedad
        // ese objeto a traves de invokeVoidAsync llama a traves del nombre hecho string al metodo definido en el archivo
        // js que hemos importado previamente en el index.html con <script src = ....>
    }


}
