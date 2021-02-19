window.Ficheros = {

    previsualizacionFotos: async (id,destino) => {

        var file = new FileReader();
        var archivo = document.getElementById(id).files[0];
        file.readAsDataURL(archivo);

        file.onloadend = function () {
            document.getElementById(destino).src = file.result;
        };
       
    },
    GetFileData: async (id, iddestino) => {
        // el parametro id= el atributo "id" del inputfile del q quiero leer el fichero seleccionado
        var target = document.getElementById(id);
        var reader = new FileReader();
        reader.readAsDataURL(target.files[0]);
        //objeto promise q enmascara callbacks para poder hacer operaciones asincronas de forma mas comoda....
        var _data = new Promise(
                                (resolve, reject) => {
                                                        reader.addEventListener('error', (err) => reject(err));
                                                        reader.addEventListener('loadend', (ev) => {
                                                                                            console.log(ev.target.result);
                                                                                            console.log("DESPUES DE LEER EL EV.TARGET.RESULT DE LA PROMESA");
                                                                                            resolve(ev.target.result);
                                                                                        }
                                                                                );
                                                    }
                                );
        return _data;
    }
}
window.inputFileControl = {
    GetFileData: async (id, iddestino) => {
        // el parametro id= el atributo "id" del inputfile del q quiero leer el fichero seleccionado
        var target = document.getElementById(id);
        var reader = new FileReader();
        reader.readAsDataURL(target.files[0]);
        //objeto promise q enmascara callbacks para poder hacer operaciones asincronas de forma mas comoda....
        var _data = new Promise(
            (resolve, reject) => {
                reader.addEventListener('error', (err) => reject(err));
                reader.addEventListener('loadend', (ev) => {
                    console.log(ev.target.result);
                    console.log("DESPUES DE LEER EL EV.TARGET.RESULT DE LA PROMESA");
                    resolve(ev.target.result);
                }
                );
            }
        );
        return _data;
    }
}



//window.setLocalStorage = (clave, valor) => {
//    console.log("el valor  en bruto");
//    console.log(valor + " el valor en bruto");
//    console.log("============");
//    console.log(` almacenando en el localStorage con la clave ${clave[0]}, y el valor: ${JSON.stringify((clave[1]))} `);
//    window.localStorage.setItem(clave[0], JSON.stringify((clave[1])));
//    //window.localStorage.setItem(clave[0], "misCojones33:eco");

//}



//window.getLocalStorage = (clave) => {
//    console.log(`recuperando valor de LocalStorage con clave: ${clave}`)
//    return JSON.parse(window.localStorage.getItem(clave))
//}


//window.manageLocalStorage = {
//    setLocalStorage: (clave, valor) => {
//        // console.log(`almacenando en localStorage con la clave ${clave}, el valor : ${JSON.stringify(valor)}`);
//        if (clave == "token") {
//            console.log("estas serializando el token" + valor);
//            window.localStorage.setItem(clave, valor);
//        } else {
//            window.localStorage.setItem(clave, JSON.stringify(valor));
//        }
//    },
//    getLocalStorage: (clave) => {

//        console.log(`recuperando valor deñ localStorage con clave ${clave}`);
//        console.log("el valor de lo recuperado es " + localStorage.getItem(clave));
//        if (clave == "token") {
//            return localStorage.getItem(clave);
//        } else {
//            return JSON.parse(window.localStorage.getItem(clave));
//        }
//    }
//}

//window.inputFileControl = {
//    GetFileData: async (id, iddestino) => {
//        // el parametro id= el atributo "id" del inputfile del q quiero leer el fichero seleccionado
//        var target = document.getElementById(id);
//        var reader = new FileReader();
//        reader.readAsDataURL(target.files[0]);
//        //objeto promise q enmascara callbacks para poder hacer operaciones asincronas de forma mas comoda....
//        var _data = new Promise(
//            (resolve, reject) => {
//                reader.addEventListener('error', (err) => reject(err));
//                reader.addEventListener('loadend', (ev) => {
//                    console.log(ev.target.result);
//                    console.log("DESPUES DE LEER EL EV.TARGET.RESULT DE LA PROMESA");
//                    resolve(ev.target.result);
//                }
//                );
//            }
//        );
//        return _data;
//    },

//    mostrar: (id, iddestino) => {
//        var archivo = document.getElementById(id).files[0];
//        var reader = new FileReader();
//        console.log("mostrando...imagen en pantalla");
//        reader.readAsDataURL(archivo);

//        reader.onerror = function () {
//            return "Han habido errores subiendo la imagen";
//        }
//        reader.onloadend = function () {
//            document.getElementById(iddestino).src = reader.result;
//        }


//    }
//}