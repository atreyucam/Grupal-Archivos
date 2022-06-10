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

        private void buttonReporteProVendidos_Click(object sender, EventArgs e)
        {
            FormReporteProductosVendidos productosVendidos = new FormReporteProductosVendidos();
            productosVendidos.ShowDialog(); 
        }

        private void buttonReportePromocion_Click(object sender, EventArgs e)
        {
            FromReportePromocion reportePromocion = new FromReportePromocion();
            reportePromocion.ShowDialog();
        }

        private void buttonReporteFueraStock_Click(object sender, EventArgs e)
        {
            FormReporteFueraStock reporteFueraStock = new FormReporteFueraStock();
            reporteFueraStock.ShowDialog();
        }

        private void buttonClienteEdad_Click(object sender, EventArgs e)
        {
            FormReporteEdadCliente edadCliente = new FormReporteEdadCliente();
            edadCliente.ShowDialog();
        }
    }
}
