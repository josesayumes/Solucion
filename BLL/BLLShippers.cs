using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLShippers
    {
        public static DataTable ListarShippers()
        {
        return DalShippers.ListarShippers();
        }    
    }
}
