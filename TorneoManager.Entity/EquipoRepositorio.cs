using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class EquipoRepositorio : IEquipoRepositorio
    {
        public void Actualizar(Equipo equipo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"UPDATE EQUIPO SET 
                               nombre = :nombre, 
                               ciudad = :ciudad, 
                               tecnico = :tecnico, 
                               activo = :activo 
                               WHERE id_equipo = :id_equipo";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("nombre", equipo.Nombre));
                    cmd.Parameters.Add(new OracleParameter("ciudad", equipo.Ciudad));
                    cmd.Parameters.Add(new OracleParameter("tecnico", equipo.Tecnico));
                    cmd.Parameters.Add(new OracleParameter("activo", equipo.Activo));
                    cmd.Parameters.Add(new OracleParameter("id_equipo", equipo.IdEquipo));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int id, bool activo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = "UPDATE EQUIPO SET activo = :activo WHERE id_equipo = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("activo", activo ? "S" : "N"));
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insertar(Equipo equipo)
        {
            using (var conn = DBContext.GetConnection())
            {
                string sql = @"INSERT INTO EQUIPO (id_torneo, nombre, ciudad, tecnico, activo) 
                               VALUES (:id_torneo, :nombre, :ciudad, :tecnico, :activo)";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id_torneo", equipo.IdTorneo));
                    cmd.Parameters.Add(new OracleParameter("nombre", equipo.Nombre));
                    cmd.Parameters.Add(new OracleParameter("ciudad", equipo.Ciudad));
                    cmd.Parameters.Add(new OracleParameter("tecnico", equipo.Tecnico));
                    cmd.Parameters.Add(new OracleParameter("activo", equipo.Activo));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Equipo> Listar(int idTorneo)
        {
            var lista = new List<Equipo>();
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM EQUIPO WHERE id_torneo = :id_torneo ORDER BY nombre";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id_torneo", idTorneo));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Equipo
                            {
                                IdEquipo = Convert.ToInt32(reader["id_equipo"]),
                                IdTorneo = Convert.ToInt32(reader["id_torneo"]),
                                Nombre = reader["nombre"].ToString(),
                                Ciudad = reader["ciudad"].ToString(),
                                Tecnico = reader["tecnico"].ToString(),
                                Activo = reader["activo"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public Equipo Obtener(int id)
        {
            Equipo equipo = null;
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM EQUIPO WHERE id_equipo = :id";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            equipo = new Equipo
                            {
                                IdEquipo = Convert.ToInt32(reader["id_equipo"]),
                                IdTorneo = Convert.ToInt32(reader["id_torneo"]),
                                Nombre = reader["nombre"].ToString(),
                                Ciudad = reader["ciudad"].ToString(),
                                Tecnico = reader["tecnico"].ToString(),
                                Activo = reader["activo"].ToString()
                            };
                        }
                    }
                }
            }
            return equipo;
        }
    }
}
