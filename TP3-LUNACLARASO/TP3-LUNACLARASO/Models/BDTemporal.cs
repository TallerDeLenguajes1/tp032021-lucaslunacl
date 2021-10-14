using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public class BDTemporal
    {
        public Cadeteria Cadeteria { get; set; }

        public BDTemporal()
        {
            Cadeteria = new Cadeteria();
            LeerCadetes();
        }
        public void GuardarCadetes(Cadete cadete)
        {
            string ruta = @"Cadetes.Json";

            using (FileStream cadetesArchivo = new FileStream(ruta, FileMode.Append))
            {
                using (StreamWriter strWriter = new StreamWriter(cadetesArchivo))
                {
                    string strJason = JsonSerializer.Serialize(cadete);
                    strWriter.WriteLine(strJason);
                }
            }
        }

        public void LeerCadetes()
        {
            string ruta = @"Cadetes.Json";

            if (File.Exists(ruta))
            {
                using (FileStream cadetesArchivo = new FileStream(ruta, FileMode.Open))
                {
                    using (StreamReader strReader = new StreamReader(cadetesArchivo))
                    {
                        while (!strReader.EndOfStream)
                        {
                            string cadete = strReader.ReadLine();
                            Cadeteria.Cadetes.Add(JsonSerializer.Deserialize<Cadete>(cadete));
                        }
                    }
                }
            }
        }
        public void borrarCadete(int id)
        {
            Cadeteria.Cadetes.RemoveAt(id);

            
        }
        public void EliminarCadete()
        {
            string ruta = @"Cadetes.Json";

            using (FileStream cadetesArchivo = new FileStream(ruta, FileMode.Create))
            {
                using (StreamWriter strWriter = new StreamWriter(cadetesArchivo))
                {
                    foreach (Cadete item in Cadeteria.Cadetes)
                    {
                        string strJason = JsonSerializer.Serialize(item);
                        strWriter.WriteLine(strJason);
                    }

                }
            }
        }
        ///////////////////////////////////////////////////////////////////
        ///
        public void GuardarPedido(List<Pedidos> pedidos)
        {
            string ruta = @"Pedidos.json";
            try
            {
                string pedidosJson = JsonSerializer.Serialize(pedidos);
                using (FileStream miArchivo = new FileStream(ruta, FileMode.Create))
                {
                    using (StreamWriter strWrite = new StreamWriter(miArchivo))
                    {
                        strWrite.Write(pedidosJson);
                        strWrite.Close();
                        strWrite.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public List<Pedidos> GetListPedidos()
        {
            List<Pedidos> pedidosJson = null;
            string ruta = @"Pedidos.json";

            try
            {
                if (File.Exists(ruta))
                {
                    using (FileStream miArchivo = new FileStream(ruta, FileMode.Open))
                    {
                        using (StreamReader strReader = new StreamReader(miArchivo))
                        {
                            string strPedidos = strReader.ReadToEnd();
                            pedidosJson = JsonSerializer.Deserialize<List<Pedidos>>(strPedidos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return pedidosJson;
        }
    }
}
