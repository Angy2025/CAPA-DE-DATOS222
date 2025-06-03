using System;
using Microsoft.Data.SqlClient;
using CAPA_DE_DATOS;

namespace CapaNegocios
{
    public class Eventos
    {
        //Atributos de la clase eventos para ser heredados en otras clases

        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string Tipo { get; set; }

    }

    //Clases CULTURAL Y DEPORTIVO para heredar de la clase EVENTOS sus atributos 
    public class Cultural : Eventos

    {
        public Cultural() { } //No puse un tipo aqui porque ya lo asigne en la base de datos
    }

    public class Deportivo : Eventos
    {
        public Deportivo() { } //Lo mismo pasa aqui que en la subclase Cultural
    }
    public class EventosDatos //Clase responsable del acceso a los datos
    {
        private readonly EventosConexion conexion = new EventosConexion();

    //Metodo usado para obtener Eventos por su Id
    public Eventos ObtenerResumenEvento(int idBusqueda)
        {
            try
            {
                //Abrimos la conexion 
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Evento WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", idBusqueda);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string tipo = reader["Tipo"].ToString();
                        Eventos evento = tipo == "Cultural" ? new Cultural() : new Deportivo();

                        evento.Id = (int)reader["Id"];
                        evento.Fecha = reader["Fecha"].ToString();
                        evento.Nombre = reader["Nombre"].ToString();
                        evento.Lugar = reader["Lugar"].ToString();
                        evento.Tipo = tipo;

                        return evento;
                    }
                }
            }

            catch (SqlException ex)
            {
                // Aquí puedes registrar el error o mostrar un mensaje
                Console.WriteLine("Error al acceder a la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return null;
        }
        //Obtiene el primer evento que coincide con el tipo
        public Eventos ObtenerEventosPorTipo(string tipo)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT TOP 1 * FROM Evento WHERE Tipo = @Tipo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Eventos eventos = tipo == "Cultural" ? new Cultural() : new Deportivo();

                        eventos.Id = (int)reader["Id"];
                        eventos.Nombre = reader["Nombre"].ToString();
                        eventos.Lugar = reader["Lugar"].ToString();
                        eventos.Fecha = reader["Fecha"].ToString();
                        eventos.Tipo = tipo;
                        return eventos;

                    }

                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine("Eroor al acceder a la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

            return null; 
        }
    }
    //Capa logica de negocios
    public class EventosNegocios
    {
        //Creamos una instancia de la clase que accede a la base de datos
        private EventosDatos datos = new EventosDatos();

        //Retorna un evento por tipo si es cultural o deportivo
        public Eventos ObtenerEventosPorTipo(string tipo)
        {
            if (tipo != "Cultural" && tipo != "Deportivo")
                return null;
            return datos.ObtenerEventosPorTipo(tipo);
        }

        public List<Eventos> ObtenerListaEventosPorTipo(string tipo)
        {
            List<Eventos> lista = new List<Eventos>();

            try
            {
                using (SqlConnection conn = new EventosConexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Evento WHERE Tipo = @Tipo";
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);

                    using SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Eventos evento = tipo == "Cultural" ? new Cultural() : new Deportivo();
                        evento.Id = (int)reader["Id"];
                        evento.Nombre = reader["Nombre"].ToString();
                        evento.Lugar = reader["Lugar"].ToString();
                        evento.Fecha = reader["Fecha"].ToString();
                        evento.Tipo = tipo;

                        lista.Add(evento);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return lista;
        }
    }
}
