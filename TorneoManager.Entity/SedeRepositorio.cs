using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class SedeRepositorio : ISedeRepositorio
    {
        public int Insertar(Sede sede)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"INSERT INTO SEDE (nombre, direccion, ciudad, activo) VALUES (:nombre, :direccion, :ciudad, :activo) RETURNING id_sede INTO :id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("nombre", sede.Nombre));
            cmd.Parameters.Add(new OracleParameter("direccion", sede.Direccion));
            cmd.Parameters.Add(new OracleParameter("ciudad", sede.Ciudad));
            cmd.Parameters.Add(new OracleParameter("activo", sede.Activo));
            cmd.Parameters.Add(new OracleParameter("id", Oracle.ManagedDataAccess.Client.OracleDbType.Int32, System.Data.ParameterDirection.Output));
            cmd.ExecuteNonQuery();
            return Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
        }

        public void Actualizar(Sede sede)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"UPDATE SEDE SET nombre = :nombre, direccion = :direccion, ciudad = :ciudad, activo = :activo WHERE id_sede = :id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("nombre", sede.Nombre));
            cmd.Parameters.Add(new OracleParameter("direccion", sede.Direccion));
            cmd.Parameters.Add(new OracleParameter("ciudad", sede.Ciudad));
            cmd.Parameters.Add(new OracleParameter("activo", sede.Activo));
            cmd.Parameters.Add(new OracleParameter("id", sede.IdSede));
            cmd.ExecuteNonQuery();
        }

        public List<Sede> Listar()
        {
            var lista = new List<Sede>();
            using var conn = DBContext.GetConnection();
            const string sql = "SELECT * FROM SEDE ORDER BY nombre";
            using var cmd = new OracleCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Sede
                {
                    IdSede = Convert.ToInt32(reader["id_sede"]),
                    Nombre = reader["nombre"].ToString(),
                    Direccion = reader["direccion"] == DBNull.Value ? string.Empty : reader["direccion"].ToString(),
                    Ciudad = reader["ciudad"] == DBNull.Value ? string.Empty : reader["ciudad"].ToString(),
                    Activo = reader["activo"].ToString()
                });
            }
            return lista;
        }
    }
}
