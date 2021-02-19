<script>
    var imgSeleccionada;
    var _divMensjaes = document.getElementById("mensajesServidor");
                    document.getElementById("selectorImagen").addEventListener("change", (ev) => {
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

                    function subirImagenServer(imagen) {
                        // peticion AJAX para mandar Multipart/form-data TIENE QUE SER POST
                        var _datosEnviar = new FormData();
                        _datosEnviar.append("ficheroAvatar", imgSeleccionada);
                        console.log("DENTRO DE LA FNCION SUBIR IMAGEN SERGVER");
                        console.log(_datosEnviar);
                        var _petAjax = new XMLHttpRequest();
                        _petAjax.open('POST', 'https://localhost:44301/api/REST/subirMultimedia');
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
                </script>