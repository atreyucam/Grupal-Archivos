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
    public partial class FormBusquedaEditarProducto : Form
    {
        int posicion;

        public FormBusquedaEditarProducto()
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
                MessageBox.Show("Encontrados");
                Forms_de_ingreso.FormEditarProducto productos = new Forms_de_ingreso.FormEditarProducto();
                productos.setCodigo(data[0]["codigoProducto"].ToString());
                productos.setTipo(data[0]["tipoProducto"].ToString());
                productos.setSubtipo(data[0]["subtipoProducto"].ToString());
                productos.setMarca(data[0]["marcaProducto"].ToString());
                productos.setNombre(data[0]["nombreProducto"].ToString());
                productos.setStock(data[0]["stockProducto"].ToString());
                productos.setPrecio(data[0]["precioProducto"].ToString());
                productos.setDescripcion(data[0]["descripcionProducto"].ToString());
                
                if (productos.ShowDialog() == DialogResult.OK)
                {
                    data[0]["tipoProducto"] = productos.getTipo();
                    data[0]["subtipoProducto"] = productos.getSubtipo();
                    data[0]["marcaProducto"] = productos.getMarca();
                    data[0]["nombreProducto"] = productos.getNombre();
                    data[0]["stockProducto"] = productos.getStock();
                    data[0]["precioProducto"] = productos.getPrecio();
                    data[0]["descripcionProducto"] = productos.getDescripcion();
                    data[0].AcceptChanges();
                    dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
                    MessageBox.Show("producto editado");
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
