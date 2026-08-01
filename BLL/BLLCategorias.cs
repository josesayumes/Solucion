using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class BLLCategorias
    {
        public static DataTable ListarCategorias()
        {
            return DALCategorias.ListarCategorias();

        }
    }
}
