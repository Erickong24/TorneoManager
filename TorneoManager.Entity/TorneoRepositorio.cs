using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class TorneoRepositorio : ITorneoRepositorio
    {
        public void Actualizar(Torneo torneo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"UPDATE TORNEO SET 
                               nombre = :nombre, 
                               fecha_inicio = :fecha_inicio, 
                               fecha_fin = :fecha_fin, 
                               puntos_victoria = :puntos_victoria, 
                               puntos_empate = :puntos_empate, 
                               puntos_derrota = :puntos_derrota, 
                               amarillas_para_suspension = :amarillas_para_suspension, 
                               estado = :estado 
                               WHERE id_torneo = :id_torneo";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("nombre", torneo.Nombre));
                    cmd.Parameters.Add(new OracleParameter("fecha_inicio", torneo.FechaInicio));
                    cmd.Parameters.Add(new OracleParameter("fecha_fin", torneo.FechaFin));
                    cmd.Parameters.Add(new OracleParameter("puntos_victoria", torneo.PuntosVictoria));
                    cmd.Parameters.Add(new OracleParameter("puntos_empate", torneo.PuntosEmpate));
                    cmd.Parameters.Add(new OracleParameter("puntos_derrota", torneo.PuntosDerrota));
                    cmd.Parameters.Add(new OracleParameter("amarillas_para_suspension", torneo.AmarillasParaSuspension));
                    cmd.Parameters.Add(new OracleParameter("estado", torneo.Estado));
                    cmd.Parameters.Add(new OracleParameter("id_torneo", torneo.IdTorneo));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = "UPDATE TORNEO SET estado = 'INACTIVO' WHERE id_torneo = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insertar(Torneo torneo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"INSERT INTO TORNEO (nombre, fecha_inicio, fecha_fin, puntos_victoria, puntos_empate, puntos_derrota, amarillas_para_suspension, estado) 
                               VALUES (:nombre, :fecha_inicio, :fecha_fin, :puntos_victoria, :puntos_empate, :puntos_derrota, :amarillas_para_suspension, :estado)";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("nombre", torneo.Nombre));
                    cmd.Parameters.Add(new OracleParameter("fecha_inicio", torneo.FechaInicio));
                    cmd.Parameters.Add(new OracleParameter("fecha_fin", torneo.FechaFin));
                    cmd.Parameters.Add(new OracleParameter("puntos_victoria", torneo.PuntosVictoria));
                    cmd.Parameters.Add(new OracleParameter("puntos_empate", torneo.PuntosEmpate));
                    cmd.Parameters.Add(new OracleParameter("puntos_derrota", torneo.PuntosDerrota));
                    cmd.Parameters.Add(new OracleParameter("amarillas_para_suspension", torneo.AmarillasParaSuspension));
                    cmd.Parameters.Add(new OracleParameter("estado", torneo.Estado));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Torneo> Listar()
        {
            var lista = new List<Torneo>();
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM TORNEO ORDER BY id_torneo DESC";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Torneo
                            {
                                IdTorneo = Convert.ToInt32(reader["id_torneo"]),
                                Nombre = reader["nombre"].ToString(),
                                FechaInicio = reader["fecha_inicio"] == DBNull.Value ? null : (DateTime?)reader["fecha_inicio"],
                                FechaFin = reader["fecha_fin"] == DBNull.Value ? null : (DateTime?)reader["fecha_fin"],
                                PuntosVictoria = Convert.ToInt32(reader["puntos_victoria"]),
                                PuntosEmpate = Convert.ToInt32(reader["puntos_empate"]),
                                PuntosDerrota = Convert.ToInt32(reader["puntos_derrota"]),
                                AmarillasParaSuspension = Convert.ToInt32(reader["amarillas_para_suspension"]),
                                Estado = reader["estado"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public Torneo Obtener(int id)
        {
            Torneo torneo = null;
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM TORNEO WHERE id_torneo = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            torneo = new Torneo
                            {
                                IdTorneo = Convert.ToInt32(reader["id_torneo"]),
                                Nombre = reader["nombre"].ToString(),
                                FechaInicio = reader["fecha_inicio"] == DBNull.Value ? null : (DateTime?)reader["fecha_inicio"],
                                FechaFin = reader["fecha_fin"] == DBNull.Value ? null : (DateTime?)reader["fecha_fin"],
                                PuntosVictoria = Convert.ToInt32(reader["puntos_victoria"]),
                                PuntosEmpate = Convert.ToInt32(reader["puntos_empate"]),
                                PuntosDerrota = Convert.ToInt32(reader["puntos_derrota"]),
                                AmarillasParaSuspension = Convert.ToInt32(reader["amarillas_para_suspension"]),
                                Estado = reader["estado"].ToString()
                            };
                        }
                    }
                }
            }
            return torneo;
        }
    }
}
