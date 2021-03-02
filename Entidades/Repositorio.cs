using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial
{
    public class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();
        public List<Dispensor> depositos { get; set; } = new List<Dispensor>();
        public List<Retiro> retiros { get; set; } = new List<Retiro>();

        private Repositorio()
        {

        }
    }
}
