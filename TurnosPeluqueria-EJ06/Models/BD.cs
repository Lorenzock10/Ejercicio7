namespace TurnosPeluqueria_EJ06.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TurnosPeluqueria_EJ06.Models;


public class BD
{
    private string _connectionString =
        @"";

    public List<Turno> ObtenerTurnos()
    {
      List<Turno> turnos = new List<Turno>();
      using(SqlConnection connection = new SqlConnection(_connectionString))

      {
       string query = "SELECT * FROM Turnos";
       turnos = connection.Query<Turnos>(query).ToList();

      }return turnos;

    }

    public int AgregarTurno(Turno t)
    {
        string query = "INSERT INTO Turnos (NombreCliente, Servicio, FechaHora, Estado) VALUES (@pNombreCliente, @pServicio, @pFechaHora, @pEstado)"

          using(SqlConnection connection = new SqlConnection(_connectionString))
          {
          connection.Execute(query, new {pNombreCliente = turnos.NombreCliente})
          }
    }


    /*
    public int CambiarEstado(int id, string nuevoEstado)
    {
        // TODO

        throw new NotImplementedException();
    }
    */
}