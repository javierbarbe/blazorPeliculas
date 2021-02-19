function pruebaPuntoNetStatic() {
    // para poder utilizar una funcion de .Net en javascript tengo que utilizar
    //  DotNet.invokeMethodAsync("") que requiere el namespace del assembly y el nobmre de la funcion a usar
    DotNet.invokeMethodAsync("BlazorUdemy.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde javascript " + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
    // como este metodo es un metodo que es void, no retorna nada ... no necito usar el .then()
    // no devuelve una promesa 
}

function subirImagenServer(imagen) {
    // peticion AJAX para mandar Multipart/form-data TIENE QUE SER POST
    var _datosEnviar = new FormData();
    _datosEnviar.append("ficheroAvatar", imgSeleccionada);
    console.log("DENTRO DE LA FNCION SUBIR IMAGEN SERGVER");
    console.log(_datosEnviar);
    var _petAjax = new XMLHttpRequest();
    _petAjax.open('POST', 'https://localhost:44365/api/REST/subirMultimedia');
    _petAjax.addEventListener("readystatechange", (ev) => {
        console.log(ev);
        if (ev.target.status == 200 && ev.target.readyState == 4) {
            console.log(ev.target.responseText);

            console.log("la pet ajax de momento OK");
            // mostrar mensaje debja del boton subir imagen "imagen subida ok!!!!"

            _divMensjaes.innerText = ev.target.responseText;
        } else {
            /// mostrar mensaje de ERROR FLIN
            _divMensjaes.innerText = 'error subiendo imagen';
        }
    });
    //  _petAjax.setRequestHeader("Content-Type", "multipart/form-data");
    _petAjax.send(_datosEnviar);
}
