using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_ingreso.Cliente
{
    public partial class FormEditarCliente : Form
    {
        public FormEditarCliente()
        {
            InitializeComponent();
            txtCedula.Enabled = false;
        }

        public void setCedula(string valor) { txtCedula.Text = valor; }
        public void setNombre(string valor) { txtNombre.Text = valor; }
        public void setApellido(string valor) { txtApellido.Text = valor; }
        public void setEdad(string valor) { cmbEdad.Text = valor; }
        //public void setFecha(string valor) { txtFecha.Text = valor; }
        public void setCiudad(string valor) { cmbCiudad.Text = valor; }
        public void setDireccion(string valor) { txtDireccion.Text = valor; }
        public void setGenero(string valor) { cmbGenero.Text = valor; }
        public void setCelular(string valor) { txtCelular.Text = valor; }
        public void setCorreo(string valor) { txtCorreo.Text = valor; }

        public string getCedula() { return txtCedula.Text; }
        public string getNombre() { return txtNombre.Text; }
        public string getApellido() { return txtApellido.Text; }
        public string getEdad() { return cmbEdad.Text; }
        //public string getFecha() { return txtFecha.Text; }
        public string getCiudad() { return cmbCiudad.Text; }
        public string getDireccion() { return txtDireccion.Text; }  
        public string getGenero() { return cmbGenero.Text; }
        public string getCelular() { return txtCelular.Text; }
        public string getCorreo() { return txtCorreo.Text; }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
