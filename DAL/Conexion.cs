using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class Conexion
    {
        public static string cadenaconexion = "Server=localhost; DATABASE=northwind; uid=root; pasword=";
        public static DataTable GetDataTable(string consulta)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cadenaconexion))
                {
                    con.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta,con))
                    {
                        using (MySqlDataReader dr= comando.ExecuteReader() )
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
                        
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool ExecTransaction(string str)
        {
            bool resultado = false;
            using (MySqlConnection cn = new MySqlConnection(cadenaconexion))
            {
                cn.Open();
                using (MySqlTransaction trx = cn.BeginTransaction())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(str, cn))
                        {
                            cmd.Transaction = trx;
                            cmd.ExecuteNonQuery();

                        }
                        trx.Commit();
                        resultado = true;

                    }
                    catch (Exception)
                    {
                        trx.Rollback();
                        resultado = false;
                    }

                }

            }
            return resultado;

        }



    }
}
