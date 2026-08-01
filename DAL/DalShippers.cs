using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalShippers : Conexion
    {
        public static DataTable ListarCategorias()
        {
            string consulta = "Select * from shippers";
            return GetDataTable(consulta);
        }
    }
}
