using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Login
{
    public partial class FormRol : Form
    {
        public FormRol()
        {
            InitializeComponent();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            if (panelRoles.Controls.Count > 0)
            {
                panelRoles.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new FormLoginAdmin();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelRoles.Controls.Add(ventana);
            panelRoles.Tag = ventana;
            ventana.Show();

            buttonLoginAdmin.Visible = false;
            buttonLoginVendedor.Visible = false;
        }

        private void buttonLoginVendedor_Click(object sender, EventArgs e)
        {
            if (panelRoles.Controls.Count > 0)
            {
                panelRoles.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new FormLoginAdmin();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelRoles.Controls.Add(ventana);
            panelRoles.Tag = ventana;
            ventana.Show();

            buttonLoginAdmin.Visible = false;
            buttonLoginVendedor.Visible = false;
        }
    }
}
