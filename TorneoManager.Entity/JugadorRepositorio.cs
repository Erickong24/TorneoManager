using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class JugadorRepositorio : IJugadorRepositorio
    {
        public void Actualizar(Jugador jugador)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"UPDATE JUGADOR SET 
                               nombre = :nombre, 
                               apellido = :apellido, 
                               posicion = :posicion, 
                               dorsal = :dorsal, 
                               estado = :estado, 
                               activo = :activo 
                               WHERE id_jugador = :id_jugador";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("nombre", jugador.Nombre));
                    cmd.Parameters.Add(new OracleParameter("apellido", jugador.Apellido));
                    cmd.Parameters.Add(new OracleParameter("posicion", jugador.Posicion));
                    cmd.Parameters.Add(new OracleParameter("dorsal", jugador.Dorsal));
                    cmd.Parameters.Add(new OracleParameter("estado", jugador.Estado));
                    cmd.Parameters.Add(new OracleParameter("activo", jugador.Activo));
                    cmd.Parameters.Add(new OracleParameter("id_jugador", jugador.IdJugador));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int id, bool activo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = "UPDATE JUGADOR SET activo = :activo WHERE id_jugador = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("activo", activo ? "S" : "N"));
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insertar(Jugador jugador)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"INSERT INTO JUGADOR (id_equipo, nombre, apellido, posicion, dorsal, estado, activo) 
                               VALUES (:id_equipo, :nombre, :apellido, :posicion, :dorsal, :estado, :activo)";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id_equipo", jugador.IdEquipo));
                    cmd.Parameters.Add(new OracleParameter("nombre", jugador.Nombre));
                    cmd.Parameters.Add(new OracleParameter("apellido", jugador.Apellido));
                    cmd.Parameters.Add(new OracleParameter("posicion", jugador.Posicion));
                    cmd.Parameters.Add(new OracleParameter("dorsal", jugador.Dorsal));
                    cmd.Parameters.Add(new OracleParameter("estado", jugador.Estado));
                    cmd.Parameters.Add(new OracleParameter("activo", jugador.Activo));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Jugador> Listar(int idEquipo)
        {
            var lista = new List<Jugador>();
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"SELECT j.*, e.nombre as nombre_equipo 
                               FROM JUGADOR j 
                               JOIN EQUIPO e ON j.id_equipo = e.id_equipo 
                               WHERE j.id_equipo = :id_equipo 
                               ORDER BY j.nombre, j.apellido";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id_equipo", idEquipo));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Jugador
                            {
                                IdJugador = Convert.ToInt32(reader["id_jugador"]),
                                IdEquipo = Convert.ToInt32(reader["id_equipo"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Posicion = reader["posicion"].ToString(),
                                Dorsal = reader["dorsal"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["dorsal"]),
                                Estado = reader["estado"].ToString(),
                                Activo = reader["activo"].ToString(),
                                NombreEquipo = reader["nombre_equipo"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public Jugador Obtener(int id)
        {
            Jugador jugador = null;
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM JUGADOR WHERE id_jugador = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jugador = new Jugador
                            {
                                IdJugador = Convert.ToInt32(reader["id_jugador"]),
                                IdEquipo = Convert.ToInt32(reader["id_equipo"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Posicion = reader["posicion"].ToString(),
                                Dorsal = reader["dorsal"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["dorsal"]),
                                Estado = reader["estado"].ToString(),
                                Activo = reader["activo"].ToString()
                            };
                        }
                    }
                }
            }
            return jugador;
        }
    }
}
