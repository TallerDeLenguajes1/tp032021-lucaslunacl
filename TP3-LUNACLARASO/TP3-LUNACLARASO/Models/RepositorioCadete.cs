using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace TP3_LunaClaraso.Models
{
    public class RepositorioCadete
    {
        private readonly string connectionString;
        private readonly SQLiteConnection conexion;

        public RepositorioCadete(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Cadete> MostrarCadetes()
        {
            List<Cadete> listadoCadetes = new List<Cadete>();

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                string query = "SELECT * FROM Cadetes;";
                SQLiteCommand command = new SQLiteCommand(query, conexion);

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Cadete cadete = new Cadete()
                    {
                        Id = Convert.ToInt32(dataReader["cadeteID"]),
                        Nombre = dataReader["cadeteNombre"].ToString(),
                        Telefono = dataReader["cadeteTelefono"].ToString(),
                        Direccion = dataReader["cadeteDireccion"].ToString(),
                    };

                    listadoCadetes.Add(cadete);
                }

                conexion.Close();
            }

            return listadoCadetes;
        }

        public Cadete MostrarCadeteID( int id)
        {
                Cadete cadete = new Cadete();

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                string query = "SELECT * FROM Cadetes where cadeteID=@id";
                SQLiteCommand command = new SQLiteCommand(query, conexion);
                command.Parameters.AddWithValue("@id", id);

                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                    cadete.Id = Convert.ToInt32(dataReader["cadeteID"]);
                        cadete.Nombre = dataReader["cadeteNombre"].ToString();
                        cadete.Telefono = dataReader["cadeteTelefono"].ToString();
                        cadete.Direccion = dataReader["cadeteDireccion"].ToString();
                   

                    
                }

                conexion.Close();
            }

            return cadete;
        }

        public void guardarCadete(Cadete nCadete)
        {
            try
            {
                string query = @"INSERT INTO
                                        Cadetes (cadeteNombre, cadeteTelefono, cadeteDireccion)
                                        VALUES (@nombre, @telefono, @direccion)";

                using (var conexion = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", nCadete.Nombre);
                        command.Parameters.AddWithValue("@telefono", nCadete.Telefono);
                        command.Parameters.AddWithValue("@direccion", nCadete.Direccion);
                        conexion.Open();
                        command.ExecuteNonQuery();
                        conexion.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                var mensaje = "Mensaje de error: " + ex.Message;
            }
        }


        public void ModificarCadete(Cadete idcadete)
        {
            try
            {
                string query = @"UPDATE Cadetes
                                        SET cadeteNombre = @nombre, cadeteTelefono = @telefono, cadeteDireccion = @direccion
                                        WHERE cadeteID = @cadeteID";

                using (var conexion = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", idcadete.Nombre);
                        command.Parameters.AddWithValue("@telefono", idcadete.Telefono);
                        command.Parameters.AddWithValue("@direccion", idcadete.Direccion);
                        command.Parameters.AddWithValue("@cadeteID", idcadete.Id);
                        conexion.Open();
                        command.ExecuteNonQuery();
                        conexion.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                var mensaje = "Mensaje de error: " + ex.Message;
            }
        }
        
    }
}
