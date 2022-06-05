using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_busqueda.Vendedor
{
    public partial class FormMostrarVendedor : Form
    {
        public FormMostrarVendedor()
        {
            InitializeComponent();
        }
        public void setCedula(string valor) { labelCedula.Text = valor; }
        public void setNombre(string valor) { labelNombre.Text = valor; }
        public void setApellido(string valor) { labelApellido.Text = valor; }
        public void setEdad(string valor) { labelEdad.Text = valor; }
        public void setUsuario(string valor) { labelUsername.Text = valor; }
        public void setGenero(string valor) { labelGenero.Text = valor; }
        public void setCelular(string valor) { labelCelular.Text = valor; }
        public void setEmail(string valor) { labelEmail.Text = valor; }
        public void setLabelButton(string valor) { labelbutton.Text = valor; }

        private void labelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
