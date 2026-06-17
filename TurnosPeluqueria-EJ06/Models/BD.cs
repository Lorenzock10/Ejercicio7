namespace TurnosPeluqueria_EJ06.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TurnosPeluqueria_EJ06.Models;


public static class BD
{
    private static string _connectionString =
        @"";

    public static List<Turno> ObtenerTurnos()
    {
        // TODO

    }

    public static int AgregarTurno(Turno t)
    {
        // TODO
    }


    /*
    public static int CambiarEstado(int id, string nuevoEstado)
    {
        // TODO

        throw new NotImplementedException();
    }
    */
}