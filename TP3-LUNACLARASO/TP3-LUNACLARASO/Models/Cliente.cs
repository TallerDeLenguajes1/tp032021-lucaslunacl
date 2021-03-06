using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public class Cliente
    {
        int id;
        string nombre;
        string direccion;
        long telefono;

        public Cliente(int id, string nombre, string direccion, long telefono) {

            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
    }
}
