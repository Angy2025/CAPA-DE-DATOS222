#nullable enable //Activa el contexto de la nulabilidad

using System;
using Microsoft.Data.SqlClient;

namespace CAPA_DE_DATOS
{
    public class EventosConexion
    {
        //Cadena de conexion de C# a SQL Server
        public readonly string Cconexion = "Server=.;Database=Eventos;Integrated Security=true" + " ;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(Cconexion);
        }
    }
}
