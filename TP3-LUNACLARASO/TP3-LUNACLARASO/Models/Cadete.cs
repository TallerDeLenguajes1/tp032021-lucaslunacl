using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public class Cadete
    {
        int id;
        string nombre;
        string direccion;
        string telefono;
        List<Pedidos> ListadoDePedidos;

        public Cadete()
        {
        }

        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ListadoDePedidos = new();
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListadoDePedidos1 { get => ListadoDePedidos; set => ListadoDePedidos = value; }
    }
}
