using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Reportes
{
    public partial class FormInicioReportes : Form
    {
        public FormInicioReportes()
        {
            InitializeComponent();
        }

        private void buttonReporteProductos_Click(object sender, EventArgs e)
        {
            FormReporteProductos reporteProductos = new FormReporteProductos();
            reporteProductos.ShowDialog();
        }

        private void buttonReporteVendedores_Click(object sender, EventArgs e)
        {
            FormReporteVendedores reporteVendedores = new FormReporteVendedores();
            reporteVendedores.ShowDialog();
        }

        private void buttonReporteCliente_Click(object sender, EventArgs e)
        {
            FormReporteClientes reporteClientes = new FormReporteClientes();
            reporteClientes.ShowDialog();
        }
    }
}
