using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public class Cadeteria
    {
        public List<Cadete> Cadetes { get; set; }
        public List<Pedidos> Pedidos { get; set; }

        public List<Cliente> Clientes { get; set; }
        public Cadeteria()
        {
            Cadetes = new List<Cadete>();
            Pedidos = new List<Pedidos>();
            Clientes = new List<Cliente>();
        }
    }
}
