using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Client.Helpers
{
   public interface IMostrarMensajes
    {
        // como uso una nueva interfaz hay que configurarla en nuestro archivo program de cliente
        Task MostrarMensajeError(string mensaje);
    }
}
