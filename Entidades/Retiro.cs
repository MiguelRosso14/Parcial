using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    public class Retiro
    {
        private object nombre;
        public string mas { get; set; }
        public int Retirar { get; set; }
        public Double Precio { get; set; }

        public Retiro(object nombre)
        {
            this.nombre = nombre;
        }
    }
}
