using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DALProductos:Conexion
    {
        public static DataTable ListarProductos()
        {
            string consulta = "Select * from products";
            return GetDataTable(consulta);
        }
    }
}
