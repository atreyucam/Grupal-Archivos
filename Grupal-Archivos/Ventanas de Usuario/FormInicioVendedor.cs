using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Ventanas_de_Usuario
{
    public partial class FormInicioVendedor : Form
    {
        public FormInicioVendedor()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new FormClientes();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }

            Form ventana;
            ventana = new Forms_de_ingreso.RelacionVenta.FormGenerarVenta();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }

            Form ventana;
            ventana = new Reportes.FormInicioReportes();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------------------------

    }
}
