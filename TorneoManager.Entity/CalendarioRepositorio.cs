using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class CalendarioRepositorio : ICalendarioRepositorio
    {
        public int InsertarReprogramacion(PartidoReprogramacion reprog)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"INSERT INTO PARTIDO_REPROGRAMACION (id_partido, fecha_anterior, fecha_nueva, motivo, notificado)
                                 VALUES (:id_partido, :fecha_anterior, :fecha_nueva, :motivo, :notificado)
                                 RETURNING id_reprog INTO :id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("id_partido", reprog.IdPartido));
            cmd.Parameters.Add(new OracleParameter("fecha_anterior", reprog.FechaAnterior));
            cmd.Parameters.Add(new OracleParameter("fecha_nueva", reprog.FechaNueva));
            cmd.Parameters.Add(new OracleParameter("motivo", reprog.Motivo));
            cmd.Parameters.Add(new OracleParameter("notificado", reprog.Notificado));
            cmd.Parameters.Add(new OracleParameter("id", Oracle.ManagedDataAccess.Client.OracleDbType.Int32, System.Data.ParameterDirection.Output));
            cmd.ExecuteNonQuery();
            return Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
        }

        public List<PartidoReprogramacion> ListarReprogramaciones(int idPartido)
        {
            var lista = new List<PartidoReprogramacion>();
            using var conn = DBContext.GetConnection();
            const string sql = @"SELECT * FROM PARTIDO_REPROGRAMACION WHERE id_partido = :id_partido ORDER BY id_reprog DESC";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("id_partido", idPartido));
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new PartidoReprogramacion
                {
                    IdReprogramacion = Convert.ToInt32(reader["id_reprog"]),
                    IdPartido = Convert.ToInt32(reader["id_partido"]),
                    FechaAnterior = reader["fecha_anterior"] == DBNull.Value ? null : (DateTime?)reader["fecha_anterior"],
                    FechaNueva = Convert.ToDateTime(reader["fecha_nueva"]),
                    Motivo = reader["motivo"] == DBNull.Value ? string.Empty : reader["motivo"].ToString(),
                    Notificado = reader["notificado"].ToString()
                });
            }
            return lista;
        }

        public void RegistrarArbitraje(PartidoArbitraje arbitraje)
        {
            using var conn = DBContext.GetConnection();
            const string sql = @"MERGE INTO PARTIDO_ARBITRAJE pa
                                 USING dual ON (pa.id_partido = :id_partido AND pa.id_arbitro = :id_arbitro AND pa.rol = :rol)
                                 WHEN MATCHED THEN
                                     UPDATE SET calificacion = :calificacion, comentarios = :comentarios
                                 WHEN NOT MATCHED THEN
                                     INSERT (id_partido, id_arbitro, rol, calificacion, comentarios)
                                     VALUES (:id_partido, :id_arbitro, :rol, :calificacion, :comentarios)";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("id_partido", arbitraje.IdPartido));
            cmd.Parameters.Add(new OracleParameter("id_arbitro", arbitraje.IdArbitro));
            cmd.Parameters.Add(new OracleParameter("rol", arbitraje.Rol));
            cmd.Parameters.Add(new OracleParameter("calificacion", (object?)arbitraje.Calificacion ?? DBNull.Value));
            cmd.Parameters.Add(new OracleParameter("comentarios", (object?)arbitraje.Comentarios ?? DBNull.Value));
            cmd.ExecuteNonQuery();
        }

        public List<PartidoArbitraje> ListarArbitrajes(int idPartido)
        {
            var lista = new List<PartidoArbitraje>();
            using var conn = DBContext.GetConnection();
            const string sql = @"SELECT * FROM PARTIDO_ARBITRAJE WHERE id_partido = :id_partido";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add(new OracleParameter("id_partido", idPartido));
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new PartidoArbitraje
                {
                    IdPartido = Convert.ToInt32(reader["id_partido"]),
                    IdArbitro = Convert.ToInt32(reader["id_arbitro"]),
                    Rol = reader["rol"].ToString(),
                    Calificacion = reader["calificacion"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["calificacion"]),
                    Comentarios = reader["comentarios"] == DBNull.Value ? string.Empty : reader["comentarios"].ToString()
                });
            }
            return lista;
        }
    }
}
