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
    public partial class FormBusquedaEliminarVendedor : Form
    {
        int posicion;
        public FormBusquedaEliminarVendedor()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            textBoxCodigo.Text = dataGridView1[0, posicion].Value.ToString();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DataRow[] data;
            data = dataSetTienda.TablaVendedor.Select("Cedula='" + textBoxCodigo.Text + "'");
            if (data.Length > 0)
            {
                FormMostrarVendedor vendedor = new FormMostrarVendedor();
                vendedor.setLabelButton("Eliminar");
                vendedor.setCedula(data[0]["Cedula"].ToString());
                vendedor.setNombre(data[0]["Nombre"].ToString());
                vendedor.setApellido(data[0]["Apellido"].ToString());
                vendedor.setUsuario(data[0]["UserName"].ToString());
                vendedor.setGenero(data[0]["Genero"].ToString());
                vendedor.setEdad(data[0]["Edad"].ToString());
                vendedor.setCelular(data[0]["Celular"].ToString());
                vendedor.setEmail(data[0]["Correo"].ToString());
                if (vendedor.ShowDialog() == DialogResult.OK)
                {
                    data[0].Delete();
                    dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
                    MessageBox.Show("Vendedor eliminado");
                }
            }
            else
            {
                MessageBox.Show("No existe el item");
            }
            textBoxCodigo.Clear();
        }
    }
}
