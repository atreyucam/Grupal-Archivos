using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_busqueda.Cliente
{
    public partial class FormBusquedaCliente : Form
    {
        int posicion;
        public FormBusquedaCliente()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DataRow[] data;
            data = dataSetTienda.TablaClientes.Select("Cedula='" + textBoxCodigo.Text + "'");
            if (data.Length > 0)
            {
                MessageBox.Show("Encontrado");
                FormMostrarCliente mostrarCliente = new FormMostrarCliente();
                mostrarCliente.setLabelButton("Cerrar");
                mostrarCliente.setCedula(data[0]["Cedula"].ToString());
                mostrarCliente.setNombre(data[0]["Nombre"].ToString());
                mostrarCliente.setApellido(data[0]["Apellido"].ToString());
                mostrarCliente.setEdad(data[0]["Edad"].ToString());
                mostrarCliente.setCiudad(data[0]["Ciudad"].ToString());
                mostrarCliente.setDireccion(data[0]["Direccion"].ToString());
                mostrarCliente.setCelular(data[0]["Celular"].ToString());
                mostrarCliente.setEmail(data[0]["Correo"].ToString());
                mostrarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe el item");
            }
            textBoxCodigo.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            textBoxCodigo.Text = dataGridView1[0, posicion].Value.ToString();
        }

    }
}
