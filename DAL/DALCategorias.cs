using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategorias:Conexion 
    {
        public static DataTable ListarCategorias()
        {
            string consulta = "Select * from categories";
            return GetDataTable(consulta);
        }
        public static bool InsertarCategoria(Categorias variableCategoria)
        {
            string consulta = $"Insert into categories (,CategoryName,Description)" +
                              $"VALUES ('{variableCategoria.CategoryName}','{variableCategoria.Description}')";
            return ExecTransaction(consulta);

        }
    }
}
