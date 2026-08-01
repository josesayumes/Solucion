using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentcion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormCategoria = new Form1();
            FormCategoria.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos FormProductos = new Productos();
            FormProductos.Show();
        }
    }
}
