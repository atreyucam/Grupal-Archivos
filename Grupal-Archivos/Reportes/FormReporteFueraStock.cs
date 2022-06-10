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
    public partial class FormReporteFueraStock : Form
    {
        public FormReporteFueraStock()
        {
            InitializeComponent();
            dataSetTienda1.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");

        }

        private void FormReporteFueraStock_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
