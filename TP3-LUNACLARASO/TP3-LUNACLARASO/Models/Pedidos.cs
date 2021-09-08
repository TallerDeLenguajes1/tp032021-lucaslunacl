using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LUNACLARASO.Models
{
    public class Pedidos
    {
        
        int Nro;
        string Obs;
        string nombre;
        string Estado;
        
        public int Nro1 { get => Nro; set => Nro = value; }
        public string Obs1 { get => Obs; set => Obs = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
    }
}
