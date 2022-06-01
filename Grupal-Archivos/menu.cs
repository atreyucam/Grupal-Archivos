using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(); 
            formClientes.ShowDialog();
        }
    }
}
