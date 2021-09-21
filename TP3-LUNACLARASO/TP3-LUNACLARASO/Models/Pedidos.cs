using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public enum EstadoPedido
    {
        pendiente,
        entregado
    }
    public class Pedidos
    {
        int nro;
        string observacion;
        Cliente cliente;
        EstadoPedido estado;
        public Pedidos(int nro, string observacion, int idCliente, string nombre,string direccion,long telefono)
        {
            Cliente = new Cliente(idCliente, nombre,  direccion, telefono);
            Nro = nro;
            Observacion = observacion;
            Estado = EstadoPedido.pendiente;
        }
        public int Nro { get => nro; set => nro = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public EstadoPedido Estado { get => estado; set => estado = value; }
    }
}
