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
    public partial class FormBusquedaEditarCliente : Form
    {
        int posicion;
        public FormBusquedaEditarCliente()
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
                Forms_de_ingreso.Cliente.FormEditarCliente mostrarCliente = new Forms_de_ingreso.Cliente.FormEditarCliente();
                mostrarCliente.setCedula(data[0]["Cedula"].ToString());
                mostrarCliente.setNombre(data[0]["Nombre"].ToString());
                mostrarCliente.setApellido(data[0]["Apellido"].ToString());
                mostrarCliente.setEdad(data[0]["Edad"].ToString());
                mostrarCliente.setCiudad(data[0]["Ciudad"].ToString());
                mostrarCliente.setDireccion(data[0]["Direccion"].ToString());
                //mostrarCliente.setFecha(data[0]["Fecha"].ToString());
                mostrarCliente.setCelular(data[0]["Celular"].ToString());
                mostrarCliente.setCorreo(data[0]["Correo"].ToString());

                if (mostrarCliente.ShowDialog() == DialogResult.OK)
                {
                    data[0]["Cedula"]= mostrarCliente.getCedula();
                    data[0]["Nombre"] = mostrarCliente.getNombre();
                    data[0]["Apellido"] = mostrarCliente.getApellido();
                    data[0]["Edad"] = mostrarCliente.getEdad();
                    data[0]["Ciudad"] = mostrarCliente.getCiudad();
                    data[0]["Direccion"] = mostrarCliente.getDireccion();
                    data[0]["Celular"] = mostrarCliente.getCelular();
                    data[0]["Correo"] = mostrarCliente.getCorreo();
                    //data[0]["Fecha"] = mostrarCliente.getFecha();
                    data[0].AcceptChanges();
                    dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
                    MessageBox.Show("Cliente editado");
                }
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
