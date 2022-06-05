using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_busqueda
{
    public partial class FormMostrarProducto : Form
    {
        public FormMostrarProducto()
        {
            InitializeComponent();
            richTextBoxDescripcion.Enabled = false;
        }

        //Metodos Sets
        public void setCodigo(string valor) { labelCodigo.Text = valor; }
        public void setTipo(string valor) { labelTipo.Text = valor; }
        public void setSubtipo(string valor) { labelSubtipo.Text = valor; }
        public void setMarca(string valor) { labelMarca.Text = valor; }
        public void setNombre(string valor) { labelNombre.Text = valor; }
        public void setStock(string valor) { labelStock.Text = valor; }
        public void setPrecio(string valor) { labelPrecio.Text = valor; }
        public void setFechaElaboracion(string valor) { labelFechaElaboracion.Text = valor; }
        public void setFechaCaducidad(string valor) { labelFechaCaducidad.Text = valor; }
        public void setDescripcion(string valor) { richTextBoxDescripcion.Text = valor; }
        public void setLabelButton(string valor) { labelbutton.Text = valor; }


        private void labelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
