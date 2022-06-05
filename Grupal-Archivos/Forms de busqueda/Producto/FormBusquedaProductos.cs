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
    public partial class FormBusquedaProductos : Form
    {
        int posicion;

        public FormBusquedaProductos()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DataRow[] data;
            data = dataSetTienda.TablaProductos.Select("codigoProducto='" + textBoxCodigo.Text + "'");
            if (data.Length > 0)
            {
                MessageBox.Show("Encontrado");
                FormMostrarProducto mostrarProducto = new FormMostrarProducto();
                mostrarProducto.setLabelButton("Cerrar");
                mostrarProducto.setCodigo(data[0]["codigoProducto"].ToString());
                mostrarProducto.setTipo(data[0]["tipoProducto"].ToString());
                mostrarProducto.setSubtipo(data[0]["subtipoProducto"].ToString());
                mostrarProducto.setMarca(data[0]["marcaProducto"].ToString());
                mostrarProducto.setNombre(data[0]["nombreProducto"].ToString());
                mostrarProducto.setStock(data[0]["stockProducto"].ToString());
                mostrarProducto.setFechaElaboracion(data[0]["fechaElaboracion"].ToString());
                mostrarProducto.setFechaCaducidad(data[0]["fechaCaducidad"].ToString());
                mostrarProducto.setPrecio(data[0]["precioProducto"].ToString());
                mostrarProducto.setDescripcion(data[0]["descripcionProducto"].ToString());
                mostrarProducto.ShowDialog();
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
