// < !--JAVASCRIPT AJAX PARA ACTUALIZAR IMAGEN USUARIO
//cuando el cliente seleccione una imagen a traves del input file
//cargarlaa en el elemento img(id = "imgUSuario")
//habilitar el boton subir imagen
//si hace click en ese boton subir la imagen al servidor directorio images / avatares
//-->
document.addEventListener("DOMContentLoaded", () => {
    var imgSeleccionada;
    var _divMensjaes = document.getElementById("mensajesServidor");
    document.getElementById("selectorImagen2").addEventListener("click", () => {
        console.log("has hecho clik en el selector");
    })
    document.getElementById("selectorImagen2").addEventListener("change", (ev) => {
        // el event target en este caso es quien desencadena el evento
        // el file tiene unas propiedades lastmodified , name , type
        console.log(typeof (ev.target.files[0].name));
        imgSeleccionada = ev.target.files[0];
        var _reader = new FileReader();

        // realiza una lectura asincrona
        // _reader.readAsDataURL(imgSeleccionada); // lectura asincrona del fichero imagen a traves de un objeto
        // filereader, cuando acavba su lectura se dispara un evento "load"
        // sobre el mismo
        _reader.addEventListener("load", (evt) => {
            // el contenido imagen esta en : evt.target.result
            // lo cargo en el tag img usando el attr src
            console.log(evt.target);
            document.getElementById("imgUsuario").setAttribute("src", evt.target.result);
            document.getElementById("actualizaFoto").setAttribute("style", "visibility:visible");
            document.getElementById("actualizaFoto").addEventListener("click", subirImagenServer); // no se le pueden pasar argumentos aqui
        })


        if (imgSeleccionada != null) {
            console.log("has seleccionado imagen");
            _reader.readAsDataURL(imgSeleccionada);
        }

    })


})

                   