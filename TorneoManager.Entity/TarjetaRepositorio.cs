using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using TorneoManager.Dominio;

namespace TorneoManager.Entity
{
    public class TarjetaRepositorio : ITarjetaRepositorio
    {
        public void Insertar(Tarjeta tarjeta)
        {
            using (var conn = DBContext.GetConnection())
            {
                using (var cmd = new OracleCommand("PKG_TARJETAS.registrar_tarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_id_partido", OracleDbType.Int32).Value = tarjeta.IdPartido;
                    cmd.Parameters.Add("p_id_jugador", OracleDbType.Int32).Value = tarjeta.IdJugador;
                    cmd.Parameters.Add("p_tipo", OracleDbType.Varchar2).Value = tarjeta.Tipo;
                    cmd.Parameters.Add("p_minuto", OracleDbType.Int32).Value = tarjeta.Minuto;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Tarjeta> Listar(int idPartido)
        {
            var lista = new List<Tarjeta>();
            using (var conn = DBContext.GetConnection())
            {
                string sql = "SELECT * FROM TARJETA WHERE id_partido = :id_partido ORDER BY minuto";
                using (var cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id_partido", idPartido));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Tarjeta
                            {
                                IdTarjeta = Convert.ToInt32(reader["id_tarjeta"]),
                                IdPartido = Convert.ToInt32(reader["id_partido"]),
                                IdJugador = Convert.ToInt32(reader["id_jugador"]),
                                Tipo = reader["tipo"].ToString(),
                                Minuto = reader["minuto"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["minuto"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
