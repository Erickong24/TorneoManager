using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class ArbitroRepositorio : IArbitroRepositorio
    {
        public int Insertar(Arbitro arbitro)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"INSERT INTO ARBITRO (nombre, tipo, activo) VALUES (:nombre, :tipo, :activo) RETURNING id_arbitro INTO :id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("nombre", arbitro.Nombre));
            cmd.Parameters.Add(new OracleParameter("tipo", arbitro.Tipo));
            cmd.Parameters.Add(new OracleParameter("activo", arbitro.Activo));
            cmd.Parameters.Add(new OracleParameter("id", Oracle.ManagedDataAccess.Client.OracleDbType.Int32, System.Data.ParameterDirection.Output));
            cmd.ExecuteNonQuery();
            return Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
        }

        public void Actualizar(Arbitro arbitro)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"UPDATE ARBITRO SET nombre = :nombre, tipo = :tipo, activo = :activo WHERE id_arbitro = :id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("nombre", arbitro.Nombre));
            cmd.Parameters.Add(new OracleParameter("tipo", arbitro.Tipo));
            cmd.Parameters.Add(new OracleParameter("activo", arbitro.Activo));
            cmd.Parameters.Add(new OracleParameter("id", arbitro.IdArbitro));
            cmd.ExecuteNonQuery();
        }

        public List<Arbitro> Listar()
        {
            var lista = new List<Arbitro>();
            using var conn = DBContext.GetConnection();
            const string sql = "SELECT * FROM ARBITRO ORDER BY nombre";
            using var cmd = new OracleCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Arbitro
                {
                    IdArbitro = Convert.ToInt32(reader["id_arbitro"]),
                    Nombre = reader["nombre"].ToString(),
                    Tipo = reader["tipo"].ToString(),
                    Activo = reader["activo"].ToString()
                });
            }
            return lista;
        }
    }
}
