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
    public partial class FormBusquedaEditarVendedor : Form
    {
        int posicion;
        public FormBusquedaEditarVendedor()
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
                MessageBox.Show("Encontrado");
                Forms_de_ingreso.Vendedor.FormEditarVendedor vendedor = new Forms_de_ingreso.Vendedor.FormEditarVendedor();
                vendedor.setCedula(data[0]["Cedula"].ToString());
                vendedor.setNombre(data[0]["Nombre"].ToString());
                vendedor.setApellido(data[0]["Apellido"].ToString());
                vendedor.setUsername(data[0]["UserName"].ToString());
                vendedor.setPassword(data[0]["Password"].ToString());
                vendedor.setGenero(data[0]["Genero"].ToString());
                vendedor.setEdad(data[0]["Edad"].ToString());
                vendedor.setCelular(data[0]["Celular"].ToString());
                vendedor.setCorreo(data[0]["Correo"].ToString());

                if (vendedor.ShowDialog() == DialogResult.OK)
                {
                    data[0]["Cedula"] = vendedor.getCedula();
                    data[0]["Nombre"] = vendedor.getNombre();
                    data[0]["Apellido"] = vendedor.getApellido();
                    data[0]["Edad"] = vendedor.getEdad();
                    data[0]["UserName"] = vendedor.getUsername();
                    data[0]["Password"] = vendedor.getPassword();
                    data[0]["Celular"] = vendedor.getCelular();
                    data[0]["Correo"] = vendedor.getCorreo();
                    data[0]["Genero"] = vendedor.getGenero();
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
    }
}
