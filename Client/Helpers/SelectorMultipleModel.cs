using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUdemy.Client.Helpers
{
    public struct SelectorMultipleModel
    {
        public string Llave { get; set; }
        public string Valor { get; set; }

        public SelectorMultipleModel(string llave, string valor)
        {
            this.Llave = llave;
            this.Valor = valor;
        }
    }
}
