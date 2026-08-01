using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        private void Productos_Load_1(object sender, EventArgs e)
        {
            DataTable dtLista = BLLProductos.ListarProductos();
            TablaProductos.DataSource = dtLista;
        }
    }
}
