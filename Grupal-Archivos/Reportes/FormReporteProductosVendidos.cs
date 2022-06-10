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
    public partial class FormReporteProductosVendidos : Form
    {
        public FormReporteProductosVendidos()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }

        private void FormReporteProductosVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
