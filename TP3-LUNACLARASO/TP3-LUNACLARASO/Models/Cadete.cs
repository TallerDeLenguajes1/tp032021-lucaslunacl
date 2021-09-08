using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LUNACLARASO.Models
{
    public class Cadete
    {
        int Id;
        string Nombre;
        string Direccion;
        int Telefono;
        List<Pedidos> ListadoPedidos;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public int Telefono1 { get => Telefono; set => Telefono = value; }
        public List<Pedidos> ListadoPedidos1 { get => ListadoPedidos; set => ListadoPedidos = value; }
    }
}
